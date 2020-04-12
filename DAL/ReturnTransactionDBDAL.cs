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
    /// This class interacts with the database and executes the necessary SQL operations
    /// </summary>
    class ReturnTransactionDBDAL
    {
        /// <summary>
        /// Method that returns all the return transactions
        /// </summary>
        /// <returns>a list of return transactions</returns
        public List<ReturnTransaction> GetAllReturnTransactions(int customerId)
        {
            string sqlStatement = "Select return_transaction_id as ReturnTransactionID, " +
                "return_date as ReturnDate, checked_in_by as CheckedinBy, " +
                "late_fee as LateFee, refund_amount as RefundAmount from return_transaction " +
                "where customer_id=@CustomerId;";

            Console.WriteLine(sqlStatement);

            List<ReturnTransaction> transactionList = new List<ReturnTransaction>();
            using (SqlConnection connection = FurnitureRentalsDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(sqlStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@CustomerID", customerId);

                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ReturnTransaction transaction = new ReturnTransaction();
                            transaction.ReturnTransactionID = (int)reader["ReturnTransactionID"];
                            transaction.ReturnDate = (DateTime)reader["ReturnDate"];
                            transaction.CheckedinBy = reader["CheckedinBy"].ToString();
                            transaction.LateFee = (decimal)reader["LateFee"];
                            transaction.RefundAmount = (decimal)reader["RefundAmount"];

                            transactionList.Add(transaction);
                        }
                    }
                }
            }

            return transactionList;
        }

        public List<ReturnItemView> GetAllReturnItems(int returnTransactionId)
        {
            string sqlStatement = "SELECT rental_id as RentalID, return_item.Quantity as ReturnQuantity, " +
                "Furniture.description as ItemRented, furniture_style.description Style, " +
                "rental_item.quantity TotalQuantity from return_item join rental_item on " +
                "return_item.rental_item_id = rental_item.rental_item_id join furniture " +
                "on rental_item.furniture_id = furniture.furniture_id join furniture_style on " +
                "furniture.style_id = furniture_style.style_id where return_item.return_transaction_id=@ReturnTransactionID;";

            Console.WriteLine(sqlStatement);

            List<ReturnItemView> transactionList = new List<ReturnItemView>();
            using (SqlConnection connection = FurnitureRentalsDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(sqlStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@ReturnTransactionID", returnTransactionId);

                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ReturnItemView transaction = new ReturnItemView();
                            transaction.RentalID = (int)reader["RentalID"];
                            transaction.ItemRented = reader["ItemRented"].ToString();
                            transaction.Style = reader["Style"].ToString();
                            transaction.TotalQuantity = (int)reader["TotalQuantity"];
                            transaction.ReturnedQuantity = (int)reader["ReturnQuantity"];

                            transactionList.Add(transaction);
                        }
                    }
                }
            }

            return transactionList;
        }

        /// <summary>
        /// Method that posts the return transactions of a given customer
        /// </summary>
        /// <param name="returnTransaction">return transaction</param>
        /// <param name="transactionList">list of items</param>
        /// <returns>true if successfull otherwise false</returns>
        public bool PostReturnTransaction(ReturnTransaction returnTransaction, List<ReturnCart> transactionList)
        {
            
            return true;
        }
    }
}
