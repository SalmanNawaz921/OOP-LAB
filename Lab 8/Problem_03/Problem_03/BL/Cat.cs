using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Problem_03.BL
{
    public class Cat : Mammal
    {
        public Cat(string name) : base(name)
        {
            this.name = name;
        }
        public override void greets()
        {
            Console.WriteLine("Meow");
        }
        public override string toString()
        {
            return ("Cat [" + base.toString() + "]");
        }
    }
}