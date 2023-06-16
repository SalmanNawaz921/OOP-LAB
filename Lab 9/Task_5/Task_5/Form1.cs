using System;
using System.Windows.Forms;

namespace Task_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_name1.Text == txt_name2.Text)
            {
                MessageBox.Show("Both Names Are Same");
            }
            else
            {
                MessageBox.Show("Names Are Not Same");

            }
        }
    }
}
