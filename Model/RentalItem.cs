using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureRentals.Model
{
   public class RentalItem
    {
        public int RentalItemID { get; set; }

        public int RentalTransactionID { get; set; }

        public int FurnitureID { get; set; }

        public int Quantity { get; set; }
    }
}
