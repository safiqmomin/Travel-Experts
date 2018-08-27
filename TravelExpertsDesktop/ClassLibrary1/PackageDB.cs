using System;
using System.Collections.Generic;
using System.Data.SqlClient;
/***************************************************************
* Author : Robert Clements & Brain Lang
* Date : 21th July, 2018
* Purpose: used to access the package table in the travel expert database
***************************************************************/
namespace TravelExpertsLibrary
{
    public static class PackageDB
    {
        /// <summary>
        /// gets all the information from the package table
        /// </summary>
        /// <returns> list of package objects </returns>
        public static List<Package> GetPackage()
        {
            List<Package> packages = new List<Package>();
            Package pack = null;
            SqlConnection con = TravelExpertsDB.GetConnection();
            string selectStatement = "SELECT PackageID, PkgName, PkgStartDate, PkgEndDate, PkgDesc, PkgBasePrice, PkgAgencyCommission " +
                                     "FROM Packages";
            SqlCommand cmd = new SqlCommand(selectStatement, con);
            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read()) // reads while still info in database
                {
                    pack = new Package();
                    pack.PackageId = (int)reader["PackageID"];
                    pack.PkgName = reader["PkgName"].ToString();
                    pack.PkgStartDate = (DateTime)reader["PkgStartDate"];
                    pack.PkgEndDate = (DateTime)reader["PkgEndDate"];
                    pack.PkgDesc = reader["PkgDesc"].ToString();
                    pack.PkgBasePrice = Convert.ToDouble(reader["PkgBasePrice"]);
                    pack.PkgAgencyCommission = Convert.ToDouble(reader["PkgAgencyCommission"]);
                    packages.Add(pack); //adds package object to packages list
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
            return packages; //list of package objects 
        }
        /// <summary>
        /// used to deleted a user selected packagefrom the database
        /// </summary>
        /// <param name="package"></param>
        /// <returns> true or false, true if count is greater than 1 menaing more than one row in the database was affected</returns>
        public static bool DeletePackage(Package package)
        {
            SqlConnection con = TravelExpertsDB.GetConnection();
            string deleteStatement = "Delete FROM Packages " +
                                     "WHERE PackageId = @PackageId " +
                                     "AND PkgName = @PkgName " +
                                     "AND PkgStartDate = @PkgStartDate " +
                                     "AND PkgEndDate = @PkgEndDate " +
                                     "AND PkgDesc = @PkgDesc " +
                                     "AND PkgBasePrice = @PkgBasePrice " +
                                     "AND PkgAgencyCommission = @PkgAgencyCommission";
            SqlCommand cmd = new SqlCommand(deleteStatement, con);
            //add values to use to find the right value to delete
            cmd.Parameters.AddWithValue("@PackageId", package.PackageId);
            cmd.Parameters.AddWithValue("@PkgName", package.PkgName);
            cmd.Parameters.AddWithValue("@PkgStartDate", package.PkgStartDate);
            cmd.Parameters.AddWithValue("@PkgEndDate", package.PkgEndDate);
            cmd.Parameters.AddWithValue("@PkgDesc", package.PkgDesc);
            cmd.Parameters.AddWithValue("@PkgBasePrice", package.PkgBasePrice);
            cmd.Parameters.AddWithValue("@PkgAgencyCommission", package.PkgAgencyCommission);
            try
            {
                con.Open();
                int count = cmd.ExecuteNonQuery();// returns int for rows affected
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
        /// <summary>
        /// inserts a new package into the database
        /// </summary>
        /// <param name="package"></param>
        /// <returns> package id for the new item</returns>
        public static int AddPackage(Package package)
        {
            int packageID;//new package id
            SqlConnection con = TravelExpertsDB.GetConnection();
            string insertStatement = "INSERT INTO Packages (PkgName, PkgStartDate, PkgEndDate, PkgDesc, PkgBasePrice, PkgAgencyCommission) " +
                                        "VALUES(@PkgName, @PkgStartDate, @PkgEndDate, @PkgDesc, @PkgBasePrice, @PkgAgencyCommission)";
            SqlCommand cmd = new SqlCommand(insertStatement, con);
            //adding values to be inserted
            cmd.Parameters.AddWithValue("@PkgName", package.PkgName);
            cmd.Parameters.AddWithValue("@PkgStartDate", package.PkgStartDate);
            cmd.Parameters.AddWithValue("@PkgEndDate", package.PkgEndDate);
            cmd.Parameters.AddWithValue("@PkgDesc", package.PkgDesc);
            cmd.Parameters.AddWithValue("@PkgBasePrice", package.PkgBasePrice);
            cmd.Parameters.AddWithValue("@PkgAgencyCommission", package.PkgAgencyCommission);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                //TODO: might not need this code below
                String selectQuery = "SELECT IDENT_CURRENT('Packages')";
                SqlCommand selectCmd = new SqlCommand(selectQuery, con);
                packageID = Convert.ToInt32(selectCmd.ExecuteScalar());
                //
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
            return packageID;
        }
        /// <summary>
        /// gets the value of the new auto generated package id
        /// </summary>
        /// <returns> new supplier id</returns>
        public static int GetNextPackageID()
        {
            int supplierID;//supplier id auto generated
            SqlConnection con = TravelExpertsDB.GetConnection();
            string selectQuery = "SELECT IDENT_CURRENT('Packages') + IDENT_INCR('Packages')";
            SqlCommand selectCmd = new SqlCommand(selectQuery, con);
            try
            {
                con.Open();
                supplierID = Convert.ToInt32(selectCmd.ExecuteScalar());
                return supplierID;
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
        /// updates a package with new info user inputs 
        /// </summary>
        /// <param name="oldPackage"></param>
        /// <param name="newPackage"></param>
        /// <returns> true or false, true if number of rows affected are greated than 0 menaing update was succesful</returns>
        public static bool UpdatePackages(Package oldPackage, Package newPackage)
        {
            SqlConnection con = TravelExpertsDB.GetConnection();
            string updateStatement = "UPDATE Packages " +
                                     "SET PkgName = @NewPkgName, " +
                                     "PkgStartDate = @NewPkgStartDate, " +
                                     "PkgEndDate = @NewPkgEndDate, " +
                                     "PkgDesc = @NewPkgDesc, " +
                                     "PkgBasePrice = @NewPkgBasePrice, " +
                                     "PkgAgencyCommission = @NewPkgAgencyCommission " +
                                     "WHERE PackageID = @OldPackageID " +
                                     "AND PkgName = @OldPkgName " +
                                     "AND PkgStartDate = @OldPkgStartDate " +
                                     "AND PkgEndDate = @OldPkgEndDate " +
                                     "AND PkgDesc = @OldPkgDesc " +
                                     "AND PkgBasePrice = @OldPkgBasePrice " +
                                     "AND PkgAgencyCommission = @OldPkgAgencyCommission";
            SqlCommand cmd = new SqlCommand(updateStatement, con);
            cmd.Parameters.AddWithValue("@NewPkgName", newPackage.PkgName);
            cmd.Parameters.AddWithValue("@NewPkgStartDate", newPackage.PkgStartDate);
            cmd.Parameters.AddWithValue("@NewPkgEndDate", newPackage.PkgEndDate);
            cmd.Parameters.AddWithValue("@NewPkgDesc", newPackage.PkgDesc);
            cmd.Parameters.AddWithValue("@NewPkgBasePrice", newPackage.PkgBasePrice);
            cmd.Parameters.AddWithValue("@NewPkgAgencyCommission", newPackage.PkgAgencyCommission);
            //start adding values of old package
            cmd.Parameters.AddWithValue("@OldPackageId", oldPackage.PackageId);
            cmd.Parameters.AddWithValue("@OldPkgName", oldPackage.PkgName);
            cmd.Parameters.AddWithValue("@OldPkgStartDate", oldPackage.PkgStartDate);
            cmd.Parameters.AddWithValue("@OldPkgEndDate", oldPackage.PkgEndDate);
            cmd.Parameters.AddWithValue("@OldPkgDesc", oldPackage.PkgDesc);
            cmd.Parameters.AddWithValue("@OldPkgBasePrice", oldPackage.PkgBasePrice);
            cmd.Parameters.AddWithValue("@OldPkgAgencyCommission", oldPackage.PkgAgencyCommission);
            try
            {
                con.Open();
                int count = cmd.ExecuteNonQuery();
                if (count > 0) return true;
                else return false;
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
    }//end of class       
}//end of namespace
