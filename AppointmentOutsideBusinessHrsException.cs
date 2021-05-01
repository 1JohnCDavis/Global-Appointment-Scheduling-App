using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace John_Davis_Appointment_App
{
    public class AppointmentOutsideBusinessHrsException : Exception
    {
        public AppointmentOutsideBusinessHrsException()
            : this("Selected appointment is outside business hours")
        {
        }
        public AppointmentOutsideBusinessHrsException(string message)
            : base(message)
        {
        }
        public AppointmentOutsideBusinessHrsException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}

