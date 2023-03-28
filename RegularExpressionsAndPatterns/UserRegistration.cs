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
    }
}
