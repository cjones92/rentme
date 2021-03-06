﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureRentals.Model
{
    /// <summary>
    /// Class for furniture objects
    /// </summary>
    public class Furniture
    {
        public string SerialNumber { get; set; }

        public int Quantity { get; set; }

        public int QuantityOrdered { get; set; }

        public string FurnitureStyle { get; set; }

        public int StyleID { get; set; }

        public int FurnitureID { get; set; }

        public decimal DailyRentalRate { get; set; }

        public decimal DailyFineRate { get; set; }

        public decimal TotalRentalCost { get; set; }

        public int DaysRented { get; set; }

        public string ItemDescription { get; set; }

        public string Category { get; set; }

        public int CategoryID { get; set; }

        public int RentalTransactionID { get; set; }

        public int RentalItemID { get; set; }

        public int QuantityBeingReturned { get; set; }

        public int QuantityAlreadyReturned { get; set; }

        public int QuantityInCart { get; set; }


    }
}
