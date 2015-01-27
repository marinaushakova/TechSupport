using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechSupportData.Model;

namespace TechSupportData.DAL
{
    public class IncidentDAL
    {
         public static List<Incident> GetOpenIncidents()
        {
            List<Incident> invoiceList = new List<Incident>();
            SqlConnection connection = TechSupportDBConnection.GetConnection();
            string selectStatement =
                "SELECT InvoiceNumber, InvoiceDate, InvoiceTotal, " +
                "PaymentTotal, CreditTotal, DueDate " +
                "FROM Invoices " +
                "WHERE InvoiceTotal - PaymentTotal - CreditTotal > 0 " +
                "ORDER BY DueDate";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            SqlDataReader reader = null;

            try
            {
                connection.Open();
                reader = selectCommand.ExecuteReader();
                while (reader.Read())
                {
                    Incident incident = new Incident();
                    incident.IncidentID = (int)reader["IncidentID"];
                    incident.CustomerID = (int)reader["CustomerID"];
                    incident.ProductCode = (string)reader["ProductCode"];
                    incident.TechID = (int?)reader["TechID"];
                    incident.DateOpened = (DateTime)reader["DateOpened"];
                    incident.DateClosed = (DateTime)reader["DateClosed"];
                    incident.Title = (string)reader["Title"];
                    incident.Description = (string)reader["Description"];
                    invoiceList.Add(incident);
                }
                reader.Close();
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
            return invoiceList;
         }
    }
}
