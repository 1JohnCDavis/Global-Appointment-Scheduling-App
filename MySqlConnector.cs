using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace John_Davis_Appointment_App
{
    public class MySqlConnector : IDataConnection
    {
        //DB connection string is stored in app.config file 

        /// <summary>
        /// Deletes a customer record from the mySqlDatabase
        /// </summary>
        /// <param name="model"> The customer information </param>
        /// <returns> Returns the customer information and deletes the record in the database </returns>
        public CustomerModel DeleteCustomer(CustomerModel model)
        {            
            //Deletes customer record based on the addressId value from above
            using (MySqlConnection con = new MySqlConnection(GlobalConfig.CS))
            {
                con.Open();
                MySqlTransaction transaction = con.BeginTransaction();
                var query = $"DELETE FROM customer WHERE customerId = '{model.Id}'";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Transaction = transaction;
                cmd.ExecuteNonQuery();
                transaction.Commit();
                con.Close();
            }

            //Deletes address record based on the cityId value from above
            using (MySqlConnection con = new MySqlConnection(GlobalConfig.CS))
            {
                con.Open();
                MySqlTransaction transaction = con.BeginTransaction();
                var query = $"DELETE FROM address WHERE addressId = '{model.AddressId}'";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Transaction = transaction;
                cmd.ExecuteNonQuery();
                transaction.Commit();
                con.Close();
            }

            //Deletes city record based on model.CountryId value from above
            using (MySqlConnection con = new MySqlConnection(GlobalConfig.CS))
            {
                con.Open();
                MySqlTransaction transaction = con.BeginTransaction();
                var query = $"DELETE FROM city WHERE cityId = '{model.CityId}'";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Transaction = transaction;
                cmd.ExecuteNonQuery();
                transaction.Commit();
                con.Close();
            }

            //Deletes country record
            using (MySqlConnection con = new MySqlConnection(GlobalConfig.CS))
            {
                con.Open();
                MySqlTransaction transaction = con.BeginTransaction();
                var query = $"DELETE FROM country WHERE countryId = '{model.CountryId}'";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Transaction = transaction;
                cmd.ExecuteNonQuery();
                transaction.Commit();
                con.Close();
            }
            MainForm mainForm = new MainForm();
            mainForm.Show();
            return model;
        }

        /// <summary>
        /// Updates a customer and writes record to the mySqlDatabase
        /// </summary>
        /// <param name="model"> The customer information </param>
        /// <returns> Returns the customer information and updates the record in the database </returns>
        public CustomerModel UpdateCustomer(CustomerModel model)
        {
            //Method-wide variable to set the active user 
            string user = DataBaseHandler.GetCurrentUserName();

            //Updates country record
            using (MySqlConnection con = new MySqlConnection(GlobalConfig.CS))
            {
                con.Open();
                MySqlTransaction transaction = con.BeginTransaction();
                var query = $"UPDATE country SET country = '{model.Country}', lastUpdate = CURRENT_TIMESTAMP, lastUpdateBy = '{user}' WHERE countryId = '{model.CountryId}'";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Transaction = transaction;
                cmd.ExecuteNonQuery();
                transaction.Commit();
                con.Close();
            }

            //Updates city record based on model.CountryId value from above
            using (MySqlConnection con = new MySqlConnection(GlobalConfig.CS))
            {
                con.Open();
                MySqlTransaction transaction = con.BeginTransaction();
                var query = $"UPDATE city SET city = '{model.City}', countryId = '{model.CountryId}', lastUpdate = CURRENT_TIMESTAMP, lastUpdateBy = '{user}' WHERE cityId = '{model.CityId}'";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Transaction = transaction;
                cmd.ExecuteNonQuery();
                transaction.Commit();
                con.Close();
            }

            //Updates address record based on the cityId value from above
            using (MySqlConnection con = new MySqlConnection(GlobalConfig.CS))
            {
                con.Open();
                MySqlTransaction transaction = con.BeginTransaction();
                var query = $"UPDATE address SET address = '{model.Address}', cityId = '{model.CityId}', postalCode = '{model.Zipcode}', phone = '{model.PhoneNumber}', lastUpdate = CURRENT_TIMESTAMP, lastUpdateBy = '{user}' WHERE addressId = '{model.AddressId}'";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Transaction = transaction;
                cmd.ExecuteNonQuery();
                transaction.Commit();
                con.Close();
            }

            //Updates customer record based on the addressId value from above
            using (MySqlConnection con = new MySqlConnection(GlobalConfig.CS))
            {
                con.Open();
                MySqlTransaction transaction = con.BeginTransaction();
                var query = $"UPDATE customer SET customerName = '{model.Name}', addressId = '{model.AddressId}', active = '{model.Active}', lastUpdate = CURRENT_TIMESTAMP, lastUpdateBy = '{user}' WHERE customerId = '{model.Id}'";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Transaction = transaction;
                cmd.ExecuteNonQuery();
                transaction.Commit();
                con.Close();
            }
            return model;
        }

        /// <summary>
        /// Querys the mySqlDatabase to populate the update form's text boxes with current info.
        /// </summary>
        /// <param name="model"> The customer information </param>
        /// <returns> Returns the customer information and populates update form's text boxes </returns>
        public CustomerModel QueryCustomerInfo(CustomerModel model)
        {
            //Method-wide variable to set the active user 
            string user = DataBaseHandler.GetCurrentUserName();

            using (MySqlConnection con = new MySqlConnection(GlobalConfig.CS))

            {
                MySqlCommand cmd = new MySqlCommand($"SELECT customerName, addressId, active FROM customer WHERE customerId = {model.Id}", con);
                con.Open();
                MySqlDataReader rdr = cmd.ExecuteReader();
                rdr.Read();
                model.Name = rdr.GetString("customerName");
                model.AddressId = rdr.GetInt32(rdr.GetOrdinal("addressId"));
                model.Active = rdr.GetInt32(rdr.GetOrdinal("active"));
                if (model.Active == 0)
                {
                    model.Inactive = 1;
                }
            }

            using (MySqlConnection con = new MySqlConnection(GlobalConfig.CS))

            {
                MySqlCommand cmd = new MySqlCommand($"SELECT address, address2, cityId, postalCode, phone FROM address WHERE addressId = {model.AddressId}", con);
                con.Open();
                MySqlDataReader rdr = cmd.ExecuteReader();
                rdr.Read();
                model.Address = rdr.GetString("address");
                model.CityId = rdr.GetInt32(rdr.GetOrdinal("cityId"));
                model.Zipcode = rdr.GetString("postalCode");
                model.PhoneNumber = rdr.GetString("phone");
            }

            using (MySqlConnection con = new MySqlConnection(GlobalConfig.CS))

            {
                MySqlCommand cmd = new MySqlCommand($"SELECT city, countryId FROM city WHERE cityId = {model.CityId}", con);
                con.Open();
                MySqlDataReader rdr = cmd.ExecuteReader();
                rdr.Read();
                model.City = rdr.GetString("city");
                model.CountryId = rdr.GetInt32(rdr.GetOrdinal("countryId"));
            }

            using (MySqlConnection con = new MySqlConnection(GlobalConfig.CS))

            {
                MySqlCommand cmd = new MySqlCommand($"SELECT country FROM country WHERE countryId = {model.CountryId}", con);
                con.Open();
                MySqlDataReader rdr = cmd.ExecuteReader();
                rdr.Read();
                model.Country = rdr.GetString("country");
            }
            return model;
        }

        /// <summary>
        /// Saves a new customer record to the database from 
        /// values entered into text boxes on add customer form.
        /// </summary>
        /// <param name="model"> The customer information </param>
        /// <returns> The customer information, including the unique identifier </returns>
        public CustomerModel CreateCustomer(CustomerModel model)
        {
            //Method-wide variable to set the active user 
            string user = DataBaseHandler.GetCurrentUserName();

            //Creates new country record
            using (MySqlConnection con = new MySqlConnection(GlobalConfig.CS))
            {
                con.Open();
                MySqlTransaction transaction = con.BeginTransaction();
                var query = "INSERT into country (country, createDate, createdBy, lastUpdate, lastUpdateBy) " +
                            $"VALUES ('{model.Country}', CURRENT_DATE,'{user}', CURRENT_TIMESTAMP, '{user}')";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Transaction = transaction;
                cmd.ExecuteNonQuery();
                transaction.Commit();
                con.Close(); 
            }

            //Finds the countryId assigned above and sets model.CountryId to that
            //value, then it is used to link the following create record action below
            using (MySqlConnection con = new MySqlConnection(GlobalConfig.CS))

            {
                MySqlCommand cmd = new MySqlCommand("SELECT countryId FROM country ORDER BY countryId DESC LIMIT 1", con);
                con.Open();
                MySqlDataReader rdr = cmd.ExecuteReader();
                rdr.Read();
                model.CountryId = rdr.GetInt32(rdr.GetOrdinal("countryId"));
            }

            //Creates new city record based on model.CountryId value from above
            using (MySqlConnection con = new MySqlConnection(GlobalConfig.CS))
            {
                con.Open();
                MySqlTransaction transaction = con.BeginTransaction();
                var query = "INSERT into city (city, countryId, createDate, createdBy, lastUpdate, lastUpdateBy) " +
                            $"VALUES ('{model.City}', '{model.CountryId}', CURRENT_DATE,'{user}', CURRENT_TIMESTAMP, '{user}')";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Transaction = transaction;
                cmd.ExecuteNonQuery();
                transaction.Commit();
                con.Close();
            }

            //Finds the cityId assigned above and sets model.CityId to that
            //value, then it is used to link the following create record action below
            using (MySqlConnection con = new MySqlConnection(GlobalConfig.CS))

            {
                MySqlCommand cmd = new MySqlCommand("SELECT cityId FROM city ORDER BY cityId DESC LIMIT 1", con);
                con.Open();
                MySqlDataReader rdr = cmd.ExecuteReader();
                rdr.Read();
                model.CityId = rdr.GetInt32(rdr.GetOrdinal("cityId"));
            }

            //Creates new address record based on the cityId value from above
            using (MySqlConnection con = new MySqlConnection(GlobalConfig.CS))
            {
                con.Open();
                MySqlTransaction transaction = con.BeginTransaction();
                var query = "INSERT into address (address, address2, cityId, postalCode, phone, createDate, createdBy, lastUpdate, lastUpdateBy) " +
                            $"VALUES ('{model.Address}', '', '{model.CityId}', '{model.Zipcode}', '{model.PhoneNumber}', CURRENT_DATE,'{user}', CURRENT_TIMESTAMP, '{user}')";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Transaction = transaction;
                cmd.ExecuteNonQuery();
                transaction.Commit();
                con.Close();
            }

            //Finds the addressId assigned above and sets model.AddressId to that
            //value, then it is used to link the following create record action below
            using (MySqlConnection con = new MySqlConnection(GlobalConfig.CS))

            {
                MySqlCommand cmd = new MySqlCommand("SELECT addressId FROM address ORDER BY addressId DESC LIMIT 1", con);
                con.Open();
                MySqlDataReader rdr = cmd.ExecuteReader();
                rdr.Read();
                model.AddressId = rdr.GetInt32(rdr.GetOrdinal("addressId"));
            }

            //Creates new customer record based on the addressId value from above
            using (MySqlConnection con = new MySqlConnection(GlobalConfig.CS))
            {
                con.Open();
                MySqlTransaction transaction = con.BeginTransaction();
                var query = "INSERT into customer (customerName, addressId, active, createDate, createdBy, lastUpdate, lastUpdateBy) " +
                            $"VALUES ('{model.Name}', '{model.AddressId}', '{model.Active}', CURRENT_DATE, '{user}', CURRENT_TIMESTAMP, '{user}')";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Transaction = transaction;
                cmd.ExecuteNonQuery();
                transaction.Commit();
                con.Close();
            }
            //Dummy initialization value for model.Id (CustomerModel object)
            model.Id = 1;
            //Returns the CustomerModel object entered into database
            return model;
        }




        /// <summary>
        /// Deletes an appointment record from the mySqlDatabase
        /// </summary>
        /// <param name="model"> The appointment's information </param>
        /// <returns> Returns the appointment information and deletes the record from the database </returns>
        public AppointmentModel DeleteAppointment(AppointmentModel model)
        {
            //Deletes an appointment record
            using (MySqlConnection con = new MySqlConnection(GlobalConfig.CS))
            {
                con.Open();
                MySqlTransaction transaction = con.BeginTransaction();
                var query = $"DELETE FROM appointment WHERE appointmentId = '{model.AppointmentId}'";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Transaction = transaction;
                cmd.ExecuteNonQuery();
                transaction.Commit();
                con.Close();
            }
            MainForm mainForm = new MainForm();
            mainForm.Show();
            return model;
        }

        /// <summary>
        /// Updates an appointment and writes record to the mySqlDatabase
        /// </summary>
        /// <param name="model"> The appointment's information </param>
        /// <returns> Returns the appointment information and updates the record in the database </returns>
        public AppointmentModel UpdateAppointment(AppointmentModel model)
        {
            string user = DataBaseHandler.GetCurrentUserName();

            //Updates appointment record
            using (MySqlConnection con = new MySqlConnection(GlobalConfig.CS))
            {
                con.Open();
                MySqlTransaction transaction = con.BeginTransaction();
                var query = $"UPDATE appointment SET customerId = '{model.CustomerId}', appointmentId = '{model.AppointmentId}', type = '{model.AppointmentType}', start = STR_TO_DATE('{model.StartTime}', '%m/%d/%Y %h:%i:%s %p'), end = STR_TO_DATE('{model.EndTime}', '%m/%d/%Y %h:%i:%s %p'), lastUpdate = CURRENT_TIMESTAMP, lastUpdateBy = '{user}' WHERE appointmentId = '{model.AppointmentId}'";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Transaction = transaction;
                cmd.ExecuteNonQuery();
                transaction.Commit();
                con.Close();
            }
            return model;
        }

        /// <summary>
        /// Querys the mySqlDatabase to populate the update form's text boxes with current info.
        /// </summary>
        /// <param name="model"> The appointment's information </param>
        /// <returns> Returns the appointment information and populates update form's text boxes </returns>
        public AppointmentModel QueryAppointmentInfo(AppointmentModel model)
        {
            using (MySqlConnection con = new MySqlConnection(GlobalConfig.CS))

            {
                MySqlCommand cmd = new MySqlCommand($"SELECT customerId, type, start, end FROM appointment WHERE appointmentId = {model.AppointmentId}", con);
                con.Open();
                MySqlDataReader rdr = cmd.ExecuteReader();
                rdr.Read();
                model.AppointmentType = rdr.GetString("type");
                model.CustomerId = rdr.GetInt32(rdr.GetOrdinal("customerId"));
                model.StartTime = rdr.GetDateTime("start");
                model.EndTime = rdr.GetDateTime("end");
            }

            //Finds customerName based on customerId from above 
            using (MySqlConnection con = new MySqlConnection(GlobalConfig.CS))

            {
                MySqlCommand cmd = new MySqlCommand($"SELECT customerName FROM customer WHERE customerId = {model.CustomerId}", con);
                con.Open();
                MySqlDataReader rdr = cmd.ExecuteReader();
                rdr.Read();
                model.CustomerName = rdr.GetString("customerName");
            }
            return model;
        }

        /// <summary>
        /// Saves a new appointment record to the database from 
        /// values entered into text boxes on add appointment form.
        /// </summary>
        /// <param name="model"> The appointment information </param>
        /// <returns> The appointment information, including the unique identifier </returns>
        public AppointmentModel CreateAppointment(AppointmentModel model)
        {
            //Method-wide variable to set the active user 
            string user = DataBaseHandler.GetCurrentUserName();
            int userId = DataBaseHandler.GetCurrentUserId();

            //Creates new appointment record
            using (MySqlConnection con = new MySqlConnection(GlobalConfig.CS))
            {
                con.Open();
                MySqlTransaction transaction = con.BeginTransaction();
                var query = "INSERT into appointment (customerId, userId, title, description, location, contact, type, url, start, end, createDate, createdBy, lastUpdate, lastUpdateBy) " +
                            $"VALUES ('{model.CustomerId}', '{userId}', 'not needed', 'not needed', 'not needed', 'not needed', '{model.AppointmentType}', 'not needed', STR_TO_DATE('{model.StartTime}', '%m/%d/%Y %h:%i:%s %p'), STR_TO_DATE('{model.EndTime}', '%m/%d/%Y %h:%i:%s %p'), CURRENT_DATE, '{user}', CURRENT_TIMESTAMP, '{user}')";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Transaction = transaction;
                cmd.ExecuteNonQuery();
                transaction.Commit();
                con.Close();
            }
            //Dummy initialization value for model.AppointmentId (AppointmentModel object)
            model.AppointmentId = 1;
            //Returns the AppointmentModel object entered into database
            return model;
        }
    }
}
