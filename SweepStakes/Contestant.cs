using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    
    public class Contestant
    {
        //variables
        public string FirstName;
        public string LastName;
        public string EmailAddress;
        public int RegistrationNumber;

        //constructor
        public Contestant()
        {
            FirstName = UserInterface.FirstName;
            LastName = UserInterface.LastName;
            EmailAddress = UserInterface.Email;
            RegistrationNumber = UserInterface.Registration;
        }

        //method
    }
}
