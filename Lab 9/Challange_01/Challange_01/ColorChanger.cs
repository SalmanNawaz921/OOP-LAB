using System.Collections.Generic;
using System.Drawing;

namespace Challange_01
{
    public class ColorChanger
    {
        private static List<ColorChanger> colors = new List<ColorChanger>();
        public ColorChanger()
        {

        }

        public static List<ColorChanger> getColorList()
        {
            return colors;
        }
        public virtual Color getColor()
        {
            return Color.Black;
        }



    }
}
