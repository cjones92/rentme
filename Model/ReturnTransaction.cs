﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureRentals.Model
{
    /// <summary>
    /// Model for return transactions
    /// </summary>
    class ReturnTransaction
    {
        public int ReturnTransactionID { get; set; }

        public int CustomerID { get; set; }

        public DateTime ReturnDate { get; set; }

        public int CheckedinBy { get; set; }

        public string EmployeeName { get; set; }

        public decimal LateFee { get; set; }

        public decimal RefundAmount { get; set; }
    }
}
