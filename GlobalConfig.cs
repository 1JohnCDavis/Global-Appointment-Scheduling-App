using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace John_Davis_Appointment_App
{
    public static class GlobalConfig
    {
        //DB connection string is stored in app.config file 

        public static string CS = ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString;
        public static List<IDataConnection> Connections { get; private set; } = new List<IDataConnection>();
        public static void InitializeConnections(bool database, bool textFiles) //Can change name to mySqlDatabase
        {
            if (database) //Or if(database == true)
            {
                MySqlConnector mySql = new MySqlConnector();
                Connections.Add(mySql);
            }
            if (textFiles)
            {
                TextFileConnector text = new TextFileConnector();
                Connections.Add(text);
            }
        }
    }
}
