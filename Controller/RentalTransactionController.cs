using FurnitureRentals.DAL;
using FurnitureRentals.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureRentals.Controller
{
    class RentalTransactionController
    {
        RentalTransactionDBDAL rentalTransactionDBDAL;

        public RentalTransactionController()
        {
            this.rentalTransactionDBDAL = new RentalTransactionDBDAL();
        }
        public RentalTransaction GetRentalTransactionsByID(int rentalID)
        {
            return this.rentalTransactionDBDAL.GetRentalTransactionsByID(rentalID);
        }
    }
}
