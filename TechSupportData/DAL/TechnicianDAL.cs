﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechSupportData.Model;

namespace TechSupportData.DAL
{
    /// <summary>
    /// This the DAL class that deals with technicians.
    /// </summary>
    public static class TechnicianDAL
    {
        /// <summary>
        /// This method returns a list of all technicians stored in the DB
        /// </summary>
        /// <returns>List of technicians</returns>
        public static List<Technician> GetTechnicians()
        {
            List<Technician> techList = new List<Technician>();
            SqlConnection connection = TechSupportDBConnection.GetConnection();
            string selectStatement =
                "SELECT TechID, Name " +
                "FROM Technicians " +
                "ORDER BY Name";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            SqlDataReader reader = null;

            try
            {
                connection.Open();
                reader = selectCommand.ExecuteReader();
                while (reader.Read())
                {
                    Technician tech = new Technician();

                    tech.TechID = (int)reader["TechID"];
                    tech.Name = reader["Name"].ToString();

                    techList.Add(tech);
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

            return techList;
        }

        /// <summary>
        /// This method returns all technicians with opened incidents
        /// </summary>
        /// <returns>List of technicians that have open incidents</returns>
        public static List<Technician> GetTechniciansWithOpenIncidents()
        {
            List<Technician> techList = new List<Technician>();
            SqlConnection connection = TechSupportDBConnection.GetConnection();
            string selectStatement =
                "SELECT t.TechID, t.Name, t.Email, t.Phone " +
                "FROM Technicians t JOIN Incidents i " +
                  "ON t.TechID = i.TechID " +
                "WHERE i.DateClosed IS NULL " +
                "GROUP BY t.TechID, t.Name, t.Email, t.Phone  " +
                "ORDER BY t.Name";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            SqlDataReader reader = null;

            try
            {
                connection.Open();
                reader = selectCommand.ExecuteReader();
                while (reader.Read())
                {
                    Technician tech = new Technician();

                    tech.TechID = (int)reader["TechID"];
                    tech.Name = reader["Name"].ToString();
                    tech.Email = reader["Email"].ToString();
                    tech.Phone = reader["Phone"].ToString();

                    techList.Add(tech);
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

            return techList;
        }
    }
}
