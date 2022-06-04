using System;

namespace UserRegistration
{
    public class Program
    {
        public static void Main(string[] args)
        {
            User getMethod = new User();
            Console.WriteLine("Enter 1 to check First name\n 2 to check Last Name");
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
                default:
                    {
                        Console.WriteLine("Enter a Valid Number");
                        break;
                    }
            }   
        }
    }
}