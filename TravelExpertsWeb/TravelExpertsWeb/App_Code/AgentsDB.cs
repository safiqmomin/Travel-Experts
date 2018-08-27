using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
/*************************************************************
 * Author: Sneha Patel(000783907)
 * Date: 29-July-2018
 * Purpose: Data Access class AgentsDB for Data Object method 
 ************************************************************/
namespace TravelExpertsWeb.App_Code
{
    [DataObject(true)]
    public class AgentsDB
    {
        [DataObjectMethod(DataObjectMethodType.Select)]     //data object method select attribute
        public static List<Agents> GetAgencyOneAgents()
        {
            List<Agents> agents = new List<Agents>(); // make an empty list
            Agents agt; // reference to new state object

            SqlConnection connection = TravelExpertsDB.GetConnection(); // create connection

            // create select command
            string selectString = "Select AgentId, AgtFirstName, AgtMiddleInitial, AgtLastName, AgtBusPhone, AgtEmail, AgtPosition " +
                                   "from Agents " +
                                   "where AgencyId = 1" +
                                   "order by AgentId";

            SqlCommand selectCommand = new SqlCommand(selectString, connection);
            try
            {
                // open connection
                connection.Open();
                // run the select command and process the results adding states to the list
                SqlDataReader reader = selectCommand.ExecuteReader();
                while (reader.Read())// process next row
                {
                    agt = new Agents();
                    agt.AgentId = (int)reader["AgentId"];
                    agt.AgtFirstName = reader["AgtFirstName"].ToString();
                    agt.AgtMiddleInitial = reader["AgtMiddleInitial"].ToString();
                    agt.AgtLastName = reader["AgtLastName"].ToString();
                    agt.AgtBusPhone = reader["AgtBusPhone"].ToString();
                    agt.AgtEmail = reader["AgtEmail"].ToString();
                    agt.AgtPosition = reader["AgtPosition"].ToString();
                    agents.Add(agt);      //adding them to technician list
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
            return agents;     // returns the technicans list
        }

        [DataObjectMethod(DataObjectMethodType.Select)]     //data object method select attribute
        public static List<Agents> GetAgencyTwoAgents()
        {
            List<Agents> agents = new List<Agents>(); // make an empty list
            Agents agt; // reference to new state object

            SqlConnection connection = TravelExpertsDB.GetConnection(); // create connection

            // create select command
            string selectString = "Select AgentId, AgtFirstName, AgtMiddleInitial, AgtLastName, AgtBusPhone, AgtEmail, AgtPosition " +
                                   "from Agents " +
                                   "where AgencyId = 2" +
                                   "order by AgentId";

            SqlCommand selectCommand = new SqlCommand(selectString, connection);
            try
            {
                // open connection
                connection.Open();
                // run the select command and process the results adding states to the list
                SqlDataReader reader = selectCommand.ExecuteReader();
                while (reader.Read())// process next row
                {
                    agt = new Agents();
                    agt.AgentId = (int)reader["AgentId"];
                    agt.AgtFirstName = reader["AgtFirstName"].ToString();
                    agt.AgtMiddleInitial = reader["AgtMiddleInitial"].ToString();
                    agt.AgtLastName = reader["AgtLastName"].ToString();
                    agt.AgtBusPhone = reader["AgtBusPhone"].ToString();
                    agt.AgtEmail = reader["AgtEmail"].ToString();
                    agt.AgtPosition = reader["AgtPosition"].ToString();
                    agents.Add(agt);      //adding them to technician list
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
            return agents;     // returns the technicans list
        }
    }
}