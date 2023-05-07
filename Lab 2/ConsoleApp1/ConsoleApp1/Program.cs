using System;
using System.IO;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("ENTER MINIMUM ORDER: ");
            int order = int.Parse(Console.ReadLine());
            Console.Write("ENTER MINIMUM PRICE: ");
            int price = int.Parse(Console.ReadLine());
            pizzapoints(order, price);
            Console.ReadKey();
        }

        static void pizzapoints(int minOrders, int minPrice)
        {
            StreamReader file = new StreamReader(@"D:\OOP\GettingStarted\Customers.txt");
            string name, line;
            int noOrder, orderPrice, eligibleOrderCount, totalSpent;
            while ((line = file.ReadLine()) != null)
            {
                string[] fields = line.Split(' ');
                name = fields[0];
                noOrder = int.Parse(fields[1]);
                string[] orderPrices = fields[2].Trim('[', ']').Split(',');
                eligibleOrderCount = 0;
                totalSpent = 0;
                for (int i = 0; i < orderPrices.Length; i++)
                {
                    orderPrice = int.Parse(orderPrices[i]);
                    if (orderPrice >= minPrice)
                    {
                        eligibleOrderCount++;
                        totalSpent += orderPrice;
                    }
                }
                if (eligibleOrderCount >= minOrders)
                {
                    Console.WriteLine($"{name} is eligible for a free pizza! They have made {noOrder} orders of at least {minPrice} and have spent a total of {totalSpent}.");
                }
            }
            file.Close();
        }
    }
}
