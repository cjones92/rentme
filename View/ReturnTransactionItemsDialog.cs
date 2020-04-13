using FurnitureRentals.Controller;
using FurnitureRentals.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FurnitureRentals.View
{
    /// <summary>
    /// Logic for return transaction dialog
    /// </summary>
    public partial class ReturnTransactionItemsDialog : Form
    {
        ReturnTransactionController returnTransactionController;

        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="customer">customer object</param>
        /// <param name="returnTransactionID"> return transaction id</param>
        public ReturnTransactionItemsDialog(Customer customer, string returnTransactionID)
        {
            InitializeComponent();
            this.returnTransactionController = new ReturnTransactionController();

            dgReturnItems.AllowUserToAddRows = false;
            dgReturnItems.RowHeadersVisible = false;
            dgReturnItems.DefaultCellStyle.WrapMode = DataGridViewTriState.False;
            dgReturnItems.AutoResizeColumns();
            dgReturnItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgReturnItems.AutoResizeRows();
            dgReturnItems.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgReturnItems.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            
            this.lblCustomerName.Text = customer.FirstName + " " + customer.LastName;
            this.lblMemberId.Text = customer.CustomerId + "";

            int transactionID = int.Parse(returnTransactionID);
            this.RefreshGrid(transactionID);
        }

        private void RefreshGrid(int transactionID)
        {
            List<ReturnItemView> returnItemList =  this.returnTransactionController.GetAllReturnItems(transactionID);
            this.rentalTransactionViewBindingSource.DataSource = returnItemList;

            /*
            _cs6232_g1ViewReturnsDataSetTableAdapters.furnitureTableAdapter adapter =
                new _cs6232_g1ViewReturnsDataSetTableAdapters.furnitureTableAdapter();

            _cs6232_g1ViewReturnsDataSet.furnitureDataTable dataTable = new _cs6232_g1ViewReturnsDataSet.furnitureDataTable();
            adapter.FetchReturnItemsByTransactionId(dataTable, transactionID);
            this.dgReturnItems.DataSource = dataTable;
            */
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
