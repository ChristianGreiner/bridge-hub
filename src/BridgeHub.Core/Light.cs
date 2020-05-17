using System;
using System.Linq;
using Newtonsoft.Json.Linq;

namespace BridgeHub.Core
{
    public class Light
    {
        public int Id { get; }
        public int Brightness { get; set; }
        public int Sat { get; set; }
        public String Name { get; set; }
        public HueXY Color { get; set; }
        public bool On { get; set; }
        
        public Light(int id)
        {
            this.Id = id;
        }

        public Light(int id, JObject json)
        {
            this.Id = id;
            this.Name = json.Value<String>("name") ?? "Light";
            this.On = json.GetValue("state").Value<bool>("on");
            this.Brightness = json.GetValue("state").Value<int>("bri");

            if (json.GetValue("state").SelectToken("xy") != null)
            {
                var colors = json.GetValue("state").SelectToken("xy").ToArray();
                this.Color = new HueXY(float.Parse(colors[0].ToString()), float.Parse(colors[1].ToString()));
            }
        }
    }
}