using System;
using Challange_01;
using points.BL;
namespace points.DL
{
    class MyLineDL
    {
        public static MyLine newLine;
        public static void updateBeginPoint(int x, int y)
        {

            newLine.getBegin().setXY(x, y);
        }
        public static void updateEndPoint(int x, int y)
        {
            newLine.getBegin().setXY(x, y);
        }

    }

}