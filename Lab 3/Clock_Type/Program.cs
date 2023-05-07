using System;

namespace Clock_Type
{

    class Program
    {
        static void Main(string[] args)
        {
            //Default
            clocktype empty_time = new clocktype();
            Console.Write("Empty Time: ");
            empty_time.printTime();
            //One Parameter
            clocktype hours_time = new clocktype(8);
            Console.Write("Hour Time: ");
            hours_time.printTime();
            //Two Parameter
            clocktype minutes_time = new clocktype(8, 10);
            Console.Write("Minutes Time: ");
            minutes_time.printTime();
            //Three Parameter
            clocktype full_time = new clocktype(8, 10, 10);
            Console.Write("Hour Time: ");
            full_time.printTime();


            //Increament Second
            full_time.incrementSecond();
            Console.Write("Full Time (Increament Second): ");
            full_time.printTime();

            //Increament Hour
            full_time.incrementHours();
            Console.Write("Full Time (Increament Hour): ");
            full_time.printTime();
            //Increament Second
            full_time.incrementMinutes();
            Console.Write("Full Time (Increament Minutes): ");
            full_time.printTime();

            //Checking Equal Or Not
            bool flag = full_time.isEqual(9, 11, 11);
            Console.WriteLine("Flag: " + flag);

            //Checking With Object
            clocktype cmp = new clocktype(10, 12, 1);
            flag = full_time.isEqual(cmp);
            Console.WriteLine("Object Flag: " + flag);
        }
    }
}