using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Challange_02
{
    public class FireChief : FireFighter
    {
        public FireChief(string name)
            : base(name)
        {
            this.name = name;
        }

        public void delegater(string delegateeName)
        {
            Console.WriteLine("Fire Chief {0} is delegated to {1}", this.name, delegateeName + " to extinguish fire");
        }
    }
}
