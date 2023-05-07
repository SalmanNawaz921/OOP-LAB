using System;

namespace Task1
{
    class Program{

            // Task1 & Task2
        class students{
            public string name;
            public int roll_no;
            public float cgpa;
        }

        static void Main(string[] args){
            // ******* For Task 1 *********
            // students s1 = new students();
            // students s2 = new students();
            // s1.name="Muhammad Salman";
            // s1.roll_no=138;
            // s1.cgpa=3.3F;
            // s2.name="Muhammad Tayyab";
            // s2.roll_no=133;
            // s2.cgpa=3.2F;
            // Console.WriteLine("Record Of First Student");
            // Console.WriteLine("Name: "+s1.name+"\n"+"RollNo: "+s1.roll_no+"\n"+"CGPA: "+s1.cgpa);
            // Console.WriteLine("Record Of Second Student");
            // Console.WriteLine("Name: "+s2.name+"\n"+"RollNo: "+s2.roll_no+"\n"+"CGPA: "+s2.cgpa);

            // ******* For Task 2 *******
            students s1 = new students();
            Console.Write("Enter Student Name: ");
            s1.name=Console.ReadLine();
            Console.Write("Enter Roll No: ");
            s1.roll_no=int.Parse(Console.ReadLine());
            Console.Write("Enter CGPA: ");
            s1.cgpa=float.Parse(Console.ReadLine());
            Console.WriteLine("Record Of Student");
            Console.WriteLine("Name: "+s1.name+"\n"+"RollNo: "+s1.roll_no+"\n"+"CGPA: "+s1.cgpa);
            Console.ReadKey();
        }
    }
}