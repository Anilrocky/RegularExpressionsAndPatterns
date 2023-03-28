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
                Console.WriteLine("\nChoose option to perform \n1.Valid first name \n2.Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Enter first name");
                        string name = Console.ReadLine();
                        reg.ValidateFirstName(name);                       
                        break;
                    case 2:
                        flag = false;
                        break;
                }
            }            
        }
    }
}