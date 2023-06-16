using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Challange_1;
using uams.BL;

namespace uams.UI
{
    class SubjectsUI
    {
        public static Subjects takeInputForSubject()
        {
            Console.Write("Enter Subject Code: ");
            int code = Program.validateInteger();
            Console.Write("Enter Subject Type: ");
            string type = (Console.ReadLine());
            Console.Write("Enter Credit Hours For This Subject: ");
            int credit = Program.validateInteger();
            Console.Write("Enter Fees For This Subject: ");
            int fee = Program.validateInteger();
            Subjects sub = new Subjects(code, type, credit, fee);
            return sub;
        }
        public static void viewSubjects(Student s)
        {
            Console.WriteLine("Subject Name " + "\t" + "Subject Code " + "\t" + "Subject Fees");
            foreach (Subjects sub in s.regDegree.subjects)
            {
                Console.WriteLine(sub.subjectType + "\t\t" + sub.subjectCode + "\t\t" + sub.subjectFees);
            }
        }

    }

}