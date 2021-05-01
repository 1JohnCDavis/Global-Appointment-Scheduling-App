using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace John_Davis_Appointment_App
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Initialize the database connection
            //(true for "MySqlConnector" and false for "TextFileConnector").
            GlobalConfig.InitializeConnections(true, false);

            Application.Run(new SignInForm());
        }
    }
}
