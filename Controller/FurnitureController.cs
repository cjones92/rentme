using FurnitureRentals.DAL;
using FurnitureRentals.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureRentals.Controller
{

    /// <summary>
    /// Class interacts with the DAL and implements functions for furniture
    /// </summary>
    class FurnitureController
    {
        StyleDBDAL styleDBDAL;
        FurnitureDBDAL furnitureDBDAL;
        CategoryDBDAL categoryDBDAL;
        RentalTransactionDBDAL rentalTransactionDBDAL;
        RentalItemDBDAL rentalItemDBDAL;
        

        /// <summary>
        /// Class controller
        /// </summary>
        public FurnitureController()
        {
            this.rentalTransactionDBDAL = new RentalTransactionDBDAL();
            this.furnitureDBDAL = new FurnitureDBDAL();
            this.styleDBDAL = new StyleDBDAL();
            this.categoryDBDAL = new CategoryDBDAL();
            this.rentalItemDBDAL = new RentalItemDBDAL();
            

        }

        /// <summary>
        /// Searches and returns furniture by serial number
        /// </summary>
        /// <param name="serialNumber">serial number</param>
        /// <returns>furniture with serial number</returns>
        public List<Furniture> GetFurnitureBySerialNumber(string serialNumber)
        {
            return this.furnitureDBDAL.GetFurnitureBySerialNumber(serialNumber);
        }

        /// <summary>
        /// Returns furniture in a category
        /// </summary>
        /// <param name="categoryID">Id of category</param>
        /// <returns>furniture in a category</returns>
        public List<Furniture> GetFurnitureByCategory(int categoryID)
        {
            return this.furnitureDBDAL.GetFurnitureByCategory(categoryID);
        }

        /// <summary>
        /// Returns categories for furniture
        /// </summary>
        /// <returns>categories of furniture</returns>
        public List<Category> GetCategories()
        {
            return this.categoryDBDAL.GetCategories();
        }

        /// <summary>
        /// Gets styes for furniture
        /// </summary>
        /// <returns>styles of furniture</returns>
        public List<Style> GetStyles()
        {
            return this.styleDBDAL.GetStyles();
        }

        /// <summary>
        /// Gets furniture with a style
        /// </summary>
        /// <param name="styleID">style id</param>
        /// <returns>furniture with a style</returns>
        public List<Furniture> GetFurnitureByStyleID(int styleID)
        {
            return this.furnitureDBDAL.GetFurnitureByStyle(styleID);
        }

        public bool EnterRentalTransaction(RentalTransaction transaction, List<Furniture> furnitureList)
        {
           return this.rentalTransactionDBDAL.EnterRentalTransaction(transaction, furnitureList);
        }

        public List<RentalTransaction> GetRentalTransactionsByCustomerID(int customerID)
        {
            return this.rentalTransactionDBDAL.GetCustomerTransactionsByCustomerID(customerID);
        }

        public List<Furniture> GetRentalItemByTransactionID(int transactionID)
        {
            return this.rentalItemDBDAL.GetRentalItemByTransactionID(transactionID);
        }



    }
}
