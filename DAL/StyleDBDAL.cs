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
    /// Accesses information related to style table from the databas
    /// </summary>
    class StyleDBDAL
    {
        /// <summary>
        /// Returns list of styles
        /// </summary>
        /// <returns>list of styles</returns>
        public List<Style> GetStyles()
        {
            List<Style> styles = new List<Style>();

            string selectStatement =
                "SELECT style_id AS StyleID, description as Description FROM furniture_style";

            using (SqlConnection connection = FurnitureRentalsDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            Style style = new Style();
                            style.StyleID = (int)reader["StyleID"];
                            style.StyleDescription = reader["Description"].ToString();
                            styles.Add(style);
                        }
                    }
                }
            }

            return styles;
        }
    }
}
