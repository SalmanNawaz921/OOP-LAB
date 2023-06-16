using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Problem_02.BL
{
    public class Person
    {
        protected string name = "";
        protected string address = "";

        public Person(string name, string address)
        {
            this.name = name;
            this.address = address;
        }
        public string getName()
        {
            return this.name;
        }
        public string getAddress()
        {
            return this.address;
        }
        public void setAddress(string address)
        {
            this.address = address;
        }
        public virtual string toString()
        {
            return ("Person [name = " + getName() + ", address = " + getAddress() + "]");
        }
    }
}