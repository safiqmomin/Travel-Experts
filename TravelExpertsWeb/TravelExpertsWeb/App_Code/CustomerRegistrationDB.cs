using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace TravelExpertsWeb.App_Code
{
    public static class CustomerRegistrationDB
    {
       
        /// <summary>
        /// creates a record with CustomerId and CustEmail which are mandatory
        /// </summary>
        /// <param name="register"></param>
        /// <returns></returns>
        public static int EmailRegistration(CustomerRegistration register)
        {

            SqlConnection conn = TravelExpertsDB.GetConnection();
            string sql = "INSERT INTO Customers (CustEmail) VALUES "
                        + "( @CustEmail)";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@CustEmail", register.CustEmail);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();

                String selectQuery = "select ident_current('customers') from customers";
                SqlCommand selectCmd = new SqlCommand(selectQuery, conn);
                int customerID = Convert.ToInt32(selectCmd.ExecuteScalar());
                return customerID;
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                string msg = "Insert Error:";
                msg += ex.Message;
                throw new Exception(msg);
            }
            finally
            {
                conn.Close();
            }
        }

        /// <summary>
        /// gets the customer details depending on the customer ID
        /// </summary>
        /// <param name="customerEmail"></param>
        /// <returns></returns>
        public static CustomerRegistration GetCustomers(int customerID)
        {
            SqlConnection con = TravelExpertsDB.GetConnection();
            string selectStatement = "select CustFirstName, CustLastName, CustAddress, CustCity, CustProv, CustPostal, CustCountry, CustHomePhone, CustBusPhone, CustEmail from Customers " +
                                        "where CustomerID = @CustomerID";
            SqlCommand cmd = new SqlCommand(selectStatement, con);
            cmd.Parameters.AddWithValue("@CustomerID", customerID);

            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.SingleRow);
                if (reader.Read())
                {
                    CustomerRegistration CR = new CustomerRegistration()
                    {
                        CustFirstName = reader["CustFirstName"].ToString(),
                        CustLastName = reader["CustLastName"].ToString(),
                        CustAddress = reader["CustAddress"].ToString(),
                        CustCity = reader["CustCity"].ToString(),
                        CustProv = reader["CustProv"].ToString(),
                        CustPostal = reader["CustPostal"].ToString(),
                        CustCountry = reader["CustCountry"].ToString(),
                        CustHomePhone = reader["CustHomePhone"].ToString(),
                        CustBusPhone = reader["CustBusPhone"].ToString(),
                        CustEmail = reader["CustEmail"].ToString()
                    };   

                    return CR;
                }
                else
                {
                    return null;
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
        }

        /// <summary>
        /// the function is used to update the data for the customer logged in
        /// </summary>
        /// <param name="oldCust"></param>
        /// <param name="newCust"></param>
        /// <returns></returns>
        public static bool updateCustomer(CustomerRegistration oldCust, CustomerRegistration newCust)
        {
            SqlConnection con = TravelExpertsDB.GetConnection();
            string updateStatement = "update Customers set " +
                "CustFirstName = @newCustFirstName, " +
                "CustLastName = @newCustLastName, " +
                "CustAddress = @newCustAddress, " +
                "CustCity = @newCustCity, " +
                "CustProv = @newCustProv, " +
                "CustPostal = @newCustPostal, " +
                "CustCountry = @newCustCountry, " +
                "CustHomePhone = @newCustHomePhone, " +
                "CustBusPhone = @newCustBusPhone, " +
                "CustEmail = @newCustEmail " +
                                "where CustomerID = @oldCustomerID";
            SqlCommand cmd = new SqlCommand(updateStatement, con);
            cmd.Parameters.AddWithValue("@newCustFirstName", newCust.CustFirstName);
            cmd.Parameters.AddWithValue("@newCustLastName", newCust.CustLastName);
            cmd.Parameters.AddWithValue("@newCustAddress", newCust.CustAddress);
            cmd.Parameters.AddWithValue("@newCustCity", newCust.CustCity);
            cmd.Parameters.AddWithValue("@newCustProv", newCust.CustProv);
            cmd.Parameters.AddWithValue("@newCustPostal", newCust.CustPostal);
            cmd.Parameters.AddWithValue("@newCustCountry", newCust.CustCountry);
            cmd.Parameters.AddWithValue("@newCustHomePhone", newCust.CustHomePhone);
            cmd.Parameters.AddWithValue("@newCustBusPhone", newCust.CustBusPhone);
            cmd.Parameters.AddWithValue("@newCustEmail", newCust.CustEmail);
            cmd.Parameters.AddWithValue("@oldCustomerID", oldCust.CustomerID);
            try
            {
                con.Open();
                int count = cmd.ExecuteNonQuery();
                if (count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
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
        }        
    }
}