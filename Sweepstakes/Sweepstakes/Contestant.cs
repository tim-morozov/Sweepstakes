using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Contestant
    {
        string firstName;
        public string FirstName
        {
            get
            {
                return firstName;
            }
        }   
        string lastName;
        public string LastName
        {
            get
            {
                return lastName;
            }
        }
        string email;
        public string Email
        {
            get
            {
                return email;
            }
        }
        int registrationNum;
        public int RegistrationNum
        {
            get
            {
                return registrationNum;
            }
        }

        public Contestant()
        {
            firstName = UserInterface.GetFirstName();
            lastName = UserInterface.GetLastName();
            email = UserInterface.GetEmail();
            registrationNum = UserInterface.AssignNumber();
        }
    }
}
