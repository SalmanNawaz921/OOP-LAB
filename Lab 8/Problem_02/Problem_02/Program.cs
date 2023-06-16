using System;
using Problem_02.BL;
namespace Problem_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Student stu1 = new Student("Salman", "Lahore", "CS", 1, 54000);
            Student stu2 = new Student("Hamza", "Lahore", "CE", 1, 64000);
            Staff staff1 = new Staff("Jami", "Kasur", "Kasur School", 14000);
            Staff staff2 = new Staff("Tayyab", "Sheikhupura", "Sheikhupura School", 25000);
            Console.WriteLine(stu1.toString());
            Console.WriteLine(stu2.toString());
            Console.WriteLine(staff1.toString());
            Console.WriteLine(staff2.toString());
            Console.ReadKey();

        }
    }
}