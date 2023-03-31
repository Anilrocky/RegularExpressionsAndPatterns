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
        public const string MAIL_ID = "^[a-zA-Z]{3,}[.]{0,1}[a-zA-Z]{0,}[@]{1}[a-zA-Z]{2,}[.]{1}[a-zA-Z]{2,3}[.]{0,1}[a-zA-Z]{0,2}$";
        public const string MOBILE_NUMBER = "^[6-9]{1}[0-9]{9}$";
        public const string PASSWORD = "^[A-Z]{1,}[a-z]{5,}[!@#$%~]{1}[0-9]{0,}$";
        public static string[] mails = { "abc@yahoo.com", "abc-100@yahoo.com", "abc111@abc.com", "abc-100@abc.net", "abc.100@abc.com.au", "abc@1.com", "abc@gmail.com.com", "abc +100@gmail.com" };
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
        public void ValidateEmail()
        {
            for (int i = 0; i < mails.Length; i++)
            {
                string data = mails[i];
                if (Regex.IsMatch(data, MAIL_ID))
                {
                    Console.WriteLine(data+" --> Valid mail id");
                }
                else
                {
                    Console.WriteLine(data+" --> Invalid mail id");
                }
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
