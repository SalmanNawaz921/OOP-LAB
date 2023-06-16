using System;
using points.BL;
using points.DL;
using points.UI;

namespace Challange_01
{

    class Program
    {
        static void Main(string[] args)
        {
            int option = 0;
            do
            {
                Console.Clear();
                option = Menu();
                if (option == 1)
                {
                    MyLineDL.newLine = MyLineUI.takeInputForLine();

                }
                else if (option == 2)
                {
                    Console.Write("Enter New Value For x1: ");
                    int x1 = int.Parse(Console.ReadLine());
                    Console.Write("Enter New Value For y1: ");
                    int y1 = int.Parse(Console.ReadLine());
                    MyLineDL.updateBeginPoint(x1, y1);
                }

                else if (option == 3)
                {
                    Console.Write("Enter New Value For x2: ");
                    int x2 = int.Parse(Console.ReadLine());
                    Console.Write("Enter New Value For y2: ");
                    int y2 = int.Parse(Console.ReadLine());
                    MyLineDL.updateEndPoint(x2, y2);
                }
                else if (option == 4)
                {
                    Console.Write("Begin Point (x1,y1) Is: ");
                    MyLineUI.showBeginPoint();
                }
                else if (option == 5)
                {
                    Console.Write("End Point (x2,y2) Is: ");
                    MyLineUI.showEndPoint();
                }
                else if (option == 6)
                {
                    Console.WriteLine("Length Of Line Is: " + MyLineDL.newLine.getLength());
                }
                else if (option == 7)
                {
                    Console.WriteLine("Gradient Of Line Is: " + MyLineDL.newLine.getGradient());
                }
                else if (option == 8)
                {
                    Console.WriteLine("Distance Of Begin Point From (0,0) Is: " + MyLineDL.newLine.getBegin().DistanceFromZero());
                }
                else if (option == 9)
                {
                    Console.WriteLine("Distance Of End Point From (0,0) Is: " + MyLineDL.newLine.getEnd().DistanceFromZero());
                }
                Console.Write("Press Any Key......");
                Console.ReadKey();
            } while (option != 10);
        }


        static int Menu()
        {
            int option = 0;
            Console.WriteLine("1. Make a Line");
            Console.WriteLine("2. Update the begin point");
            Console.WriteLine("3. Update the end point");
            Console.WriteLine("4. Show the begin point");
            Console.WriteLine("5. Show the end point");
            Console.WriteLine("6. Get the Length of the line");
            Console.WriteLine("7. Get the Gradient of the line");
            Console.WriteLine("8. Find the distance of begin point from zero coordinates");
            Console.WriteLine("9. Find the distance of end point from zero coordinates");
            Console.Write("Your Option: ");
            option = int.Parse(Console.ReadLine());
            return option;
        }
    }
}