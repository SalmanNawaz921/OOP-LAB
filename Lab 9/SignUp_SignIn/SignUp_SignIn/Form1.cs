using SignUp_SignIn.DL;
using SignUp_SignIn.UI;
using System;
using System.Windows.Forms;


namespace SignUp_SignIn
{
    public partial class frm_SignUp : Form
    {
        public frm_SignUp()
        {
            InitializeComponent();
            MUserDL.loadUser("Users.txt");
        }

        private void SignUpSignInApp_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click_1(object sender, EventArgs e)
        {

        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Frm_Login form = new Frm_Login();
            //form.Show();
        }

        private void lbl_header_Click(object sender, EventArgs e)
        {


        }

        private void lil_login_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_SignUp signUp = new frm_SignUp();
            signUp.Hide();
            frm_login loginPage = new frm_login();
            loginPage.Show();

        }

        private void txt_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_pass_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_role_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_name_Click(object sender, EventArgs e)
        {

        }

        private void lbl_pass_Click(object sender, EventArgs e)
        {

        }

        private void lbl_role_Click(object sender, EventArgs e)
        {

        }

        private void btn_signUp_Click(object sender, EventArgs e)
        {
            string username = txt_name.Text;
            string userpassword = txt_pass.Text;
            string role = txt_role.Text;
            string path = "Users.txt";
            MUser user = new MUser(username, userpassword, role);
            MUserDL.addUser(user, path);
        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }
    }
}
