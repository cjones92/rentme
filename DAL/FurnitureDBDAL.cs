using FurnitureRentals.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureRentals.DAL
{
    class FurnitureDBDAL
    {
        public Furniture GetFurnitureBySerialNumber(string serialNumber)
        {

            Furniture chosenFurniture = new Furniture();
            chosenFurniture.SerialNumber = serialNumber;

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

                            chosenFurniture.ItemDescription = reader["Serial Number"].ToString();
                            chosenFurniture.FurnitureStyle = reader["Style"].ToString();
                            chosenFurniture.Quantity = (int)reader["Quantity"];

                        }

                    }

                }

            }
            return chosenFurniture;
        }

        public List<Furniture> GetFurnitureByCategory(int categoryID)
        {
            List<Furniture> furnitureList = new List<Furniture>();
            Furniture chosenFurniture = new Furniture();
            chosenFurniture.CategoryID = categoryID;

            string selectStatement = "SELECT serial_no AS 'Serial Number', furniture.description AS Item, furniture_style.description AS Style, total_available AS 'Total Available' " +
"FROM furniture JOIN furniture_style ON furniture.style_id = furniture_style.style_id JOIN inventory ON furniture.furniture_id = inventory.furniture_id WHERE furniture.CategoryID = @CategoryID";
            ;

            using (SqlConnection connection = FurnitureRentalsDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@CategoryID", chosenFurniture.CategoryID);
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {


                        while (reader.Read())
                        {
                            Furniture furniture = new Furniture();
                            furniture.ItemDescription = reader["Serial Number"].ToString();
                            furniture.FurnitureStyle = reader["Style"].ToString();
                            furniture.Quantity = (int)reader["Quantity"];

                            furnitureList.Add(furniture);

                        }

                    }

                }

            }
            return furnitureList;
        }
    }
}

