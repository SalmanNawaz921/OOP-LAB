using System.Collections.Generic;
using System.Windows.Forms;
using Task_01.BL;

namespace Task_01
{
    public partial class Form1 : Form
    {
        public static List<Student> students = new List<Student>();
        public Form1()
        {
            InitializeComponent();


        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            Student stu1 = new Student();
            stu1.Name = "Tayyab Salman";
            stu1.Id = 1;
            Student stu2 = new Student();
            stu2.Name = "Taha Saleem";
            stu2.Id = 2;
            students.Add(stu1);
            students.Add(stu2);
            dataGridView1.DataSource = students;
            // dataGridView1.Columns["Name"].Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Student stu = dataGridView1.CurrentRow.DataBoundItem as Student;
            students.Remove(stu);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = students;
            dataGridView1.Refresh();
        }
    }
}
