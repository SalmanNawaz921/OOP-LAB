using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Challange_1;

namespace uams.BL
{
    class Subjects
    {
        public int subjectCode;
        public string subjectType = "";
        public int creditHours;
        public int subjectFees;

        public Subjects(int subjectCode, string subjectType, int creditHours, int subjectFees)
        {
            this.subjectCode = subjectCode;
            this.subjectType = subjectType;
            this.creditHours = creditHours;
            this.subjectFees = subjectFees;
        }
        public int GetCode()
        {
            return subjectCode;
        }
        public static void registerSubjects(Student s)
        {
            Console.Write("How Many Subjects You Want To Register: ");
            int count = Program.validateInteger();
            for (int x = 0; x < count; x++)
            {
                Console.WriteLine("Enter the subject Code");
                int code = Program.validateInteger();
                bool Flag = false;
                foreach (Subjects sub in s.regDegree.subjects)
                {
                    if (code == sub.GetCode() && !(s.regSubject.Contains(sub)))
                    {
                        if (s.regStudentSubject(sub) == true)
                        {
                            Flag = true;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("A student cannot have more than 9 CH");
                            Flag = true;
                            break;
                        }
                    }
                }
                if (Flag == false)
                {
                    Console.WriteLine("Enter Valid Course");
                    x--;
                }
            }
        }

    }

}