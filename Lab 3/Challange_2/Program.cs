using System;

namespace Challange_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Products> products = new List<Products>();
            char opt = ' ';
            while (opt != '6')
            {
                opt = menu();
                if (opt == '1')
                {
                    addProduct(products);
                }
                else if (opt == '2')
                {
                    viewProducts(products);
                }
                else if (opt == '3')
                {
                    Products.highestPrice(products);
                }
                else if (opt == '4')
                {
                    foreach (Products p in products)
                    {
                        Console.WriteLine(p.productName + " " + p.viewSalesTax(products) + "%");
                    }
                }
                else if (opt == '5')
                {
                    Products.productsOrdered(products);
                }
                else
                {
                    Console.WriteLine("Wrong Option......");
                }
                Console.ReadKey();
            }

        }
        static char menu()
        {
            Console.Clear();
            char choice;
            Console.WriteLine("1. Add a Product ");
            Console.WriteLine("2. View Products ");
            Console.WriteLine("3. Highest Price Product ");
            Console.WriteLine("4. View Sales Tax ");
            Console.WriteLine("5. Products To Order ");
            choice = char.Parse(Console.ReadLine());
            return choice;
        }
        static void addProduct(List<Products> products)
        {
            Console.Clear();
            Console.Write("Enter Product Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Product Price: ");
            int price = int.Parse(Console.ReadLine());
            Console.Write("Enter Category: ");
            string cate = (Console.ReadLine());
            Console.Write("Enter Product Stock Quantity: ");
            int stock = int.Parse(Console.ReadLine());
            Console.Write("Enter Product Minimum Stock Quantity: ");
            int min = int.Parse(Console.ReadLine());
            Products product = new Products(name, cate, price, stock, min);
            products.Add(product);
            // return brand;
        }
        static void viewProducts(List<Products> products)
        {
            foreach (var p in products)
            {
                Console.WriteLine("Product Name: {0} \t Product Price: {1} \t Cateogory:{2} \t Product Stock:{3} \t Minimum Stock:{4} ", p.productName, p.productPrice, p.category, p.stockQuantity, p.minStock);
            }
        }
    }
}