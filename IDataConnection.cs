using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace John_Davis_Appointment_App
{
    public interface IDataConnection
    {
        //CustomerModel Interfaces
        CustomerModel CreateCustomer(CustomerModel model);
        CustomerModel QueryCustomerInfo(CustomerModel model);
        CustomerModel UpdateCustomer(CustomerModel model);
        CustomerModel DeleteCustomer(CustomerModel model);

        //AppointmentModel Interfaces
        AppointmentModel CreateAppointment(AppointmentModel model);
        AppointmentModel QueryAppointmentInfo(AppointmentModel model);
        AppointmentModel UpdateAppointment(AppointmentModel model);
        AppointmentModel DeleteAppointment(AppointmentModel model);
    }
}
