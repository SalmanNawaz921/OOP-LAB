using System;

namespace Challange_1
{

    class Program
    {
        static void Main(string[] args)
        {
            clocktype time = new clocktype();
            time.hours = 12;
            time.minutes = 12;
            time.seconds = 32;
            printTime(time);

            int elapse = time.elapsedTime();
            int remaining = time.remainingTime();

            Console.WriteLine("Elapsed Time: " + elapse);
            Console.WriteLine("Remaining Time: " + remaining);

            clocktype checkTime = new clocktype();
            checkTime.hours = 12;
            checkTime.minutes = 12;
            checkTime.seconds = 32;

            Console.Write("Equal?: ");
            time.isEqual(checkTime);
            Console.Read();
        }

        static void printTime(clocktype time)
        {
            Console.WriteLine(time.hours + ":" + time.minutes + ":" + time.seconds);
        }
    }
}