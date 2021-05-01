using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace John_Davis_Appointment_App
{
    public class InvalidCredentialsException : Exception
    {
        public InvalidCredentialsException()
            : this("Invalid credentials")
        {
        }
        public InvalidCredentialsException(string message)
            : base(message)
        {
        }
        public InvalidCredentialsException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
