using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace John_Davis_Appointment_App
{
    //DB connection string is stored in app.config file 

    public class DataBaseHandler
    {
        private static string userName;
        private static int userId;

        public static string CS = ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString;

        public static void PopulateUserTable()
        {
            using (MySqlConnection con = new MySqlConnection(CS))
            {
                MySqlCommand cmd1 = new MySqlCommand("SELECT userId from user");
                cmd1.Connection = con;
                con.Open();
                MySqlDataReader rdr = cmd1.ExecuteReader();

                if (!rdr.HasRows)
                {
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = "INSERT INTO `user` VALUES (1, 'test', 'test', 1, '2019-01-01 00:00:00', 'test', '2019-01-01 00:00:00', 'test'), " +
                                                                "(2, 'new', 'new', 1, '2020-01-01 00:00:00', 'new', '2020-01-01 00:00:00', 'new');";
                    cmd.Connection = con;
                    con.Close();
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                con.Close();
            }
        }

        public static void PopulateCountryTable()
        {
            using (MySqlConnection con = new MySqlConnection(CS))
            {
                MySqlCommand cmd1 = new MySqlCommand("SELECT countryId from country");
                cmd1.Connection = con;
                con.Open();
                MySqlDataReader rdr = cmd1.ExecuteReader();

                if (!rdr.HasRows)
                {
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = "INSERT INTO `country` VALUES (1, 'US', '2019-01-01 00:00:00', 'test', '2019-01-01 00:00:00', 'test'), " +
                                                                   "(2, 'Canada', '2019-01-01 00:00:00', 'test', '2019-01-01 00:00:00', 'test'), " +
                                                                   "(3, 'Norway', '2019-01-01 00:00:00', 'test', '2019-01-01 00:00:00', 'test');";
                    cmd.Connection = con;
                    con.Close();
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                con.Close();
            }
        }

        public static void PopulateCityTable()
        {
            using (MySqlConnection con = new MySqlConnection(CS))
            {
                MySqlCommand cmd1 = new MySqlCommand("SELECT cityId from city");
                cmd1.Connection = con;
                con.Open();
                MySqlDataReader rdr = cmd1.ExecuteReader();

                if (!rdr.HasRows)
                {
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = "INSERT INTO `city` VALUES (1, 'New York', 1, '2019-01-01 00:00:00', 'test', '2019-01-01 00:00:00', 'test'), " +
                                                                "(2, 'Los Angeles', 1, '2019-01-01 00:00:00', 'test', '2019-01-01 00:00:00', 'test'), " +
                                                                "(3, 'Toronto', 2, '2019-01-01 00:00:00', 'test', '2019-01-01 00:00:00', 'test'), " +
                                                                "(4, 'Vancouver', 2, '2019-01-01 00:00:00', 'test', '2019-01-01 00:00:00', 'test'), " +
                                                                "(5, 'Oslo', 3, '2019-01-01 00:00:00', 'test', '2019-01-01 00:00:00', 'test');";
                    cmd.Connection = con;
                    con.Close();
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                con.Close();
            }
        }

        public static void PopulateAddressTable()
        {
            using (MySqlConnection con = new MySqlConnection(CS))
            {
                MySqlCommand cmd1 = new MySqlCommand("SELECT addressId from address");
                cmd1.Connection = con;
                con.Open();
                MySqlDataReader rdr = cmd1.ExecuteReader();

                if (!rdr.HasRows)
                {
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = "INSERT INTO `address` VALUES (1, '123 Main', '', 1, '11111', '5551212', '2019-01-01 00:00:00', 'test', '2019-01-01 00:00:00', 'test'), " +
                                                                   "(2, '123 Elm', '', 3, '11112', '5551213', '2019-01-01 00:00:00', 'test', '2019-01-01 00:00:00', 'test'), " +
                                                                   "(3, '123 Oak', '', 5, '11113', '5551214', '2019-01-01 00:00:00', 'test', '2019-01-01 00:00:00', 'test');";
                    cmd.Connection = con;
                    con.Close();
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                con.Close();
            }
        }

        public static void PopulateCustomerTable()
        {
            using (MySqlConnection con = new MySqlConnection(CS))
            {
                MySqlCommand cmd1 = new MySqlCommand("SELECT customerId from customer");
                cmd1.Connection = con;
                con.Open();
                MySqlDataReader rdr = cmd1.ExecuteReader();

                if (!rdr.HasRows)
                {
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = "INSERT INTO `customer` VALUES (1, 'John Doe', 1, 1, '2019-01-01 00:00:00', 'test', '2019-01-01 00:00:00', 'test'), " +
                                                                    "(2, 'Alfred E Newman', 2, 1, '2019-01-01 00:00:00', 'test', '2019-01-01 00:00:00', 'test'), " +
                                                                    "(3, 'Ina Prufung', 3, 1, '2019-01-01 00:00:00', 'test', '2019-01-01 00:00:00', 'test');";
                    cmd.Connection = con;
                    con.Close();
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                con.Close();
            }
        }

        public static void PopulateAppointmentTable()
        {
            using (MySqlConnection con = new MySqlConnection(CS))
            {
                MySqlCommand cmd1 = new MySqlCommand("SELECT appointmentId from appointment");
                cmd1.Connection = con;
                con.Open();
                MySqlDataReader rdr = cmd1.ExecuteReader();

                if (!rdr.HasRows)
                {
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = "INSERT INTO `appointment` VALUES (1, 1, 1, 'not needed', 'not needed', 'not needed', 'not needed', 'Psoriasis', 'not needed', '2021-11-16 14:00:00', '2021-11-16 15:00:00', '2020-01-01 00:00:00', 'test', '2020-01-01 00:00:00', 'test'), " +
                                                                       "(2, 2, 1, 'not needed', 'not needed', 'not needed', 'not needed', 'Eczema', 'not needed', '2021-11-01 15:00:00', '2021-11-01 16:00:00', '2020-01-01 00:00:00', 'test', '2020-01-01 00:00:00', 'test');";
                    cmd.Connection = con;
                    con.Close();
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                con.Close();
            }
        }

        public static string GetCurrentUserName()
        {
            return userName;
        }

        public static int GetCurrentUserId()
        {
            return userId;
        }

        public static void SetCurrentUserId(int currentUserId)
        {
            userId = currentUserId;
        }

        public static void SetCurrentUserName(string currentUsername)
        {
            userName = currentUsername;
        }

        public static int UserExists(string username, string password)
        {
            using (MySqlConnection con = new MySqlConnection(CS))

            {
                MySqlCommand cmd = new MySqlCommand($"SELECT userId, userName FROM user where userName = '{username}' AND password = '{password}'", con);
                con.Open();
                MySqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    rdr.Read();

                    //Puts values into variables for log file
                    SetCurrentUserId(Convert.ToInt32(rdr[0]));
                    SetCurrentUserName(Convert.ToString(rdr[1]));
                    rdr.Close();
                    con.Close();
                    return 1;
                }
                return 0;
            }
        }
    }
}
