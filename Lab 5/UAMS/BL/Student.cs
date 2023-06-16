using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Challange_1;

namespace uams.BL
{
    class Student
    {
        public string studentName = "";
        public int studentAge;
        public double fscMarks;
        public double ecatMarks;
        public double merit;
        public List<DegreeProgram> preferences;
        public List<Subjects> regSubject;
        public DegreeProgram regDegree;

        public Student(string studentName, int studentAge, double fscMarks, double ecatMarks, List<DegreeProgram> preferences)
        {
            this.studentName = studentName;
            this.studentAge = studentAge;
            this.fscMarks = fscMarks;
            this.ecatMarks = ecatMarks;
            this.preferences = preferences;
            regSubject = new List<Subjects>();
        }

        public bool regStudentSubject(Subjects s)
        {
            int stCH = getCreditHours();
            if (regDegree != null &&
            regDegree.isSubjectExists(s) && stCH +
            s.creditHours <= 9)
            {
                regSubject.Add(s);
                Console.WriteLine("Added");
                return true;
            }
            else
            {
                Console.WriteLine("A student cannot have more than 9 CH or Wrong Subject");
                return false;
            }
        }

        public int getCreditHours()
        {
            int ch = 0;
            foreach (Subjects sub in regSubject)
            {
                ch += sub.creditHours;
            }
            return ch;
        }
        public int calculateFees()
        {
            int fees = 0;
            foreach (Subjects sub in regSubject)
            {
                fees += sub.subjectFees;
            }
            return fees;
        }

        public void calculateMerit()
        {
            merit = (((fscMarks / 1100) * 0.45F) + ((ecatMarks / 400) * 0.55F)) * 100;

        }

    }

}