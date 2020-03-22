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
        /// Method that returns the selected employee from the employee table
        /// </summary>
        /// <param name="name">first name last name of the employee</param>
        /// <param name="phone">phone number of the employee</param>
        /// <param name="customerid">employee id of the employee</param>
        /// <returns>Employee object</returns>
        public Employee GetEmployee(string name, string phone, int employeeid)
        {
            Employee employee = null;

            string sqlStatement = "SELECT employee_id, first_name, middle_name, last_name, sex, " +
                "date_of_birth, phone_number, address1, address2, city, state, zipcode, username, password, status FROM employee ";

            if (name != null && name.Length > 0)
            {
                sqlStatement += "where concat(first_name, ' ', last_name) = @Name";
            }
            else if (phone != null && phone.Length > 0)
            {
                sqlStatement += "where phone_number = @Phone";
            }
            else if (employeeid > 0)
            {
                sqlStatement += "where employee_id = @EmployeeID";
            }

            using (SqlConnection connection = FurnitureRentalsDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(sqlStatement, connection))
                {
                    if (name != null && name.Length > 0)
                    {
                        selectCommand.Parameters.AddWithValue("@Name", name);
                    }
                    else if (phone != null && phone.Length > 0)
                    {
                        selectCommand.Parameters.AddWithValue("@Phone", phone);
                    }
                    else if (employeeid > 0)
                    {
                        selectCommand.Parameters.AddWithValue("@EmployeeID", employeeid);
                    }

                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            employee = new Employee();
                            employee.EmployeeID = Convert.ToInt32(reader["employee_id"].ToString());
                            employee.FirstName = reader["first_name"].ToString();
                            employee.MiddleName = reader["middle_name"].ToString();
                            employee.LastName = reader["last_name"].ToString();
                            employee.Sex = reader["sex"].ToString();
                            employee.PostalCode = reader["phone_number"].ToString();
                            employee.Address1 = reader["address1"].ToString();
                            employee.Address2 = reader["address2"].ToString();
                            employee.City = reader["city"].ToString();
                            employee.State = reader["state"].ToString();
                            employee.PostalCode = reader["zipcode"].ToString();
                            employee.DateOfBirth = (DateTime)reader["date_of_birth"];
                            employee.UserName = reader["username"].ToString();
                            employee.Password = reader["password"].ToString();
                            employee.Status = reader["status"].ToString();
                        }
                    }
                }
            }

            return employee;
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

