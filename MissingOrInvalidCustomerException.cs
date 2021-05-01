using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace John_Davis_Appointment_App
{
    public class MissingOrInvalidCustomerException : Exception
    {
        public MissingOrInvalidCustomerException()
            : this("Invalid customer information")
        {
        }
        public MissingOrInvalidCustomerException(string message)
            : base(message)
        {
        }
        public MissingOrInvalidCustomerException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
