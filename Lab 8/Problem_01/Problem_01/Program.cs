using Problem_01.BL;

namespace Problem_01
{
    public class Program
    {
        static void Main(string[] args)
        {
            Cylinder cylinder1 = new Cylinder();
            Cylinder cylinder2 = new Cylinder(4, 12);
            Cylinder cylinder3 = new Cylinder(10, 12, "Blue");
            cylinder2.setColour("Black");
            Console.WriteLine("Area of Circle 1 is: " + cylinder1.getArea() + " " + cylinder1.getColour());
            Console.WriteLine("Area of Circle 2 is: " + cylinder2.getArea() + " " + cylinder2.getColour());
            Console.WriteLine("Area of Circle 3 is: " + cylinder3.getArea() + " " + cylinder3.getColour());
            Console.WriteLine("Volume of Cylinder 1 is: " + cylinder1.getVolume() + " " + cylinder1.getHeight());
            Console.WriteLine("Volume of Cylinder 2 is: " + cylinder2.getVolume() + " " + cylinder2.getHeight());
            Console.WriteLine("Volume of Cylinder 3 is: " + cylinder3.getVolume() + " " + cylinder3.getHeight());
            Console.ReadKey();
        }
    }
}
