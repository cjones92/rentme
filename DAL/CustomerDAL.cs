﻿using FurnitureRentals.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FurnitureRentals.DAL
{
    /// <summary>
    /// Accesses information regarding the Customer table from the database
    /// </summary>
    class CustomerDAL
    {
        /// <summary>
        /// Method that returns the customer from customer table
        /// </summary>
        /// <param name="name">first name last name of the customer</param>
        /// <param name="phone">phone number of the customer</param>
        /// <param name="customerid">customer id of the customer</param>
        /// <returns>list of customer objects</returns>
        public List<Customer> GetCustomers(string name, string phone, int customerid)
        {
            List<Customer> customerList = new List<Customer>();

            string sqlStatement = "SELECT customer_id, first_name, middle_name, last_name, sex, " +
                "date_of_birth, phone_number, address1, address2, city, state, zipcode from customer ";

            if (name != null && name.Length > 0)
            {
                sqlStatement += "where concat(first_name, ' ', last_name) = @Name";
            }
            else if (phone != null && phone.Length > 0)
            {
                sqlStatement += "where phone_number = @Phone";
            }
            else if (customerid > 0)
            {
                sqlStatement += "where customer_id = @CustomerID";
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
                    else if (customerid > 0)
                    {
                        selectCommand.Parameters.AddWithValue("@CustomerID", customerid);
                    }

                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Customer customer = new Customer();
                            customer.CustomerId = Convert.ToInt32(reader["customer_id"].ToString());
                            customer.FirstName = reader["first_name"].ToString();
                            customer.MiddleName = reader["middle_name"].ToString();
                            customer.LastName = reader["last_name"].ToString();
                            customer.Gender = reader["sex"].ToString();
                            customer.HomePhone = reader["phone_number"].ToString();
                            customer.Address1 = reader["address1"].ToString();
                            customer.Address2 = reader["address2"].ToString();
                            customer.City = reader["city"].ToString();
                            customer.State = reader["state"].ToString();
                            customer.PostalCode = reader["zipcode"].ToString();
                            customer.DateOfBirth = (DateTime)reader["date_of_birth"];
                            customerList.Add(customer);
                        }
                    }
                }
            }

            return customerList;
        }

        /// <summary>
        /// Method that registers the customer into customer table
        /// </summary>
        /// <param name="customer">customer object</param>
        /// <returns>true if customer registered successfully</returns>
        public Boolean RegisterCustomer(Customer customer)
        {
            using (SqlConnection connection = FurnitureRentalsDBConnection.GetConnection())
            {
                string sqlStatement = "INSERT INTO CUSTOMER (first_name, middle_name, last_name, sex, " +
                "date_of_birth, phone_number, address1, address2, city, state, zipcode) " +
                "VALUES (@FirstName, @MiddleName, @LastName, @Gender, @DateOfBirth, @PhoneNumber, @Address1," +
                "@Address2, @City, @State, @PostalCode); SELECT SCOPE_IDENTITY() ";

                connection.Open();

                using (SqlCommand insertCommand = new SqlCommand(sqlStatement, connection))
                {
                    insertCommand.Connection = connection;
                    insertCommand.Parameters.AddWithValue("@FirstName", customer.FirstName.Trim());
                    insertCommand.Parameters.AddWithValue("@MiddleName", customer.MiddleName.Trim());
                    insertCommand.Parameters.AddWithValue("@LastName", customer.LastName.Trim());
                    insertCommand.Parameters.AddWithValue("@Gender", customer.Gender);
                    insertCommand.Parameters.AddWithValue("@DateOfBirth", customer.DateOfBirth);
                    insertCommand.Parameters.AddWithValue("@PhoneNumber", customer.HomePhone);
                    insertCommand.Parameters.AddWithValue("@Address1", customer.Address1.Trim());
                    insertCommand.Parameters.AddWithValue("@Address2", customer.Address2.Trim());
                    insertCommand.Parameters.AddWithValue("@City", customer.City.Trim());
                    insertCommand.Parameters.AddWithValue("@State", customer.State.Trim());
                    insertCommand.Parameters.AddWithValue("@PostalCode", customer.PostalCode);
                    customer.CustomerId = Convert.ToInt32(insertCommand.ExecuteScalar());

                    return true;
                }
            }
        }

        /// <summary>
        /// Method that updates the customer into customer table
        /// </summary>
        /// <param name="customer">customer object</param>
        /// <returns>true if customer updated successfully</returns>
        public Boolean UpdateCustomer(Customer customer)
        {
            using (SqlConnection connection = FurnitureRentalsDBConnection.GetConnection())
            {
                string sqlStatement = "UPDATE CUSTOMER SET first_name=@FirstName, middle_name = @MiddleName, " +
                    "last_name = @LastName, sex = @Gender, date_of_birth = @DateOfBirth, phone_number=@PhoneNumber, " +
                    "address1=@Address1, address2=@Address2, city=@City, state=@State, zipcode=@PostalCode " +
                    "WHERE customer_id=@CustomerId";

                connection.Open();

                using (SqlCommand updateCommand = new SqlCommand(sqlStatement, connection))
                {
                    updateCommand.Connection = connection;
                    updateCommand.Parameters.AddWithValue("@CustomerId", customer.CustomerId);
                    updateCommand.Parameters.AddWithValue("@FirstName", customer.FirstName.Trim());
                    updateCommand.Parameters.AddWithValue("@MiddleName", customer.MiddleName.Trim());
                    updateCommand.Parameters.AddWithValue("@LastName", customer.LastName.Trim());
                    updateCommand.Parameters.AddWithValue("@Gender", customer.Gender);
                    updateCommand.Parameters.AddWithValue("@DateOfBirth", customer.DateOfBirth);
                    updateCommand.Parameters.AddWithValue("@PhoneNumber", customer.HomePhone);
                    updateCommand.Parameters.AddWithValue("@Address1", customer.Address1.Trim());
                    updateCommand.Parameters.AddWithValue("@Address2", customer.Address2.Trim());
                    updateCommand.Parameters.AddWithValue("@City", customer.City.Trim());
                    updateCommand.Parameters.AddWithValue("@State", customer.State);
                    updateCommand.Parameters.AddWithValue("@PostalCode", customer.PostalCode);

                    updateCommand.ExecuteNonQuery();
                    return true;
                }
            }
        }
    }
}
