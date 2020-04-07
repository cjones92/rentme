using FurnitureRentals.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureRentals.DAL
{
    class RentalTransactionDBDAL
    {
        public Boolean EnterRentalTransaction(RentalTransaction transaction)
        {
            using (SqlConnection connection = FurnitureRentalsDBConnection.GetConnection())
            {
                string sqlStatement = "INSERT INTO RENTAL_TRANSACTION (customer_id, rented_on, due_date, " +
                "total_due, checked_out_by, status) " +
                "VALUES (@CustomerID, @RentedOn, @DueDate, @TotalDue, @CheckedOutBy, @Status " +
                "); SELECT SCOPE_IDENTITY() ";

                connection.Open();

                using (SqlCommand insertCommand = new SqlCommand(sqlStatement, connection))
                {
                    insertCommand.Connection = connection;
                    
                    insertCommand.Parameters.AddWithValue("@CustomerID", transaction.CustomerID);
                    insertCommand.Parameters.AddWithValue("@RentedOn", transaction.RentalDate);
                    insertCommand.Parameters.AddWithValue("@DueDate", transaction.DueDate);
                    insertCommand.Parameters.AddWithValue("@TotalDue", transaction.TotalDue);
                    insertCommand.Parameters.AddWithValue("@CheckedOutBy", transaction.CheckedOutByID);
                    insertCommand.Parameters.AddWithValue("@Status", transaction.Status.Trim());
                    
                    transaction.RentalID = Convert.ToInt32(insertCommand.ExecuteScalar());

                    return true;
                }
            }
        }
    }
}
