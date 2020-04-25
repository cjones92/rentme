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
    /// This controller class interacts with the DAL layer and implements functions
    /// for employees
    /// </summary>
    public class EmployeeController
    {

        EmployeeDBDAL employeeDBDAL;

        /// <summary>
        /// Class controller
        /// </summary>
        public EmployeeController()
        {
            this.employeeDBDAL = new EmployeeDBDAL();
        }

        /// <summary>
        /// Verifies employee login credentials
        /// </summary>
        /// <param name="UserName">Employee username<param>
        /// <param name="Password">Employee password</param>
        /// <returns>Whether login credentials are valid</returns>
        public Employee EmployeeLogin(string UserName, string Password)
        {
            return this.employeeDBDAL.CheckPassword(UserName, Password);
        }

        /// <summary>
        /// Adds an employee to the database through the DAL class.
        /// </summary>
        /// <param name="employee">Employee</param>
        public Boolean RegisterEmployee(Employee employee)
        {

            return EmployeeDBDAL.RegisterEmployee(employee);

        }

        /// <summary>
        /// Method that returns the selected employee(s) from the employee table
        /// </summary>
        /// <param name="name">first name last name of the employee</param>
        /// <param name="phone">phone number of the employee</param>
        /// <param name="customerid">employee id of the employee</param>
        /// <returns>Customer object</returns>
        public List<Employee> GetEmployees(string name, string phone, int employeeId)
        {
            return this.employeeDBDAL.GetEmployees(name, phone, employeeId);
        }


        /// <summary>
        /// Updates the employee in the employee table.
        /// </summary>
        /// <param name="employee">Employee object</param>
        /// <returns>true if employee is updated successfully</returns>
        public static bool UpdateEmployee(Employee employee)
        {
            return EmployeeDBDAL.UpdateEmployee(employee);
        }

    }
}
