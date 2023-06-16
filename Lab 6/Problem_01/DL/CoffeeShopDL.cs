using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Problem_01;
using Problem_01.BL;
using Problem_01.UI;

namespace Problem_01.DL
{
    public class CoffeeShopDL
    {
        public static List<string> orders = new List<string>();

        public List<string> ordersTaken()
        {
            return orders;
        }

        public static int dueAmount()
        {
            int amount = 0;
            if (orders != null)
            {
                foreach (MenuItem item in CoffeeShop.items)
                {
                    foreach (var order in orders)
                    {
                        if (order == item.getName())
                        {
                            amount += item.getPrice();
                            break;
                        }
                    }
                }
            }
            else
            {
                return 0;
            }
            return amount;
        }

        public static void addOrder()
        {
            string name = CoffeeShopUI.Input_For_Order();
            foreach (MenuItem item in CoffeeShop.items)
            {
                if (item.getName() == name)
                {
                    orders.Add(name);
                    break;
                }
            }
        }

        public static void storeOrders(string path)
        {
            StreamWriter file = new StreamWriter(path);
            foreach (var item in orders)
            {
                file.WriteLine(item);
            }
            file.Close();
        }
        public static bool loadOrders(string path)
        {
            StreamReader reader = new StreamReader(path);
            if (File.Exists(path))
            {
                string line = "";
                while ((line = reader.ReadLine()) != null)
                {
                    string name = line;
                    orders.Add(name);
                }
                reader.Close();
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}