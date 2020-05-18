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
            Client = new RestClient("http://localhost/api/2987683a38804f3787fe19781175e6f3/");
        }

        public static async Task<List<Light>> GetLights()
        {
            var lights = new List<Light>();

            var request = MakeRequest("/lights", Method.GET);
            var response = await Client.ExecuteAsync(request);

            if (!String.IsNullOrEmpty(response.Content))
            {
                JObject jObject = JObject.Parse(response.Content);

                foreach (var light in jObject)
                {
                    lights.Add(new Light((int)float.Parse(light.Key), JObject.FromObject(light.Value)));
                }
            }
            return lights;
        }

        public static async Task<Light> GetLight(int id)
        {
            var request = MakeRequest("/lights/" + id, Method.GET);
            var response = await Client.ExecuteAsync(request);

            JObject jObject = JObject.Parse(response.Content);

            return new Light(id, jObject);
        }

        public static async Task<bool> SetBrightness(int deviceId, float brightness)
        {
            var request = MakeRequest("/lights/" + deviceId + "/state", Method.PUT);
            var json = JsonConvert.SerializeObject(new { bri = brightness });
            var response = await SendRequest(request, json);
            return response.IsSuccessful;
        }

        public static async Task<bool> SetOn(int deviceId, bool onState)
        {
            var request = MakeRequest("/lights/" + deviceId + "/state", Method.PUT);
            var json = JsonConvert.SerializeObject(new { on = onState });
            var response = await SendRequest(request, json);
            return response.IsSuccessful;
        }

        public static async Task<bool> SetColor(int deviceId, int r, int g, int b)
        {
            var request = MakeRequest("/lights/" + deviceId + "/state", Method.PUT);
            var hueColor = HueXY.ConvertRgbToXy(r, g, b);
            var json = JsonConvert.SerializeObject(new { xy = new JArray(hueColor.X, hueColor.Y) });
            Console.WriteLine(json);
            var response = await SendRequest(request, json);
            return response.IsSuccessful;
        }

        private static RestRequest MakeRequest(string resource, Method method)
        {
            var request = new RestRequest(resource, method, DataFormat.Json);
            request.AddHeader("Content-type", "application/json");
            return request;
        }

        private static async Task<IRestResponse> SendRequest(RestRequest request, string body)
        {
            request.AddParameter("application/json", body, ParameterType.RequestBody);
            return await Client.ExecuteAsync(request);
        }
    }
}