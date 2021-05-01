using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace John_Davis_Appointment_App
{
    public class ConflictingAppointmentException : Exception
    {
        public ConflictingAppointmentException()
            : this("You already have another appointment set somewhere within this time.\n\nPlease review your schedule for details.")
        {
        }
        public ConflictingAppointmentException(string message)
            : base(message)
        {
        }
        public ConflictingAppointmentException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
