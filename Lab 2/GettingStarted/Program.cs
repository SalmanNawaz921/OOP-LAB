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
    }

    static void pizzapoints(int order, int price)
    {
        StreamReader file = new StreamReader(@"D:\OOP\GettingStarted\Customers.txt");
        string name, line;
        int noOrder, orderPrice, count;
        while ((line = file.ReadLine()) != null)
        {
            string[] fields = line.Split(',');
            name = fields[0];
            noOrder = int.Parse(fields[1]);
            if (noOrder >= order)
            {
                line = fields[2];
                count = 0;
                for (int i = 1; i <= noOrder; i++)
                {
                    try
                    {
                        orderPrice = int.Parse(parseData(line, i));
                    }
                    catch (FormatException e)
                    {
                        // handle the error
                        Console.WriteLine("Invalid price format: {0}", e.Message);
                        continue;
                    }
                    if (orderPrice >= price)
                    {
                        count++;
                    }
                }
                if (count >= order)
                {
                    Console.WriteLine(name);
                }
            }
        }
        file.Close();
    }

    static string parseData(string line, int field)
    {
        int commaCount = 1;
        string data = "";
        for (int i = 0; i < line.Length; i++)
        {
            if (line[i] == ',')
            {
                commaCount++;
            }
            else if (commaCount == field)
            {
                data += line[i];
            }
        }
        return data;
    }
}
}