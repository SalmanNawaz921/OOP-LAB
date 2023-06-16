using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Problem_01.BL
{
    public class MenuItem
    {
        private string name = "";
        private string type = "";
        private int price;

        public MenuItem(string name, string type, int price)
        {
            this.name = name;
            this.type = type;
            this.price = price;
        }

        public string getName()
        {
            return this.name;
        }
        public string getType()
        {
            return this.type;
        }
        public int getPrice()
        {
            return this.price;
        }

        public void setName(string name)
        {
            this.name = name;
        }
        public void setType(string type)
        {
            this.type = type;
        }
        public void setPrice(int price)
        {
            this.price = price;
        }
    }
}