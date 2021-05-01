using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace John_Davis_Appointment_App
{
    public partial class UpdateCustomerForm : Form
    {
        private bool AllowSave()
        {
            return (!string.IsNullOrWhiteSpace(updateCustomerNameTextBox.Text) &&
                !string.IsNullOrWhiteSpace(updateCustomerAddressTextBox.Text) &&
                !string.IsNullOrWhiteSpace(updateCustomerCityTextBox.Text)) &&
                !string.IsNullOrWhiteSpace(updateCustomerCountryTextBox.Text) &&
                (!(string.IsNullOrWhiteSpace(updateCustomerPhoneNumberTextBox.Text) || (!Int32.TryParse(updateCustomerPhoneNumberTextBox.Text, out _) &&
                (!(string.IsNullOrWhiteSpace(updateCustomerZipcodeTextBox.Text) || (!Int32.TryParse(updateCustomerZipcodeTextBox.Text, out _)))))));
        }
        
        //Querys database in the "MySqlConnector" class and creates a new CustomerModel
        //object to populate the update form's current values.
        public UpdateCustomerForm(CustomerModel model)
        {
            InitializeComponent();

            //For each interface IDataConnection in the "list" of connections 
            //(stored in the GlobalConfig class),
            //implement the contract's methods as alias db
            foreach (IDataConnection db in GlobalConfig.Connections)
            {
                db.QueryCustomerInfo(model);
            }

            updateAddressIdTextBox.Text = Convert.ToString(model.AddressId);
            updateCityIdTextBox.Text = Convert.ToString(model.CityId);
            updateCountryIdTextBox.Text = Convert.ToString(model.CountryId);            
            updateCustomerActiveRadioBtn.Checked = Convert.ToBoolean(model.Active);
            updateCustomerInactiveRadioBtn.Checked = Convert.ToBoolean(model.Inactive);
            updateCustomerIdTextBox.Text = Convert.ToString(model.Id);
            updateCustomerNameTextBox.Text = model.Name;
            updateCustomerPhoneNumberTextBox.Text = model.PhoneNumber;
            updateCustomerAddressTextBox.Text = model.Address;
            updateCustomerZipcodeTextBox.Text = model.Zipcode;
            updateCustomerCityTextBox.Text = model.City;
            updateCustomerCountryTextBox.Text = model.Country;

            updateCustomerSaveBtn.Enabled = AllowSave();  
        }

        private void updateCustomerActiveRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            //Not needed   
        }

        private void updateCustomerInactiveRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            //Not needed
        }
        
        private void updateCustomerNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (Int32.TryParse(updateCustomerNameTextBox.Text, out _) || string.IsNullOrWhiteSpace(updateCustomerNameTextBox.Text))
            {
                updateCustomerNameTextBox.BackColor = System.Drawing.Color.Salmon;
            }
            else
            {
                updateCustomerNameTextBox.BackColor = System.Drawing.Color.White;
            }
            updateCustomerSaveBtn.Enabled = AllowSave();
        }

        private void updateCustomerPhoneNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!Int32.TryParse(updateCustomerPhoneNumberTextBox.Text, out _) || string.IsNullOrWhiteSpace(updateCustomerPhoneNumberTextBox.Text))
            {
                updateCustomerPhoneNumberTextBox.BackColor = System.Drawing.Color.Salmon;
            }
            else
            {
                updateCustomerPhoneNumberTextBox.BackColor = System.Drawing.Color.White;
            }
            updateCustomerSaveBtn.Enabled = AllowSave();
        }

        private void updateCustomerAddressTextBox_TextChanged(object sender, EventArgs e)
        {
            if (Int32.TryParse(updateCustomerAddressTextBox.Text, out _) || string.IsNullOrWhiteSpace(updateCustomerAddressTextBox.Text))
            {
                updateCustomerAddressTextBox.BackColor = System.Drawing.Color.Salmon;
            }
            else
            {
                updateCustomerAddressTextBox.BackColor = System.Drawing.Color.White;
            }
            updateCustomerSaveBtn.Enabled = AllowSave();
        }

        private void updateCustomerZipcodeTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!Int32.TryParse(updateCustomerZipcodeTextBox.Text, out _) || string.IsNullOrWhiteSpace(updateCustomerZipcodeTextBox.Text))
            {
                updateCustomerZipcodeTextBox.BackColor = System.Drawing.Color.Salmon;
            }
            else
            {
                updateCustomerZipcodeTextBox.BackColor = System.Drawing.Color.White;
            }
            updateCustomerSaveBtn.Enabled = AllowSave();
        }

        private void updateCustomerCityTextBox_TextChanged(object sender, EventArgs e)
        {
            if (Int32.TryParse(updateCustomerCityTextBox.Text, out _) || string.IsNullOrWhiteSpace(updateCustomerCityTextBox.Text))
            {
                updateCustomerCityTextBox.BackColor = System.Drawing.Color.Salmon;
            }
            else
            {
                updateCustomerCityTextBox.BackColor = System.Drawing.Color.White;
            }
            updateCustomerSaveBtn.Enabled = AllowSave();
        }

        private void updateCustomerCountryTextBox_TextChanged(object sender, EventArgs e)
        {
            if (Int32.TryParse(updateCustomerCountryTextBox.Text, out _) || string.IsNullOrWhiteSpace(updateCustomerCountryTextBox.Text))
            {
                updateCustomerCountryTextBox.BackColor = System.Drawing.Color.Salmon;
            }
            else
            {
                updateCustomerCountryTextBox.BackColor = System.Drawing.Color.White;
            }
            updateCustomerSaveBtn.Enabled = AllowSave();
        }
        //Creates the updated CustomerModel object and writes info to database
        private void updateCustomerSaveBtn_Click(object sender, EventArgs e)
        {
            CustomerModel model = new CustomerModel(
                int.Parse(updateAddressIdTextBox.Text),
                int.Parse(updateCityIdTextBox.Text),
                int.Parse(updateCountryIdTextBox.Text),
                int.Parse(updateCustomerIdTextBox.Text),
                updateCustomerActiveRadioBtn.Checked ? 1 : 0,
                updateCustomerInactiveRadioBtn.Checked ? 1 : 0,
                updateCustomerNameTextBox.Text,
                updateCustomerPhoneNumberTextBox.Text,
                updateCustomerAddressTextBox.Text,
                updateCustomerZipcodeTextBox.Text,
                updateCustomerCityTextBox.Text,
                updateCustomerCountryTextBox.Text);

            //For each interface IDataConnection in the "list" of connections 
            //(stored in the GlobalConfig class),
            //implement the contract's methods as alias db
            foreach (IDataConnection db in GlobalConfig.Connections)
            {
                db.UpdateCustomer(model);
            }

            MessageBox.Show("The existing customer was successfully updated.");

            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

        private void updateCustomerCancelBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }
    }
}
