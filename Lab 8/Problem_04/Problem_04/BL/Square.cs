using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Problem_04.BL
{
    public class Square : Shapes
    {
        private double side = 0.0;

        public Square(string type, double side) : base(type)
        {
            this.type = type;
            this.side = side;
        }
        public double getSide()
        {
            return this.side;
        }
        public override double getArea()
        {
            return (Math.Pow(this.side, 2));
        }
        public override string toString()
        {
            return base.toString();
        }
    }
}