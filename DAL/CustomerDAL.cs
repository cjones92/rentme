using FurnitureRentals.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureRentals.DAL
{
    class CustomerDAL
    {
        public Customer GetCustomer(string name, string phone, int customerid)
        {
            Customer customer = null;

            string sqlStatement = "SELECT customer_id, first_name, middle_name, last_name, sex, " +
                "date_of_birth, phone_number, address1, address2, city, state, zipcode from customer ";

            if (name != null && name.Length > 0)
            {
                sqlStatement += "where concat(first_name, ' ', last_name) = @Name";
            }
            else if (phone != null && phone.Length > 0)
            {
                sqlStatement += "where home_phone = @Phone";
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
                        if (reader.Read())
                        {
                            customer = new Customer();
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
                        }
                    }
                }
            }

            return customer;
        }
    }
}
