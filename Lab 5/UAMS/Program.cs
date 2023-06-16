using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uams.BL;
using uams.DL;
using uams.UI;

namespace Challange_1
{
    class Program
    {
        public static void Main(string[] args)
        {

            if (SubjectsDL.LoadData())
            {
                Console.WriteLine("Subjects Loaded Successfully");
            }
            if (DegreeProgramDL.LoadData())
            {
                Console.WriteLine("Degree Program Loaded Successfully");
            }
            if (StudentDL.LoadData())
            {
                Console.WriteLine("Students Loaded Successfully");
            }

            while (true)
            {
                printHeader();
                int option = menu();
                Console.Clear();
                printHeader();
                if (option == 1)
                {
                    if (DegreeProgramDL.degrees.Count > 0)
                    {
                        Student s = StudentUI.takeInputForStudent();
                        StudentDL.addStudent(s);
                        StudentDL.storeStudents();

                    }
                }
                else if (option == 2)
                {
                    DegreeProgram newDegree = DegreeProgramUI.takeInputFromDegree();
                    DegreeProgramDL.addDegree(newDegree);
                    DegreeProgramDL.storeData(newDegree);
                }
                else if (option == 3)
                {
                    List<Student> sortedList = new List<Student>();
                    sortedList = StudentDL.sortByMerit();
                    StudentDL.giveAdmission(sortedList);
                    StudentUI.printStudents();
                }
                else if (option == 4)
                {
                    StudentUI.registeredStudents();
                    Console.ReadKey();
                }
                else if (option == 5)
                {
                    StudentUI.specificStudents();
                }
                else if (option == 6)
                {
                    Console.Write("Enter Student Name: ");
                    string name = Console.ReadLine();
                    Student s = StudentDL.students.Find(e => e.studentName == name);
                    if (s != null)
                    {
                        SubjectsUI.viewSubjects(s);
                        Subjects.registerSubjects(s);

                    }
                }
                else if (option == 7)
                {
                    StudentUI.viewFeesForAll();

                }
                else if (option == 8)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Option ");
                }
                Console.Write("Press Any Key......");
                Console.ReadKey();
                Console.Clear();
            }
        }

        static int menu()
        {
            int option = 0;
            Console.WriteLine("1.Add Student");
            Console.WriteLine("2.Add Degree Program");
            Console.WriteLine("3.Generate Merit");
            Console.WriteLine("4.View Registered Students");
            Console.WriteLine("5.View Students of a Specific Program");
            Console.WriteLine("6.Registered Subjects For Specific Student");
            Console.WriteLine("7.Calculate Fees For All Registered Students");
            Console.Write("Your Option: ");
            option = validateInteger();
            return option;
        }
        static void printHeader()
        {
            Console.WriteLine("******************************************");
            Console.WriteLine("*****  University Management System  *****");
            Console.WriteLine("******************************************");

        }
        public static int validateInteger()
        {
            string number = Console.ReadLine();
            bool flag = false;
            while (!flag)
            {
                for (int i = 0; i < number.Length; i++)
                {
                    if (number[i] > '9' || number[i] < '0')
                    {
                        flag = false;
                        break;
                    }
                    else
                    {
                        flag = true;
                    }
                }
                if (!flag)
                {
                    Console.WriteLine("Enter Valid Integer: ");
                    number = Console.ReadLine();
                }
            }
            return int.Parse(number);
        }
    }

}