
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challange_2
{
     class Program
    {

        // Task 4
        static char menu()
        {
            Console.Clear();
            char choice;
            Console.WriteLine("1. Add a Product ");
            Console.WriteLine("2. View Products ");
            Console.WriteLine("3. Total Store Worth ");
            Console.WriteLine("4. Exit ");
            choice = char.Parse(Console.ReadLine());
            return choice;
        }
        static Brand addProducts()
        {
            Console.Clear();
            Brand brand = new Brand();
            Console.Write("Enter Product ID: ");
            brand.productId = int.Parse(Console.ReadLine());
            Console.Write("Enter Product Name: ");
            brand.productName = Console.ReadLine();
            Console.Write("Enter Product Price: ");
            brand.productPrice = int.Parse(Console.ReadLine());
            Console.Write("Enter Category: ");
            brand.category = (Console.ReadLine());
            Console.Write("Enter Brand Name: ");
            brand.brandName = (Console.ReadLine()); 
            Console.Write("Enter Country Name: ");
            brand.country = (Console.ReadLine());
            return brand;
        }

        static void viewProducts(Brand[] brand, int count)
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Product ID: {0} Product Name: {1} Product Price: {2} Product Category: {3} Brand Name: {4} Country: {5} ", brand[i].productId, brand[i].productName, brand[i].productPrice,brand[i].category, brand[i].brandName, brand[i].country);
            }
            Console.WriteLine("Press Any Key To Continue... ");
            Console.ReadKey();
        }

        static void totalStoreWorth(Brand[] brand,int count)
        {
            int add = 0;
            for(int i = 0; i < count; i++)
            {
                add += brand[i].productPrice;
            }
            Console.WriteLine("Total Store Worth Is About: {0}", add);
            Console.WriteLine("Press Any Key To Continue... ");
            Console.ReadKey();

        }
        static void Main(string[] args) 
        {
            // ******* For Task 2 *******
            Brand[] brand = new Brand[10];
            char option;
            int count = 0;
            do
            {
                option = menu();
                if (option == '1')
                {
                    brand[count] = addProducts();
                    count++;
                }
                else if (option == '2')
                {
                    viewProducts(brand, count);
                }
                else if (option == '3')
                {
                    //Console.WriteLine("Total Store Worth Is About: {0}", totalStoreWorth(brand, count));
                    totalStoreWorth(brand, count);
                }
                else if (option == '4')
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Select Valid Option");
                }
            } while (option != '4');
            Console.WriteLine("Press Enter To Exit");
            Console.Read();
        }
    }

    }

