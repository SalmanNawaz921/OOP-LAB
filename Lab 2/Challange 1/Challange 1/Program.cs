using Challange_1;
using Microsoft.VisualBasic.FileIO;
using System;
using System.IO;

namespace Test
{
    class Program
    {
       
        static void Main(string[] args)
        {
            string path = "D:\\OOP\\Challange 1\\Challange 1\\names.txt";
            Credentials[] credentials = new Credentials[5];
            int count = 0;
            int num = 0;
            do
            {
                readData(credentials,path);
                string option;
                Console.Clear();
                option = Menu();
                Console.Clear();

                if (option == "1")
                {
                    Console.WriteLine("Enter Name: ");
                    string n = Console.ReadLine();
                    Console.WriteLine("Enter Password: ");
                    string p = Console.ReadLine();
                    signIn(credentials, n, p);
                    Console.Clear();
                }

                else if (option == "2")
                {
                    Console.WriteLine("Enter New Name: ");
                    string n = Console.ReadLine();
                    Console.WriteLine("Enter New Passwrds: ");
                    string p = Console.ReadLine();
                    signUp(path,n,p);
                    credentials[count].userName=n;
                    credentials[count].password=p;
                    count++;
                }

                else if (option == "3")
                {
                    Console.WriteLine("Thanks For Using!!");
                    Console.ReadKey();
                    break;
                }
                num = int.Parse(option);
            }
            while (num < 4);
            Console.Read();
        }
        
        
        static string Menu()
{
    string option;
    Console.WriteLine("1. Sign In");
    Console.WriteLine("2. Sign Up");
    Console.WriteLine("3. Exit");
    Console.WriteLine("Enter Option");
    option = Console.ReadLine();
    Console.WriteLine(option);
    return option;
}

static void readData(Credentials[] credentials,string path)
{
            int count= 0;
            if (File.Exists(path))
    {

        StreamReader fileVariable = new StreamReader(path);
        string record;
        while ((record = fileVariable.ReadLine()) != null && count<credentials.Length)
        {
                    if (count >= 5)
                    {
                        break;
                    }
                    else
                    {
                        credentials[count] = new Credentials(); // initialize the element
                        credentials[count].userName = parseData(record, 1);
                        credentials[count].password = parseData(record, 2);
                        count++;
                    }
        }
        fileVariable.Close();
    }
}

static string parseData(string record, int field)
{
    int comma = 1;
    string item = "";
    for (int x = 0; x < record.Length; x++)
    {
        if (record[x] == ',')
        {
            comma++;
        }
        else if (comma == field)
        {
            item = item + record[x];
        }
    }
    return item;
}

        static void signIn(Credentials[] credentials, string nam, string pass)
        {
            bool flag = false;
            for (int x = 0; x < credentials.Length; x++)
            {
                if (credentials[x] != null && nam == credentials[x].userName && pass == credentials[x].password)
                {
                    Console.WriteLine("Valid User");
                    flag = true;
                    break;
                }
            }

            if (!flag)
            {
                Console.WriteLine("Invalid User");
            }
            Console.ReadKey();
        }


        static void signUp(string path,string name ,string password)
{
    StreamWriter file = new StreamWriter(path, true);
            //Credentials credentials = new Credentials();
            file.WriteLine(name+ "," +password);
             file.Flush();
             file.Close();
        }
    }
}
