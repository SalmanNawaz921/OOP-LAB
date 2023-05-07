using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clock_Type
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
        public void printTime()
        {
            Console.WriteLine(hours + " " + minutes + " " + seconds);
        }

        public bool isEqual(int h, int m, int s)
        {
            if (hours == h && minutes == m && seconds == s)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool isEqual(clocktype temp)
        {
            if (hours == temp.hours && minutes == temp.minutes && seconds == temp.seconds)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public int hours;
        public int minutes;
        public int seconds;
    }

}
