using System;

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
    }
}