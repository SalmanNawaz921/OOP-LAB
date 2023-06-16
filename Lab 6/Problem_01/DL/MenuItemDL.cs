using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Problem_01;
using Problem_01.BL;
using Problem_01.UI;

namespace Problem_01.DL
{
    public class MenuItemDL
    {
        public static void storeItems(string path)
        {
            StreamWriter writer = new StreamWriter(path);
            foreach (MenuItem item in CoffeeShop.items)
            {
                writer.WriteLine(item.getName() + "," + item.getType() + "," + item.getPrice());
            }
            writer.Close();
        }
        public static bool loadItems(string path)
        {
            StreamReader reader = new StreamReader(path);
            if (File.Exists(path))
            {
                string line = "";
                while ((line = reader.ReadLine()) != null)
                {
                    string[] seperateData = line.Split(",");
                    string name = seperateData[0];
                    string type = seperateData[1];
                    int price = int.Parse(seperateData[2]);
                    MenuItem newItem = new MenuItem(name, type, price);
                    CoffeeShop.items.Add(newItem);
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