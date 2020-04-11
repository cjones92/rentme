using FurnitureRentals.DAL;
using FurnitureRentals.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureRentals.Controller
{
    class ReturnTransactionController
    {
        ReturnTransactionDBDAL returnTransactionDBDAL;

        /// <summary>
        /// Class controller
        /// </summary>
        public ReturnTransactionController()
        {
            this.returnTransactionDBDAL = new ReturnTransactionDBDAL();
        }

        /// <summary>
        /// Method that returns all the return transactions for a given customer
        /// </summary>
        /// <param name="customerId">customer id of the customer</param>
        /// <returns>list of return transactions</returns>
        public List<ReturnTransactionView> GetAllReturnTransactions(int customerId)
        {
            return this.returnTransactionDBDAL.GetAllReturnTransactions(customerId);
        }

        /// <summary>
        /// Method that returns all the return transactions for a given customer
        /// </summary>
        /// <param name="customerId">customer id of the customer</param>
        /// <returns>list of return transactions</returns>
        public bool PostReturnTransaction(List<ReturnCart> transactionList)
        {
            return true;// this.returnTransactionDBDAL.GetAllReturnTransactions(customerId);
        }

    }
}
