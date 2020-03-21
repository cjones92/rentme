﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureRentals.Model
{
    class Furniture
    {
       public string SerialNumber { get; set; }

       public int Quantity { get; set; }

       public string FurnitureStyle { get; set; }

        public int StyleID { get; set; }

       public int FurnitureID { get; set; }

       public string ItemDescription { get; set; }

       public string Category { get; set; }

       public int CategoryID { get; set; }
    }
}
