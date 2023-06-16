using System;
using points.DL;
using Challange_01;

namespace points.BL
{
    class MyPoint
    {
        public int x;
        public int y;

        public MyPoint()
        {
            this.x = 0;
            this.y = 0;
        }

        public MyPoint(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public int getX()
        {
            return x;
        }
        public int getY()
        {
            return y;
        }
        public void setX(int x)
        {
            this.x = x;
        }
        public void setY(int y)
        {
            this.y = y;
        }
        public void setXY(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public double DistanceWithCords(int x, int y)
        {
            double z = 0;
            int dx = getX() - x;
            int dy = getY() - y;
            z = Math.Sqrt(dx * dx + dy * dy);
            return z;
        }
        public double DistanceWithObject(MyPoint points)
        {
            double z = 0;
            int dx = getX() - points.x;
            int dy = getY() - points.y;
            z = Math.Sqrt(dx * dx + dy * dy);
            return z;
        }
        public double DistanceFromZero()
        {
            return Math.Sqrt(x * x + y * y);

        }

    }

}