using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK1
{
    class student
    {
        public student(string name, float mMarks, float interMarks, float ecat, float aggregat)
        {
            // Console.WriteLine("Default Constructor");
            studentName = name;
            matricMarks = mMarks;
            fscMarks = interMarks;
            ecatMarks = ecat;
            aggregate = aggregat;

            // Console.Read();
        }

        public string studentName = " ";
        public float matricMarks;
        public float fscMarks;
        public float ecatMarks;
        public float aggregate;
        // public student()
        // {
        //     Console.WriteLine("Default Constructor");

        // }


    }
}
