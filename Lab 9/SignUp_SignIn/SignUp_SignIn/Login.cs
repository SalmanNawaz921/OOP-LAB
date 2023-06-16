using SignUp_SignIn.UI;
using System;
using System.Windows.Forms;

namespace SignUp_SignIn
{
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string username = txt_name.Text;
            string userpassword = txt_pass.Text;
            MUser existingUser = new MUser(username, userpassword);
            string role = MUser.validUser(existingUser);
            if (role != "User Not Found")
            {
                MessageBox.Show("You Have Logged In");
            }
            else
            {
                MessageBox.Show("Username or Password is incorrect");

            }
        }

        private void lil_signup_Click(object sender, EventArgs e)
        {
            frm_login frm1 = new frm_login();
            frm1.Hide();
            frm_SignUp frm = new frm_SignUp();
            frm.Show();
        }
    }
}
