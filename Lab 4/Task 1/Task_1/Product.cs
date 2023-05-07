using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public class Product
    {
        public Product(string name, string category, int price)
        {
            this.name = name;
            this.category = category;
            this.price = price;
        }
        public Product(int price)
        {
            this.price = price;
        }
        public string name = "";
        public string category = "";
        public int price;
        public float calculateTax()
        {
            float tax = price * 0.05F;
            return tax;
        }

    }

}
