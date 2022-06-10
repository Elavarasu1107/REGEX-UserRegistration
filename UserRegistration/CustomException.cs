using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistration
{
    public class CustomException : Exception
    {
        public enum ExceptionType
        {
            INVALID_NAME, INVALID_EMAIL, INVALID_NUMBER, INVALID_PASSWORD
        }
        ExceptionType type;
        public CustomException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}
