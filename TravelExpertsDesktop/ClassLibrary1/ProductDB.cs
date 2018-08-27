using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/***************************************************************
* Author : Robert Clements
* Date : 26th July, 2018
* Purpose: Connectes to travel experts database to access the Product table.
***************************************************************/
namespace TravelExpertsLibrary
{
    public static class ProductDB
    {
        /// <summary>
        /// Gets list of all products from the database
        /// </summary>
        /// <returns>list of product objects </returns>
        public static List<Product> GetAllProduct()
        {
            //list to hold all of product objects
            List<Product> products = new List<Product>();
            Product prod = null;
            //create connection
            SqlConnection con = TravelExpertsDB.GetConnection();
            //SQL string to make selection
            string selectStatement = "SELECT ProductID, ProdName " +
                "FROM Products ORDER BY ProductID";
            SqlCommand cmd = new SqlCommand(selectStatement, con);
            try
            {
                //open connection
                con.Open();
                // create SQL reader 
                SqlDataReader reader = cmd.ExecuteReader();
                while(reader.Read()) // keep reading while values in table
                {
                    prod = new Product();
                    prod.ProductID = (int)reader["ProductID"];
                    prod.ProdName = reader["ProdName"].ToString();
                    products.Add(prod);
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
            //return list of products
            return products;
        }

        public static int AddProduct(Product product)
        {
            int productID; //hold productID value (might not need this)
            SqlConnection con = TravelExpertsDB.GetConnection(); //connect to database
            //SQL string to insert new product, dont need ProductID as it is Auto increment
            string insertStatement = "INSERT INTO Products (ProdName) " +
                "VALUES (@ProdName)";
            SqlCommand cmd = new SqlCommand(insertStatement, con);
            cmd.Parameters.AddWithValue("@ProdName", product.ProdName); //add value to parameter in sql string
            try
            {
                con.Open();
                cmd.ExecuteNonQuery(); //execute the insert sql string
                string selectQuery = "SELECT IDENT_CURRENT ('Products')"; //might not need this code below as i might not need to return Prodcut ID
                SqlCommand selectCmd = new SqlCommand(selectQuery, con);
                productID = Convert.ToInt32(selectCmd.ExecuteScalar());
                
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
            return productID;
        }
        /// <summary>
        /// gets the next product id from the product id column
        /// </summary>
        /// <returns>returns the value of the product id</returns>
        public static int GetNextProductID()
        {
            int productId; //holds value of product id from database
            SqlConnection con = TravelExpertsDB.GetConnection();
            string selectQuery = "SELECT IDENT_CURRENT('Products') + IDENT_INCR('Products')"; //gets the current identity for the products table and then adds the identity increment value
            SqlCommand selectCmd = new SqlCommand(selectQuery, con);
            try
            {
                con.Open();
                productId = Convert.ToInt32(selectCmd.ExecuteScalar());
                return productId;
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
        /// this is used to deleted a selected product by the user from the travel experts database
        /// </summary>
        /// <param name="product"></param>
        /// <returns> returns a true or false value, true if the count of the rows affected is greater than 1 meaning the row was deleted </returns>
        public static bool DeleteProduct(Product product)
        {
            SqlConnection con = TravelExpertsDB.GetConnection();
            string deleteStatement = "DELETE FROM Products " +
                                     "WHERE ProductID = @ProductID " +
                                     "AND ProdName = @ProdName";
            SqlCommand cmd = new SqlCommand(deleteStatement, con);
            cmd.Parameters.AddWithValue("@ProductID", product.ProductID); //product id of the user chosen value to be deleted
            cmd.Parameters.AddWithValue("@ProdName", product.ProdName); //product name of the user chosen value to be deleted
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
        /// <summary>
        /// user picks a product to be updated this methods is called and updates that product in the database
        /// </summary>
        /// <param name="oldProduct"></param>
        /// <param name="newProduct"></param>
        /// <returns> true or false value, true if count is greater than 1 meaning more than 1 row was affected</returns>
        public static bool UpdateProduct(Product oldProduct, Product newProduct)
        {
            SqlConnection con = TravelExpertsDB.GetConnection();
            string updateStatement = "UPDATE Products " +
                                     "SET ProdName = @NewProdName " +
                                     "WHERE ProductID = @OldProductID " +
                                     "AND ProdName = @OldProdName";
            SqlCommand cmd = new SqlCommand(updateStatement, con);
            cmd.Parameters.AddWithValue("@NewProdName", newProduct.ProdName); //new value entered in database 
            //start adding values of old product
            cmd.Parameters.AddWithValue("@OldProductID", oldProduct.ProductID); 
            cmd.Parameters.AddWithValue("@OldProdName", oldProduct.ProdName); //old name to be changed
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
