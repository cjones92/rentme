using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureRentals.Model
{
    public class RentalTransaction
    {
        public int RentalID { get; set; }

        public int CustomerID { get; set; }

        public DateTime RentalDate { get; set; }

        public DateTime DueDate { get; set; }

        public decimal TotalDue { get; set; }

        public int CheckedOutByID { get; set; }

        public decimal CurrentAmountDue { get; set; }

        public string Status { get; set; }
    }
}
