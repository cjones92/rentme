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
        /// Gets styles for furniture
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

        /// <summary>
        /// Enters a rental transaction
        /// </summary>
        /// <param name="transaction">transaction</param>
        /// <param name="furnitureList">list of furniture</param>
        /// <returns>whether transaction was entered</returns>
        public bool EnterRentalTransaction(RentalTransaction transaction, List<Furniture> furnitureList)
        {
            return this.rentalTransactionDBDAL.EnterRentalTransaction(transaction, furnitureList);
        }

        /// <summary>
        /// Searches for rental transactions by customer id
        /// </summary>
        /// <param name="customerID">customer id</param>
        /// <returns>transaction that matches id in list</returns>
        public List<RentalTransaction> GetRentalTransactionsByCustomerID(int customerID)
        {
            return this.rentalTransactionDBDAL.GetCustomerTransactionsByCustomerID(customerID);
        }

        /// <summary>
        /// Searches for rental item in a transaction by id
        /// </summary>
        /// <param name="transactionID">transaction id</param>
        /// <returns>transction that has id in list form</returns>
        public List<Furniture> GetRentalItemByTransactionID(int transactionID)
        {
            return this.rentalItemDBDAL.GetRentalItemByTransactionID(transactionID);
        }

        /// <summary>
        /// Returns furniture that matches id
        /// </summary>
        /// <param name="furnitureId">furniture id</param>
        /// <returns>furniture item</returns>
        public Furniture GetFurnitureByID(int furnitureId)
        {
            return this.furnitureDBDAL.GetFurnitureByID(furnitureId);
        }

        /// <summary>
        /// Method that updates the inventory
        /// </summary>
        /// <param name="furnitureId">furniture id that was returned</param>
        /// <param name="quantity">quantity that was the returned</param>
        /// <returns>true if successfull otherwise false</returns>
        public bool UpdateInventory(int furnitureId, int quantity)
        {
            return this.furnitureDBDAL.UpdateInventory(furnitureId, quantity);
        }
    }
}
