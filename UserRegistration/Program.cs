using System;

namespace UserRegistration
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter 1 to check First name\n 2 to check Last Name\n 3 to check Email\n 4 to check Phone Number\n 5 to check Password\n 6 for Check Multiple Email's");
            Console.WriteLine("Enter a Number");
            int userInput = Convert.ToInt32(Console.ReadLine());

            switch (userInput)
            {
                case 1:
                    {
                        Console.Write("Enter Your First Name: ");
                        string firstName = Console.ReadLine();
                        User getMethod = new User(firstName);
                        getMethod.NameChecker();
                        break;
                    }
                case 2:
                    {
                        Console.Write("Enter Your Last Name: ");
                        string lastName = Console.ReadLine();
                        User getMethod = new User(lastName);
                        getMethod.NameChecker();
                        break;
                    }
                case 3:
                    {
                        Console.Write("Enter Your Email: ");
                        string email = Console.ReadLine();
                        User getMethod = new User(email);
                        getMethod.EmailChecker();
                        break;
                    }
                case 4:
                    {
                        Console.Write("Enter Your Phone Number: ");
                        string phone = Console.ReadLine();
                        User getMethod = new User(phone);
                        getMethod.Phone();
                        break;
                    }
                case 5:
                    {
                        Console.Write("Enter Your Password: ");
                        string password = Console.ReadLine();
                        User getMethod = new User(password);
                        getMethod.Password();
                        break;
                    }
                case 6:
                    {
                        string[] validEmail = System.IO.File.ReadAllLines(@"D:\BridgeLabz\REGEX-UserRegistration\UserRegistration\ValidEmail.txt");
                        string[] inValidEmail = System.IO.File.ReadAllLines(@"D:\BridgeLabz\REGEX-UserRegistration\UserRegistration\InvalidEmail.txt");

                        for (int i = 0; i < validEmail.Length; i++)
                        {
                            User getMethod = new User(validEmail[i]);
                            getMethod.EmailChecker();
                        }
                        Console.WriteLine();
                        for (int i = 0; i < inValidEmail.Length; i++)
                        {
                            User getMethod = new User(inValidEmail[i]);
                            getMethod.EmailChecker();
                        }
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