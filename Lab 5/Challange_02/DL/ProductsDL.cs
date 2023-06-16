using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Challange_02;
using shop.BL;

namespace shop.DL
{
    public class ProductsDL
    {
        public static List<Products> products = new List<Products>();
        public static List<Products> sortedList = new List<Products>();
        public static void addProduct(Products product)
        {
            products.Add(product);

        }
        public static List<Products> highestPrice()
        {
            sortedList = products.OrderByDescending(o => o.productPrice).ToList();
            return sortedList;
        }

    }

}
