using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Problem_03.BL
{
    public class Animal
    {
        protected string name;
        public Animal(string name)
        {
            this.name = name;
        }
        public virtual string toString()
        {
            return ("Animal [name = " + this.name + "]");
        }
    }
}