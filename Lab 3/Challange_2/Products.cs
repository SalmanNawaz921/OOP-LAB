using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challange_2
{
    public class Products
    {
        public string productName;
        public string category;
        public int productPrice;
        public int stockQuantity;
        public int minStock;

        public Products()
        {
            productName = " ";
            category = " ";
            productPrice = 0;
            stockQuantity = 0;
            minStock = 0;
        }

        public Products(string n, string categ, int price, int stock, int min)
        {
            productName = n;
            category = categ;
            productPrice = price;
            stockQuantity = stock;
            minStock = min;
        }

        public float viewSalesTax(List<Products> products)
        {
            float salesTax = 0;
            for (int i = 0; i < products.Count; i++)
            {
                if (category == "Groceries")
                {
                    salesTax = ((5 * productPrice) / 100);
                }
                if (category == "Fresh Fruits")
                {
                    salesTax = ((10 * productPrice) / 100);
                }
                else
                {
                    salesTax = ((15 * productPrice) / 100);

                }
            }
            return salesTax;
        }

        public static void highestPrice(List<Products> products)
        {
            // products.Sort((x, y) => x.productPrice.CompareTo(y.productPrice));
            int greatest = -1;
            int temp3 = 0, temp4 = 0;
            string temp1 = " ", temp2 = " ";
            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].productPrice > greatest)
                {
                    greatest = products[i].productPrice;
                    temp1 = products[i].productName;
                    temp2 = products[i].category;
                    temp3 = products[i].stockQuantity;
                    temp4 = products[i].minStock;
                }

            }
            Console.WriteLine("Product Name: {0} \t Product Price: {1} \t Cateogory:{2} \t Product Stock:{3} \t Minimum Stock:{4} ", temp1, greatest, temp2, temp3, temp4);
            // return temp1;
        }
        public static void productsOrdered(List<Products> products)
        {
            foreach (Products product in products)
            {
                if (product.stockQuantity < product.minStock)
                {
                    Console.WriteLine(product.productName);
                }
            }
        }
    }

}
