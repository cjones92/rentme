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
        RentalTransactionController rentalTransactionController;
        ReturnTransactionController returnTransactionController;
        //ReturnTransaction returnTransaction = new ReturnTransaction();

        List<ReturnCart> transactionList = new List<ReturnCart>();
        DataGridViewButtonColumn btnRemove = new DataGridViewButtonColumn();

        public ReturnShoppingCartUserControl()
        {
            InitializeComponent();
            this.currentCustomer = new Customer();
            this.furnitureController = new FurnitureController();
            this.rentalTransactionController = new RentalTransactionController();
            this.returnTransactionController = new ReturnTransactionController();

            dgvCartReturn.AllowUserToAddRows = false;
            dgvCartReturn.RowHeadersVisible = false;
            dgvCartReturn.DefaultCellStyle.WrapMode = DataGridViewTriState.False;
            dgvCartReturn.AutoResizeColumns();
            dgvCartReturn.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvCartReturn.AutoResizeRows();
            dgvCartReturn.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvCartReturn.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            btnRemove.Text = "Remove";
            dgvCartReturn.Columns.Add(btnRemove);
        }

        /// <summary>
        /// Method that sets the current customer
        /// </summary>
        public void SetCurrentCustomer(Customer customer)
        {
            this.currentCustomer = customer;
            this.lblCustomerName.Text = customer.FirstName + " " + customer.LastName;
            this.lblMemberId.Text = customer.CustomerId + "";
            this.addReturn(1, 1, "T001", 1);
        }

        /// <summary>
        /// Method that refrehes the incidents.
        /// This gets invoked automatically when a new incident is added
        /// </summary>
        public void addReturn(int rentalId, int furnitureId, String serialNo, int returnQuantity)
        {
            Furniture furniture = this.furnitureController.GetFurnitureByID(furnitureId);
            RentalTransaction rentalTransaction = this.rentalTransactionController.GetRentalTransactionsByID(rentalId);

            decimal dailyRentalRate = furniture.DailyRentalRate;
            decimal dailyFineRate = furniture.DailyFineRate;

            DateTime rentedOn = rentalTransaction.RentalDate;
            DateTime dueDate = rentalTransaction.DueDate;

            decimal lateFee = 0;
            decimal refundAmount = 0;

            if (dueDate > DateTime.Now) // refund amount
            {
                int days = (dueDate - DateTime.Now).Days;
                refundAmount = dailyRentalRate * days;
            }
            else if (dueDate < DateTime.Now) // late fee
            {
                int days = (DateTime.Now - dueDate).Days;
                lateFee = dailyFineRate * days;
            }

            ReturnCart returnItem = new ReturnCart();
            returnItem.RentalID = rentalId;
            returnItem.SerialNo = serialNo;
            returnItem.ItemRented = furniture.ItemDescription;
            returnItem.Style = furniture.FurnitureStyle;
            returnItem.Quantity = returnQuantity;
            returnItem.LateFee = lateFee;
            returnItem.Refund = refundAmount;

            transactionList.Add(returnItem);
            returnItemBindingSource.DataSource = transactionList;

            //returnTransaction.LateFee = CalculateLateFee();
            //returnTransaction.Refund = CalculateRefundAmount();

            //txtLateFee.Text = Convert.ToString(returnTransaction.LateFee);
            //txtRefundTotal.Text = Convert.ToString(returnTransaction.Refund);
        }

        private decimal CalculateLateFee()
        {
            decimal totalLateFee = 0;
            foreach (ReturnCart returnItem in transactionList)
            {
                totalLateFee = totalLateFee + returnItem.LateFee;
            }

            return totalLateFee;
        }

        private decimal CalculateRefundAmount()
        {
            decimal totalRefundAmount = 0;
            foreach (ReturnCart returnItem in transactionList)
            {
                totalRefundAmount = totalRefundAmount + returnItem.Refund;
            }

            return totalRefundAmount;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            DialogResult RentalConfirmDialog = MessageBox.Show("Are you ready to submit?", "Return Confirmation", MessageBoxButtons.YesNo);
            if(RentalConfirmDialog == DialogResult.Yes)
            {
                //returnTransaction.cu
                //this.returnTransactionController.
                this.transactionList.Clear();
            }
        }
    }
}
