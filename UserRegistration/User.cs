using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration
{
    public class User
    {
        public string input;
        public User(string input)
        {
            this.input = input;
        }
        public string NameChecker()
        {
            const string NAME = "^[A-Z]{1}[a-z]{2,}$";
            if (Regex.IsMatch(input, NAME))
            {
                Console.WriteLine("Your Name is Valid");
                return "Valid";
            }
            Console.WriteLine("Your Name is Invalid...Name should start with Caps and have atleast 3 characters");
            return "Invalid";
        }
        public string EmailChecker()
        {
            const string EMAIL = "^[0-9a-z]{1,}([.+-]?)[0-9a-z]{1,}(@)(gmail|bl|yahoo|abc|1)(.)(com|co|net)((.in|.com|.au)*)$";
            if (Regex.IsMatch(input, EMAIL))
            {
                Console.WriteLine(input + " - is Valid");
                return "Valid";
            }
            Console.WriteLine(input + " - is Invalid");
            return "Invalid";
        }
        public string Phone()
        {
            const string PHONE = "^([+]{0,1})(91 )[6-9]{1}[0-9]{9}$";
            if (Regex.IsMatch(input, PHONE))
            {
                Console.WriteLine("Your Phone Number is Valid");
                return "Valid";
            }
            Console.WriteLine("Your Phone Number not is Valid");
            return "Invalid";
        }
        public string Password()
        {
            const string PASSWORD = "^(?=[a-zA-Z0-9]*[!#@$%^&][a-zA-Z0-9]*$)[a-zA-Z0-9!#@$%^&]+.{8,}$";
            if (Regex.IsMatch(input, PASSWORD))
            {
                Console.WriteLine("Your Password is Valid");
                return "Valid";
            }
            Console.WriteLine("Your Password is not Valid");
            return "Invalid";
        }
    }
}