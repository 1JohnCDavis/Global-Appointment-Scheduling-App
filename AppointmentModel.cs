using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace John_Davis_Appointment_App
{
    public class AppointmentModel
    {
        public string CustomerName { get; set; }
        public int CustomerId { get; set; }
        public int AppointmentId { get; set; }
        public string AppointmentType { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public AppointmentModel()
        {
        }

        //Add appointment constructor
        public AppointmentModel(string customerId, string appointmentType, DateTime startTime, DateTime endTime)
        {
            int customerIdValue = 0;
            int.TryParse(customerId, out customerIdValue);
            CustomerId = customerIdValue;

            //CustomerId = customerId;
            AppointmentType = appointmentType;
            StartTime = startTime;
            EndTime = endTime;
        }

        public AppointmentModel(string customerName, int customerId, int appointmentId, string appointmentType, DateTime startTime, DateTime endTime)
        {
            CustomerName = customerName;
            CustomerId = customerId;
            AppointmentId = appointmentId;
            AppointmentType = appointmentType;
            StartTime = startTime;
            EndTime = endTime;
        }
    }
}
