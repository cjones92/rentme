using FurnitureRentals.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureRentals.Controller
{
    class EmployeeController
    {

        EmployeeDBDAL employeeDBDAL;

        public EmployeeController()
        {
            this.employeeDBDAL = new EmployeeDBDAL();
        }
        public bool EmployeeLogin(string UserName, string Password)
        {
            return this.employeeDBDAL.CheckPassword(UserName, Password);
        }
    }
}
