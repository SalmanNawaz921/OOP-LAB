using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Challange_1;
using uams.BL;
using uams.UI;

namespace uams.DL
{
    class DegreeProgramUI
    {
        public static DegreeProgram takeInputFromDegree()
        {
            Console.Write("Enter Degree Name: ");
            string name = (Console.ReadLine());
            Console.Write("Enter Degree Duration: ");
            int duration = Program.validateInteger();
            Console.Write("Enter Seats For The Degree: ");
            int seats = Program.validateInteger();
            Console.Write("Enter No Of Subjects For This Degree: ");
            int no = Program.validateInteger();
            DegreeProgram degree = new DegreeProgram(name, duration, seats);
            for (int i = 0; i < no; i++)
            {
                Subjects subj = SubjectsUI.takeInputForSubject();
                if (degree.addSubject(subj))
                {
                    if (!(SubjectsDL.subjects.Contains(subj)))
                    {
                        SubjectsDL.subjectsIntoList(subj);
                        SubjectsDL.storeData(subj);
                    }
                    Console.WriteLine("Subject Added");
                }
                else
                {
                    Console.WriteLine("Subject Not Added");
                    Console.WriteLine("20 credit hour limit exceeded");
                    i--;
                }
            }

            return degree;
        }

    }

}