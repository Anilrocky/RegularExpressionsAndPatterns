using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegularExpressionsAndPatterns
{
    public class UserRegistration
    {
        public const string NAME = "^[A-Z]{1}[a-z]{2,}$";
        public const string MAIL_ID = "^[0-9a-zA-Z]+[.+-_]{0,1}[0-9a-zA-Z]+[.][a-zA-Z]{2,3}([.][a-zA-Z]{2,3}){0,1}$";
        public const string MOBILE_NUMBER = "^[6-9]{1}[0-9]{9}$";
        public const string PASSWORD = "^[A-Z]{1,}[0-9a-zA-Z]{7,}";
        public void ValidateFirstName(string name)
        {
            if (Regex.IsMatch(name, NAME))
            {
                Console.WriteLine("Valid first name");
            }
            else
            {
                Console.WriteLine("Invalid first name");
            }
        }
        public void ValidateLastName(string name)
        {
            if (Regex.IsMatch(name, NAME))
            {
                Console.WriteLine("Valid last name");
            }
            else
            {
                Console.WriteLine("Invalid last name");
            }
        }
        public void ValidateEmail(string mail)
        {
            if (Regex.IsMatch(mail, MAIL_ID))
            {
                Console.WriteLine("Valid mail id");
            }
            else
            {
                Console.WriteLine("Invalid mail id");
            }
        }
        public void ValidateMobileNumber(string number)
        {
            if (Regex.IsMatch(number, MOBILE_NUMBER))
            {
                Console.WriteLine("Valid mobile number");
            }
            else
            {
                Console.WriteLine("Invalid mobile number");
            }
        }
        public void ValidatePassword(string passwd)
        {
            if (Regex.IsMatch(passwd, PASSWORD))
            {
                Console.WriteLine("Valid password");
            }
            else
            {
                Console.WriteLine("Invalid password");
            }
        }
    }
}
