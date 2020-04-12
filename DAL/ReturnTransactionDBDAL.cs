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
