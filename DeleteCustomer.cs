using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace John_Davis_Appointment_App
{
    public class DeleteCustomer
    {
        public DeleteCustomer(CustomerModel model)
        {
            //For each interface IDataConnection in the "list" of connections 
            //(stored in the GlobalConfig class),
            //implement the contract's methods as alias db
            foreach (IDataConnection db in GlobalConfig.Connections)
            {
                db.QueryCustomerInfo(model);
            }
            DeleteThisCustomer(model);
        }

        public int DeleteThisCustomer(CustomerModel model)
        {
            //For each interface IDataConnection in the "list" of connections 
            //(stored in the GlobalConfig class),
            //implement the contract's methods as alias db
            foreach (IDataConnection db in GlobalConfig.Connections)
            {
                db.DeleteCustomer(model);
            }
            return 0;
        }
    }
}
