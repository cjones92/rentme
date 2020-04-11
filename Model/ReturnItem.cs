using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureRentals.Model
{
    class ReturnItem
    {
        public int RentalID { get; set; }

        public String SerialNo { get; set; }

        public String ItemRented { get; set; }

        public String Style { get; set; }

        public int ReturnQuantity { get; set; }

        public decimal LateFee { get; set; }

        public decimal Refund { get; set; }
    }
}
