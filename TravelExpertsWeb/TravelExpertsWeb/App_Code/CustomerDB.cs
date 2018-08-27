using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/*******************************************************
 * Author: Brian Liang
 * Date: July-2018
 * Purpose: Prop for Customer
 *******************************************************/

namespace TravelExpertsWeb.App_Code
{
    [DataObject(true)]
    public class CustomerDB
    {
        [DataObjectMethod(DataObjectMethodType.Select)]     //data object method select attribute
        public static Customer GetCustomerID(string customerEmail)
        {
            Customer cust = null;
            SqlConnection con = TravelExpertsDB.GetConnection();
            string selectStatement = "SELECT CustomerID, CustEmail " +
                                     "FROM Customers " +
                                     "WHERE CustEmail = @CustEmail";
            SqlCommand cmd = new SqlCommand(selectStatement, con);
            cmd.Parameters.AddWithValue("@CustEmail", customerEmail); // value comes from the method's argument
            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.SingleRow);
                if (reader.Read()) // found a customer
                {
                    cust = new Customer();
                    cust.CustomerId = (int)reader["CustomerID"];
                    cust.CustEmail = reader["CustEmail"].ToString();
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
            
            return cust;        //return the customer list
        }

        //Using the code below for a customer list drop down when I was initially testing the connection and trouble shooting

        //[DataObjectMethod(DataObjectMethodType.Select)]     //data object method select attribute
        //public static List<Customer> GetBooking(int CustomerID)
        //{
        //    List<Customer> bookings = new List<Customer>(); // make an empty list
        //    Customer mybooking; // reference to new state object

        //    SqlConnection connection = TravelExpertsDB.GetConnection(); // create connection

        //    // create select command
        //    string selectString = "Select Bookings.BookingID, BookingDate, TravelerCount, TripStart, TripEnd, [Description], Destination, BasePrice, CustomerId " +
        //                           "From Bookings inner join BookingDetails on Bookings.BookingId = BookingDetails.BookingId " +
        //                          "where CustomerId = @CustomerId " +
        //                          "order by CustomerId";


        //    SqlCommand selectCommand = new SqlCommand(selectString, connection);
        //    selectCommand.Parameters.AddWithValue("@CustomerId", CustomerID);
        //    try
        //    {
        //        // open connection
        //        connection.Open();
        //        // run the select command and process the results adding states to the list
        //        SqlDataReader reader = selectCommand.ExecuteReader();
        //        while (reader.Read())// process next row
        //        {
        //            mybooking = new Customer();
        //            mybooking.BookingId = (int)reader["BookingId"];
        //            mybooking.BookingDate = (DateTime)reader["BookingDate"];
        //            mybooking.TravelerCount = (double)reader["TravelerCount"];
        //            mybooking.TripStart = (DateTime)reader["TripStart"];
        //            mybooking.TripEnd = (DateTime)reader["TripEnd"];
        //            mybooking.Description = reader["Description"].ToString();
        //            mybooking.Destination = reader["Destination"].ToString();
        //            mybooking.BasePrice = (decimal)reader["BasePrice"];
        //            mybooking.CustomerId = (int)reader["CustomerId"];
        //            bookings.Add(mybooking);      //adding them to technician list
        //        }
        //        reader.Close();     // close reader
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex; // throw it to the form to handle
        //    }
        //    finally
        //    {
        //        connection.Close();     //close connection
        //    }
        //    return bookings;     // returns the technicans list
        //}
    }
}