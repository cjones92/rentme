﻿using FurnitureRentals.Model;
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
        public List<ReturnTransactionView> GetAllReturnTransactions(int customerId)
        {
            /*
            string sqlStatement = " SELECT return_transaction.return_transaction_id ReturnID, " +
                "return_date ReturnDate, rental_item.rental_id RentalId, furniture.description ItemRented, " +
                "furniture_style.description Style, rental_item.quantity TotalQuantity, " +
                "return_item.quantity as ReturnedQuantity, late_fee LateFee, refund_amount RefundAmount " +
                "from return_transaction, return_item, rental_item, furniture, furniture_style " +
                "where return_item.return_transaction_id = return_transaction.return_transaction_id " +
                "and rental_item.furniture_id = furniture.furniture_id " +
                "and furniture.style_id = furniture_style.style_id and return_transaction.customer_id=@CustomerId;";
            */

            string sqlStatement = "  SELECT return_transaction.return_transaction_id ReturnID, " +
                "return_date ReturnDate, rental_item.rental_id RentalId, furniture.description ItemRented, " +
                "furniture_style.description Style, rental_item.quantity TotalQuantity, " +
                "return_item.quantity as ReturnedQuantity, late_fee LateFee, refund_amount RefundAmount " +
                "from return_transaction join return_item on " +
                "return_item.return_transaction_id = return_transaction.return_transaction_id,  " +
                "rental_item join furniture on rental_item.furniture_id = furniture.furniture_id " +
                "join furniture_style on furniture.style_id = furniture_style.style_id " +
                "where return_transaction.customer_id=@CustomerId;";
            
            List<ReturnTransactionView> transactionList = new List<ReturnTransactionView>();
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
                            ReturnTransactionView transaction = new ReturnTransactionView();
                            transaction.ReturnID = (int)reader["ReturnID"];
                            transaction.ReturnDate = (DateTime)reader["ReturnDate"];
                            transaction.RentalID = (int)reader["RentalId"];
                            transaction.ItemRented = reader["ItemRented"].ToString();
                            transaction.Style = reader["Style"].ToString();
                            transaction.TotalQuantity = (int)reader["TotalQuantity"];
                            transaction.ReturnedQuantity = (int)reader["ReturnedQuantity"];
                            transaction.LateFee = (decimal)reader["LateFee"];
                            transaction.Refund = (decimal)reader["RefundAmount"];

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
