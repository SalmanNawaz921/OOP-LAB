using System;

namespace Task_3
{
    class Program
    {

        // Task 3
        static char menu()
        {
            Console.Clear();
            char choice;
            Console.WriteLine("1. Add a Student ");
            Console.WriteLine("2. View Student ");
            Console.WriteLine("3. Top Three Students ");
            Console.WriteLine("4. Exit ");
            choice=char.Parse(Console.ReadLine()); 
            return choice;
        }
        static Students addStudent()
        {
            Console.Clear();
            Students student = new Students();
            Console.Write("Enter Student Name: ");
            student.name = Console.ReadLine();
            Console.Write("Enter Roll No: ");
            student.roll_no = int.Parse(Console.ReadLine());
            Console.Write("Enter CGPA: ");
            student.cgpa = float.Parse(Console.ReadLine()); 
            Console.Write("Hostlide (Y/N): ");
            student.isHostelide = char.Parse(Console.ReadLine()); 
            Console.Write("Enter Department: ");
            student.department =(Console.ReadLine());
            return student;
        }
        static  void viewStudents(Students[] student,int count)
        {
            for(int i = 0; i < count; i++)
            {
                Console.WriteLine("Name: {0} RollNo: {1} CGPA: {2} HOSTLITE: {3} DEPARTMENT: {4} ", student[i].name, student[i].roll_no, student[i].cgpa, student[i].isHostelide, student[i].department);
            }
            Console.WriteLine("Press Any Key To Continue... ");
            Console.ReadKey();
        }

        static void topStudents(Students[] student,int count)
        {
            Console.Clear();
            if (count == 0)
            {
                Console.WriteLine("No Record Available");
            }
            else if(count == 1)
            {
                viewStudents(student, 1);
            }
            else if (count == 2)
            {
                for(int i = 0; i < 2; i++)
                {
                    int index=largest(student, i,count);
                    Students temp = student[index];
                    student[index] = student[i];
                    student[i] = temp;
                }
                viewStudents(student, 2);
            }
            else
            {
                for (int i = 0; i < 3; i++)
                {
                    int index = largest(student, i, count);
                    Students temp = student[index];
                    student[index] = student[i];
                    student[i] = temp;
                }
                viewStudents(student, 3);
            }
        }
        static int largest(Students[] student,int start,int end)
        {
            int index = start;
            float large = student[start].cgpa;
            for(int i = start; i < end; i++)
            {
                if (large < student[i].cgpa)
                {
                    large = student[i].cgpa;
                    index = i;
                }
            }
            return index;
        }
        static void Main(string[] args)
        {

            // ******* For Task 2 *******
            Students[] student = new Students[10];
            char option;
            int count = 0;
            do
            {
                option = menu();
                if(option == '1')
                {
                    student[count] = addStudent();
                    count++;
                }
                else if (option == '2')
                {
                    viewStudents(student, count);
                }
                else if (option == '3')
                {
                    topStudents(student, count);
                }
                else if (option == '4')
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Select Valid Option");
                }
            }while(option!='4');
            Console.WriteLine("Press Enter To Exit");
            Console.Read();
        }
    }
}
