using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Challange_1;
using uams.BL;

namespace uams.DL
{
    class StudentDL
    {
        public static string path = "Students.txt";
        public static List<Student> students = new List<Student>();
        public static void addStudent(Student s)
        {
            students.Add(s);
        }
        public static List<Student> sortByMerit()
        {
            List<Student> sortedList = new List<Student>();
            foreach (Student stu in students)
            {
                stu.calculateMerit();
            }
            sortedList = students.OrderByDescending(o => o.merit).ToList();
            return sortedList;
        }
        public static void giveAdmission(List<Student> sortedList)
        {
            foreach (Student stu in sortedList)
            {
                foreach (DegreeProgram d in stu.preferences)
                {
                    if (d.seatsForDegree > 0 && stu.regDegree == null)
                    {
                        stu.regDegree = d;
                        int seats = d.seatsForDegree;
                        seats--;
                        d.setSeats(seats);
                        break;
                    }
                }
            }
        }
        public static void storeStudents()
        {
            StreamWriter writer = new StreamWriter(path, true);
            foreach (Student stu in students)
            {
                string preferenceName = "";
                foreach (DegreeProgram program in stu.preferences)
                {
                    preferenceName += program.degreeName + ";";
                }
                writer.WriteLine(stu.studentName + "," + stu.studentAge + "," + stu.fscMarks + "," + stu.ecatMarks + "," + preferenceName);
            }
            writer.Flush();
            writer.Close();
        }
        public static bool LoadData()
        {
            StreamReader reader = new StreamReader(path);
            string line;
            if (File.Exists(path))
            {
                while ((line = reader.ReadLine()) != null)
                {
                    string[] fields = line.Split(",");
                    string name = fields[0];
                    int age = int.Parse(fields[1]);
                    double fsc = double.Parse(fields[2]);
                    double ecat = double.Parse(fields[3]);
                    string[] preferenceSplit = fields[4].Split(";");
                    List<DegreeProgram> preferences = new List<DegreeProgram>();
                    for (int x = 0; x < preferenceSplit.Length; x++)
                    {
                        string preference = preferenceSplit[x];
                        DegreeProgram program = DegreeProgramDL.degrees.Find(e => e.degreeName == preference);
                        if (program != null)
                        {
                            if (!(preferences.Contains(program)))
                            {
                                preferences.Add(program);
                            }
                        }
                    }
                    Student stu = new Student(name, age, fsc, ecat, preferences);
                    students.Add(stu);
                }
                reader.Close();
                return true;
            }
            return false;
        }
    }

}