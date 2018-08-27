using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*******************************************************
 * Author: Brian Liang 
 * Date: July-2018
 * Purpose: Connection to the travel experts database
 *******************************************************/

namespace TravelExpertsWeb

{
    public static class TravelExpertsDB
    {
        public static SqlConnection GetConnection()
        {
            // get connection string from Web.config
            string connString = ConfigurationManager.ConnectionStrings["TravelExpertsConnectionString"].ConnectionString;   //connection string
            SqlConnection conn = new SqlConnection(connString);     //sqlconnection object
            return conn;    //returns the connection object
        }
    }
}
