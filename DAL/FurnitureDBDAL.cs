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
    /// DAL class responsible for interacting with the Furniture table of the FurnitureRentals database
    /// </summary>
    class FurnitureDBDAL
    {
        /// <summary>
        /// Searches for furniture by serial number
        /// </summary>
        /// <param name="serialNumber">serial number</param>
        /// <returns>furniture that matches that serial number</returns>
        public List<Furniture> GetFurnitureBySerialNumber(string serialNumber)
        {

            Furniture chosenFurniture = new Furniture();
            List<Furniture> furnitureList = new List<Furniture>();
            chosenFurniture.SerialNumber = serialNumber;

            string selectStatement = "SELECT serial_no AS 'Serial Number', furniture.description AS Item, furniture_style.description AS Style, total_available AS 'Total Available', daily_rental_rate AS 'Daily Rental Rate' " +
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

                            chosenFurniture.SerialNumber = reader["Serial Number"].ToString();
                            chosenFurniture.ItemDescription = reader["Item"].ToString();
                            chosenFurniture.FurnitureStyle = reader["Style"].ToString();
                            chosenFurniture.Quantity = (int)reader["Total Available"];
                            chosenFurniture.DailyRentalRate = (decimal)reader["Daily Rental Rate"];
                            furnitureList.Add(chosenFurniture);

                        }

                    }

                }

            }
            return furnitureList;
        }

        


        /// <summary>
        /// Searches for furniture by category
        /// </summary>
        /// <param name="categoryID">category</param>
        /// <returns>list of furniture with that category</returns>
        public List<Furniture> GetFurnitureByCategory(int categoryID)
        {
            List<Furniture> furnitureList = new List<Furniture>();
            Furniture chosenFurniture = new Furniture();
            chosenFurniture.CategoryID = categoryID;

            string selectStatement = "SELECT serial_no AS 'Serial Number', furniture.description AS Item, furniture_style.description AS Style, total_available AS 'Total Available', daily_rental_rate AS 'Daily Rental Rate' " +
"FROM furniture JOIN furniture_style ON furniture.style_id = furniture_style.style_id JOIN inventory ON furniture.furniture_id = inventory.furniture_id WHERE furniture.category_id = @CategoryID";
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
                            furniture.SerialNumber = reader["Serial Number"].ToString();
                            furniture.ItemDescription = reader["Item"].ToString();
                            furniture.FurnitureStyle = reader["Style"].ToString();
                            furniture.Quantity = (int)reader["Total Available"];
                            furniture.DailyRentalRate = (decimal)reader["Daily Rental Rate"];

                            furnitureList.Add(furniture);

                        }

                    }

                }

            }
            return furnitureList;
        }


        /// <summary>
        /// Searches for furniture with a certain style
        /// </summary>
        /// <param name="styleID">style of furniture</param>
        /// <returns>list of furniture with style</returns>
        public List<Furniture> GetFurnitureByStyle(int styleID)
        {
            List<Furniture> furnitureList = new List<Furniture>();
            Furniture chosenFurniture = new Furniture();
            chosenFurniture.StyleID = styleID;

            string selectStatement = "SELECT serial_no AS 'Serial Number', furniture.description AS Item, furniture_style.description AS Style, total_available AS 'Total Available', daily_rental_rate AS 'Daily Rental Rate' " +
"FROM furniture JOIN furniture_style ON furniture.style_id = furniture_style.style_id JOIN inventory ON furniture.furniture_id = inventory.furniture_id WHERE furniture.style_id = @StyleID";
            ;

            using (SqlConnection connection = FurnitureRentalsDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@StyleID", chosenFurniture.StyleID);
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {


                        while (reader.Read())
                        {
                            Furniture furniture = new Furniture();
                            furniture.SerialNumber = reader["Serial Number"].ToString();
                            furniture.ItemDescription = reader["Item"].ToString();
                            furniture.FurnitureStyle = reader["Style"].ToString();
                            furniture.Quantity = (int)reader["Total Available"];
                            furniture.DailyRentalRate = (decimal)reader["Daily Rental Rate"];

                            furnitureList.Add(furniture);

                        }

                    }

                }

            }
            return furnitureList;
        }
    }
}

