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
using FurnitureRentals.View;

namespace FurnitureRentals.User_Controls
{
    /// <summary>
    /// Logic for view of return transactions
    /// </summary>
    public partial class ViewReturnTransactionsUserControl : UserControl
    {
        Customer currentCustomer;
        ReturnTransactionController returnTransactionController;

        /// <summary>
        /// Controller
        /// </summary>
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
            this.returnTransactionController = new ReturnTransactionController();
            this.RefreshDataGrid();
        }

        /// <summary>
        /// Method that sets the current customer
        /// </summary>
        public void SetCurrentCustomer(Customer customer)
        {
            this.currentCustomer = customer;
            this.lblCustomerName.Text = customer.FirstName + " " + customer.LastName;
            this.lblMemberId.Text = customer.CustomerId + "";            
            this.RefreshDataGrid();
        }

        /// <summary>
        /// Method that refrehes the return transactions.
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
                List<ReturnTransaction> transactionList = this.returnTransactionController.GetAllReturnTransactions(currentCustomer.CustomerId);
                returnTransactionBindingSource.DataSource = transactionList;
            }
        }

        private void dgvViewReturns_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvViewReturns.CurrentCell.ColumnIndex.Equals(0) && e.RowIndex != -1)
            {
                string rentalTransactionId = dgvViewReturns.CurrentCell.Value.ToString();
                ReturnTransactionItemsDialog returnTransactionDialog = new ReturnTransactionItemsDialog(this.currentCustomer, rentalTransactionId);
                returnTransactionDialog.StartPosition = FormStartPosition.CenterParent;
                returnTransactionDialog.ShowDialog();
            }
        }


    }
}
