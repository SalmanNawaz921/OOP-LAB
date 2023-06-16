using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using shop.BL;
using shop.UI;

namespace shop.DL
{
    public class MUserDL
    {
        public static List<MUser> usersList = new List<MUser>();
        public static void addUser(MUser user, string path)
        {
            bool flag = true;
            foreach (MUser u in usersList)
            {
                if (u.userPassword == user.userPassword && u.userName == user.userPassword)
                {
                    flag = false;
                    Console.WriteLine("Sign Up Failed!");
                    break;
                }
            }
            if (flag == true)
            {
                usersList.Add(user);
                storeUser(path, user);
                Console.WriteLine("Signed Up Successfully!");
            }
        }
        public static void storeUser(string path, MUser newUser)
        {
            StreamWriter writer = new StreamWriter(path);
            foreach (MUser user in usersList)
            {
                writer.WriteLine(user.userName + "," + user.userPassword + "," + user.role);
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
                    newUser.userName = userFields[0];
                    newUser.userPassword = userFields[1];
                    newUser.role = userFields[2];
                    usersList.Add(newUser);
                }
                file.Close();
            }
        }
    }
}