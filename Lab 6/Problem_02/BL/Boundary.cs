using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Problem_02.BL
{
    public class Boundary
    {
        private Point Top_Left;
        private Point Top_Right;
        private Point Bottom_Left;
        private Point Bottom_Right;

        public Boundary()
        {
            this.Top_Left = new Point(0, 0);
            this.Top_Right = new Point(0, 90);
            this.Bottom_Left = new Point(90, 0);
            this.Bottom_Right = new Point(90, 90);
        }

        public Boundary(Point Top_Left, Point Top_Right, Point Bottom_Left, Point Bottom_Right)
        {
            this.Top_Left = Top_Left;
            this.Top_Right = Top_Right;
            this.Bottom_Left = Bottom_Left;
            this.Bottom_Right = Bottom_Right;
        }

        public Point get_Top_Left()
        {
            return this.Top_Left;
        }
        public Point get_Top_Right()
        {
            return this.Top_Right;
        }
        public Point get_Bottom_Left()
        {
            return this.Bottom_Left;
        }
        public Point get_Bottom_Right()
        {
            return this.Bottom_Right;
        }
    }
}