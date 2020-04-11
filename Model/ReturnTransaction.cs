using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureRentals.Model
{
    class ReturnTransaction
    {
        public int ReturnID { get; set; }

        public DateTime ReturnDate { get; set; }

        public int RentalID { get; set; }

        public String ItemRented { get; set; }

        public String Style { get; set; }

        public int TotalQuantity { get; set; }

        public int ReturnedQuantity { get; set; }

        public decimal LateFee { get; set; }

        public decimal Refund { get; set; }
    }
}
