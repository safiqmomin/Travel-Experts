using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/*******************************************************
 * Author: Brian Liang
 * Date: July-2018
 * Purpose: Accessor for Package Database
 *******************************************************/
namespace TravelExpertsWeb.App_Code
{
    [DataObject(true)]
    public class PackageDB
    {
        [DataObjectMethod(DataObjectMethodType.Select)]     //data object method select attribute
        public static List<Package> GetPackage()
        {
            List<Package> packages = new List<Package>(); // make an empty list
            Package pkg; // reference to new state object

            SqlConnection connection = TravelExpertsDB.GetConnection(); // create connection

            // create select command
            string selectString = "Select PackageId, PkgName, PkgStartDate, PkgEndDate, PkgDesc, PkgBasePrice " +
                                   "from Packages " +
                                  "order by PackageId";


            SqlCommand selectCommand = new SqlCommand(selectString, connection);
            try
            {
                // open connection
                connection.Open();
                // run the select command and process the results adding states to the list
                SqlDataReader reader = selectCommand.ExecuteReader();
                while (reader.Read())// process next row
                {
                    pkg = new Package();
                    pkg.PackageId = (int)reader["PackageId"];
                    pkg.PkgName = reader["PkgName"].ToString();
                    pkg.PkgStartDate = (DateTime)reader["PkgStartDate"];
                    pkg.PkgEndDate = (DateTime)reader["PkgEndDate"];
                    pkg.PkgDesc = reader["PkgDesc"].ToString();
                    pkg.PkgBasePrice = (decimal)reader["PkgBasePrice"];

                    packages.Add(pkg);      //adding them to package list
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
            return packages;     // returns the packages list
        }
    }
}