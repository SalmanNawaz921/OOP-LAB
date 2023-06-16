using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Problem_03.BL
{
    public class Dog : Mammal
    {
        public Dog(string name) : base(name)
        {
            this.name = name;
        }
        public override void greets()
        {
            Console.WriteLine("Woof");
        }
        public void greets(Dog another)
        {
            Console.WriteLine("Woooof");
        }
        public override string toString()
        {
            return ("Dog [" + base.toString() + "]");
        }
    }
}