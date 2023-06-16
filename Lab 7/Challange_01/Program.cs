using System;
using Challange_01.BL;
namespace Challange_01
{
    class Program
    {
        static void Main(string[] args)
        {
            MountainBike bike = new MountainBike(30, 4, 7, 2);
            Console.WriteLine("Speed of Bike Before Speed Up: "+bike.getSpeed());
            bike.speedUp();
            Console.WriteLine("Speed of Bike Has Increased To: "+bike.getSpeed());

        }
    }
}