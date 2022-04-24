using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Cw1
{
    static class RGBController
    {
        public static RGB initializeRGB(int R_value, int G_value, int B_value)
        {
            int[] RGBvalues = new int[] { R_value, G_value, B_value };
            for (int i = 0; i <= 2; i++) 
            {
                if (RGBvalues[i] > 255)
                {
                    RGBvalues[i] = 255;
                }
                else if (RGBvalues[i] < 0)
                {
                    RGBvalues[i] = 0;
                }
            }

            return new RGB(RGBvalues[0], RGBvalues[1], RGBvalues[2]);
        }

        public static void displayRGB(RGB value) 
        {
            Console.WriteLine("[" + value.getRedValue() + "," + value.getGreenValue() + "," + value.getBlueValue() + "]");
        }

        public static RGB mixRGB(RGB value, RGB value2)
        {
            int R_value,G_value, B_value;
            R_value = value.getRedValue() + value2.getRedValue();
            R_value = R_value / 2;
            G_value = value.getGreenValue() + value2.getGreenValue();
            G_value = G_value / 2;
            B_value = value.getBlueValue() + value2.getBlueValue();
            B_value = B_value / 2;

            return new RGB(R_value,G_value,B_value);
        }

    }
}
