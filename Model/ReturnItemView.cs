using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureRentals.Model
{
    class ReturnItemView
    {
        public int ReturnTransactionID { get; set; }

        public int RentalID { get; set; }

        public string ItemRented { get; set; }

        public string Style { get; set; }

        public int TotalQuantity { get; set; }

        public int ReturnedQuantity { get; set; }
    }
}
