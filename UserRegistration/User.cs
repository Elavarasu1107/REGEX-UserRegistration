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
            Func<string, bool> result = (input) => (Regex.IsMatch(input, NAME));
            if (result(input))
            {
                Console.WriteLine("Your Name is Valid");
                return "Valid";
            }
            else
            {
                Console.WriteLine("Your Name is Invalid...Name should start with Caps and have atleast 3 characters");
                throw new CustomException(CustomException.ExceptionType.INVALID_NAME, "Invalid Name");
            }
        }
        public string EmailChecker()
        {
            //const string EMAIL = "^[0-9a-z]{1,}([.+-]?)[0-9a-z]{1,}(@)(gmail|bl|yahoo|abc|1)(.)(com|co|net)((.in|.com|.au)*)$";
            const string EMAIL = "^[0-9a-z]{1,}([.+-]?)[0-9a-z]{1,}(@)[a-z0-9]{1,}(.)(com|co|net)((.in|.com|.au)*)$";
            Func<string, bool> result = input => (Regex.IsMatch(input, EMAIL));
            if (result(input))
            {
                Console.WriteLine(input + " - is Valid");
                return "Valid";
            }
            else
            {
                Console.WriteLine(input + " - is Invalid");
                throw new CustomException(CustomException.ExceptionType.INVALID_EMAIL, "Invalid Email");
            }
        }
        public string Phone()
        {
            const string PHONE = "^([+]{0,1})(91 )[6-9]{1}[0-9]{9}$";
            Func<string, bool> result = input => (Regex.IsMatch(input, PHONE));
            if (result(input))
            {
                Console.WriteLine("Your Phone Number is Valid");
                return "Valid";
            }
            else
            {
                Console.WriteLine("Your Phone Number not is Valid");
                throw new CustomException(CustomException.ExceptionType.INVALID_NUMBER, "Invalid PhoneNumber");
            }
        }
        public string Password()
        {
            const string PASSWORD = "^(?=[a-zA-Z0-9]*[!#@$%^&][a-zA-Z0-9]*$)[a-zA-Z0-9!#@$%^&]+.{8,}$";
            Func<string, bool> result = input => (Regex.IsMatch(input, PASSWORD));
            if (result(input))
            {
                Console.WriteLine("Your Password is Valid");
                return "Valid";
            }
            else
            {
                Console.WriteLine("Your Password is not Valid");
                throw new CustomException(CustomException.ExceptionType.INVALID_PASSWORD, "Invalid Password");
            }
        }
    }
}