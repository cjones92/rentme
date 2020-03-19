using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using rentmecs6232.Models;
using System.Data.SqlClient;

namespace FurnitureRentals.DAL
{
    /// <summary>
    /// Class initialized the db connection string
    /// </summary>
    public static class FurnitureDBDAL
    {
       public List<Furniture> GetFurnitureBySerialNumber(string serialNumber)
        {

            Furniture chosenFurniture = new Furniture();
            chosenFurniture.SerialNUmber = serialNumber;

            string selectStatement = "SELECT serial_no AS 'Serial Number', furniture.description AS Item, furniture_style.description AS Style, total_available AS 'Total Available' " +
"FROM furniture JOIN furniture_style ON furniture.style_id = furniture_style.style_id JOIN inventory ON furniture.furniture_id = inventory.furniture_id WHERE furniture.serial_no = @SerialNumber";
            ;

            using (SqlConnection connection = FurnitureRentalsDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@SerialNumber", chosenFurniture.SerialNumber);
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {


                        while (reader.Read())
                        {

                            chosenFurniture.Description = reader["Serial Number"].ToString();
                            chosenFurniture.Style = reader["Style"].ToString();
                            chosenFurniture.Quantity = (int)reader["Quantity"];

                        }

                    }

                }
            }

            return chosenFurniture;
        }
    }
}
