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
    /// DAL class responsible for interacting with the Category table of the FurnitureRentals database
    /// </summary>
    class CategoryDBDAL
    {
        /// <summary>
        /// Method gets categories 
        /// </summary>
        /// <returns>list of categories</returns>
        public List<Category> GetCategories()
        {
            List<Category> categories = new List<Category>();


            string selectStatement =
                "SELECT category_id AS CategoryID, description as Description FROM furniture_category";

            using (SqlConnection connection = FurnitureRentalsDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            Category category = new Category();
                            category.CategoryID = (int)reader["CategoryID"];
                            category.CategoryDescription = reader["Description"].ToString();
                            categories.Add(category);
                        }
                    }
                }
            }

            return categories;
        }
    }
}
