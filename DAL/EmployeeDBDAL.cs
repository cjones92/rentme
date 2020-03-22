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
    /// DAL class responsible for interacting with the Employee table of the FurnitureRentals database
    /// </summary>
    public class EmployeeDBDAL
    {
        /// <summary>
        /// Verifies that an employee's login credentials are in the database
        /// </summary>
        /// <param name="userName">Employee's username</param>
        /// <param name="password">Employee's password</param>
        /// <returns>whether credentials are valid</returns>
        public bool CheckPassword(string userName, string password)
        {
            int foundLogins = 0;
            var convertedPassword = System.Text.Encoding.UTF8.GetBytes(password);
            string encodedPassword = System.Convert.ToBase64String(convertedPassword);



            string selectStatement = "SELECT COUNT(*) AS Login FROM employee WHERE username = @UserName AND password = @Password";


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

        /// <summary>
        /// Adds a new employee to the Employee table of the RentMe database using a parameterized query.
        /// </summary>
        /// <param name="employee">Employee object with required properties added to the DB</param>
        public static bool RegisterEmployee(Employee employee)
        {

            using (SqlConnection connection = FurnitureRentalsDBConnection.GetConnection())
            {
                string insertStatement =
               "INSERT INTO employee " +
                "(first_name, middle_name, last_name, sex, date_of_birth, address1, address2, " +
                "city, state, zipcode, phone_number, username, password, status) " +
                "VALUES (@first_name, @middle_name, @last_name, @sex, @date_of_birth, @address1, " +
                "@address2, @city, @state, @zipcode, @phone_number, @username, @password, @status)";


                connection.Open();

                using (SqlCommand insertCommand = new SqlCommand(insertStatement, connection))
                {
                    insertCommand.Parameters.AddWithValue("@first_name", employee.FirstName);
                    insertCommand.Parameters.AddWithValue("@middle_name", employee.MiddleName);
                    insertCommand.Parameters.AddWithValue("@last_name", employee.LastName);
                    insertCommand.Parameters.AddWithValue("@sex", employee.Sex);
                    insertCommand.Parameters.AddWithValue("@date_of_birth", employee.DateOfBirth);
                    insertCommand.Parameters.AddWithValue("@address1", employee.Address1);
                    insertCommand.Parameters.AddWithValue("@address2", employee.Address2);
                    insertCommand.Parameters.AddWithValue("@city", employee.City);
                    insertCommand.Parameters.AddWithValue("@state", employee.State);
                    insertCommand.Parameters.AddWithValue("@zipcode", employee.PostalCode);
                    insertCommand.Parameters.AddWithValue("@phone_number", employee.Phone);
                    insertCommand.Parameters.AddWithValue("@username", employee.UserName);
                    insertCommand.Parameters.AddWithValue("@password", employee.Password);
                    insertCommand.Parameters.AddWithValue("@status", employee.Status);

                    insertCommand.ExecuteNonQuery();
                    return true;
                }
            }
        }

    }

}

