using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Problem_04.BL;

namespace Problem_04.UI
{
    public class SquareUI
    {
        public static Square takeInputForSquare()
        {
            Console.WriteLine("Enter Side: ");
            double side = double.Parse(Console.ReadLine());
            Square square = new Square("Square", side);
            return square;
        }

    }
}