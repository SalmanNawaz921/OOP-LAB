﻿using SignUp_SignIn.DL;

namespace SignUp_SignIn.UI
{
    public class MUser
    {
        protected string userName = "";
        protected string userPassword = "";
        protected int userId = 0;
        protected string role = "";
        public MUser()
        {
        }

        public string GetName()
        {
            return this.userName;
        }
        public string GetPassword()
        {
            return this.userPassword;
        }
        public string GetRole()
        {
            return this.role;
        }
        public int GetId()
        {
            return this.userId;
        }

        public void SetName(string userName)
        {
            this.userName = userName;
        }
        public void SetPassword(string userPassword)
        {
            this.userPassword = userPassword;
        }
        public void SetRole(string role)
        {
            this.role = role;
        }
        public void SetId(int id)
        {
            this.userId = id;
        }
        public MUser(string userName, int userId, string userPassword, string role)
        {
            this.userName = userName;
            this.userId = userId;
            this.userPassword = userPassword;
            this.role = role;
        }
        public MUser(string userName, string userPassword, string role)
        {
            this.userName = userName;
            this.userPassword = userPassword;
            this.role = role;
        }
        public MUser(string userName, int userId, string userPassword)
        {
            this.userName = userName;
            this.userId = userId;
            this.userPassword = userPassword;
        }
        public MUser(string userName, string userPassword)
        {
            this.userName = userName;
            this.userPassword = userPassword;
        }
        public MUser(int userId)
        {
            this.userId = userId;
        }
        public static string validUser(MUser existingUser)
        {
            string name = "";
            foreach (MUser user in MUserDL.usersList)
            {
                if (user.userName == existingUser.userName && user.userPassword == existingUser.userPassword)
                {
                    return user.role;
                }

            }
            return "User Not Found";
        }

        public virtual string toString()
        {
            return $"{GetName(),-25}";
        }
    }
}
