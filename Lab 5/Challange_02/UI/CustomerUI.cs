using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using shop.BL;
using shop.DL;

namespace shop.UI
{
    public class CustomerUI
    {
        public static void GenerateInvoice(MUser user)
        {
            Console.WriteLine("Name: " + user.userName);
            Console.WriteLine("Item: " + Customer.itemName);
            Console.WriteLine("Quantity: " + Customer.itemQuantity);
            Console.WriteLine("Total Bill: " + Customer.totalBill);
        }
    }
}