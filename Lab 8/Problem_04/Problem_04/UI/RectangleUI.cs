using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Problem_04.BL;

namespace Problem_04.UI
{
    public class RectangleUI
    {
        public static Rectangle takeInputForRectangle()
        {
            Console.WriteLine("Enter Width: ");
            double width = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Height: ");
            double height = double.Parse(Console.ReadLine());
            Rectangle rectangle = new Rectangle("Rectangle", width, height);
            return rectangle;
        }

    }
}