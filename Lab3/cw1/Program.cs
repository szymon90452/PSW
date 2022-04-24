using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Cw1
{
    class Program
    {
        static void Main(string[] args)
        {
            RGB azure = RGBController.initializeRGB(0, 127, 255);
            RGBController.displayRGB(azure);

            RGB amber = RGBController.initializeRGB(255, 191, 0);
            RGBController.displayRGB(amber);

            RGB mixedColor = RGBController.mixRGB(azure, amber);
            RGBController.displayRGB(mixedColor);
        }
    }
}
