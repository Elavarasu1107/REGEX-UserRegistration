using System;

namespace UserRegistration
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter Your First Name: ");
            string firstName = Console.ReadLine();
            User getMethod = new User();
            getMethod.NameChecker(firstName);
        }
    }
}