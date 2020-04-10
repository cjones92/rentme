using FurnitureRentals.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureRentals.DAL
{
    /// <summary>
    /// DAL class responsible for interacting with the Administrator table of the FurnitureRentals database
    /// </summary>
    class AdministratorDBDAL
    {
        /// <summary>
        /// Checks validity of administrator's login credentials
        /// </summary>
        /// <param name="userName">admin user name</param>
        /// <param name="password">admin password</param>
        /// <returns>whether credentials are valid</returns>
        public Model.Administrator CheckPassword(string userName, string password)
        {
            int foundLogins = 0;
            Administrator loggedInAdministrator = new Administrator();
            var convertedPassword = System.Text.Encoding.UTF8.GetBytes(password);
            string encodedPassword = System.Convert.ToBase64String(convertedPassword);



            string selectStatement = "SELECT COUNT(*) AS Login, first_name, last_name, admin_id FROM administrator WHERE username = @UserName AND password = @Password GROUP BY first_name, last_name, admin_id";


            using (SqlConnection connection = FurnitureRentalsDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@UserName", userName);
                    selectCommand.Parameters.AddWithValue("@Password", encodedPassword);
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {


                        while (reader.Read())
                        {
                            foundLogins = (int)reader["Login"];
                            loggedInAdministrator.AdminstratorID = (int)reader["admin_id"];
                            loggedInAdministrator.FirstName = reader["first_name"].ToString();
                            loggedInAdministrator.LastName = reader["last_name"].ToString();
                        }

                    }

                }

            }
            if (foundLogins == 1)
            {
                return loggedInAdministrator;
            }
            else
            {
                return null;
            }
        }
    }
}
