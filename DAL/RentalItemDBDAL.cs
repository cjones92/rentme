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
        public List<Furniture> GetRentalItemByTransactionID(int transactionID)
        {
            Furniture rentalItem = new Furniture();
            List<Furniture> rentalItemList = new List<Furniture>();
            rentalItem.RentalTransactionID = transactionID;

            string selectStatement = "SELECT furniture.furniture_id AS FurnitureID, furniture.serial_no AS SerialNumber,  rental_item.rental_id AS RentalTransactionID, rental_item.rental_item_id As ReturnItemID, rental_item.quantity AS Quantity, furniture.description AS Item, furniture_style.description AS Style " +
"FROM rental_item JOIN furniture ON rental_item.furniture_id = furniture.furniture_id JOIN furniture_style ON furniture.style_id = furniture_style.style_id WHERE rental_id = @RentalTransactionID";
            ;

            using (SqlConnection connection = FurnitureRentalsDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
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

        public int GetQuantityRented(int rentalItemID)
        {
            
            int rentalAmount  = 0;

            string selectStatement = "SELECT rental_item.quantity as RentalQuantity From rental_item WHERE rental_item.rental_item_id = @RentalItemID;"
            ;

            using (SqlConnection connection = FurnitureRentalsDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@RentalItemID", rentalItemID);
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            rentalAmount = (int)reader["RentalQuantity"];                            
                        }
                    }
                }               
            }

            return rentalAmount; 
        }

        public int GetQuantityReturned(int rentalItemID)
        {

            int returnAmount = 0;

            string selectStatement = "SELECT Sum(return_item.quantity) AS ReturnQuantity From return_item WHERE return_item.rental_item_id = @RentalItemID;"
            ;

            using (SqlConnection connection = FurnitureRentalsDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@RentalItemID", rentalItemID);
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int value;
                            if (int.TryParse(reader["ReturnQuantity"].ToString(), out value ))
                            {
                                returnAmount = (int)reader["ReturnQuantity"];
                            } else
                            {
                                returnAmount = 0;
                            }
                        }
                    }
                }
            }
            return returnAmount;
        }
    }
}
