using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration
{
    internal class User
    {
        public void NameChecker(string inputName)
        {
            const string NAME = "^[A-Z]{1}[a-z]{2,}$";
            if(Regex.IsMatch(inputName, NAME))
            {
                Console.WriteLine("Your Name is Valid");
                return;
            }
            Console.WriteLine("Your Name is Invalid...Name should start with Caps and have atleast 3 characters");
        }
        public void EmailChecker(string inputEmail)
        {
            const string EMAIL = "^[0-9a-z]{1,}([.+-_]*)[0-9a-z]{1,}(@)(gmail|bl)(.)(com|co)((.in)*)$";
            if (Regex.IsMatch(inputEmail, EMAIL))
            {
                Console.WriteLine("Your Email is Valid");
                return;
            }
            Console.WriteLine("Your Email is not Valid");
        }
        public void Phone(string inputPhone)
        {
            const string PHONE = "^([+]*)(91 )[6-9]{1}[0-9]{9}$";
            if( Regex.IsMatch(inputPhone, PHONE))
            {
                Console.WriteLine("Your Phone Number is Valid");
                return;
            }
            Console.WriteLine("Your Phone Number not is Valid");
        }
    }
}
