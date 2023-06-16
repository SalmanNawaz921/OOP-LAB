using System;
using Problem_04.BL;
using Problem_04.DL;
using Problem_04.UI;
namespace Problem_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Rectangle rectangle1 = RectangleUI.takeInputForRectangle();
            Circle circle1 = CircleUI.takeInputForCircle();
            Square square1 = SquareUI.takeInputForSquare();
            Rectangle rectangle2 = RectangleUI.takeInputForRectangle();
            Circle circle2 = CircleUI.takeInputForCircle();
            ShapesDL.addShapes(rectangle1);
            ShapesDL.addShapes(circle1);
            ShapesDL.addShapes(square1);
            ShapesDL.addShapes(rectangle2);
            ShapesDL.addShapes(circle2);
            foreach (Shapes shape in ShapesDL.listShapes())
            {
                int index = ShapesDL.listShapes().IndexOf(shape) + 1;
                Console.WriteLine(index + ". " + shape.toString());

            }
            Console.ReadKey();
        }
    }
}