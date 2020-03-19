using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

            Incident chosenIncident = new Incident();
            chosenIncident.IncidentID = incidentID;

            string selectStatement = "SELECT serial_no AS 'Serial Number', furniture.description AS Item, furniture_style.description AS Style, total_available AS 'Total Available' " +
"FROM furniture JOIN furniture_style ON furniture.style_id = furniture_style.style_id JOIN inventory ON furniture.furniture_id = inventory.furniture_id WHERE furniture.";
            ;

            using (SqlConnection connection = FurnitureRentalsDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@IncidentID", chosenIncident.IncidentID);
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {


                        while (reader.Read())
                        {

                            chosenIncident.ProductCode = reader["ProductCode"].ToString();
                            chosenIncident.DateOpened = (DateTime)reader["DateOpened"];
                            chosenIncident.CustomerName = reader["CustomerName"].ToString();
                            chosenIncident.TechnicianName = reader["TechnicianName"].ToString();
                            chosenIncident.Title = reader["Title"].ToString();
                            chosenIncident.Description = reader["Description"].ToString();

                            if (reader["DateClosed"] != DBNull.Value)
                            {
                                chosenIncident.DateClosed = (DateTime)reader["DateClosed"];
                            }

                        }

                    }

                }
            }

            return chosenIncident;
        }
    }
}
