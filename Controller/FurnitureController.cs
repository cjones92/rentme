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
        ReturnTransactionDBDAL returnTransactionDBDAL;

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
            this.returnTransactionDBDAL = new ReturnTransactionDBDAL();
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
        /// Returns furniture that matches id
        /// </summary>
        /// <param name="furnitureId">furniture id</param>
        /// <returns>furniture item</returns>
        public Furniture GetFurnitureByID(int furnitureId)
        {
            return this.furnitureDBDAL.GetFurnitureByID(furnitureId);
        }

        /// <summary>
        /// Returns quantity of an item rented in a transaction
        /// </summary>
        /// <param name="rentalItemID"></param>
        /// <returns>quantity</returns>
        public int GetQuantityRented(int rentalItemID)
        {
            return this.rentalItemDBDAL.GetQuantityRented(rentalItemID);
        }

        /// <summary>
        /// Returns quantity of an item returned in a return transaction
        /// </summary>
        /// <param name="rentalItemID">rentalID</param>
        /// <returns>quantity</returns>
        public int GetQuantityReturned(int rentalItemID)
        {
            return this.returnTransactionDBDAL.GetQuantityReturned(rentalItemID);
        }
    }
}
