using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/*******************************************************
 * Author: Brian Liang 
 * Date: July-2018
 * Purpose: Access for the booking database
 *******************************************************/

namespace TravelExpertsWeb.App_Code
{
    [DataObject(true)]
    public class BookingDB
    {
        [DataObjectMethod(DataObjectMethodType.Select)]     //data object method select attribute
        public static List<Booking> GetCustomerID()
        {
            List<Booking> customerId = new List<Booking>(); // make an empty list
            Booking cust; // reference to new state object

            SqlConnection connection = TravelExpertsDB.GetConnection(); // create connection

            // create select command
            string selectString = "Select distinct CustomerId " +
                                   "from Bookings " +
                                  "order by CustomerId";


            SqlCommand selectCommand = new SqlCommand(selectString, connection);
            try
            {
                // open connection
                connection.Open();
                // run the select command and process the results adding states to the list
                SqlDataReader reader = selectCommand.ExecuteReader();
                while (reader.Read())// process next row
                {
                    cust = new Booking();
                    cust.CustomerId = (int)reader["CustomerId"];
                    customerId.Add(cust);      //adding them to technician list
                }
                reader.Close();     // close reader
            }
            catch (Exception ex)
            {
                throw ex; // throw it to the form to handle
            }
            finally
            {
                connection.Close();     //close connection
            }
            return customerId;     // returns the technicans list
        }


        [DataObjectMethod(DataObjectMethodType.Select)]     //data object method select attribute
        public static List<Booking> GetBooking(string CustomerID)
        {
            List<Booking> bookings = new List<Booking>(); // make an empty list
            Booking mybooking; // reference to new state object

            SqlConnection connection = TravelExpertsDB.GetConnection(); // create connection

            // create select command
            string selectString = "Select Bookings.BookingID, BookingDate, TravelerCount, TripStart, TripEnd, [Description], Destination, BasePrice, CustomerId " +
                                   "From Bookings inner join BookingDetails on Bookings.BookingId = BookingDetails.BookingId " +
                                  "where CustomerId = @CustomerId " +
                                  "order by CustomerId";


            SqlCommand selectCommand = new SqlCommand(selectString, connection);
            selectCommand.Parameters.AddWithValue("@CustomerId", CustomerID);
            try
            {
                // open connection
                connection.Open();
                // run the select command and process the results adding states to the list
                SqlDataReader reader = selectCommand.ExecuteReader();
                while (reader.Read())// process next row
                {
                    mybooking = new Booking();
                    mybooking.BookingId = (int)reader["BookingId"];
                    mybooking.BookingDate = (DateTime)reader["BookingDate"];
                    mybooking.TravelerCount = (double)reader["TravelerCount"];
                    mybooking.TripStart = (DateTime)reader["TripStart"];
                    mybooking.TripEnd = (DateTime)reader["TripEnd"];
                    mybooking.Description = reader["Description"].ToString();
                    mybooking.Destination = reader["Destination"].ToString();
                    mybooking.BasePrice = (decimal)reader["BasePrice"];
                    mybooking.CustomerId = (int)reader["CustomerId"];
                    bookings.Add(mybooking);      //adding them to technician list
                }
                reader.Close();     // close reader
            }
            catch (Exception ex)
            {
                throw ex; // throw it to the form to handle
            }
            finally
            {
                connection.Close();     //close connection
            }
            return bookings;     // returns the technicans list
        }
    }
}