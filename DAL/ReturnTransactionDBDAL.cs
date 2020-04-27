using FurnitureRentals.Model;
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
    /// This class interacts with the database and executes the necessary SQL operations
    /// </summary>
    class ReturnTransactionDBDAL
    {
        FurnitureDBDAL furnitureDBDAL;
        RentalItemDBDAL rentalItemDBDAL;
        RentalTransactionDBDAL rentalTransactionDBDAL;

        /// <summary>
        /// Class controller
        /// </summary>
        public ReturnTransactionDBDAL()
        {
            this.furnitureDBDAL = new FurnitureDBDAL();
            this.rentalItemDBDAL = new RentalItemDBDAL();
            this.rentalTransactionDBDAL = new RentalTransactionDBDAL();
        }

        /// <summary>
        /// Method that returns all the return transactions
        /// </summary>
        /// <returns>a list of return transactions</returns
        public List<ReturnTransaction> GetAllReturnTransactions(int customerId)
        {
            string sqlStatement = "Select return_transaction_id as ReturnTransactionID, " +
                "return_date as ReturnDate, checked_in_by as CheckedinBy, concat(first_name, ' ', last_name) as EmployeeName, " +
                "late_fee as LateFee, refund_amount as RefundAmount from return_transaction join employee on checked_in_by = employee_id " +
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
                            transaction.CheckedinBy = (int)reader["CheckedinBy"];
                            transaction.EmployeeName = reader["EmployeeName"].ToString();
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
        /// Method gets all return itmes for a transaction
        /// </summary>
        /// <param name="returnTransactionId"> transaction id</param>
        /// <returns>items in return transaction</returns>
        public List<ReturnItemView> GetAllReturnItems(int returnTransactionId)
        {
            string sqlStatement = "SELECT rental_id as RentalID, return_item.Quantity as ReturnQuantity, " +
                "Furniture.serial_no as SerialNo, Furniture.description as ItemRented, furniture_style.description Style, " +
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
                            transaction.SerialNo = reader["SerialNo"].ToString();
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
        public bool PostReturnTransaction(ReturnTransaction returnTransaction, List<ReturnCart> ReturnItemList)
        {
            SqlTransaction sqlTransaction = null;
            using (SqlConnection connection = FurnitureRentalsDBConnection.GetConnection())
            {
                string sqlStatement = "INSERT INTO Return_Transaction (customer_id, return_date, " +
                "checked_in_by, late_fee, refund_amount) " +
                "VALUES (@CustomerID, @ReturnDate, @CheckedinBy, @LateFee, @RefundAmount); SELECT SCOPE_IDENTITY() ";

                connection.Open();
                sqlTransaction = connection.BeginTransaction();

                using (SqlCommand insertCommand = new SqlCommand(sqlStatement, connection, sqlTransaction))
                {
                    insertCommand.Connection = connection;
                    insertCommand.Parameters.AddWithValue("@CustomerID", returnTransaction.CustomerID);
                    insertCommand.Parameters.AddWithValue("@ReturnDate", returnTransaction.ReturnDate);
                    insertCommand.Parameters.AddWithValue("@CheckedinBy", returnTransaction.CheckedinBy);
                    insertCommand.Parameters.AddWithValue("@LateFee", returnTransaction.LateFee);
                    insertCommand.Parameters.AddWithValue("@RefundAmount", returnTransaction.RefundAmount);
                    returnTransaction.ReturnTransactionID = Convert.ToInt32(insertCommand.ExecuteScalar());

                    if (returnTransaction.ReturnTransactionID > 0)
                    {
                        this.InsertReturnItem(connection, returnTransaction.ReturnTransactionID, ReturnItemList, sqlTransaction);
                    }

                    var rentalIdList = new List<int>();
                    foreach (ReturnCart returnItem in ReturnItemList)
                    {
                        if(!rentalIdList.Contains(returnItem.RentalID))
                        {
                            rentalIdList.Add(returnItem.RentalID);
                        }
                        this.furnitureDBDAL.UpdateInventory(returnItem.FurnitureID, returnItem.Quantity, connection, sqlTransaction);
                    }


                    foreach (int rentalTransactionId in rentalIdList)
                    {
                        List<Furniture> furnitureList = this.rentalItemDBDAL.GetRentalItemByTransactionID(rentalTransactionId, connection, sqlTransaction);

                        bool isCloseTransaction = true;
                        int totalQuantityRented = 0;
                        int totalQuantityReturned = 0;
                        foreach (Furniture furniture in furnitureList)
                        {
                            totalQuantityRented = furniture.QuantityOrdered;
                            totalQuantityReturned = this.GetQuantityReturned(furniture.RentalItemID, connection, sqlTransaction);
                            if (totalQuantityRented != totalQuantityReturned)
                            {
                                isCloseTransaction = false;
                            }
                        }

                        if (isCloseTransaction)
                        {
                            this.rentalTransactionDBDAL.CloseRentalTransaction(rentalTransactionId, connection, sqlTransaction);
                        }
                    }

                    sqlTransaction.Commit();
                    return true;
                }
            }
        }

        private void InsertReturnItem(SqlConnection connection, int returnTxnId, List<ReturnCart> ReturnItemList, SqlTransaction renturnTransaction)
        {
            string insertReturnItemStatement = "INSERT INTO Return_Item (return_transaction_id, " +
                            "rental_item_id, quantity) VALUES (@ReturnTransactionID, @RentalItemID, @Quantity); " +
                            "SELECT SCOPE_IDENTITY() ";
            using (SqlCommand insertCommand = new SqlCommand(insertReturnItemStatement, connection, renturnTransaction))
            {
                insertCommand.Connection = connection;
                foreach (ReturnCart returnItem in ReturnItemList)
                {
                    insertCommand.Parameters.Clear();
                    insertCommand.Parameters.AddWithValue("@ReturnTransactionID", returnTxnId);
                    insertCommand.Parameters.AddWithValue("@RentalItemID", returnItem.RentalItemID);
                    insertCommand.Parameters.AddWithValue("@Quantity", returnItem.Quantity);
                    insertCommand.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Method that returns the total quantity returned for a given rental item id
        /// </summary>
        /// <param name="rentalItemID">rental item id of a rental transaction</param>
        /// <returns></returns>
        public int GetQuantityReturned(int rentalItemID)
        {
            using (SqlConnection connection = FurnitureRentalsDBConnection.GetConnection())
            {
                connection.Open();
                SqlTransaction sqlTransaction = connection.BeginTransaction();
                int totalQuantityReturned = this.GetQuantityReturned(rentalItemID, connection, sqlTransaction);
                sqlTransaction.Dispose();
                return totalQuantityReturned;
            }
        }

        /// <summary>
        /// Method that returns the total quantity returned for a given rental item id
        /// </summary>
        /// <param name="rentalItemID">rental item id of a rental transaction</param>
        /// <param name="connection">SQL connection object</param>
        /// <param name="sqlTransaction">SQL transaction object</param>
        /// <returns>total quantity returned</returns>
        public int GetQuantityReturned(int rentalItemID, SqlConnection connection, SqlTransaction sqlTransaction)
        {
            int totalQuantityReturned = 0;
            string selectStatement = "SELECT Sum(return_item.quantity) AS ReturnQuantity From return_item " +
                "WHERE return_item.rental_item_id = @RentalItemID;";

            using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection, sqlTransaction))
            {
                selectCommand.Parameters.AddWithValue("@RentalItemID", rentalItemID);
                using (SqlDataReader reader = selectCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int value;
                        if (int.TryParse(reader["ReturnQuantity"].ToString(), out value))
                        {
                            totalQuantityReturned = (int)reader["ReturnQuantity"];
                        }
                        else
                        {
                            totalQuantityReturned = 0;
                        }
                    }
                }
            }
            return totalQuantityReturned;
        }
    }
}
