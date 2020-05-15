using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

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
                l.Brightness = light.Value["state"].Value<int>("bri");
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

            var lightState = jObject.GetValue("state");

            l.On = lightState.Value<bool>("on");
            l.Brightness = lightState.Value<int>("bri");

            Console.WriteLine(lightState.Value<int>("bri"));
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