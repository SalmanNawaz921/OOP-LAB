using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Challange_01.BL
{
    public class Bicycle
    {
        protected int candence;
        protected int gear;
        protected int speed;

        public Bicycle(int candence, int speed, int gear)
        {
            this.candence = candence;
            this.speed = speed;
            this.gear = gear;
        }

        public void setCandence(int candence)
        {
            this.candence = candence;
        }

        public void setGear(int gear)
        {
            this.gear = gear;
        }

        public int getSpeed()
        {
            return this.speed;
        }

        public void applyBrake()
        {
            speed = 0;
        }

        public void speedUp()
        {
            speed++;
        }
    }
}
