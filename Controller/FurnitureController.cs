using FurnitureRentals.DAL;
using FurnitureRentals.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureRentals.Controller
{
    

    class FurnitureController
    {
        FurnitureDBDAL furnitureDBDAL;

        public FurnitureController()
        {
            this.furnitureDBDAL = new FurnitureDBDAL();
        }

        public Furniture GetFurnitureBySerialNumber(string serialNumber)
        {
            return this.furnitureDBDAL.GetFurnitureBySerialNumber(serialNumber);
        }
    }
}
