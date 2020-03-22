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
        public bool CheckPassword(string userName, string password)
        {
            int foundLogins = 0;
            var convertedPassword = System.Text.Encoding.UTF8.GetBytes(password);
            string encodedPassword = System.Convert.ToBase64String(convertedPassword);



            string selectStatement = "SELECT COUNT(*) AS Login FROM administrator WHERE username = @UserName AND password = @Password";


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

                        }

                    }

                }

            }
            if (foundLogins == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
