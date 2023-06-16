using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Challange_02;
using shop.BL;

namespace shop.UI
{
    public class MUserUI
    {
        public static MUser takeInputForSignUP()
        {
            Console.Write("Enter User Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter User Password: ");
            string password = Console.ReadLine();
            Console.Write("Enter User Role: ");
            string role = Console.ReadLine();
            MUser newUser = new MUser(name, password, role);
            return newUser;
        }
        public static MUser takeInputForLogin()
        {
            Console.Write("Enter User Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter User Password: ");
            string password = Console.ReadLine();
            MUser existingUser = new MUser(name, password);
            return existingUser;
        }
    }
}