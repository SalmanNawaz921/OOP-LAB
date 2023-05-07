using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public class Customer
    {
        public Customer(string customerName,
        string customerAddress,
        string customerContact)
        {
            this.customerName = customerName;
            this.customerAddress = customerAddress;
            this.customerContact = customerContact;
        }
        public string customerName = "";
        public string customerAddress = "";
        public string customerContact = "";

        public List<Product> products = new List<Product>();

        public List<Product> getAllProducts()
        {
            return products;
        }

        public void addProduct(Product p)
        {
            products.Add(p);
        }
    }

}
