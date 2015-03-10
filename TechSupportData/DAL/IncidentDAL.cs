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
    /// This the DAL class that deals with incidents.
    /// </summary>
    public class IncidentDAL
    {
        /// <summary>
        /// This method returns a list of all open incidents
        /// </summary>
        /// <returns>List of open incidents</returns>
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

        /// <summary>
        /// This method adds a new incident to the Incidents table
        /// </summary>
        /// <param name="incident">Incident object that is being added to the DB</param>
         public static void AddIncident(Incident incident)
         {
             SqlConnection connection = TechSupportDBConnection.GetConnection();
             string insertStatement =
                 "INSERT Incidents " +
                 "(CustomerID, ProductCode, TechID, DateOpened, DateClosed, Title, Description) " +
                 "VALUES (@CustomerID, @ProductCode, @TechID, @DateOpened, @DateClosed, @Title, @Description)";
             
             SqlCommand insertCommand = new SqlCommand(insertStatement, connection);
             insertCommand.Parameters.AddWithValue("@CustomerID", incident.CustomerID);
             insertCommand.Parameters.AddWithValue("@ProductCode", incident.ProductCode);
             insertCommand.Parameters.AddWithValue("@TechID", DBNull.Value);
             insertCommand.Parameters.AddWithValue("@DateOpened", incident.DateOpened);
             insertCommand.Parameters.AddWithValue("@DateClosed", DBNull.Value);
             insertCommand.Parameters.AddWithValue("@Title", incident.Title);
             insertCommand.Parameters.AddWithValue("@Description", incident.Description);

             try
             {
                 connection.Open();
                 insertCommand.ExecuteNonQuery();

             }
             catch (SqlException ex)
             {
                 throw ex;
             }
             finally
             {
                 if (connection != null)
                     connection.Close();
             }
         }

        /// <summary>
         /// This method gets an incident by its IncidentID
        /// </summary>
         /// <param name="incidentID">IncidentID of the incident that is being returned</param>
        /// <returns>An Incident object that has required IncidentID</returns>
         public static Incident GetIncident(int incidentID)
         {
             Incident incident = new Incident();
             SqlConnection connection = TechSupportDBConnection.GetConnection();
             string selectStatement =
                 "SELECT c.Name AS CustomerName, " + 
                         "p.Name AS ProductName, " +
                         "t.Name AS TechName, t.TechID AS TechID, Title, " +
                         "DateOpened, DateClosed, " +
                         "Description " +
                 "FROM Incidents i " +
                 "LEFT JOIN Technicians t ON i.TechID = t.TechID " +
                 "JOIN Customers c ON i.CustomerID = c.CustomerID " +
                 "JOIN Products p ON i.ProductCode = p.ProductCode " +
                 "WHERE IncidentID = @IncidentID";
             SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
             selectCommand.Parameters.AddWithValue("@IncidentID", incidentID);

             SqlDataReader reader = null;

             try
             {
                 connection.Open();
                 reader = selectCommand.ExecuteReader();
                 while (reader.Read())
                 {
                     incident.CustomerName = reader["CustomerName"].ToString();
                     incident.ProductName = reader["ProductName"].ToString();
                     
                     if (reader["TechID"] != System.DBNull.Value)
                     {
                         incident.TechName = reader["TechName"].ToString();
                         incident.TechID = (int)reader["TechID"];
                     }
                     else
                     {
                         incident.TechID = null;
                         incident.TechName = null;
                     }
                     
                     incident.Title = reader["Title"].ToString();
                     incident.DateOpened = (DateTime)reader["DateOpened"];

                     if (reader["DateClosed"] != System.DBNull.Value)
                     {
                         incident.DateClosed = (DateTime)reader["DateClosed"];
                     }
                     else
                     {
                         incident.DateClosed = null;
                     }

                     incident.Description = reader["Description"].ToString();
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
             return incident;
         }

         /// <summary>
         /// This method updates an incident to the Incidents table
         /// </summary>
         /// <param name="incident">Incident object that is being updated to the DB</param>
         public static bool UpdateIncident(Incident oldIncident, Incident newIncident)
         {
             SqlConnection connection = TechSupportDBConnection.GetConnection();
             string updateStatement =
                 "UPDATE Incidents " +
                 "SET TechID = @NewTechID, Description = @NewDescription " +
                 "WHERE IncidentID = @OldIncidentID AND Description = @OldDescription AND DateClosed IS NULL";

             SqlCommand updateCommand = new SqlCommand(updateStatement, connection);

             //updateCommand.Parameters.AddWithValue("@NewIncidentID", newIncident.IncidentID);
             if (newIncident.TechID != null)
             {
                updateCommand.Parameters.AddWithValue("@NewTechID", newIncident.TechID);
             }
             else
             {
                 updateCommand.Parameters.AddWithValue("@NewTechID", System.DBNull.Value);
             }
             updateCommand.Parameters.AddWithValue("@NewDescription", newIncident.Description);
             updateCommand.Parameters.AddWithValue("@OldIncidentID", oldIncident.IncidentID);
             updateCommand.Parameters.AddWithValue("@OldDescription", oldIncident.Description);

             try
             {
                 connection.Open();
                 int count = updateCommand.ExecuteNonQuery();
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
                 if (connection != null)
                     connection.Close();
             }
         }

         /// <summary>
         /// This method closes an incident - assigns current date to DateClosed
         /// </summary>
         /// <param name="incident">Incident object that is being closed</param>
         public static bool CloseIncident(Incident oldIncident, Incident newIncident)
         {
             SqlConnection connection = TechSupportDBConnection.GetConnection();
             string updateStatement =
                 "UPDATE Incidents " +
                 "SET DateClosed = @NewDateClosed " +
                 "WHERE IncidentID = @OldIncidentID AND Description = @OldDescription AND DateClosed IS NULL";

             SqlCommand updateCommand = new SqlCommand(updateStatement, connection);
             updateCommand.Parameters.AddWithValue("@OldIncidentID", oldIncident.IncidentID);
             updateCommand.Parameters.AddWithValue("@OldDescription", oldIncident.Description);
             updateCommand.Parameters.AddWithValue("@NewDateClosed", newIncident.DateClosed);

             try
             {
                 connection.Open();
                 int count = updateCommand.ExecuteNonQuery();
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
                 if (connection != null)
                     connection.Close();
             }
         }

         /// <summary>
         /// This method returns a list of all open incidents 
         /// for technician with ThechID passed as parameter
         /// </summary>
         /// <returns>List of open incidents</returns>
         public static List<Incident> GetOpenIncidentsByTechnician(int techID)
         {
             List<Incident> incidentList = new List<Incident>();
             SqlConnection connection = TechSupportDBConnection.GetConnection();
             string selectStatement =
                 "SELECT p.Name AS ProdName, DateOpened, c.Name AS CustName, Title " +
                    "FROM Incidents i " +
                      "JOIN Products p " +
                        "ON i.ProductCode = p.ProductCode " +
                      "JOIN Customers c " +
                        "ON i.CustomerID = c.CustomerID " +
                    "WHERE DateClosed IS NULL AND i.TechID = @TechID ";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            selectCommand.Parameters.AddWithValue("@TechID", techID);

             SqlDataReader reader = null;

             try
             {
                 connection.Open();
                 reader = selectCommand.ExecuteReader();
                 while (reader.Read())
                 {
                     Incident incident = new Incident();

                     incident.ProductName = reader["ProdName"].ToString();
                     incident.DateOpened = (DateTime)reader["DateOpened"];
                     incident.CustomerName = reader["CustName"].ToString();
                     incident.Title = reader["Title"].ToString();

                     incidentList.Add(incident);
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
             return incidentList;
         }
    }
}
