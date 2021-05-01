using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace John_Davis_Appointment_App
{
    public class CustomerModel
    {
        /// <summary>
        /// The unique identifier for the address
        /// </summary>
        public int AddressId { get; set; }
        /// <summary>
        /// The unique identifier for the city
        /// </summary>
        public int CityId { get; set; }
        /// <summary>
        /// The unique identifier for the country
        /// </summary>
        public int CountryId { get; set; }
        /// <summary>
        /// The unique identifier for the customer
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// The status of the customer
        /// </summary>
        public int Active { get; set; }
        /// <summary>
        /// The status of the customer
        /// </summary>
        public int Inactive { get; set; }
        /// <summary>
        /// The customers full name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// The customers phone number
        /// </summary>
        public string PhoneNumber { get; set; }
        /// <summary>
        /// The customers address
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// The customers zipcode
        /// </summary>
        public string Zipcode { get; set; }
        /// <summary>
        /// The customers city
        /// </summary>
        public string City { get; set; }
        /// <summary>
        /// The customers country
        /// </summary>
        public string Country { get; set; }

        public CustomerModel()
        {
        }

        //Add customer constructor
        public CustomerModel(int addressId, int cityId, int countryId, int active, string name, string phoneNumber, string address, string zipcode, string city, string country)
        {
            AddressId = addressId;
            CityId = cityId;
            CountryId = countryId;

            //Use the code below when passing a string as the "active" parameter datatype in this method

            //int activeValue = 0;
            //int.TryParse(active, out activeValue);
            //Active = activeValue;
            Active = active;

            Name = name;
            PhoneNumber = phoneNumber;
            Address = address;
            Zipcode = zipcode;
            City = city;
            Country = country;
        }

        //Update customer constructor
        public CustomerModel(int addressId, int cityId, int countryId, int id, int active, int inactive, string name, string phoneNumber, string address, string zipcode, string city, string country)
        {
            AddressId = addressId;
            CityId = cityId;
            CountryId = countryId;
            Id = id;
            Active = active;
            Inactive = inactive;
            Name = name;
            PhoneNumber = phoneNumber;
            Address = address;
            Zipcode = zipcode;
            City = city;
            Country = country;
        }
    }
}
