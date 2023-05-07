using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Customer c1 = new Customer("John", "Lahore", "0124");
            Customer c2 = new Customer("Salman", "Lahore", "921");
            Customer c3 = new Customer("Tayyab", "Karachi", "021");
            Product p1 = new Product("iPhone", "Electronics", 100);
            c2.addProduct(p1);
            Product p2 = new Product("Hp Laptop", "Electronics", 180);
            c2.addProduct(p2);
            // for (int i = 0; i < c2.products.Count; i++)
            // {
            // Product p = c2.getAllProducts()[i];
            // float tax = p.calculateTax();
            //     Console.WriteLine(c2.getAllProducts()[i].name + "," + c2.getAllProducts()[i].category + "," + c2.getAllProducts()[i].price);
            // Console.WriteLine(p.name + "," + p.category + "," + p.price + "," +tax);

            // }
            foreach (Product p in c2.getAllProducts())
            {
                Console.WriteLine(p.name + "," + p.category + "," + p.price + "," + p.calculateTax());
            }
        }

    }

}
