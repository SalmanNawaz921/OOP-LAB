using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Challange_1;

namespace uams.BL
{
    class DegreeProgram
    {
        public string degreeName = "";
        public int degreeDuration;
        public int seatsForDegree;
        public int noOfSubjects;
        public List<Subjects> subjects;

        public DegreeProgram(string degreeName, int degreeDuration, int seatsForDegree)
        {
            this.degreeName = degreeName;
            this.degreeDuration = degreeDuration;
            this.seatsForDegree = seatsForDegree;
            subjects = new List<Subjects>();
        }
        public void setSeats(int seats)
        {
            this.seatsForDegree = seats;
        }

        public int calculateCreditHours()
        {
            int ch = 0;

            foreach (Subjects sub in subjects)
            {
                ch += sub.creditHours;
            }

            return ch;
        }

        public bool addSubject(Subjects s)
        {
            int creditHours = calculateCreditHours();
            if (creditHours + s.creditHours
            <= 20)
            {

                subjects.Add(s);
                return true;
            }
            else
            {
                return false;

            }
        }

        public bool isSubjectExists(Subjects s)
        {
            Subjects s1 = subjects.Find(e => e.subjectType == s.subjectType);
            if (s1 != null)
            {
                return true;
            }

            return false;


        }
    }

}