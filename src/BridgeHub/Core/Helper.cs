using System;
using System.Collections.Generic;

namespace BridgeHub.Core
{
    public static class Helper
    {
        // https://github.com/sqmk/Phue/blob/master/library/Phue/Helper/ColorConversion.php

        public static HueXY ConvertRgbToXy(int r, int g, int b)
        {
            Dictionary<String, float> rgbValues = new Dictionary<string, float>();
            Dictionary<String, float> colors = new Dictionary<string, float>();

            // Normalize the values to 1
            rgbValues.Add("red", r / 255f);
            rgbValues.Add("green", g / 255f);
            rgbValues.Add("blue", b / 255f);

            // Make colors more vivid
            foreach (var rgb in rgbValues)
            {
                if (rgb.Value > 0.04045f)
                {
                    colors.Add(rgb.Key, (float)Math.Pow((rgb.Value + 0.055f) / (1.0f + 0.055f), 2.4f));
                }
                else
                {
                    colors.Add(rgb.Key, rgb.Value / 12.92f);
                }
            }

            // Convert to XYZ using the Wide RGB D65 formula
            float x = colors["red"] * 0.664511f + colors["green"] * 0.154324f + colors["blue"] * 0.162028f;
            float y = colors["red"] * 0.283881f + colors["green"] * 0.668433f + colors["blue"] * 0.047685f;
            float z = colors["red"] * 0.000000f + colors["green"] * 0.072310f + colors["blue"] * 0.986039f;

            // Calculate the x/y values
            float sum = x + y + z;
            if (sum == 0f)
            {
                x = 0;
                y = 0;
            }
            else
            {
                x = x / sum;
                y = y / sum;
            }

            return new HueXY((float)Math.Round(x, 4), (float)Math.Round(y, 4), (float)Math.Round(y * 255));
        }
    }
}