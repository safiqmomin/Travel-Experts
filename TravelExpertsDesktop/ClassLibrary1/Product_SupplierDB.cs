using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/***************************************************************
* Author : Robert Clements & Safiq
* Date : 26th July, 2018
* Purpose: Connectes to travel experts database to access the Product suuplier table.
***************************************************************/

namespace TravelExpertsLibrary
{
    public class Product_SupplierDB
    {
        /// <summary>
        /// function to get data from Product_Supplier table
        /// </summary>
        /// <param name="ProdcutSupplierID"></param>
        /// <returns> list of product_supplier </returns>
        public static List<Product_Supplier> GetProduct_Supplier()
        {
            List<Product_Supplier> productSuppliers = new List<Product_Supplier>(); //holds list of product_supplier objects
            Product_Supplier ps;
            SqlConnection con = TravelExpertsDB.GetConnection();
            string selectStatement = "SELECT ProductSupplierID, ProdName, SupName, ps.ProductID, ps.SupplierID " +
                                     "FROM Products_Suppliers ps " +
                                     "INNER JOIN Products p ON ps.ProductID = p.ProductID " +
                                     "INNER JOIN Suppliers s ON ps.SupplierID = s.SupplierID " +
                                     "ORDER BY ProductSupplierID";
            SqlCommand cmd = new SqlCommand(selectStatement, con);
            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read()) //reads until nothing left to read
                {
                    ps = new Product_Supplier();
                    ps.ProductSupplierID = (int)reader["ProductSupplierID"];
                    ps.ProductID = (int)reader["ProductID"];
                    ps.SupplierID = (int)reader["SupplierID"];
                    ps.ProdName = reader["ProdName"].ToString();
                    ps.SupName = reader["SupName"].ToString();
                    productSuppliers.Add(ps); //adds product_supplier to list
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
            return productSuppliers;
        }

        /// <summary>
        /// function update the product supplier table
        /// </summary>
        /// <param name="oldProduct_Supplier"></param>
        /// <param name="newProduct_Supplier"></param>
        /// <returns> true or false value, true if count is greater than 1 menaing more than 1 row was affected</returns>
        public static bool UpdateProduct_Supplier(Product_Supplier oldProduct_Supplier, Product_Supplier newProduct_Supplier)
        {
            SqlConnection con = TravelExpertsDB.GetConnection();
            string updateStatement = "UPDATE Products_Suppliers " +
                                "SET ProductID = @newProductID, " +
                                "SupplierID = @newSupplierID " +
                                "WHERE ProductSupplierID = @oldProductSupplierID " +
                                "AND ProductID = @oldProductID " +
                                "AND SupplierID = @oldSupplierID ";
            SqlCommand cmd = new SqlCommand(updateStatement, con);
            //new value to be entered
            cmd.Parameters.AddWithValue("@newProductID", newProduct_Supplier.ProductID); 
            cmd.Parameters.AddWithValue("@newSupplierID", newProduct_Supplier.SupplierID);
            //start adding old product supplier values
            cmd.Parameters.AddWithValue("@oldProductSupplierID", oldProduct_Supplier.ProductSupplierID);
            cmd.Parameters.AddWithValue("@oldProductID", oldProduct_Supplier.ProductID);
            cmd.Parameters.AddWithValue("@oldSupplierID", oldProduct_Supplier.SupplierID);

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

        public static bool UpdateProduct_Supplier_Packages(Packages_Products_Suppliers oldProduct_Supplier, Product_Supplier newProduct_Supplier)
        {
            SqlConnection con = TravelExpertsDB.GetConnection();
            string updateStatement = "UPDATE Products_Suppliers " +
                                "SET ProductID = @newProductID, " +
                                "SupplierID = @newSupplierID " +
                                "WHERE ProductSupplierID = @oldProductSupplierID " +
                                "AND ProductID = @oldProductID " +
                                "AND SupplierID = @oldSupplierID ";
            SqlCommand cmd = new SqlCommand(updateStatement, con);
            //new value to be entered
            cmd.Parameters.AddWithValue("@newProductID", newProduct_Supplier.ProductID);
            cmd.Parameters.AddWithValue("@newSupplierID", newProduct_Supplier.SupplierID);
            //start adding old product supplier values
            cmd.Parameters.AddWithValue("@oldProductSupplierID", oldProduct_Supplier.ProductSupplerID);
            cmd.Parameters.AddWithValue("@oldProductID", oldProduct_Supplier.ProductID);
            cmd.Parameters.AddWithValue("@oldSupplierID", oldProduct_Supplier.SupplierID);

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

        /// <summary>
        /// function is used to delete the data from Product_supplier table
        /// </summary>
        /// <param name="PS"></param>
        /// <returns> true or false value, true if count is greater than 1 menaing more than 1 row was affected </returns>
        public static bool DeleteProduct_Supplier(Product_Supplier productSupplier)
        {
            SqlConnection con = TravelExpertsDB.GetConnection();
            string deleteStatement = "DELETE FROM Products_Suppliers WHERE ProductSupplierID = @ProductSupplierID " +
                                        "AND ProductID=@ProductID " +
                                        "AND SupplierID=@SupplierID";
            SqlCommand cmd = new SqlCommand(deleteStatement, con);
            //values to be deleted
            cmd.Parameters.AddWithValue("@ProductSupplierID", productSupplier.ProductSupplierID);
            cmd.Parameters.AddWithValue("@ProductID", productSupplier.ProductID);
            cmd.Parameters.AddWithValue("@SupplierID", productSupplier.SupplierID);
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

        /// <summary>
        /// function is used to add data to Product_Supplier table
        /// </summary>
        /// <param name="PS"></param>
        /// <returns> product supplier id</returns>
        public static int AddProduct_Supplier(Product_Supplier productSupplier)
        {
            int productSupplierID;//holds value of product supplier id
            SqlConnection con = TravelExpertsDB.GetConnection();
            string insertStatement = "INSERT INTO Products_Suppliers (ProductID, SupplierID) " +
                                        "VALUES (@ProductID, @SupplierID)";
            SqlCommand cmd = new SqlCommand(insertStatement, con);
            //values to be added
            cmd.Parameters.AddWithValue("@ProductID", productSupplier.ProductID);
            cmd.Parameters.AddWithValue("@SupplierID", productSupplier.SupplierID);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                //TODO: Might not need this code below
                string selectQuery = "SELECT IDENT_CURRENT ('Products_Suppliers')";
                SqlCommand selectCmd = new SqlCommand(selectQuery, con);
                productSupplierID = Convert.ToInt32(selectCmd.ExecuteScalar());
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
            return productSupplierID;
        }
        /// <summary>
        /// gets the next product supplier id when user is adding a new supplier
        /// </summary>
        /// <returns> product supplier id to dispaly for the user to see what the id is for the new info they are entering</returns>
        public static int GetNextProductSupplierID()
        {
            int productSupplier;
            SqlConnection con = TravelExpertsDB.GetConnection();
            //selects the current indentity and then adds the identity increment for the table
            string selectQuery = "SELECT IDENT_CURRENT('Products_Suppliers') + IDENT_INCR('Products_Suppliers')";
            SqlCommand selectCmd = new SqlCommand(selectQuery, con);
            try
            {
                con.Open();
                productSupplier = Convert.ToInt32(selectCmd.ExecuteScalar());
                return productSupplier;
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
