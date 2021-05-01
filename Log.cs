using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace John_Davis_Appointment_App
{
    class Log
    {
        public static void LogUser()
        {
            using (StreamWriter w = File.AppendText("log.txt"))
            {
                LogEntry($"UserId:\t{DataBaseHandler.GetCurrentUserId()}\n  :Username:\t{DataBaseHandler.GetCurrentUserName()}", w);
                
            }
        }

        public static void LogEntry(string logMessage, TextWriter w)
        {
            w.Write("\r\nLog Entry : ");
            w.WriteLine($"{DateTime.Now.ToLongTimeString()} {DateTime.Now.ToLongDateString()}");
            w.WriteLine("  :");
            w.WriteLine($"  :{logMessage}");
            w.WriteLine("-------------------------------");
        }
    }
}
