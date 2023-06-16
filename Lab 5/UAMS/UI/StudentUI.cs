using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Challange_1;

using uams.DL;
using uams.BL;
namespace uams.UI
{
    class StudentUI
    {
        public static Student takeInputForStudent()
        {
            Console.Write("Enter Student Name: ");
            string name = (Console.ReadLine());
            Console.Write("Enter Student Age: ");
            int age = Program.validateInteger();
            Console.Write("Enter Student FSC Marks: ");
            int fscMarks = Program.validateInteger();
            Console.Write("Enter Student ECAT Marks: ");
            int ecatMarks = Program.validateInteger();

            Console.WriteLine("Available Degree Programs:");
            Console.WriteLine("Degree Name:");
            for (int i = 0; i < DegreeProgramDL.degrees.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {DegreeProgramDL.degrees[i].degreeName}");
            }

            Console.Write("Enter How Many Preferences: ");
            int numPreferences = Program.validateInteger();
            List<DegreeProgram> preferences = new List<DegreeProgram>();
            for (int i = 0; i < numPreferences; i++)
            {
                Console.Write($"Enter Preference {i + 1}:");
                string preferenceName = Console.ReadLine();
                DegreeProgram degree = DegreeProgramDL.degrees.Find(d => d.degreeName == preferenceName);
                if (degree != null)
                {
                    preferences.Add(degree);
                }
                else
                {
                    Console.WriteLine($"Degree program '{preferenceName}' not found!");
                }
            }

            Student student = new Student(name, age, fscMarks, ecatMarks, preferences);
            return student;
        }


        public static void viewFeesForAll()
        {
            Console.WriteLine("Fees of All Students\n");
            foreach (Student stu in StudentDL.students)
            {
                Console.WriteLine(stu.studentName + " has " + stu.calculateFees() + " fees");
            }
        }
        public static void printStudents()
        {
            foreach (Student stu in StudentDL.students)
            {
                if (stu.regDegree != null)
                {
                    Console.WriteLine(stu.studentName + " got admission in " + stu.regDegree.degreeName);
                }
                else
                {
                    Console.WriteLine(stu.studentName + " did not get admission in " + stu.regDegree.degreeName);

                }
            }
        }
        public static void specificStudents()
        {
            Console.WriteLine("Enter Degree Name: ");
            string name = Console.ReadLine();
            DegreeProgram degree = DegreeProgramDL.degrees.Find(e => e.degreeName == name);
            if (degree != null)
            {
                Console.WriteLine(" NAME " + "\t" + " INTER " + "\t" + " ECAT " + "\t" + " Age ");
                foreach (Student stu in StudentDL.students)
                {
                    if (stu.regDegree != null)
                    {
                        if (stu.regDegree.degreeName == degree.degreeName)
                        {
                            Console.WriteLine(stu.studentName + "\t" + stu.fscMarks + "\t" + stu.ecatMarks + "\t" + stu.studentAge);
                        }
                    }
                    else
                    {
                        Console.WriteLine("No Student");
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Degree Not Found");
            }
        }
        public static void registeredStudents()
        {

            Console.WriteLine("All Students");
            Console.WriteLine(" NAME " + "\t" + " INTER " + "\t" + " ECAT " + "\t" + " Age ");
            foreach (Student stu in StudentDL.students)
            {
                Console.WriteLine(stu.studentName + "\t" + stu.fscMarks + "\t" + stu.ecatMarks + "\t" + stu.studentAge);
            }
            Console.ReadKey();

        }
    }

}