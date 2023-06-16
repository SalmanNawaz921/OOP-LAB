using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using shop.DL;

namespace shop.BL
{
    public class MUser
    {
        public string userName = "";
        public string userPassword = "";
        public string role = "";
        public MUser()
        {
        }

        public MUser(string userName, string userPassword, string role)
        {
            this.userName = userName;
            this.userPassword = userPassword;
            this.role = role;
        }
        public MUser(string userName, string userPassword)
        {
            this.userName = userName;
            this.userPassword = userPassword;
        }
        public static string validUser(MUser existingUser)
        {
            foreach (MUser user in MUserDL.usersList)
            {
                if (user.userName == existingUser.userName && user.userPassword == existingUser.userPassword)
                {
                    return user.role;
                }
            }
            return "User Not Found";
        }
    }
}