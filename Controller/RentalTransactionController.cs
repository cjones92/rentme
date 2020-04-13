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

        /// <summary>
        /// Controller
        /// </summary>
        public RentalTransactionController()
        {
            this.rentalTransactionDBDAL = new RentalTransactionDBDAL();
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
    }
}
