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
    public partial class ReturnTransactionItemsDialog : Form
    {
        public ReturnTransactionItemsDialog(Customer customer, string returnTransactionID)
        {
            InitializeComponent();
            this.lblCustomerName.Text = customer.FirstName + " " + customer.LastName;
            this.lblMemberId.Text = customer.CustomerId + "";

            int transactionID = int.Parse(returnTransactionID);
            this.RefreshGrid(transactionID);
        }

        private void RefreshGrid(int transactionID)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
