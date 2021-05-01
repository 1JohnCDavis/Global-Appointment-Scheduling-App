using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace John_Davis_Appointment_App
{
    public class TextFileConnector : IDataConnection
    {
        //This does not currently do anything.  It was
        //created for possible future scaling purposes.
        //Do not delete this class unless IDataConnection
        //interface is updated as well.

        /// <summary>
        /// Saves a new customer to the textFile
        /// </summary>
        /// <param name="model"> The customer information </param>
        /// <returns> The customer information and initializes the unique customer identifier </returns>
        public CustomerModel CreateCustomer(CustomerModel model)
        {
            //This doesn't actually do anything right now
            model.Id = 1;
            return model;
        }

        //Included to satisfy contract terms
        public CustomerModel QueryCustomerInfo(CustomerModel model)
        {
            throw new NotImplementedException();
        }

        //Included to satisfy contract terms
        public CustomerModel UpdateCustomer(CustomerModel model)
        {
            throw new NotImplementedException();
        }

        //Included to satisfy contract terms
        public CustomerModel DeleteCustomer(CustomerModel model)
        {
            throw new NotImplementedException();
        }

        //Included to satisfy contract terms
        public AppointmentModel CreateAppointment(AppointmentModel model)
        {
            throw new NotImplementedException();
        }

        //Included to satisfy contract terms
        public AppointmentModel QueryAppointmentInfo(AppointmentModel model)
        {
            throw new NotImplementedException();
        }

        //Included to satisfy contract terms
        public AppointmentModel UpdateAppointment(AppointmentModel model)
        {
            throw new NotImplementedException();
        }

        //Included to satisfy contract terms
        public AppointmentModel DeleteAppointment(AppointmentModel model)
        {
            throw new NotImplementedException();
        }
    }
}
