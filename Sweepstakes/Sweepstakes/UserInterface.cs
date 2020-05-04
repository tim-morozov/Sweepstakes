using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
   static class UserInterface
    {
        public static string GetFirstName()
        {
            string name;
            Console.WriteLine("What is your first name?");
            name = Console.ReadLine();
            return name;
        }
        public static string GetLastName()
        {
            string name;
            Console.WriteLine("What is your last name?");
            name = Console.ReadLine();
            return name;
        }
        public static string GetEmail()
        {
            string email;
            Console.WriteLine("What is your email?");
            email = Console.ReadLine();
            return email;
        }
    }
}
