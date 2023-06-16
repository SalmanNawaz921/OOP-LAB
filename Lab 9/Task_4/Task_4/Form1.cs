using System;
using System.Windows.Forms;

namespace Task_4
{
    public partial class frm_1 : Form
    {
        public frm_1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void btn_click_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Hello World!";

        }
    }
}
