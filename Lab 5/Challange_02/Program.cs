using System;
using shop.BL;
using shop.DL;
using shop.UI;

namespace Challange_02
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "users.txt";
            MUserDL.loadUser(path);
            MUser newUser;
            char option = ' ';
            while (option != '4')
            {
                Console.Clear();
                printHeader();
                option = loginMenu();
                Console.Clear();
                printHeader();
                if (option == '1')
                {
                    newUser = MUserUI.takeInputForSignUP();
                    MUserDL.addUser(newUser, path);
                }
                else if (option == '2')
                {
                    MUser existingUser = MUserUI.takeInputForLogin();
                    MUser.validUser(existingUser);
                    if (MUser.validUser(existingUser).ToUpper() == "ADMIN")
                    {
                        Console.WriteLine("Logged In");
                        char opt = ' ';
                        while (opt != '6')
                        {
                            Console.Clear();
                            printHeader();
                            opt = adminMenu();
                            Console.Clear();
                            printHeader();
                            if (opt == '1')
                            {
                                Products p = ProductsUI.takeInputForProduct();
                                ProductsDL.addProduct(p);
                            }
                            else if (opt == '2')
                            {
                                ProductsUI.viewProducts();
                            }
                            else if (opt == '3')
                            {
                                ProductsUI.sortByOrder();
                            }
                            else if (opt == '4')
                            {
                                ProductsUI.viewSalesTax();
                            }
                            else if (opt == '5')
                            {
                                ProductsUI.productsOrdered();
                            }
                            else
                            {
                                Console.WriteLine("Wrong Option......");
                            }
                            Console.WriteLine("Press Any Key......");
                            Console.ReadKey();
                            Console.Clear();
                        }
                    }
                    else if (MUser.validUser(existingUser).ToUpper() == "CUSTOMER")
                    {

                        char opt = ' ';
                        while (opt != '6')
                        {
                            Console.Clear();
                            printHeader();
                            opt = customerMenu();
                            Console.Clear();
                            printHeader();
                            if (opt == '1')
                            {
                                ProductsUI.viewProducts();

                            }
                            else if (opt == '2')
                            {
                                ProductsUI.viewProducts();
                                Customer.buyProduct();
                            }
                            else if (opt == '3')
                            {
                                CustomerUI.GenerateInvoice(existingUser);
                            }
                            Console.WriteLine("Press Any Key......");
                            Console.ReadKey();
                            Console.Clear();
                        }
                    }
                    else
                    {
                        Console.WriteLine("You Have Entered Wrong Role.......");
                    }
                }
                Console.WriteLine("Press Any Key......");
                Console.ReadKey();
                Console.Clear();
            }
        }
        static char adminMenu()
        {
            char choice;
            Console.WriteLine("1. Add a Product ");
            Console.WriteLine("2. View Products ");
            Console.WriteLine("3. Highest Price Product ");
            Console.WriteLine("4. View Sales Tax ");
            Console.WriteLine("5. Products To Order ");
            Console.WriteLine("6. Exit ");
            Console.Write("Your Option: ");
            choice = char.Parse(Console.ReadLine());
            return choice;
        }
        static char customerMenu()
        {

            char choice;
            Console.WriteLine("1. View All The Products ");
            Console.WriteLine("2. Buy The Products ");
            Console.WriteLine("3. Generate Invoice ");
            Console.WriteLine("4. Exit ");
            Console.Write("Your Option: ");
            choice = char.Parse(Console.ReadLine());
            return choice;
        }
        static char loginMenu()
        {
            char choice;
            Console.WriteLine("1. Sign UP ");
            Console.WriteLine("2. Sign IN ");
            Console.WriteLine("3. Exit ");
            Console.Write("Your Option: ");
            choice = char.Parse(Console.ReadLine());
            return choice;
        }
        static void printHeader()
        {
            Console.WriteLine("************************************");
            Console.WriteLine("*****  Shop Management System  *****");
            Console.WriteLine("************************************");
        }
    }
}