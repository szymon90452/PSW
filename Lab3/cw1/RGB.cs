using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Cw1
{
    class RGB
    {

        int R_value;
        int G_value;
        int B_value;

        public RGB(int R_value, int G_value, int B_value) 
        { 
            this.R_value = R_value;
            this.G_value = G_value;
            this.B_value = B_value;
        }

        public void setRedValue(int R_value) 
        {
            this.R_value = R_value;
        }

        public void setGreenValue(int G_value)
        {
            this.G_value = G_value;
        }

        public void setBlueValue(int B_value)
        {
            this.B_value = B_value;
        }

        public int getRedValue() 
        {
            return R_value;
        }

        public int getGreenValue()
        {
            return G_value;
        }

        public int getBlueValue()
        {
            return B_value;
        }

    }
}
