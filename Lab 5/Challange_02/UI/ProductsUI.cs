using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Challange_02;
using shop.BL;
using shop.DL;

namespace shop.UI
{
    public class ProductsUI
    {
        public static Products takeInputForProduct()
        {
            Console.Write("Enter Product Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Product Price: ");
            int price = int.Parse(Console.ReadLine());
            Console.Write("Enter Category: ");
            string cate = (Console.ReadLine());
            Console.Write("Enter Product Stock Quantity: ");
            int stock = int.Parse(Console.ReadLine());
            Console.Write("Enter Product Minimum Stock Quantity: ");
            int min = int.Parse(Console.ReadLine());
            Products product = new Products(name, cate, price, stock, min);
            return product;
        }
        public static void productsOrdered()
        {
            foreach (Products product in ProductsDL.products)
            {
                if (product.stockQuantity < product.minStock)
                {
                    Console.WriteLine(product.productName);
                }
            }
        }
        public static void viewProducts()
        {
            foreach (var p in ProductsDL.products)
            {
                Console.WriteLine("Product Name: {0} \t Product Price: {1} \t Cateogory:{2} \t Product Stock:{3} \t Minimum Stock:{4} ", p.productName, p.productPrice, p.category, p.stockQuantity, p.minStock);
            }
        }
        public static void viewSalesTax()
        {
            Console.WriteLine("Product Name \t Sales Tax");

            foreach (Products p in ProductsDL.products)
            {
                Console.WriteLine(p.productName + "\t " + p.SalesTax() + " RS ");
            }

        }
        public static void sortByOrder()
        {
            Console.WriteLine("Product Name  \t Product Price \t Cateogory  \t Product Stock  \t Minimum Stock");
            foreach (Products item in ProductsDL.highestPrice())
            {
                Console.WriteLine(item.productName + "\t\t" + item.productPrice + "\t\t" + item.category + "\t\t" + item.stockQuantity + "\t\t" + item.minStock);
            }
        }
    }

}
