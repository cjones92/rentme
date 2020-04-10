using FurnitureRentals.DAL;
using FurnitureRentals.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureRentals.Controller
{
    /// <summary>
    /// This class interacts with the DAL and performs functions relevant to administrators
    /// </summary>
    class AdminstratorController
    {
        AdministratorDBDAL administratorDBAL;

        /// <summary>
        /// Class controller
        /// </summary>
        public AdminstratorController()
        {
            this.administratorDBAL = new AdministratorDBDAL();
        }


        /// <summary>
        /// Verifies administrator login credentials
        /// </summary>
        /// <param name="UserName">Admin user name</param>
        /// <param name="Password">Admin password</param>
        /// <returns>Whether credentials are valid</returns>
        public Administrator AdministratorLogin(string UserName, string Password)
        {
            return this.administratorDBAL.CheckPassword(UserName, Password);
        }
    }
}
