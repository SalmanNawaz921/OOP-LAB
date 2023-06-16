using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Problem_01;
using Problem_01.DL;
using Problem_01.UI;

namespace Problem_01.BL
{
    public class CoffeeShop
    {
        private string shopName = "";
        public static List<MenuItem> items = new List<MenuItem>();

        public void Add_Item(MenuItem product)
        {
            items.Add(product);
        }
        public CoffeeShop(string shopName)
        {
            this.shopName = shopName;
        }

        public void setShopName(string shopName)
        {
            this.shopName = shopName;
        }

        public string getshopName()
        {
            return this.shopName;
        }

        public static bool orders_FullFilled()
        {
            if (CoffeeShopDL.orders != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static string cheapestItem()
        {
            List<MenuItem> sortedList = new List<MenuItem>();
            sortedList = items.OrderBy(o => o.getPrice()).ToList();
            return sortedList[0].getName();
        }

        public static List<string> foodOnly()
        {
            List<string> foodOnlyItems = new List<string>();
            foreach (MenuItem item in items)
            {
                if (item.getType() == "Food")
                {
                    foodOnlyItems.Add(item.getName());
                }
            }
            return foodOnlyItems;
        }
        public static List<string> drinksOnly()
        {
            List<string> drinksOnlyItems = new List<string>();
            foreach (MenuItem item in items)
            {
                if (item.getType() == "Drink")
                {
                    drinksOnlyItems.Add(item.getName());
                }
            }
            return drinksOnlyItems;
        }

    }
}