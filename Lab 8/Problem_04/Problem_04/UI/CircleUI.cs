using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Problem_04.BL;
using Problem_04.DL;

namespace Problem_04.UI
{
    public class CircleUI
    {
        public static Circle takeInputForCircle()
        {
            Console.WriteLine("Enter Radius: ");
            double radius = double.Parse(Console.ReadLine());
            Circle circle = new Circle("Circle", radius);
            return circle;
        }



    }
}
