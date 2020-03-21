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

        /// <summary>
        /// Method that returns the customer from customer table
        /// </summary>
        /// <param name="name">first name last name of the customer</param>
        /// <param name="phone">phone number of the customer</param>
        /// <param name="customerid">customer id of the customer</param>
        /// <returns>Customer object</returns>
        public Customer GetCustomer(string name, string phone, int customerId)
        {
            return customerDAL.GetCustomer(name, phone, customerId);
        }

        /// <summary>
        /// Method that registers the customer into customer table
        /// </summary>
        /// <param name="customer">customer object</param>
        /// <returns>true if customer registered successfully</returns>
        public Boolean RegisterCustomer(Customer customer)
        {
            return this.customerDAL.RegisterCustomer(customer);
        }
    }
}
