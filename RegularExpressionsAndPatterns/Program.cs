using System;
namespace RegularExpressionsAndPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            UserRegistration reg = new UserRegistration();
            while (flag)
            {
                Console.WriteLine("\nChoose option to perform \n1.Validate first name \n2.Validate last name \n3.Validtae Mail Id \n4.Validate mobile number \n5.Validate password \n6.Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Enter first name");
                        string firstName = Console.ReadLine();
                        reg.ValidateFirstName(firstName);                       
                        break;
                    case 2:
                        Console.WriteLine("Enter last name");
                        string lastName = Console.ReadLine();
                        reg.ValidateLastName(lastName);
                        break;
                    case 3:                        
                        reg.ValidateEmail();
                        break;
                    case 4:
                        Console.WriteLine("Enter mobile number");
                        string number = Console.ReadLine();
                        reg.ValidateMobileNumber(number);
                        break;
                    case 5:
                        Console.WriteLine("Enter password");
                        string passwd = Console.ReadLine();
                        reg.ValidatePassword(passwd);
                        break;
                    case 6:
                        flag = false;
                        break;
                }
            }            
        }
    }
}