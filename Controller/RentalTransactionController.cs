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
    /// Class for controlling functions related to transactions
    /// </summary>
    class RentalTransactionController
    {
        RentalTransactionDBDAL rentalTransactionDBDAL;
        RentalItemDBDAL rentalItemDBDAL;

        /// <summary>
        /// Controller
        /// </summary>
        public RentalTransactionController()
        {
            this.rentalTransactionDBDAL = new RentalTransactionDBDAL();
            this.rentalItemDBDAL = new RentalItemDBDAL();
        }

        /// <summary>
        /// Gets rentals by id
        /// </summary>
        /// <param name="rentalID">id</param>
        /// <returns>transaction matching id</returns>
        public RentalTransaction GetRentalTransactionsByID(int rentalID)
        {
            return this.rentalTransactionDBDAL.GetRentalTransactionsByID(rentalID);
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

    }
}
