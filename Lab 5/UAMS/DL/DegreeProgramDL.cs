using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Challange_1;
using uams.BL;

namespace uams.DL
{
    class DegreeProgramDL
    {

        public static string path = "DegreePrograms.txt";
        public static List<DegreeProgram> degrees = new List<DegreeProgram>();
        public static void addDegree(DegreeProgram degree)
        {
            if (degree != null)
            {
                degrees.Add(degree);

            }
        }
        public static void storeData(DegreeProgram program)
        {
            StreamWriter write = new StreamWriter(path, true);
            string SubjectNames = "";
            foreach (Subjects sub in program.subjects)
            {
                SubjectNames += sub.subjectType + ';';
            }
            // SubjectNames = SubjectNames + program.subjects[program.subjects.Count - 1].subjectType;
            write.WriteLine(program.degreeName + "," + program.degreeDuration + "," + program.seatsForDegree + "," + SubjectNames);

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
                    string[] fields = line.Split(',');
                    string name = fields[0];
                    int duration = int.Parse(fields[1]);
                    int seat = int.Parse(fields[2]);
                    string[] subjectSplit = fields[3].Split(';');
                    DegreeProgram newProgram = new DegreeProgram(name, duration, seat);
                    for (int x = 0; x < subjectSplit.Length; x++)
                    {
                        string subject = subjectSplit[x];
                        Subjects s = SubjectsDL.isSubjectExists(subject);
                        if (s != null)
                        {
                            newProgram.addSubject(s);
                        }
                    }
                    addDegree(newProgram);

                }
                read.Close();
                return true;
            }

            return false;

        }

    }

}