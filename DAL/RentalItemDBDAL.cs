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
    /// Class deals with information related to the rental item table in the database
    /// </summary>
    class RentalItemDBDAL
    {
        /// <summary>
        /// Gets items by transaction id
        /// </summary>
        /// <param name="transactionID">transaction id</param>
        /// <returns>furniture matching id in list form</returns>
        public List<Furniture> GetRentalItemByTransactionID(int transactionID, SqlConnection connection, SqlTransaction sqlTransaction)
        {
            Furniture rentalItem = new Furniture();
            List<Furniture> rentalItemList = new List<Furniture>();
            rentalItem.RentalTransactionID = transactionID;

            string selectStatement = "SELECT furniture.furniture_id AS FurnitureID, furniture.serial_no AS SerialNumber,  " +
                "rental_item.rental_id AS RentalTransactionID, rental_item.rental_item_id As ReturnItemID, " +
                "rental_item.quantity AS Quantity, furniture.description AS Item, furniture_style.description AS Style " +
                "FROM rental_item JOIN furniture ON rental_item.furniture_id = furniture.furniture_id JOIN furniture_style ON " +
                "furniture.style_id = furniture_style.style_id WHERE rental_id = @RentalTransactionID";

            //using (SqlConnection connection = FurnitureRentalsDBConnection.GetConnection())
            {
               // connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection, sqlTransaction))
                {
                    selectCommand.Parameters.AddWithValue("@RentalTransactionID", rentalItem.RentalTransactionID);
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Furniture rentedFurniture = new Furniture();
                            rentedFurniture.FurnitureID = (int)reader["FurnitureID"];
                            rentedFurniture.SerialNumber = reader["SerialNumber"].ToString();
                            rentedFurniture.RentalItemID = (int)reader["ReturnItemID"];
                            rentedFurniture.RentalTransactionID = (int)reader["RentalTransactionID"];
                            rentedFurniture.QuantityOrdered = (int)reader["Quantity"];
                            rentedFurniture.ItemDescription = reader["Item"].ToString();
                            rentedFurniture.FurnitureStyle = reader["Style"].ToString();

                            rentalItemList.Add(rentedFurniture);
                        }
                    }
                }
            }
            return rentalItemList;
        }

        /// <summary>
        /// Method that returns the list of furnitures rented
        /// </summary>
        /// <param name="transactionID">transaction of the rental</param>
        /// <returns>a list of furnitures</returns>
        public List<Furniture> GetRentalItemByTransactionID(int transactionID)
        {
            using (SqlConnection connection = FurnitureRentalsDBConnection.GetConnection())
            {
                connection.Open();
                SqlTransaction sqlTransaction = connection.BeginTransaction();
                List<Furniture> furnitureList = this.GetRentalItemByTransactionID(transactionID, connection, sqlTransaction);
                sqlTransaction.Dispose();

                return furnitureList;
            }
        }

        /// <summary>
        /// Method that returns the total quantity rented for a given rental item id
        /// </summary>
        /// <param name="rentalItemID">rental item id of a rental transaction</param>
        /// <param name="connection">SQL connection object</param>
        /// <param name="sqlTransaction">SQL transaction object</param>
        /// <returns>total quantity ordered</returns>
        public int GetQuantityRented(int rentalItemID, SqlConnection connection, SqlTransaction sqlTransaction)
        {
            int totalQuantityRented = 0;

            string selectStatement = "SELECT rental_item.quantity as RentalQuantity From rental_item " +
                "WHERE rental_item.rental_item_id = @RentalItemID;";

            using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection, sqlTransaction))
            {
                selectCommand.Parameters.AddWithValue("@RentalItemID", rentalItemID);
                using (SqlDataReader reader = selectCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        totalQuantityRented = (int)reader["RentalQuantity"];
                    }
                }
            }

            return totalQuantityRented;
        }

        /// <summary>
        /// Method that returns the total quantity rented for a given rental item id
        /// </summary>
        /// <param name="rentalItemID">rental item id of a rental transaction</param>
        /// <returns></returns>
        public int GetQuantityRented(int rentalItemID)
        {
            using (SqlConnection connection = FurnitureRentalsDBConnection.GetConnection())
            {
                connection.Open();
                SqlTransaction sqlTransaction = connection.BeginTransaction();
                int totalQuantityRented =  this.GetQuantityRented(rentalItemID, connection, sqlTransaction);
                sqlTransaction.Dispose();

                return totalQuantityRented;
            }
        }
    }
}
