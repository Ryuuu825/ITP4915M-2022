using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TheBetterLimited_ManagementSystem.Lib.Toolkit.Colour
{
    public class Factory
    {

        public static Color Create(string hex)
        {
            return Color.FromArgb(Convert.ToInt32(hex.Substring(1, 2), 16), Convert.ToInt32(hex.Substring(3, 2), 16), Convert.ToInt32(hex.Substring(5, 2), 16));
        }

        public static Color Create(int red, int green, int blue)
        {
            return Color.FromArgb(red, green, blue);
        }

        // add an transparency to a color
        public static Color Create(string hex, int alpha)
        {
            return Color.FromArgb(alpha, Convert.ToInt32(hex.Substring(1, 2), 16), Convert.ToInt32(hex.Substring(3, 2), 16), Convert.ToInt32(hex.Substring(5, 2), 16));
        }

        // add an transparency to a color
        public static Color Create(int alpha, int red, int green, int blue)
        {
            return Color.FromArgb(alpha, red, green, blue);
        }

        



    }
}
