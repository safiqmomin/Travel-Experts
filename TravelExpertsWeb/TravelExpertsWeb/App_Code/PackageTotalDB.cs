using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/*******************************************************
 * Author: Brian Liang
 * Date: July-2018
 * Purpose: Prop for Customer
 *******************************************************/

/*
 * This calcualte could be done in the Booking/BookingDB accessor, however:
 * I found that the booking/bookingDB needed the properties to be set to content for the data object to work.
 * Where as if I wanted to access the bookingDB to calcualte the total for the form in the code, it needed to be complied.
 * Therefore I decided to create a seperate data access class to calulate the package total.
 */ 

namespace TravelExpertsWeb.App_Code
{
    public class PackageTotalDB
    {
        [DataObjectMethod(DataObjectMethodType.Select)]     //data object method select attribute
        public static List<PackageTotal> GetPackageTotal(string CustomerID)
        {
            List<PackageTotal> totals = new List<PackageTotal>(); // make an empty list
            PackageTotal tot; // reference to new state object

            SqlConnection connection = TravelExpertsDB.GetConnection(); // create connection

            // create select command
            string selectString = "Select BasePrice, CustomerId " +
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
                    tot = new PackageTotal();
                    
                    tot.BasePrice = (decimal)reader["BasePrice"];
                    tot.CustomerId = (int)reader["CustomerId"];
                    totals.Add(tot);      //adding them to totals list
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
            return totals;     // returns the totals list
        }
    }
}