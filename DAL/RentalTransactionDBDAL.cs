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
        public string EnterRentalTransaction(RentalTransaction transaction, List<Furniture> furnitureList)
        {
            List<Furniture> addedFurnitureItems = new List<Furniture>();
            using (SqlConnection connection = FurnitureRentalsDBConnection.GetConnection())
            {
                SqlTransaction rentalTransaction = null;
                string sqlTransactionStatement = "INSERT INTO RENTAL_TRANSACTION (customer_id, rented_on, due_date, " +
                "total_due, checked_out_by, status) " +
                "VALUES (@CustomerID, @RentedOn, @DueDate, @TotalDue, @CheckedOutBy, @Status " +
                "); SELECT SCOPE_IDENTITY() ";

                string sqlItemStatement = "INSERT INTO RENTAL_item (rental_id, furniture_id, quantity) " +
                "VALUES (@RentalID, @FurnitureID, @Quantity); SELECT SCOPE_IDENTITY() ";

                connection.Open();
                rentalTransaction = connection.BeginTransaction();

                using (SqlCommand insertTransactionCommand = new SqlCommand(sqlTransactionStatement, connection, rentalTransaction),  insertCommand = new SqlCommand(sqlItemStatement, connection, rentalTransaction) )
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
                    
                    return "TransactionIssue";
                }

                ///foreach (Furniture furniture in furnitureList)
                for(int index = 0; index < furnitureList.Count; index++)
                {
                        furnitureList[index].RentalTransactionID = transaction.RentalID;
                        insertCommand.Connection = connection;
                        insertCommand.Parameters.AddWithValue("@RentalID", furnitureList[index].RentalTransactionID);
                        insertCommand.Parameters.AddWithValue("@FurnitureID", furnitureList[index].FurnitureID);
                        insertCommand.Parameters.AddWithValue("@Quantity", furnitureList[index].QuantityAvailable);

                        
                        furnitureList[index].RentalItemID = Convert.ToInt32(insertCommand.ExecuteScalar());
                        addedFurnitureItems.Add(furnitureList[index]);
                        if (addedFurnitureItems.Count <= 0) { 
                        
                            rentalTransaction.Rollback();
                            return "ItemIssue";
                        }

                    }
                }
                rentalTransaction.Commit();
                return "Successful";


            }



        }
    }
}
