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
    public partial class MainForm : Form
    {
        DateTime currentDate;
        DataTable dt = new DataTable();

        public MainForm()
        {
            InitializeComponent();
            currentDate = DateTime.Now;
            RefreshCustomerDgv();
            RefreshFilterAppointmentsByCustomerComboBox();
            handleDay();
        }

        public static string CS = ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString;

        //Refreshes customerDgv
        private void RefreshCustomerDgv()
        {
            using (MySqlConnection con = new MySqlConnection(CS))
            {
                MySqlCommand cmd = new MySqlCommand("SELECT customer.customerId, customer.customerName, address.phone, address.address, address.postalCode, city.city, country.country " +
                                                    "FROM  address INNER JOIN " +
                                                    "city ON address.cityId = city.cityId INNER JOIN " +
                                                    "country ON city.countryId = country.countryId INNER JOIN " +
                                                    "customer ON address.addressId = customer.addressId", con);
                con.Open();
                BindingSource binding = new BindingSource();
                binding.DataSource = cmd.ExecuteReader();
                customerDgv.DataSource = binding;
            }
        }

        //Refreshes appointmentDgv
        //private void RefreshAppointmentDgv()
        //{
        //    using (MySqlConnection con = new MySqlConnection(CS))
        //    {
        //        MySqlCommand cmd = new MySqlCommand("SELECT appointment.appointmentId, customer.customerName, appointment.type, appointment.start, appointment.end " +
        //                                            "FROM  appointment INNER JOIN " +
        //                                            "customer ON appointment.customerId = customer.customerId", con);
        //        con.Open();
        //        BindingSource binding = new BindingSource();
        //        binding.DataSource = cmd.ExecuteReader();
        //        appointmentDgv.DataSource = binding;
        //    }
        //}

        private void mainFormExitBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void customerAddBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AddCustomerForm().ShowDialog();
        }

        private void customerUpdateBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerModel model = new CustomerModel();
            model.Id = Convert.ToInt32(this.customerDgv.CurrentRow.Cells[0].Value.ToString());
            new UpdateCustomerForm(model).ShowDialog();
        }

        private void customerDeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {                
                CustomerModel model = new CustomerModel();
                model.Id = Convert.ToInt32(this.customerDgv.CurrentRow.Cells[0].Value.ToString());

                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this customer?", "Delete customer", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    this.Hide();
                    new DeleteCustomer(model);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("This customer has one or more appointments on record and cannot be deleted yet.", "Error");
            }
        }

        private void appointmentAddBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AddAppointmentForm().ShowDialog();
        }

        private void appointmentUpdateBtn_Click(object sender, EventArgs e)
        {
            if(this.appointmentDgv.CurrentRow != null)
            {
                this.Hide();
                AppointmentModel model = new AppointmentModel();
                model.AppointmentId = Convert.ToInt32(this.appointmentDgv.CurrentRow.Cells[0].Value.ToString());
                new UpdateAppointmentForm(model).ShowDialog();
            }
        }

        private void appointmentDeleteBtn_Click(object sender, EventArgs e)
        {
            if(this.appointmentDgv.CurrentRow != null)
            {
                AppointmentModel model = new AppointmentModel();
                model.AppointmentId = Convert.ToInt32(this.appointmentDgv.CurrentRow.Cells[0].Value.ToString());
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this appointment?", "Delete appointment", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    this.Hide();
                    new DeleteAppointment(model);
                }
            }
        }

        //Populates customer combobox with current customers in database
        private void RefreshFilterAppointmentsByCustomerComboBox()
        {
            using (MySqlConnection con = new MySqlConnection(CS))
            {
                string command = "SELECT DISTINCT customer.customerName " +
                                 "FROM  appointment INNER JOIN " +
                                 $"customer ON appointment.customerId = customer.customerId";
                MySqlDataAdapter da = new MySqlDataAdapter(command, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow row in dt.Rows)
                {
                    string customerName = string.Format("{0}", row.ItemArray[0]);
                    filterAppointmentsByCustomerComboBox.Items.Add(customerName);
                }
            }
        }

        //Populates appointmentDgv based on selected customer
        private void AppointmentsByCustomerDgv(string customerName)
        {
            using (MySqlConnection con = new MySqlConnection(CS))
            {
                MySqlCommand cmd = new MySqlCommand("SELECT appointment.appointmentId, customer.customerName, appointment.type, appointment.start, appointment.end " +
                                                    "FROM  appointment INNER JOIN " +
                                                    $"customer ON appointment.customerId = customer.customerId WHERE customer.customerName = '{customerName}'", con);
                con.Open();
                //BindingSource binding = new BindingSource();
                //binding.DataSource = cmd.ExecuteReader();
                //appointmentDgv.DataSource = binding;
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                dt.Clear();
                adapter.Fill(dt);
                appointmentDgv.DataSource = dt;

                //Converts from UTC (DateTimes stored in database) to user's local time using TimeZoneInfo
                for (int idx = 0; idx < dt.Rows.Count; idx++)
                {
                    dt.Rows[idx]["start"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)dt.Rows[idx]["start"], TimeZoneInfo.Local).ToString();
                }

                for (int idx = 0; idx < dt.Rows.Count; idx++)
                {
                    dt.Rows[idx]["end"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)dt.Rows[idx]["end"], TimeZoneInfo.Local).ToString();
                }
            }
        }

        private void filterAppointmentsByCustomerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            AppointmentsByCustomerDgv(filterAppointmentsByCustomerComboBox.Text);
        }

        //private void RefreshAppointmentsByCurrentDayDgv(DateTime currentDate)
        //{
        //    using (MySqlConnection con = new MySqlConnection(CS))
        //    {
        //        MySqlCommand cmd = new MySqlCommand("SELECT appointment.appointmentId, customer.customerName, appointment.type, appointment.start, appointment.end " +
        //                                            "FROM  appointment INNER JOIN " +
        //                                            $"customer ON appointment.customerId = customer.customerId WHERE appointment.start = STR_TO_DATE('{currentDate}', '%m/%d/%Y')", con);
        //        con.Open();
        //        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
        //        adapter.Fill(dt);
        //        appointmentDgv.DataSource = dt;
        //    }
        //}

        private void mainFormCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            currentDate = e.Start;

            if (monthRadioBtn.Checked)
            {
                handleMonth();
            }
            else
            {
                if (weekRadioBtn.Checked)
                {
                    handleWeek();
                }
                else
                {
                    handleDay();
                }
            }
        }

        private void handleDay()
        {
            int userId = DataBaseHandler.GetCurrentUserId();
            mainFormCalendar.RemoveAllBoldedDates();
            mainFormCalendar.AddBoldedDate(currentDate);
            mainFormCalendar.UpdateBoldedDates();
            dt.Clear();

            using (MySqlConnection con = new MySqlConnection(CS))
            {
                MySqlCommand cmd = new MySqlCommand($"SELECT appointment.appointmentId, customer.customerName, appointment.type, appointment.start, appointment.end " +
                                                    "FROM appointment INNER JOIN " +
                                                    $"customer ON appointment.customerId = customer.customerId WHERE DATE(start) = STR_TO_DATE('{currentDate}', '%m/%d/%Y') AND appointment.userId = {userId} ORDER BY appointment.start", con);
                con.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);
                appointmentDgv.DataSource = dt;

                //Converts from UTC (DateTimes stored in database) to user's local time using TimeZoneInfo
                for (int idx = 0; idx < dt.Rows.Count; idx++)
                {
                    dt.Rows[idx]["start"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)dt.Rows[idx]["start"], TimeZoneInfo.Local).ToString();
                }

                for (int idx = 0; idx < dt.Rows.Count; idx++)
                {
                    dt.Rows[idx]["end"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)dt.Rows[idx]["end"], TimeZoneInfo.Local).ToString();
                }
            }
        }

        private void handleWeek()
        {
            int userId = DataBaseHandler.GetCurrentUserId();
            mainFormCalendar.RemoveAllBoldedDates();
            dt.Clear();
            int dow = (int)currentDate.DayOfWeek;
            string startDate = currentDate.AddDays(-dow).ToString();
            DateTime tempDate = Convert.ToDateTime(startDate);
            for (int i = 0; i < 7; i++)
            {
                mainFormCalendar.AddBoldedDate(tempDate.AddDays(i));
            }
            mainFormCalendar.UpdateBoldedDates();
            string endDate = currentDate.AddDays(7 - dow).ToString();
            using (MySqlConnection con = new MySqlConnection(CS))
            {
                MySqlCommand cmd = new MySqlCommand("SELECT appointment.appointmentId, customer.customerName, appointment.type, appointment.start, appointment.end " +
                                                    "FROM appointment INNER JOIN " +
                                                    $"customer ON appointment.customerId = customer.customerId WHERE DATE(start) AND DATE(end) BETWEEN STR_TO_DATE('{startDate}', '%m/%d/%Y') AND STR_TO_DATE('{endDate}', '%m/%d/%Y') AND appointment.userId = {userId} ORDER BY appointment.start", con);
                con.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);
                appointmentDgv.DataSource = dt;

                //Converts from UTC (DateTimes stored in database) to user's local time using TimeZoneInfo
                for (int idx = 0; idx < dt.Rows.Count; idx++)
                {
                    dt.Rows[idx]["start"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)dt.Rows[idx]["start"], TimeZoneInfo.Local).ToString();
                }

                for (int idx = 0; idx < dt.Rows.Count; idx++)
                {
                    dt.Rows[idx]["end"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)dt.Rows[idx]["end"], TimeZoneInfo.Local).ToString();
                }
            }
        }

        private void handleMonth()
        {
            int userId = DataBaseHandler.GetCurrentUserId();
            mainFormCalendar.RemoveAllBoldedDates();
            dt.Clear();
            int mo = currentDate.Month;
            int yr = currentDate.Year;
            int d = 0;
            string startDate = mo.ToString() + "/01/" + yr.ToString();
            DateTime tempDate = Convert.ToDateTime(startDate);
            switch (mo)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                    d = 31;
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    d = 30;
                    break;
                default:
                    d = 29;
                    break;
            }
            for (int i = 0; i < d; i++)
            {
                mainFormCalendar.AddBoldedDate(tempDate.AddDays(i));
            }
            mainFormCalendar.UpdateBoldedDates();
            string endDate = mo.ToString() + "/" + d.ToString() + "/" + yr.ToString();
            using (MySqlConnection con = new MySqlConnection(CS))
            {
                MySqlCommand cmd = new MySqlCommand("SELECT appointment.appointmentId, customer.customerName, appointment.type, appointment.start, appointment.end " +
                                                    "FROM appointment INNER JOIN " +
                                                    $"customer ON appointment.customerId = customer.customerId WHERE DATE(start) AND DATE(end) BETWEEN STR_TO_DATE('{startDate}', '%m/%d/%Y') AND STR_TO_DATE('{endDate}', '%m/%d/%Y') AND appointment.userId = {userId} ORDER BY appointment.start", con);
                con.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);
                appointmentDgv.DataSource = dt;

                //Converts from UTC (DateTimes stored in database) to user's local time using TimeZoneInfo
                for (int idx = 0; idx < dt.Rows.Count; idx++)
                {
                    dt.Rows[idx]["start"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)dt.Rows[idx]["start"], TimeZoneInfo.Local).ToString();
                }

                for (int idx = 0; idx < dt.Rows.Count; idx++)
                {
                    dt.Rows[idx]["end"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)dt.Rows[idx]["end"], TimeZoneInfo.Local).ToString();
                }
            }
        }

        private void dayRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            handleDay();
        }

        private void weekRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            handleWeek();
        }

        private void monthRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            handleMonth();
        }

        private void appointmentsByMonthBtn_Click(object sender, EventArgs e)
        {
            int userId = DataBaseHandler.GetCurrentUserId();
            txtReport.Text = "";

            using (MySqlConnection con = new MySqlConnection(CS))
            {
                string[] Months = new string[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
                int temp = 1;

                foreach (string month in Months)
                {
                    txtReport.Text = txtReport.Text + month + "\r";
                    MySqlCommand cmd = new MySqlCommand($"SELECT appointment.type, COUNT(*) FROM appointment WHERE month(start) = {temp++} AND appointment.userId = {userId} GROUP BY appointment.type", con);
                    MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adp.Fill(dt);

                    foreach (DataRow row in dt.Rows)
                    {
                        txtReport.Text = txtReport.Text +
                            "\t(" + row[1].ToString() + ")\t" +
                            "\"" + row[0].ToString() + "\"" + "\r";
                    }
                    txtReport.Select(0, 0);
                }
            }
        }

        private void customersWithAppointmentsBtn_Click(object sender, EventArgs e)
        {
            int userId = DataBaseHandler.GetCurrentUserId();
            txtReport.Text = "";

            using (MySqlConnection con = new MySqlConnection(CS))
            {
                //txtReport.Text = txtReport.Text + "\r";
                MySqlCommand cmd = new MySqlCommand("SELECT DISTINCT customer.customerName " +
                                                    "FROM  appointment INNER JOIN " +
                                                    $"customer ON appointment.customerId = customer.customerId WHERE appointment.userId = {userId}", con);
                MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adp.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    txtReport.Text = txtReport.Text +
                        "\t" + row[0].ToString() + "\r";/* + ")\t" +
                        "\"" + row[0].ToString() + "\"" + "\r";*/
                }
                txtReport.Select(0, 0);
            }
        }

        private void scheduleBtn_Click(object sender, EventArgs e)
        {
            txtReport.Text = "";

            using (MySqlConnection con = new MySqlConnection(CS))
            {
                string[] Months = new string[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
                int temp = 1;

                foreach (string month in Months)
                {
                    txtReport.Text = txtReport.Text + month + "\r";
                    MySqlCommand cmd = new MySqlCommand($"SELECT appointment.createdBy, appointment.start, appointment.end FROM appointment WHERE month(start) = {temp++} ORDER BY appointment.createdBy", con);
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
                        txtReport.Text = txtReport.Text +
                            "\t" + row[0].ToString() + "\r" +
                            "\t" + row[1].ToString() + "\r" +
                            "\t" + row[2].ToString() + "\r\n";
                        
                            //"\t(" + row[1].ToString() + ")\t" +
                            //"\"" + row[0].ToString() + "\"" + "\r";
                    }
                    txtReport.Select(0, 0);
                }
            }
        }

        private void searchAppointmentsByCustomerBtn_Click(object sender, EventArgs e)
        {
            CustomerModel model = new CustomerModel();
            model.Name = Convert.ToString(this.customerDgv.CurrentRow.Cells[1].Value.ToString());

            AppointmentsByCustomerDgv(model.Name);
        }
    }
}
