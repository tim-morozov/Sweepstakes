using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
   static class UserInterface
    {
        static int registration = 0;
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
        public static int AssignNumber()
        {
            registration++;
            Console.WriteLine("Your registration number is " + registration);
            return registration;
        }

        public static string NameSweepstakes()
        {
            Console.WriteLine("What would you like to name your sweepstakes?");
            string name = Console.ReadLine();
            return name;
        }
    }
}
