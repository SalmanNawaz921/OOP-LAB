using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Problem_04.BL
{
    public class Rectangle : Shapes
    {
        private double width = 0.0;
        private double height = 0.0;

        public Rectangle(string type, double width, double height) : base(type)
        {
            this.type = type;
            this.width = width;
            this.height = height;
        }

        public double getWidth()
        {
            return this.width;
        }
        public double getHeight()
        {
            return this.height;
        }
        public override double getArea()
        {
            return (this.width * this.height);
        }
        public override string toString()
        {
            return base.toString();
        }
    }
}