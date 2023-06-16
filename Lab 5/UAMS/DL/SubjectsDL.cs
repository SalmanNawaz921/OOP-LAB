using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Challange_1;
using uams.BL;

namespace uams.DL
{
    class SubjectsDL
    {
        public static List<Subjects> subjects = new List<Subjects>();
        public static string path = "Subjects.txt";
        public static void subjectsIntoList(Subjects sub)
        {
            subjects.Add(sub);
        }
        public static void storeData(Subjects subject)
        {
            StreamWriter write = new StreamWriter(path, true);
            write.WriteLine(subject.subjectType + "," + subject.subjectCode + "," + subject.creditHours + "," + subject.subjectFees);
            write.Flush();
            write.Close();
        }
        public static bool LoadData()
        {
            StreamReader read = new StreamReader(path);
            string line;
            if (File.Exists(path))
            {
                while ((line = read.ReadLine()) != null)

                {
                    string[] field = line.Split(',');
                    string name = field[0];
                    int code = int.Parse(field[1]);
                    int creditHours = int.Parse(field[2]);
                    int fees = int.Parse(field[3]);
                    Subjects subject = new Subjects(code, name, creditHours, fees);
                    subjects.Add(subject);
                }
                read.Close();
                return true;
            }

            return false;

        }
        public static Subjects isSubjectExists(string type)
        {
            foreach (Subjects s in subjects)
            {
                if (s.subjectType == type)
                {
                    return s;
                }
            }
            return null;
        }
    }

}