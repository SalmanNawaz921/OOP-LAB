using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Problem_04.BL;

namespace Problem_04.DL
{
    public class ShapesDL
    {
        private static List<Shapes> shapesList = new List<Shapes>();

        public static List<Shapes> listShapes()
        {
            return shapesList;
        }

        public static void addShapes(Shapes shape)
        {
            shapesList.Add(shape);
        }
    }
}