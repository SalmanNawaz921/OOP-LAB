using System;

namespace TASK1
{

    class Program
    {
        static void Main(string[] args)
        {
            // Task1 : Part A

            // student s1 = new student("Salman", 996F, 1011F, 142F, 80.23F);
            // Console.WriteLine("Name: {0} Matric: {1} Inter: {2} ECAT: {3} Aggregate: {4} ", s1.studentName, s1.matricMarks, s1.fscMarks, s1.ecatMarks, s1.aggregate);

            // Task1 : Part B

            student s1 = new student("Salman", 996F, 1011F, 142F, 80.23F);
            student s2 = new student("Hamze", 1031F, 1020F, 128F, 80.12F);
            Console.WriteLine("Name: {0} Matric: {1} Inter: {2} ECAT: {3} Aggregate: {4} ", s2.studentName, s2.matricMarks, s2.fscMarks, s2.ecatMarks, s2.aggregate);
            if (s1.studentName == s2.studentName)
            {
                Console.Write("Same");
            }
            Console.Read();

        }
    }
}