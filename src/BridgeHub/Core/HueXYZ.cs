namespace BridgeHub.Core
{
    public class HueXY
    {
        public float X { get; }
        public float Y { get; }
        public float Bri { get; }

        public HueXY(float x, float y, float bri = 0f)
        {
            this.X = x;
            this.Y = y;
            this.Bri = bri;
        }

        public override string ToString()
        {
            return this.X + "," + this.Y;
        }
    }
}