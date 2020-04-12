﻿using FurnitureRentals.DAL;
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
        /// Method that posts the return transactions of a given customer
        /// </summary>
        /// <param name="returnTransaction">return transaction</param>
        /// <param name="transactionList">list of items</param>
        /// <returns>true if successfull otherwise false</returns>
        public bool PostReturnTransaction(ReturnTransaction returnTransaction, List<ReturnCart> transactionList)
        {
            return this.returnTransactionDBDAL.PostReturnTransaction(returnTransaction, transactionList);
        }

    }
}
