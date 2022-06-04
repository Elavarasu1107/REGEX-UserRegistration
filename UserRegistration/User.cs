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
    }
}
