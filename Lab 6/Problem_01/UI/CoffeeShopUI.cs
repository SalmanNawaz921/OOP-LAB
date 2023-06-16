using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Problem_01;
using Problem_01.BL;
using Problem_01.DL;
namespace Problem_01.UI
{
    public class CoffeeShopUI
    {
        public static string Input_For_Order()
        {
            Console.Write("ENTER NAME OF THE ORDER: ");
            string name = Console.ReadLine();
            return name;
        }
        public static void View_FullFilled_Orders()
        {
            if (CoffeeShop.orders_FullFilled() == true)
            {
                foreach (string item in CoffeeShopDL.orders)
                {
                    Console.WriteLine("The " + item + " is ready");
                }
                CoffeeShopDL.orders = null;
            }
            else
            {
                Console.WriteLine("All Orders Have Been FullFilled!");
            }
        }
        public static void viewFoodOnly()
        {
            foreach (var item in CoffeeShop.foodOnly())
            {
                Console.WriteLine(item);
            }
        }
        public static void viewDrinksOnly()
        {
            foreach (var item in CoffeeShop.drinksOnly())
            {
                Console.WriteLine(item);
            }
        }
        public static void viewCheapestItem()
        {
            Console.WriteLine("Name: {0}", CoffeeShop.cheapestItem());
        }

        public static void viewDueAmount()
        {
            Console.WriteLine("Total Due Amount Is: {0}", CoffeeShopDL.dueAmount());
        }
        public static void viewAllOrders()
        {
            if (CoffeeShopDL.orders != null)
            {
                foreach (var item in CoffeeShopDL.orders)
                {
                    Console.WriteLine("Name: {0}", item);
                }
            }
            else
            {
                Console.WriteLine("Orders List Is Empty");
            }
        }
    }
}