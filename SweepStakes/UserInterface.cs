using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    public static class UserInterface
    {
        public static string FirstName;
        public static string LastName;
        public static string Email;
        public static int Registration;
        public static string userinput;
        public static void GetFirstName()
        {
            
            Console.WriteLine("what is your first name?");
            userinput = Console.ReadLine();
            FirstName = userinput;
            
            
        }
        public static void GetLastName()
        {
            Console.WriteLine("what is your last name?");
            userinput = Console.ReadLine();
            LastName = userinput;
            
        }
        public static void GetEmailAddress()
        {
            Console.WriteLine("what is your email address?");
            userinput = Console.ReadLine();
            Email = userinput;
            
        }
        public static void SetRegistrationNumber()
        {
            int count;
            count = 0;
            count++;
            Registration = count;
            Console.WriteLine("your registration number is" + count);
        }
    }
}
