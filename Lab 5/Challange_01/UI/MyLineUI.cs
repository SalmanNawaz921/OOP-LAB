using System;
using Challange_01;
using points.DL;
using points.BL;

namespace points.UI
{
    class MyLineUI
    {
        public static MyLine takeInputForLine()
        {
            Console.Write("Enter Value For x1: ");
            int x1 = int.Parse(Console.ReadLine());
            Console.Write("Enter Value For y1: ");
            int y1 = int.Parse(Console.ReadLine());
            MyPoint newBeg = new MyPoint(x1, y1);
            Console.Write("Enter Value For x2: ");
            int x2 = int.Parse(Console.ReadLine());
            Console.Write("Enter Value For y2: ");
            int y2 = int.Parse(Console.ReadLine());
            MyPoint newEnd = new MyPoint(x2, y2);
            MyLine newLine = new MyLine(newBeg, newEnd);
            newLine.setBegin(newBeg);
            newLine.setEnd(newEnd);
            return newLine;
        }
        public static void showBeginPoint()
        {
            Console.WriteLine(MyLineDL.newLine.getBegin().getX() + ", " + MyLineDL.newLine.getBegin().getY());
        }
        public static void showEndPoint()
        {
            Console.WriteLine(MyLineDL.newLine.getEnd().getX() + ", " + MyLineDL.newLine.getEnd().getY());
        }
    }

}