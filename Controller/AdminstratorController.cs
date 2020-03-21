using FurnitureRentals.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureRentals.Controller
{
    class AdminstratorController
    {
        AdministratorDBDAL administratorDBAL;

        public AdminstratorController()
        {
            this.administratorDBAL = new AdministratorDBDAL();
        }


        public bool AdministratorLogin(string UserName, string Password)
        {
            return this.administratorDBAL.CheckPassword(UserName, Password);
        }
    }
}
