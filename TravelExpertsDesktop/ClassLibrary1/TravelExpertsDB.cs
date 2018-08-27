using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExpertsLibrary
{
 /***************************************************************
 * Author : Brain Lang
 * Date : 20th July, 2018
 ***************************************************************/
    public class TravelExpertsDB
    {
        /// <summary>
        /// this is used to establish the connection to the local database
        /// </summary>
        /// <returns> returns the connection </returns>
        public static SqlConnection GetConnection()
        {
            string connectionString = @"Data Source=localhost\sqlexpress;Initial Catalog=TravelExperts;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionString);
            return con;
        }
    }
}
