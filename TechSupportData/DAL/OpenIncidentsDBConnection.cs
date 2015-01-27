using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace TechSupportData.DAL
{
    class OpenIncidentsDBConnection
    {
        public static SqlConnection GetConnection()
        {
            string connectionString =
                "Data Source=(local);Initial Catalog=OpenIncidents;" +
                "Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
    }
}
