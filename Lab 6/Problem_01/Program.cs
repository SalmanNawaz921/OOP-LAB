using System;
using Problem_01.DL;
using Problem_01.BL;
using Problem_01.UI;

namespace Problem_01
{

    class Program
    {
        static void Main(string[] args)
        {
            string path = "items.txt";
            string path1 = "orders.txt";
            if (MenuItemDL.loadItems(path))
            {
                Console.WriteLine("Items Data Loaded Successfully");
            }
            if (CoffeeShopDL.loadOrders(path1)
)
            {
                Console.WriteLine("Orders Data Loaded Successfully");
            }

            int opt = 0;
            CoffeeShop c = new CoffeeShop("The Bar");
            do
            {
                printHeader(c);
                opt = Menu();
                Console.Clear();
                printHeader(c);
                if (opt == 1)
                {
                    MenuItem newItem = MenuItemUI.Input_For_Item();
                    c.Add_Item(newItem);
                    MenuItemDL.storeItems(path);
                }
                else if (opt == 2)
                {
                    CoffeeShopUI.viewCheapestItem();
                }
                else if (opt == 3)
                {
                    CoffeeShopUI.viewDrinksOnly();
                }
                else if (opt == 4)
                {
                    CoffeeShopUI.viewFoodOnly();
                }
                else if (opt == 5)
                {
                    CoffeeShopDL.addOrder();
                    CoffeeShopDL.storeOrders(path1);

                }
                else if (opt == 6)
                {
                    CoffeeShopUI.View_FullFilled_Orders();
                }
                else if (opt == 7)
                {
                    CoffeeShopUI.viewAllOrders();
                }
                else if (opt == 8)
                {
                    CoffeeShopUI.viewDueAmount();
                }
                Console.Write("Press Any Key...");
                Console.ReadKey();
                Console.Clear();
            } while (opt != 9);
        }

        static int Menu()
        {
            Console.WriteLine("1.Add a Menu item");
            Console.WriteLine("2.View the Cheapest Item in the menu");
            Console.WriteLine("3.View the Drink’s Menu");
            Console.WriteLine("4.View the Food’s Menu");
            Console.WriteLine("5.Add Order");
            Console.WriteLine("6.Fulfill the Order");
            Console.WriteLine("7.View the Orders’s List");
            Console.WriteLine("8.Total Payable Amount");
            Console.WriteLine("9.Exit");
            Console.Write("Your Option: ");
            int choice = int.Parse(Console.ReadLine());
            return choice;
        }
        static void printHeader(CoffeeShop c)
        {
            Console.WriteLine("**********************************");
            Console.WriteLine("*****" + c.getshopName() + "*****");
            Console.WriteLine("**********************************");
        }
    }
}