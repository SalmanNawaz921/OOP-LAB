using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Problem_02.BL
{
    public class Staff : Person
    {
        private string school = "";
        private double pay = 0.0;

        public Staff(string name, string address, string school, double pay)
                    : base(name, address)
        {
            this.name = name;
            this.address = address;
            this.school = school;
            this.pay = pay;
        }
        public string getSchool()
        {
            return this.school;
        }
        public double getPay()
        {
            return this.pay;
        }
        public void setPay(double pay)
        {
            this.pay = pay;
        }
        public override string toString()
        {
            return ("Staff [" + base.toString() + "]");
        }

    }
}