using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FurnitureRentals.Model;
using FurnitureRentals.Controller;

namespace FurnitureRentals.User_Controls
{
    public partial class ReturnShoppingCartUserControl : UserControl
    {
        Customer currentCustomer;
        FurnitureController furnitureController;
        List<ReturnItem> transactionList = new List<ReturnItem>();

        public ReturnShoppingCartUserControl()
        {
            InitializeComponent();
            this.currentCustomer = new Customer();
            this.furnitureController = new FurnitureController();
        }

        /// <summary>
        /// Method that sets the current customer
        /// </summary>
        public void SetCurrentCustomer(Customer customer)
        {
            this.currentCustomer = customer;
            this.lblCustomerName.Text = customer.FirstName + " " + customer.LastName;
            this.lblMemberId.Text = customer.CustomerId + "";
        }

        /// <summary>
        /// Method that refrehes the incidents.
        /// This gets invoked automatically when a new incident is added
        /// </summary>
        public void RefreshDataGrid()
        {
            this.GetAllReturnCartTransactions();
        }

        private void GetAllReturnCartTransactions()
        {
            returnItemBindingSource.DataSource = transactionList;
        }
    }
}
