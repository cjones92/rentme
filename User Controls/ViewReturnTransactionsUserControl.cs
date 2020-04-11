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
    public partial class ViewReturnTransactionsUserControl : UserControl
    {
        Customer currentCustomer;
        FurnitureController furnitureController;

        public ViewReturnTransactionsUserControl()
        {
            InitializeComponent();
            dgvViewReturns.AllowUserToAddRows = false;
            dgvViewReturns.RowHeadersVisible = false;
            dgvViewReturns.DefaultCellStyle.WrapMode = DataGridViewTriState.False;
            dgvViewReturns.AutoResizeColumns();
            dgvViewReturns.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvViewReturns.AutoResizeRows();
            dgvViewReturns.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvViewReturns.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            this.currentCustomer = new Customer();
            this.furnitureController = new FurnitureController();
            this.RefreshDataGrid();
        }
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
            this.GetAllReturnTransactions();
        }

        private void GetAllReturnTransactions()
        {
            returnTransactionBindingSource.DataSource = new List<ReturnTransaction>();
            if (currentCustomer.CustomerId > 0)
            {
                List<ReturnTransaction> transactionList = this.furnitureController.GetAllReturnTransactions(currentCustomer.CustomerId);
                returnTransactionBindingSource.DataSource = transactionList;
            }

        }
    }
}
