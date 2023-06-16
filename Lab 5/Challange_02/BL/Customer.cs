using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Challange_02;
using shop.DL;
using shop.UI;

namespace shop.BL
{
    public class Customer
    {
        public static string itemName = "";
        public static int itemQuantity;
        public static int totalBill;
        public static void buyProduct()
        {
            Console.Write("Enter Product Name You Want To Buy: ");
            string name = Console.ReadLine();
            Products product = ProductsDL.products.Find(e => e.productName == name);
            if (product != null)
            {
                Console.Write("Enter Product Quantity: ");
                int quantity = int.Parse(Console.ReadLine());
                if (quantity < product.stockQuantity)
                {
                    itemQuantity = quantity;
                    itemName = name;
                    totalBill = quantity * product.productPrice;
                    Console.WriteLine("You Have Purchased " + product.productName);
                    product.stockQuantity--;
                }
            }
        }

    }
}