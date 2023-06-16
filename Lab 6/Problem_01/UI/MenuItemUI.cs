using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Problem_01;
using Problem_01.BL;
using Problem_01.DL;

namespace Problem_01.UI
{
    public class MenuItemUI
    {
        public static MenuItem Input_For_Item()
        {
            Console.Write("Enter Name of The Item: ");
            string name = Console.ReadLine();
            Console.Write("Enter Type of The Item (Food or Drink): ");
            string type = Console.ReadLine();
            Console.Write("Enter Price of The " + type + " : ");
            int price = int.Parse(Console.ReadLine());
            MenuItem newItem = new MenuItem(name, type, price);
            return newItem;
        }
    }
}