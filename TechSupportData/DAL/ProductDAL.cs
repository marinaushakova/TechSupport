using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechSupportData.Model;

namespace TechSupportData.DAL
{
    /// <summary>
    /// This the DAL class that deals with products.
    /// </summary>
    public static class ProductDAL
    {
        /// <summary>
        /// This method returns a list of all products stored in the DB
        /// </summary>
        /// <returns>List of all products</returns>
        public static List<Product> GetProductList() {
            List<Product> productList = new List<Product>();
            SqlConnection connection = TechSupportDBConnection.GetConnection();
            string selectStatement =
                "SELECT ProductCode, Name " +
                "FROM Products " +
                "ORDER BY Name";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            SqlDataReader reader = null;
            try
            {
                connection.Open();
                reader = selectCommand.ExecuteReader();
                while (reader.Read())
                {
                    Product product = new Product();
                    product.ProductCode = reader["ProductCode"].ToString();
                    product.Name = reader["Name"].ToString();
                    productList.Add(product);
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                if (connection != null)
                    connection.Close();
                if (reader != null)
                    reader.Close();
            }

            return productList;
        }
    }
}
