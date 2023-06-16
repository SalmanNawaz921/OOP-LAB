using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Challange_02
{
    public class FireTruck
    {
        private Ladder ladder;
        private HosePipe pipe;
        private FireFighter driver;
        public static List<FireTruck> trucks=new List<FireTruck>();

        public FireTruck(Ladder ladder, HosePipe pipe, FireFighter driver)
        {
            this.ladder = new Ladder(55, "Red");
            this.pipe = pipe;
            this.driver = driver;
        }
         public static void addTruck(FireTruck newTruck)
        {
            trucks.Add(newTruck);
        }
    }
}
