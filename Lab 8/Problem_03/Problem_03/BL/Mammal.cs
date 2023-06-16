using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Problem_03.BL
{
    public class Mammal : Animal
    {
        public Mammal(string name) : base(name)
        {
            this.name = name;
        }
        public virtual void greets()
        {
            Console.WriteLine("YO");
        }
        public override string toString()
        {
            return ("Mammal [" + base.toString() + "]");
        }
    }
}