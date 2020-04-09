using FurnitureRentals.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureRentals.DAL
{
    class RentalItemDBDAL
    {

        public List<Furniture> GetRentalItemByTransactionID(int transactionID)
        {
            Furniture rentalItem = new Furniture();
            List<Furniture> rentalItemList = new List<Furniture>();
            rentalItem.RentalTransactionID = transactionID;

            string selectStatement = "SELECT rental_item.quantity AS Quantity, furniture.description AS Item, furniture_style.description AS Style " +
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
    }
}
