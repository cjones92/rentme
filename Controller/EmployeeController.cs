﻿using FurnitureRentals.DAL;
using FurnitureRentals.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureRentals.Controller
{
    public class EmployeeController
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

        /// <summary>
        /// Adds an employee to the database through the DAL class.
        /// </summary>
        /// <param name="employee">Employee</param>
        public Boolean RegisterEmployee(Employee employee)
        {
            if (employee == null)
            {
                throw new ArgumentNullException("Employee cannot be null");
            }

           return  EmployeeDBDAL.RegisterEmployee(employee);

        }

    }
}
