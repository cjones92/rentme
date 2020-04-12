using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureRentals.Model
{
    class ReturnItem
    {
        public int ReturnItemID { get; set; }

        public int ReturnTransactionID { get; set; }

        public int RentalItemID { get; set; }

        public int Quantity { get; set; }
    }
}
