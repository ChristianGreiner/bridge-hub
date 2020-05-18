using System;
using System.Drawing;
using System.Linq;

namespace BridgeHub.Core
{
    public class HueXY
    {
        public float X { get; }
        public float Y { get; }
        public float Bri { get; }
        public HueXY()
        {
        }

        public HueXY(float x, float y, float bri = 0f)
        {
            this.X = x;
            this.Y = y;
            this.Bri = bri;
        }

        public override string ToString()
        {
            return this.X.ToString().Replace(',', '.') + "," + this.Y.ToString().Replace(',', '.');
        }

        public Color ToRgb()
        {
            return ConvertXyToRgb(this.X, this.Y);
        }

        public static HueXY ConvertRgbToXy(int r, int g, int b)
        {
            // Normalize the values to 1
            float red = NormalizeColor(r);
            float green = NormalizeColor(g);
            float blue = NormalizeColor(b);

            // Make colors more vivid
            red = VividColor(red);
            green = VividColor(green);
            blue = VividColor(blue);

            // Convert to XYZ using the Wide RGB D65 formula
            float x = red * 0.664511f + green * 0.154324f + blue * 0.162028f;
            float y = red * 0.283881f + green * 0.668433f + blue * 0.047685f;
            float z = red * 0.000000f + green * 0.072310f + blue * 0.986039f;

            // Calculate the x/y values
            float sum = x + y + z;

            // is almost 0f
            if (Math.Abs(sum) < Double.Epsilon)
            {
                x = 0;
                y = 0;
            }
            else
            {
                x /= sum;
                y /= sum;
            }

            return new HueXY((float)Math.Round(x, 4), (float)Math.Round(y, 4), (float)Math.Round(y * 255));
        }

        public static Color ConvertXyToRgb(float xVal, float yVal, float bri = 255)
        {

            // by https://stackoverflow.com/questions/22894498/philips-hue-convert-xy-from-api-to-hex-or-rgb

            // Calculate XYZ
            float zDif = 1.0f - xVal - yVal;
            
            float y = bri / 255f; // Brightness of lamp
            float x = (y / yVal) * xVal;
            float z = (y / yVal) * zDif;

            // Convert to RGB using Wide RGB D65 conversion
            float red = x * 1.612f - y * 0.203f - z * 0.302f;
            float green = -x * 0.509f + y * 1.412f + z * 0.066f;
            float blue = x * 0.026f - y * 0.072f + z * 0.962f;

            red = CorrectGamma(red);
            green = CorrectGamma(green);
            blue = CorrectGamma(blue);

            float[] rgbArr = {red, green, blue};
            float maxValue = rgbArr.Max();

            red /= maxValue;
            green /= maxValue;
            blue /= maxValue;

            red = NormalizeColor2(red);
            green = NormalizeColor2(green);
            blue = NormalizeColor2(blue);

            return Color.FromArgb((int)red, (int)green, (int)blue);
        }

        private static float NormalizeColor(int color)
        {
            return color / 255f;
        }

        private static float NormalizeColor2(float color)
        {
            float val = color * 255f;
            if (val < 0)
            {
                val = 0;
            }

            return val;
        }

        private static float VividColor(float value)
        {
            if (value > 0.04045f)
            {
                return (float)Math.Pow((value + 0.055f) / (1.0f + 0.055f), 2.4f);
            }

            return value / 12.92f;
        }

        private static float CorrectGamma(float value)
        {
            if (value <= 0.0031308f) {
                value = (12.92f * value);
            }
            else
            {
                value = (1.0f + 0.055f) * (float)Math.Pow(value, (1.0f / 2.4f)) - 0.055f;
            }

            //return (float)Math.Round(value * 255f);

            return value;
        }
    }
}