using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using rentmecs6232.DAL;

namespace FurnitureRentals.Controllers
{
    FurnitureDBDAL furnitureDBDAL;

    /// <summary>
    /// Controller class for furniture-related items
    /// </summary>
    public static class FurnitureController
    {
        public FurnitureController()
        {
            this.furnitureBDAL = new FurnitureDBDAL();
        }

        public List<Furniture> GetFurnitureBySerialNumber(string serialNumber)
        {
            return this.furnitureDBDAL.GetFurnitureBySerialNumber(serialNumber);
        }

    }
}
