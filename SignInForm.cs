using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace John_Davis_Appointment_App
{
    public partial class SignInForm : Form
    {
        //LCID for Mexico is 2058

        DataTable dt = new DataTable();
        DateTime currentDate;
        private string invalidCredentials = "Invalid username and/or password";

        public SignInForm()
        {
            InitializeComponent();
            currentDate = DateTime.Now;
            DetermineUsersLocation(CultureInfo.CurrentUICulture.LCID);
            DataBaseHandler.PopulateUserTable();
            DataBaseHandler.PopulateCountryTable();
            DataBaseHandler.PopulateCityTable();
            DataBaseHandler.PopulateAddressTable();
            DataBaseHandler.PopulateCustomerTable();
            DataBaseHandler.PopulateAppointmentTable();
        }

        public static string CS = ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString;

        private void DetermineUsersLocation(int LCID)
        {
            if (CultureInfo.CurrentUICulture.LCID == 2058)
            {
                this.Text = "Registrarse";
                usernameLabel.Text = "Nombre de usuario:";
                passwordLabel.Text = "Contraseña:";
                signInBtn.Text = "Registrarse";
                exitBtn.Text = "Salid";
                invalidCredentials = "Nombre de usuario y/o contraseña son inválidos";
            }
        }

        private void signInBtn_Click(object sender, EventArgs e)
        {
            if (DataBaseHandler.UserExists(usernameTextBox.Text, passwordTextBox.Text) == 1)
            {
                //log user to file
                Log.LogUser();
                this.Hide();
                Reminder();
                //open main form
                MainForm Main = new MainForm();
                Main.Show();
            }
            else
            {
                MessageBox.Show(invalidCredentials);
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        /// <summary>
        /// Querys appointment table to check if there are any upcoming appointments 15 minutes
        /// or sooner in advance upon sign-in.
        /// </summary>
        private void Reminder()
        {
            //DataBaseHandler.GetCurrentUserName();
            DateTime logInTime = DateTime.Now;
            TimeSpan time;

            using (MySqlConnection con = new MySqlConnection(CS))
            {
                MySqlCommand cmd = new MySqlCommand($"SELECT appointment.appointmentId, customer.customerName, appointment.type, appointment.start, appointment.end " +
                                                    "FROM appointment INNER JOIN " +
                                                    $"customer ON appointment.customerId = customer.customerId WHERE DATE(start) = STR_TO_DATE('{currentDate}', '%m/%d/%Y')", con);
                con.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);

                //Converts from UTC (DateTimes stored in database) to user's local time using TimeZoneInfo
                for (int idx = 0; idx < dt.Rows.Count; idx++)
                {
                    dt.Rows[idx]["start"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)dt.Rows[idx]["start"], TimeZoneInfo.Local).ToString();
                }

                for (int idx = 0; idx < dt.Rows.Count; idx++)
                {
                    dt.Rows[idx]["end"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)dt.Rows[idx]["end"], TimeZoneInfo.Local).ToString();
                }
                                
                for (int idx = 0; idx < dt.Rows.Count; idx++)
                {
                    DateTime nextAppointment = (DateTime)dt.Rows[idx]["start"];

                    time = nextAppointment - logInTime;

                        if ((time <= TimeSpan.FromMinutes(15)) && (time > TimeSpan.FromMinutes(0)))
                    {
                        MessageBox.Show($"You have an upcoming appointment in 15 minutes or less.\n\nPlease review your schedule for details.", "Reminder");
                    }
                }
            }
        }
    }
}
