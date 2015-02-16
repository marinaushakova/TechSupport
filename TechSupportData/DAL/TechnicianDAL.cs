﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechSupportData.Model;

namespace TechSupportData.DAL
{
    public static class TechnicianDAL
    {
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
    }
}