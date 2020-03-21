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
        StyleDBDAL styleDBDAL;
        FurnitureDBDAL furnitureDBDAL;
        CategoryDBDAL categoryDBDAL;

        public FurnitureController()
        {
            this.furnitureDBDAL = new FurnitureDBDAL();
            this.styleDBDAL = new StyleDBDAL();
            this.categoryDBDAL = new CategoryDBDAL();
        }

        public List<Furniture> GetFurnitureBySerialNumber(string serialNumber)
        {
            return this.furnitureDBDAL.GetFurnitureBySerialNumber(serialNumber);
        }

        public List<Furniture> GetFurnitureByCategory(int categoryID)
        {
            return this.furnitureDBDAL.GetFurnitureByCategory(categoryID);
        }

        public List<Category> GetCategories()
        {
            return this.categoryDBDAL.GetCategories();
        }

        public List<Style> GetStyles()
        {
            return this.styleDBDAL.GetStyles();
        }

        public List<Furniture> GetFurnitureByStyleID(int styleID)
        {
            return this.furnitureDBDAL.GetFurnitureByStyle(styleID);
        }

    }
}
