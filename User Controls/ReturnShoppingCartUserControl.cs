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
        ReturnTransaction returnTransaction = new ReturnTransaction();

        List<ReturnCart> returnCartItemList = new List<ReturnCart>();
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
        public void SetCurrentCustomer(int employeeId, Customer customer)
        {
            this.returnTransaction.CustomerID = customer.CustomerId;
            this.returnTransaction.ReturnDate = DateTime.Now;
            this.returnTransaction.CheckedinBy = employeeId;
            this.currentCustomer = customer;
            this.lblCustomerName.Text = customer.FirstName + " " + customer.LastName;
            this.lblMemberId.Text = customer.CustomerId + "";
            this.addReturn(1, 1, 1);
        }

        /// <summary>
        /// Method that adds an return item to the cart
        /// </summary>
        /// <param name="rentalId">rental id of the returning item</param>
        /// <param name="furnitureId">furniture id of the returning item</param>
        /// <param name="returnQuantity">return quantity of the returning item"></param>
        public void addReturn(int rentalId, int furnitureId, int returnQuantity)
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

            ReturnCart returnCartItem = new ReturnCart();
            returnCartItem.RentalID = rentalId;
            returnCartItem.ItemRented = furniture.ItemDescription;
            returnCartItem.Style = furniture.FurnitureStyle;
            returnCartItem.Quantity = returnQuantity;
            returnCartItem.LateFee = lateFee;
            returnCartItem.Refund = refundAmount;

            bool itemNotFoundInCart = true;
            foreach(ReturnCart returnItem in returnCartItemList)
            {
                if(returnItem.RentalID == rentalId && furniture.FurnitureID == furnitureId)
                {
                    returnItem.Quantity = returnQuantity;
                    itemNotFoundInCart = false;
                }
            }

            if(itemNotFoundInCart)
            {
                returnCartItemList.Add(returnCartItem);
            }
            
            returnItemBindingSource.DataSource = returnCartItemList;

            returnTransaction.LateFee = CalculateLateFee();
            returnTransaction.RefundAmount = CalculateRefundAmount();

            txtLateFee.Text = Convert.ToString(returnTransaction.LateFee);
            txtRefundTotal.Text = Convert.ToString(returnTransaction.RefundAmount);
        }

        private decimal CalculateLateFee()
        {
            decimal totalLateFee = 0;
            foreach (ReturnCart returnItem in returnCartItemList)
            {
                totalLateFee = totalLateFee + returnItem.LateFee;
            }

            return totalLateFee;
        }

        private decimal CalculateRefundAmount()
        {
            decimal totalRefundAmount = 0;
            foreach (ReturnCart returnItem in returnCartItemList)
            {
                totalRefundAmount = totalRefundAmount + returnItem.Refund;
            }

            return totalRefundAmount;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            DialogResult RentalConfirmDialog = MessageBox.Show("Are you ready to submit?", "Return Confirmation", MessageBoxButtons.YesNo);
            if (RentalConfirmDialog == DialogResult.Yes)
            {
                this.returnTransactionController.PostReturnTransaction(this.returnTransaction, this.returnCartItemList);
                MessageBox.Show("Return transaction (ID: " + this.returnTransaction.ReturnTransactionID + ") " +
                    "are successfully posted", "Success");
                this.returnCartItemList.Clear();
                returnItemBindingSource.DataSource = new List<ReturnCart>();
            }
        }
    }
}
;