using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Challange_02
{
    public class FireFighter
    {
        public static List<FireFighter> fighters = new List<FireFighter>();
        protected string name = "";

        public FireFighter(string name)
        {
            this.name = name;
        }
        public string getName()
        {
           return this.name;
        }

        public void drive()
        {
            Console.WriteLine(name + " is driving the truck");
        }

        public void extinguishFire()
        {
            Console.WriteLine(name + " is extinguishing the fire");
        }

        public static void addFighter(FireFighter newFigter)
        {
            fighters.Add(newFigter);
        }

        public static void viewAllFighters()
        {
            foreach (FireFighter fighter in fighters)
            {
                Console.WriteLine("FighterName{0}", fighter.name);
            }
        }
    }
}
