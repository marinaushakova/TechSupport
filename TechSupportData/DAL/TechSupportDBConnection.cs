using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace TechSupportData.DAL
{
    /// <summary>
    /// Provides connectionto the database.
    /// </summary>
    public class TechSupportDBConnection
    {
        public static SqlConnection GetConnection()
        {
            string connectionString =
                "Data Source=(local);Initial Catalog=TechSupport;" +
                "Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
    }
}
