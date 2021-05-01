using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace John_Davis_Appointment_App
{
    public class DeleteAppointment
    {
        public DeleteAppointment(AppointmentModel model)
        {
            //For each interface IDataConnection in the "list" of connections 
            //(stored in the GlobalConfig class),
            //implement the contract's methods as alias db
            foreach (IDataConnection db in GlobalConfig.Connections)
            {
                db.QueryAppointmentInfo(model);
            }
            DeleteThisAppointment(model);
        }

        public int DeleteThisAppointment(AppointmentModel model)
        {
            //For each interface IDataConnection in the "list" of connections 
            //(stored in the GlobalConfig class),
            //implement the contract's methods as alias db
            foreach (IDataConnection db in GlobalConfig.Connections)
            {
                db.DeleteAppointment(model);
            }
            return 0;
        }
    }
}
