using Newtonsoft.Json.Linq;
using System;
using System.Linq;

namespace BridgeHub.Core
{
    public class Light
    {
        public int Id { get; }
        public string UniqueId { get; set; }
        public string ProductId { get; set; }
        public string ManufacturerName { get; set; }
        public String Name { get; set; }
        public String Type { get; set; }
        public int Brightness { get; set; }
        public int Sat { get; set; }
        public HueColor Color { get; set; }
        public bool On { get; set; }

        public Light(int id)
        {
            this.Id = id;
        }

        public Light(int id, JObject json)
        {
            this.Id = id;
            this.Name = json.Value<String>("name") ?? "Light";
            this.UniqueId = json.Value<String>("uniqueid") ?? "";
            this.ManufacturerName = json.Value<String>("manufacturername") ?? "";
            this.ManufacturerName = json.Value<String>("manufacturername") ?? "";
            this.ProductId = json.Value<String>("productid") ?? "";
            this.Type = json.Value<String>("type") ?? "";

            // states
            this.On = json.GetValue("state").Value<bool>("on");
            this.Brightness = json.GetValue("state").Value<int>("bri");

            // set color
            if (json.GetValue("state").SelectToken("xy") != null)
            {
                var colors = json.GetValue("state").SelectToken("xy").ToArray();
                this.Color = new HueColor(float.Parse(colors[0].ToString()), float.Parse(colors[1].ToString()));
            }
        }
    }
}