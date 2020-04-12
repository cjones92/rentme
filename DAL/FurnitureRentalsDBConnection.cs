using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace FurnitureRentals.DAL
{
    /// <summary>
    /// Class initialized the db connection string
    /// </summary>
    public static class FurnitureRentalsDBConnection
    {
        /// <summary>
        /// Method that creates the DB connection to SQL Server
        /// </summary>
        /// <returns>Returns SQL connection</returns>
        public static SqlConnection GetConnection()
        {
            string connectionString =
                "Data Source=localhost;Initial Catalog=cs6232-g1;" +
                "Integrated Security=True";

            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
    }
}
