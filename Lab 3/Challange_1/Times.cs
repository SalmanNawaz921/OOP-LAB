using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challange_1
{
    public class clocktype
    {

        public clocktype()
        {
            hours = 0;
            minutes = 0;
            seconds = 0;
        }
        public clocktype(int h)
        {
            hours = h;
        }
        public clocktype(int h, int m)
        {
            hours = h;
            minutes = m;
        }
        public clocktype(int h, int m, int s)
        {
            hours = h;
            minutes = m;
            seconds = s;
        }

        public void incrementSecond()
        {
            seconds++;
        }
        public void incrementMinutes()
        {
            minutes++;
        }
        public void incrementHours()
        {
            hours++;
        }
        public void isEqual(clocktype time)
        {
            if (hours == time.hours && minutes == time.minutes && seconds == time.seconds)
            {
                Console.WriteLine("Time Is Equal");
            }
            else
            {
                int difference;
                int obj = (time.hours * 3600) + (time.minutes * 60) + time.seconds;
                int newtime = (hours * 3600) + (minutes * 60) + seconds;
                difference = obj - newtime;
                if (difference < 0)
                {

                    difference = -difference;
                }
                Console.WriteLine("Not Equal");
                Console.WriteLine("Difference Between Time Is: " + difference);
            }
        }

        public int elapsedTime()
        {
            int elapse = (3600 * hours) + (60 * minutes) + seconds;
            return elapse;
        }

        public int remainingTime()
        {
            int remaining = (3600 * 24) - elapsedTime();
            return remaining;
        }
        public int hours;
        public int minutes;
        public int seconds;
    }

}
