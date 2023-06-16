using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Problem_04.BL
{
    public class Shapes
    {
        protected string type = "";
        protected double area = 0.0;

        public Shapes(string type)
        {
            this.type = type;
        }

        public virtual double getArea()
        {
            return this.area;
        }
        public string getType()
        {
            return this.type;
        }
        public virtual string toString()
        {
            return "The Shape is " + getType() + " & its area is " + getArea();
        }

    }
}