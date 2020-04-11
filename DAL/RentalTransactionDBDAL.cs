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
        public bool EnterRentalTransaction(RentalTransaction transaction, List<Furniture> furnitureList)
        {
            List<Furniture> addedFurnitureItems = new List<Furniture>();
            using (SqlConnection connection = FurnitureRentalsDBConnection.GetConnection())
            {
                SqlTransaction rentalTransaction = null;
                string sqlTransactionStatement = "INSERT INTO RENTAL_TRANSACTION (customer_id, rented_on, due_date, " +
                "total_due, checked_out_by, status) " +
                "VALUES (@CustomerID, @RentedOn, @DueDate, @TotalDue, @CheckedOutBy, @Status " +
                "); SELECT SCOPE_IDENTITY() ";

                string sqlQuantityStatement = "UPDATE inventory SET total_available = total_available - @QuantityOrdered " +
                    "WHERE inventory.furniture_id = @FurnitureID AND total_available = @AvailableQuantity ";

                string sqlItemStatement = "INSERT INTO RENTAL_item (rental_id, furniture_id, quantity) " +
                "VALUES (@RentalID, @FurnitureID, @QuantityOrdered); SELECT SCOPE_IDENTITY() ";

                connection.Open();
                rentalTransaction = connection.BeginTransaction();

                using (SqlCommand insertTransactionCommand = new SqlCommand(sqlTransactionStatement, connection, rentalTransaction), updateInventoryCommand = new SqlCommand(sqlQuantityStatement, connection, rentalTransaction), insertItemCommand = new SqlCommand(sqlItemStatement, connection, rentalTransaction))
                {
                    insertTransactionCommand.Connection = connection;

                    insertTransactionCommand.Parameters.AddWithValue("@CustomerID", transaction.CustomerID);
                    insertTransactionCommand.Parameters.AddWithValue("@RentedOn", transaction.RentalDate);
                    insertTransactionCommand.Parameters.AddWithValue("@DueDate", transaction.DueDate);
                    insertTransactionCommand.Parameters.AddWithValue("@TotalDue", transaction.TotalDue);
                    insertTransactionCommand.Parameters.AddWithValue("@CheckedOutBy", transaction.CheckedOutByID);
                    insertTransactionCommand.Parameters.AddWithValue("@Status", transaction.Status.Trim());

                    transaction.RentalID = Convert.ToInt32(insertTransactionCommand.ExecuteScalar());


                    if (transaction.RentalID <= 0)
                    {
                        rentalTransaction.Rollback();

                        return false;
                    }

                    ///foreach (Furniture furniture in furnitureList)
                    for (int index = 0; index < furnitureList.Count; index++)

                    {
                        updateInventoryCommand.Connection = connection;
                        updateInventoryCommand.Parameters.Clear();
                        updateInventoryCommand.Parameters.AddWithValue("@AvailableQuantity", furnitureList[index].Quantity);
                        updateInventoryCommand.Parameters.AddWithValue("@QuantityOrdered", furnitureList[index].QuantityOrdered);
                        updateInventoryCommand.Parameters.AddWithValue("@FurnitureID", furnitureList[index].FurnitureID);



                        int count = updateInventoryCommand.ExecuteNonQuery();

                        if (count <= 0)
                        {
                            rentalTransaction.Rollback();
                            return false;
                        }

                        furnitureList[index].RentalTransactionID = transaction.RentalID;
                        insertItemCommand.Connection = connection;
                        insertItemCommand.Parameters.Clear();
                        insertItemCommand.Parameters.AddWithValue("@RentalID", furnitureList[index].RentalTransactionID);
                        insertItemCommand.Parameters.AddWithValue("@FurnitureID", furnitureList[index].FurnitureID);
                        insertItemCommand.Parameters.AddWithValue("@QuantityOrdered", furnitureList[index].QuantityOrdered);





                        furnitureList[index].RentalItemID = Convert.ToInt32(insertItemCommand.ExecuteScalar());
                        addedFurnitureItems.Add(furnitureList[index]);
                        if (addedFurnitureItems.Count <= 0)
                        {

                            rentalTransaction.Rollback();
                            return false;
                        }

                    }
                }
                rentalTransaction.Commit();
                return true;


            }



        }

        public List<RentalTransaction> GetCustomerTransactionsByCustomerID(int customerID)
        {
            RentalTransaction transaction = new RentalTransaction();
            List<RentalTransaction> transactionList = new List<RentalTransaction>();
            transaction.CustomerID = customerID;

            string selectStatement = "SELECT rental_id as RentalTransactionID, rented_on AS RentedOn, due_date AS DueDate, total_due AS TotalDue, status AS Status " +
"FROM rental_transaction WHERE customer_id = @CustomerID";
            ;

            using (SqlConnection connection = FurnitureRentalsDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@CustomerID", transaction.CustomerID);
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {


                        while (reader.Read())
                        {
                            RentalTransaction newTransaction = new RentalTransaction();
                            newTransaction.RentalID = (int)reader["RentalTransactionID"];
                            newTransaction.RentalDate = (DateTime)reader["RentedOn"];
                            newTransaction.DueDate = (DateTime)reader["DueDate"];
                            newTransaction.TotalDue = (Decimal)reader["TotalDue"];
                            newTransaction.Status = reader["Status"].ToString();
                            transactionList.Add(newTransaction);


                        }

                    }

                }

            }
            return transactionList;
        }

        public RentalTransaction GetRentalTransactionsByID(int rentalID)
        {
            RentalTransaction transaction = new RentalTransaction();

            string selectStatement = "SELECT rental_id as RentalTransactionID, rented_on AS RentedOn, " +
                "due_date AS DueDate, total_due AS TotalDue, status AS Status " +
                "FROM rental_transaction WHERE rental_id = @RentalID;";

            using (SqlConnection connection = FurnitureRentalsDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@RentalID", rentalID);
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            transaction.RentalID = (int)reader["RentalTransactionID"];
                            transaction.RentalDate = (DateTime)reader["RentedOn"];
                            transaction.DueDate = (DateTime)reader["DueDate"];
                            transaction.TotalDue = (Decimal)reader["TotalDue"];
                            transaction.Status = reader["Status"].ToString();
                        }
                    }
                }
            }
            return transaction;
        }
    }
}

