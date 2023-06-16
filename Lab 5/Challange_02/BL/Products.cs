using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Challange_02;
using shop.DL;

namespace shop.BL
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

        public float SalesTax()
        {
            float salesTax = 0;
            for (int i = 0; i < ProductsDL.products.Count; i++)
            {
                if (category.ToLower() == "groceries")
                {
                    salesTax = ((5 * productPrice) / 100);
                }
                if (category.ToLower() == "fresh fruits")
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



    }

}
