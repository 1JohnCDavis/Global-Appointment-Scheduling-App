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

namespace John_Davis_Appointment_App
{
    public partial class AddCustomerForm : Form
    {
        private bool AllowSave()
        {
            return (!string.IsNullOrWhiteSpace(addCustomerNameTextBox.Text) &&
                !string.IsNullOrWhiteSpace(addCustomerAddressTextBox.Text) &&
                !string.IsNullOrWhiteSpace(addCustomerCityTextBox.Text)) &&
                !string.IsNullOrWhiteSpace(addCustomerCountryTextBox.Text) &&
                (!(string.IsNullOrWhiteSpace(addCustomerPhoneNumberTextBox.Text) || (!Int32.TryParse(addCustomerPhoneNumberTextBox.Text, out _) &&
                (!(string.IsNullOrWhiteSpace(addCustomerZipcodeTextBox.Text) || (!Int32.TryParse(addCustomerZipcodeTextBox.Text, out _)))))));
        }

        public AddCustomerForm()
        {
            InitializeComponent();

            //Colors all fields salmon until text box validation is satisfied
            addCustomerNameTextBox.BackColor = System.Drawing.Color.Salmon;
            addCustomerPhoneNumberTextBox.BackColor = System.Drawing.Color.Salmon;
            addCustomerAddressTextBox.BackColor = System.Drawing.Color.Salmon;
            addCustomerZipcodeTextBox.BackColor = System.Drawing.Color.Salmon;
            addCustomerCityTextBox.BackColor = System.Drawing.Color.Salmon;
            addCustomerCountryTextBox.BackColor = System.Drawing.Color.Salmon;

            addCustomerSaveBtn.Enabled = AllowSave();
        }
        
        private void addCustomerNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (Int32.TryParse(addCustomerNameTextBox.Text, out _) || string.IsNullOrWhiteSpace(addCustomerNameTextBox.Text))
            {
                addCustomerNameTextBox.BackColor = System.Drawing.Color.Salmon;
            }
            else
            {
                addCustomerNameTextBox.BackColor = System.Drawing.Color.White;
            }
            addCustomerSaveBtn.Enabled = AllowSave();
        }

        private void addCustomerPhoneNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!Int32.TryParse(addCustomerPhoneNumberTextBox.Text, out _) || string.IsNullOrWhiteSpace(addCustomerPhoneNumberTextBox.Text))
            {
                addCustomerPhoneNumberTextBox.BackColor = System.Drawing.Color.Salmon;
            }
            else
            {
                addCustomerPhoneNumberTextBox.BackColor = System.Drawing.Color.White;
            }
            addCustomerSaveBtn.Enabled = AllowSave();
        }

        private void addCustomerAddressTextBox_TextChanged(object sender, EventArgs e)
        {
            if (Int32.TryParse(addCustomerAddressTextBox.Text, out _) || string.IsNullOrWhiteSpace(addCustomerAddressTextBox.Text))
            {
                addCustomerAddressTextBox.BackColor = System.Drawing.Color.Salmon;
            }
            else
            {
                addCustomerAddressTextBox.BackColor = System.Drawing.Color.White;
            }
            addCustomerSaveBtn.Enabled = AllowSave();
        }

        private void addCustomerZipcodeTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!Int32.TryParse(addCustomerZipcodeTextBox.Text, out _) || string.IsNullOrWhiteSpace(addCustomerZipcodeTextBox.Text))
            {
                addCustomerZipcodeTextBox.BackColor = System.Drawing.Color.Salmon;
            }
            else
            {
                addCustomerZipcodeTextBox.BackColor = System.Drawing.Color.White;
            }
            addCustomerSaveBtn.Enabled = AllowSave();
        }

        private void addCustomerCityTextBox_TextChanged(object sender, EventArgs e)
        {
            if (Int32.TryParse(addCustomerCityTextBox.Text, out _) || string.IsNullOrWhiteSpace(addCustomerCityTextBox.Text))
            {
                addCustomerCityTextBox.BackColor = System.Drawing.Color.Salmon;
            }
            else
            {
                addCustomerCityTextBox.BackColor = System.Drawing.Color.White;
            }
            addCustomerSaveBtn.Enabled = AllowSave();
        }

        private void addCustomerCountryTextBox_TextChanged(object sender, EventArgs e)
        {
            if (Int32.TryParse(addCustomerCountryTextBox.Text, out _) || string.IsNullOrWhiteSpace(addCustomerCountryTextBox.Text))
            {
                addCustomerCountryTextBox.BackColor = System.Drawing.Color.Salmon;
            }
            else
            {
                addCustomerCountryTextBox.BackColor = System.Drawing.Color.White;
            }
            addCustomerSaveBtn.Enabled = AllowSave();
        }

        private void addCustomerCancelBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }
        
        //Creates a new CustomerModel object and writes info to database
        //inside the "MySqlConnector" class.
        //The addressId, cityId, and countryId are auto incremented
        //in database and the "MySqlConnector" class querys as 
        //necessary to link table entries together.
        private void addCustomerSaveBtn_Click(object sender, EventArgs e)
        {
            //Constructor for adding a new customer
            CustomerModel model = new CustomerModel(
                0,
                0,
                0,
                addCustomerActiveRadioBtn.Checked ? 1 : 0,
                addCustomerNameTextBox.Text,
                addCustomerPhoneNumberTextBox.Text,
                addCustomerAddressTextBox.Text,
                addCustomerZipcodeTextBox.Text,
                addCustomerCityTextBox.Text,
                addCustomerCountryTextBox.Text);

            //For each interface IDataConnection in the "list" of connections 
            //(stored in the GlobalConfig class),
            //implement the contract's methods as alias db
            foreach (IDataConnection db in GlobalConfig.Connections)
            {
                db.CreateCustomer(model);
            }
            //Clears the text boxes once the customer was added to the database
            addCustomerNameTextBox.Text = "";
            addCustomerPhoneNumberTextBox.Text = "";
            addCustomerAddressTextBox.Text = "";
            addCustomerZipcodeTextBox.Text = "";
            addCustomerCityTextBox.Text = "";
            addCustomerCountryTextBox.Text = "";

            MessageBox.Show("The new customer was successfully created.");

            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }
    }
}
