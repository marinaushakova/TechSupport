using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechSupportData.Model;

namespace TechSupportData.DAL
{
    /// This the DAL class that deals with incidents.
    public class IncidentDAL
    {
         public static List<Incident> GetOpenIncidents()
        {
            List<Incident> incidentList = new List<Incident>();
            SqlConnection connection = TechSupportDBConnection.GetConnection();
            string selectStatement =
                "SELECT ProductCode, DateOpened, DateClosed, c.Name AS CustName, " +
                "t.Name AS TechName, Title " +
                "FROM Incidents i LEFT JOIN Technicians t " +
                "ON i.TechID = t.TechID " +
                "JOIN Customers c ON i.CustomerID = c.CustomerID " +
                "WHERE DateClosed IS NULL " +
                "ORDER BY DateOpened";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            SqlDataReader reader = null;

            try
            {
                connection.Open();
                reader = selectCommand.ExecuteReader();
                while (reader.Read())
                {
                    Incident incident = new Incident();

                    incident.ProductCode = reader["ProductCode"].ToString();
                    incident.DateOpened = (DateTime)reader["DateOpened"];

                    DateTime? dateClosed = null;
                    if (reader["DateClosed"] != System.DBNull.Value)
                    {
                        dateClosed = (DateTime)reader["DateClosed"];
                    }
                    else
                    {
                        dateClosed = null;
                    }
                    
                    incident.CustomerName = reader["CustName"].ToString();
                    if (reader["TechName"] != System.DBNull.Value) 
                    {
                        incident.TechName = reader["TechName"].ToString();
                    }
                    else
                    {
                        incident.TechName = null;
                    }
                    incident.Title = reader["Title"].ToString();
                    
                    incidentList.Add(incident);
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
            return incidentList;
         }
    }
}
