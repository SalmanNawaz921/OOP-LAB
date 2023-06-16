using System;
using Challange_01;
using points.DL;

namespace points.BL
{

    class MyLine
    {
        public MyPoint begin;
        public MyPoint end;

        public MyLine(MyPoint begin, MyPoint end)
        {
            this.begin = begin;
            this.end = end;
        }
        public MyPoint getBegin()
        {
            return begin;
        }
        public MyPoint getEnd()
        {
            return end;
        }
        public void setBegin(MyPoint begin)
        {
            this.begin = begin;
        }
        public void setEnd(MyPoint end)
        {
            this.end = end;
        }
        public double getLength()
        {
            double z = 0;
            z = Math.Sqrt(Math.Pow((getEnd().getX() - getBegin().getX()), 2) + Math.Pow((getEnd().getY() - getBegin().getY()), 2));
            return z;
        }
        public double getGradient()
        {
            double z = 0;
            z = ((getEnd().getY() - getBegin().getY()) / (getEnd().getX() - getBegin().getX()));
            return z;
        }

    }

}