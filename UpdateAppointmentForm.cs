using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace John_Davis_Appointment_App
{
    public partial class UpdateAppointmentForm : Form
    {
        //Lambda used as an efficient way to combine the two separate date and time dateTimePickers
        public DateTime StartDateTime => updateAppointmentStartDateDateTimePicker.Value.Date +
                   updateAppointmentStartTimeDateTimePicker.Value.TimeOfDay;
        //Lambda used as an efficient way to combine the two separate date and time dateTimePickers
        public DateTime EndDateTime => updateAppointmentEndDateDateTimePicker.Value.Date +
                   updateAppointmentEndTimeDateTimePicker.Value.TimeOfDay;

        public static string CS = ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString;

        private bool AllowSave()
        {
            return (!string.IsNullOrWhiteSpace(updateAppointmentTypeTextBox.Text) &&
                updateAppointmentCustomerNameComboBox.SelectedIndex > -1 &&
                (updateAppointmentStartDateDateTimePicker.Value < updateAppointmentEndDateDateTimePicker.Value));
        }

        public UpdateAppointmentForm(AppointmentModel model)
        {
            InitializeComponent();
            
            RefreshUpdateAppointmentCustomerNameComboBox();

            //For each interface IDataConnection in the "list" of connections 
            //(stored in the GlobalConfig class),
            //implement the contract's methods as alias db
            foreach (IDataConnection db in GlobalConfig.Connections)
            {
                db.QueryAppointmentInfo(model);
            }

            updateAppointmentIdTextBox.Text = Convert.ToString(model.AppointmentId);
            AddCustomerIdToCustomerIdTextBox();
            model.CustomerId = Convert.ToInt32(updateAppointmentCustomerIdTextBox.Text);
            updateAppointmentCustomerNameComboBox.Text = model.CustomerName;
            updateAppointmentTypeTextBox.Text = model.AppointmentType;
            updateAppointmentStartDateDateTimePicker.Value = model.StartTime.ToLocalTime();
            updateAppointmentStartTimeDateTimePicker.Value = model.StartTime.ToLocalTime();
            updateAppointmentEndDateDateTimePicker.Value = model.EndTime.ToLocalTime();
            updateAppointmentEndTimeDateTimePicker.Value = model.EndTime.ToLocalTime();

            updateAppointmentSaveBtn.Enabled = AllowSave();
        }

        private void updateAppointmentTypeTextBox_TextChanged(object sender, EventArgs e)
        {
            if (Int32.TryParse(updateAppointmentTypeTextBox.Text, out _) || string.IsNullOrWhiteSpace(updateAppointmentTypeTextBox.Text))
            {
                updateAppointmentTypeTextBox.BackColor = System.Drawing.Color.Salmon;
            }
            else
            {
                updateAppointmentTypeTextBox.BackColor = System.Drawing.Color.White;
            }
            updateAppointmentSaveBtn.Enabled = AllowSave();
        }

        private void updateAppointmentCancelBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

        private void updateAppointmentSaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                ValidateAppointment(StartDateTime, EndDateTime);

                //Constructor for updating an appointment
                AppointmentModel model = new AppointmentModel(

                    updateAppointmentCustomerNameComboBox.Text,
                    int.Parse(updateAppointmentCustomerIdTextBox.Text),
                    int.Parse(updateAppointmentIdTextBox.Text),
                    updateAppointmentTypeTextBox.Text,
                    StartDateTime.ToUniversalTime(),
                    EndDateTime.ToUniversalTime());


                //For each interface IDataConnection in the "list" of connections 
                //(stored in the GlobalConfig class),
                //implement the contract's methods as alias db
                foreach (IDataConnection db in GlobalConfig.Connections)
                {
                    db.UpdateAppointment(model);
                }
                //Clears the text boxes once the appointment was added to the database
                updateAppointmentTypeTextBox.Text = "";


                MessageBox.Show("The appointment was successfully updated.");
            }
            catch (AppointmentOutsideBusinessHrsException aobhe)
            {
                MessageBox.Show(aobhe.Message);
            }
            catch (ConflictingAppointmentException cae)
            {
                MessageBox.Show(cae.Message);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                this.Hide();
                MainForm mainForm = new MainForm();
                mainForm.Show();
            }
        }

        private void RefreshUpdateAppointmentCustomerNameComboBox()
        {
            using (MySqlConnection con = new MySqlConnection(CS))
            {
                string command = "SELECT customerName FROM customer";
                MySqlDataAdapter da = new MySqlDataAdapter(command, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow row in dt.Rows)
                {
                    string customerName = string.Format("{0}", row.ItemArray[0]);
                    updateAppointmentCustomerNameComboBox.Items.Add(customerName);
                }

                //TODO - Get this working properly
                if (updateAppointmentCustomerNameComboBox.Text == "Select customer")
                {
                    //addAppointmentCustomerNameComboBox.BackColor = System.Drawing.Color.Salmon;
                    updateAppointmentCustomerNameComboBox.BackColor = System.Drawing.Color.White;
                }
                else
                {
                    updateAppointmentCustomerNameComboBox.BackColor = System.Drawing.Color.White;
                }
                updateAppointmentSaveBtn.Enabled = AllowSave();
            }
        }

        private void AddCustomerIdToCustomerIdTextBox()
        {
            using (MySqlConnection con = new MySqlConnection(CS))
            {
                string command = $"SELECT customerId FROM appointment WHERE appointmentId = '{updateAppointmentIdTextBox.Text}'";
                MySqlDataAdapter da = new MySqlDataAdapter(command, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow row in dt.Rows)
                {
                    string customerId = string.Format("{0}", row.ItemArray[0]);
                    updateAppointmentCustomerIdTextBox.Text = customerId;
                }
            }
        }

        private void AddUpdatedCustomerIdToCustomerIdTextBox()
        {
            using (MySqlConnection con = new MySqlConnection(CS))
            {
                string command = $"SELECT customerId FROM customer WHERE customerName = '{updateAppointmentCustomerNameComboBox.Text}'";
                MySqlDataAdapter da = new MySqlDataAdapter(command, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow row in dt.Rows)
                {
                    string customerId = string.Format("{0}", row.ItemArray[0]);
                    updateAppointmentCustomerIdTextBox.Text = customerId;
                }
            }
        }

        private void updateAppointmentCustomerNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddUpdatedCustomerIdToCustomerIdTextBox();
        }

        private void ValidateAppointment(DateTime startDT, DateTime endDT)
        {
            //Checks for appointments made outside of business hours.  Mon-Fri, 8am to 5pm

            int validStartTime = 480; //8am
            int validEndTime = 1020; //5pm
            DayOfWeek validStartDay = DayOfWeek.Monday;
            DayOfWeek validEndDay = DayOfWeek.Friday;
            int selectedStartTime = startDT.Hour * 60 + startDT.Minute;
            int selectedEndTime = endDT.Hour * 60 + endDT.Minute;
            DayOfWeek selectedStartDay = startDT.DayOfWeek;
            DayOfWeek selectedEndDay = endDT.DayOfWeek;

            if (selectedStartDay >= DayOfWeek.Monday && selectedStartDay <= DayOfWeek.Friday &&
                selectedEndDay >= DayOfWeek.Monday && selectedEndDay <= DayOfWeek.Friday)
            {
                if (selectedStartTime >= validStartTime && selectedStartTime < validEndTime &&
                selectedEndTime > validStartTime && selectedEndTime <= validEndTime)
                {
                    //Appointment is valid, do nothing
                }
                else
                {
                    throw new AppointmentOutsideBusinessHrsException();
                }
            }
            else
            {
                throw new AppointmentOutsideBusinessHrsException();
            }



            //Checks for overlapping appointments.  

            using (MySqlConnection con = new MySqlConnection(CS))
            {
                int userId = DataBaseHandler.GetCurrentUserId();
                DateTime dt1Start = startDT;
                DateTime dt1End = endDT;
                DateTime dt2Start;
                DateTime dt2End;

                MySqlCommand cmd = new MySqlCommand($"SELECT appointment.start, appointment.end FROM appointment WHERE appointment.userId = {userId}", con);
                MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adp.Fill(dt);

                //Converts from UTC (DateTimes stored in database) to user's local time using TimeZoneInfo
                for (int idx = 0; idx < dt.Rows.Count; idx++)
                {
                    dt.Rows[idx]["start"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)dt.Rows[idx]["start"], TimeZoneInfo.Local).ToString();
                }

                for (int idx = 0; idx < dt.Rows.Count; idx++)
                {
                    dt.Rows[idx]["end"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)dt.Rows[idx]["end"], TimeZoneInfo.Local).ToString();
                }

                foreach (DataRow row in dt.Rows)
                {
                    dt2Start = (DateTime)row[0];
                    dt2End = (DateTime)row[1];

                    if ((dt1Start <= dt2Start && dt2Start < dt1End) || (dt2Start <= dt1Start && dt1Start < dt2End))
                    {
                        throw new ConflictingAppointmentException();
                    }
                    else
                    {
                        //Appointment is valid, do nothing
                    }
                }
            }
        }
    }
}
