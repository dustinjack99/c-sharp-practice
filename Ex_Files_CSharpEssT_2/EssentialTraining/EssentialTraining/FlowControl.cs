using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace EssentialTraining
{
    public class FlowControl
    {
        public bool IsYourFavoriteColorBlue(string color)
        {
            if (color == "blue")
            {
                return true;
            }
            else return false;
        }

        public bool IsYourFavoriteColorRed(string color)
        {
            if (color == "red") return true;
            else return false;

        }

        public bool IsYourFavoriteColorGreen(string green)
        {
            return green == "Green" ? true : false;
        }

        public bool IsYourFavoriteColorYellow(string color)
        {
            return color == "Yellow";
        }
    }
}
