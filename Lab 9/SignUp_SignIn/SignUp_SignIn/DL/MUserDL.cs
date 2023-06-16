using SignUp_SignIn.UI;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace SignUp_SignIn.DL
{
    public class MUserDL
    {
        public static List<MUser> usersList = new List<MUser>();
        public static void addUser(MUser user, string path)
        {
            bool flag = true;
            foreach (MUser u in usersList)
            {
                if (user.GetRole() == "MANAGER" || user.GetRole() == "CASHIER")
                {
                    if (u.GetPassword() == user.GetPassword() && u.GetPassword() == user.GetPassword())
                    {
                        flag = false;
                        MessageBox.Show("Sign Up Failed!");
                        break;
                    }
                }
            }
            if (flag == true)
            {
                usersList.Add(user);
                storeUser(path, user);
                MessageBox.Show("Signed Up Successfully!");
            }
        }
        public static void storeUser(string path, MUser newUser)
        {
            StreamWriter writer = new StreamWriter(path);
            foreach (MUser user in usersList)
            {
                writer.WriteLine(user.GetName() + "," + user.GetPassword() + "," + user.GetRole());
            }
            writer.Close();
        }
        public static void loadUser(string path)
        {
            string line;
            if (File.Exists(path))
            {
                StreamReader file = new StreamReader(path);
                while ((line = file.ReadLine()) != null)
                {
                    string[] userFields = line.Split(',');
                    MUser newUser = new MUser();
                    newUser.SetName(userFields[0]);
                    newUser.SetPassword(userFields[1]);
                    newUser.SetRole(userFields[2]);
                    usersList.Add(newUser);
                }
                file.Close();
            }
        }
    }
}
