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
        public Boolean EnterRentalItem(Furniture furniture)
        {
            using (SqlConnection connection = FurnitureRentalsDBConnection.GetConnection())
            {
                string sqlStatement = "INSERT INTO RENTAL_item (rental_id, furniture_id, quantity) " +
                "VALUES (@RentalID, @FurnitureID, @Quantity); SELECT SCOPE_IDENTITY() ";

                connection.Open();
                

                using (SqlCommand insertCommand = new SqlCommand(sqlStatement, connection))
                {
                    insertCommand.Connection = connection;
                    

                    insertCommand.Parameters.AddWithValue("@RentalID", furniture.RentalTransactionID);
                    insertCommand.Parameters.AddWithValue("@FurnitureID", furniture.FurnitureID);
                    insertCommand.Parameters.AddWithValue("@Quantity", furniture.QuantityAvailable);
                    

                    furniture.RentalItemID = Convert.ToInt32(insertCommand.ExecuteScalar());

                    return true;
                }
            }
        }
    }
}
