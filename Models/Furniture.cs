using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace FurnitureRentals.Models
{
    /// <summary>
    /// Class initialized the db connection string
    /// </summary>
    public static class Furniture
    {
       string SerialNumber { get; set; }
       
       int Quantity { get; set; }

       string FurnitureStyle { get; set; }

       string ItemDescription { get; set; }
    }
}
