using System;
using Problem_03.BL;
namespace Problem_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Dog dog1 = new Dog("Jackie");
            Dog dog2 = new Dog("Tommy");
            Cat cat1 = new Cat("Kitten");
            Cat cat2 = new Cat("Pie");
            dog1.greets();
            Console.WriteLine(dog1.toString());
            dog2.greets(dog2);
            Console.WriteLine(dog2.toString());
            cat1.greets();
            Console.WriteLine(cat1.toString());
            cat2.greets();
            Console.WriteLine(cat2.toString());
            Console.ReadKey();
        }
    }
}