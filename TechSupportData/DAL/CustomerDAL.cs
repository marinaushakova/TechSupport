using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechSupportData.Model;

namespace TechSupportData.DAL
{
    public static class CustomerDAL
    {
        public static List<Customer> GetCustomers()
        {
            List<Customer> customerList = new List<Customer>();
            SqlConnection connection = TechSupportDBConnection.GetConnection();
            string selectStatement =
                "SELECT CustomerID, Name " +
                "FROM Customers " +
                "ORDER BY Name";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            //SqlDataReader reader = null;

            try
            {
                connection.Open();
                SqlDataReader reader = selectCommand.ExecuteReader();
                while (reader.Read())
                {
                    Customer customer = new Customer();
                   
                    customer.CustomerID = (int)reader["CustomerID"];
                    customer.Name = reader["Name"].ToString();

                    customerList.Add(customer);
                    
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
                //if (connection != null)
               //     connection.Close();
               // if (reader != null)
                //    reader.Close();
            }
            
            return customerList;
        }

    }
}
