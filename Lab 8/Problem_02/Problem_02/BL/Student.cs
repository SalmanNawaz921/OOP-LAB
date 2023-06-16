using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Problem_02.BL
{
    public class Student : Person
    {
        private string program = "";
        private int year = 0;
        private double fee = 0.0;

        public Student(string name, string address, string program, int year, double fee)
                    : base(name, address)
        {
            this.name = name;
            this.address = address;
            this.program = program;
            this.year = year;
            this.fee = fee;
        }

        public string getProgram()
        {
            return this.program;
        }

        public int getYear()
        {
            return this.year;
        }
        public double getFee()
        {
            return this.fee;
        }
        public override string toString()
        {
            return ("Student [" + base.toString() + "]");
        }
    }
}