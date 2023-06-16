using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Problem_04.BL
{
    public class Circle : Shapes
    {
        private double radius = 0.0;

        public Circle(string type, double radius) : base(type)
        {
            this.type = type;
            this.radius = radius;
        }
        public double getRadius()
        {
            return this.radius;
        }
        public override double getArea()
        {
            return (3.14 * Math.Pow(this.radius, 2));
        }
        public override string toString()
        {
            return base.toString();
        }
    }
}