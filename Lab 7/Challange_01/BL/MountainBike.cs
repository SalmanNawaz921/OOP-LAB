using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Challange_01.BL
{
    public class MountainBike : Bicycle
    {
        private int seatHeight;

        public MountainBike(int seatHeight, int candence, int speed, int gear)
            : base(candence, speed, gear)
        {
            this.seatHeight = seatHeight;
            this.candence = candence;
            this.speed = speed;
            this.gear = gear;
        }
        public void setSeatHeight(int seatHeight)
        {
            this.seatHeight = seatHeight;
        }
    }
}
