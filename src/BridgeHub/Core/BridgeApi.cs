using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;

namespace BridgeHub.Core
{
    public static class BridgeApi
    {
        public static RestClient Client;

        public static async void Init()
        {
            Client = new RestClient("http://localhost/api/2987683a38804f3787fe19781175e6f3/lights/");
        }

        public static List<Light> GetLights()
        {
            var lights = new List<Light>();

            var request = MakeRequest("/", Method.GET);
            var response = Client.ExecuteAsync(request);
            JObject jObject = JObject.Parse(response.Result.Content);

            foreach (var light in jObject)
            {
                Light l = new Light((int)float.Parse(light.Key));
                l.Name = light.Value.Value<String>("name");
                l.On = light.Value["state"].Value<bool>("on");
                lights.Add(l);
            }

            return lights;
        }

        public static Light GetLight(int id)
        {
            var request = MakeRequest("/" + id, Method.GET);
            var response = Client.ExecuteAsync(request);

            JObject jObject = JObject.Parse(response.Result.Content);

            Light l = new Light(id);
            Console.WriteLine(jObject.GetValue("name"));
            l.Name = (string)jObject.GetValue("name");
            l.On = jObject.GetValue("state").Value<bool>("on");
            //Console.WriteLine(jObject.GetValue("state").Value<String>("xy"));

            return l;
        } 

        public static async Task<IRestResponse> SetBrightness(int deviceId, float brightness)
        {
            var request = MakeRequest(deviceId + "/state", Method.PUT);

            var json = JsonConvert.SerializeObject(new { bri = brightness });
            request.AddParameter("application/json", json, ParameterType.RequestBody);
            return await Client.ExecuteAsync(request);
        }

        public static async Task<IRestResponse> SetOn(int deviceId, bool onState)
        {
            var request = MakeRequest(deviceId + "/state", Method.PUT);
            var json = JsonConvert.SerializeObject(new { on = onState });
            request.AddParameter("application/json", json, ParameterType.RequestBody);
            return await Client.ExecuteAsync(request);
        }

        private static RestRequest MakeRequest(string resource, Method method)
        {
            var request = new RestRequest(resource, method, DataFormat.Json);
            request.AddHeader("Content-type", "application/json");
            return request;
        }
    }
}