using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechSupportData.Model;

namespace TechSupportData.DAL
{
    public static class ProductDAL
    {
        public static List<Product> GetProductList() {
            List<Product> productList = new List<Product>();
            SqlConnection connection = TechSupportDBConnection.GetConnection();
            string selectStatement =
                "SELECT ProductCode, Name " +
                "FROM Products " +
                "ORDER BY Name";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = selectCommand.ExecuteReader();
                while (reader.Read())
                {
                    Product product = new Product();
                    product.ProductCode = reader["ProductCode"].ToString();
                    product.Name = reader["Name"].ToString();
                    productList.Add(product);
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
            return productList;
        }
    }
}
