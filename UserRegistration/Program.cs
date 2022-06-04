using System;

namespace UserRegistration
{
    public class Program
    {
        public static void Main(string[] args)
        {
            User getMethod = new User();
            Console.WriteLine("Enter 1 to check First name\n 2 to check Last Name\n 3 to check Email\n 4 to check Phone Number\n 5 to check Password");
            Console.WriteLine("Enter a Number");
            int userInput = Convert.ToInt32(Console.ReadLine());

            switch(userInput)
            {
                case 1:
                    {
                        Console.Write("Enter Your First Name: ");
                        string firstName = Console.ReadLine();
                        getMethod.NameChecker(firstName);
                        break;
                    }
                case 2:
                    {
                        Console.Write("Enter Your Last Name: ");
                        string lastName = Console.ReadLine();
                        getMethod.NameChecker(lastName);
                        break;
                    }
                case 3:
                    {
                        Console.Write("Enter Your Email: ");
                        string email = Console.ReadLine();
                        getMethod.EmailChecker(email);
                        break;
                    }
                case 4:
                    {
                        Console.Write("Enter Your Phone Number: ");
                        string phone = Console.ReadLine();
                        getMethod.Phone(phone);
                        break;
                    }
                case 5:
                    {
                        Console.Write("Enter Your Password: ");
                        string password = Console.ReadLine();
                        getMethod.Password(password);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Enter a Valid Number");
                        break;
                    }
            }   
        }
    }
}