using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FurnitureRentals.DAL;
using FurnitureRentals.Model;

namespace FurnitureRentals.Controller
{
    /// <summary>
    /// This controller class that interacts with Data Access Layer and 
    /// implements Get All Customers function
    /// </summary>
    class CustomerController
    {
        private CustomerDAL customerDAL;

        /// <summary>
        /// Constructor that initializes class variables
        /// </summary>
        public CustomerController()
        {
            this.customerDAL = new CustomerDAL();
        }

        public Customer GetCustomer(string name, string phone, int customerId)
        {
            return customerDAL.GetCustomer(name, phone, customerId);
        }

        public Boolean RegisterCustomer(Customer customer)
        {
            return this.customerDAL.RegisterCustomer(customer);
        }
    }
}
