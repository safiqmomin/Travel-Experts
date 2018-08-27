using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/***************************************************************
* Author : Robert Clements
* Date : 26th July, 2018
* Purpose: Connectes to travel experts database to access the packages products suppliers table.
***************************************************************/
namespace TravelExpertsLibrary
{
    public class Packages_Products_SuppliersDB
    {
        /// <summary>
        /// gets product name and supplier name for certain package id
        /// joins products suppliuer and pakcages product suppliers to match the product and supplier id to a package id
        /// joins the package supplier to the supplier and product table to match a package id and supplier id with a package name and supplier name
        /// </summary>
        /// <param name="package"></param>
        /// <returns> list of produt name and supplier name</returns>
        public static List<Packages_Products_Suppliers> GetAllPackagesProductsSuppliers(Package package)
        {
            List<Packages_Products_Suppliers> packProdSups = new List<Packages_Products_Suppliers>();
            Packages_Products_Suppliers packProdSup = null;
            SqlConnection con = TravelExpertsDB.GetConnection();
            string selectStatement = "SELECT p.ProdName, s.SupName, pps.ProductSupplierID, ps.ProductID, ps.SupplierID " +
                                     "FROM Packages_Products_Suppliers pps " +
                                     "INNER JOIN Products_Suppliers ps ON pps.ProductSupplierID = ps.ProductSupplierID " +
                                     "INNER JOIN Products p ON ps.ProductID = p.ProductID " +
                                     "INNER JOIN Suppliers s ON ps.SupplierID = s.SupplierID " +
                                     "WHERE PackageID = @PackageID";
            SqlCommand cmd = new SqlCommand(selectStatement, con);
            cmd.Parameters.AddWithValue("@PackageID", package.PackageId);
            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read()) //while there is still data to be read
                {
                    packProdSup = new Packages_Products_Suppliers();
                    packProdSup.ProductSupplerID = (int)reader["ProductSupplierID"];
                    packProdSup.ProductID = (int)reader["ProductID"];
                    packProdSup.SupplierID = (int)reader["SupplierID"];
                    packProdSup.ProdName = reader["ProdName"].ToString();
                    packProdSup.SupName = reader["SupName"].ToString();
                    packProdSups.Add(packProdSup); // add package products supplier object to the list
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
            return packProdSups; //list to be returned
        }
        /// <summary>
        /// adds row to package prodcut supplier connecting product and supplier info for a certain package
        /// takes both a product supplier object and package object
        /// </summary>
        /// <param name="productSupplier"></param>
        /// <param name="package"></param>
        public static void Add(Product_Supplier productSupplier, Package package)
        {
            SqlConnection con = TravelExpertsDB.GetConnection();
            string insertStatement = "INSERT INTO Packages_Products_Suppliers (PackageID, ProductSupplierID) " +
                                        "VALUES (@PackageID, @ProductSupplierID)";
            SqlCommand cmd = new SqlCommand(insertStatement, con);
            cmd.Parameters.AddWithValue("@PackageID", package.PackageId);
            cmd.Parameters.AddWithValue("@ProductSupplierID", productSupplier.ProductSupplierID);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
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
        public static bool Delete(Packages_Products_Suppliers packProdSup,Package package)
        {

            SqlConnection con = TravelExpertsDB.GetConnection();
            string insertStatement = "DELETE FROM Packages_Products_Suppliers " +
                                     "WHERE PackageID = @PackageID " +
                                     "AND ProductSupplierID = @ProductSupplierID";
            SqlCommand cmd = new SqlCommand(insertStatement, con);
            cmd.Parameters.AddWithValue("@PackageID", package.PackageId);
            cmd.Parameters.AddWithValue("@ProductSupplierID", packProdSup.ProductSupplerID);
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
    }
}
