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
using System.Diagnostics;

namespace FurnitureRentals.User_Controls
{
    public partial class ReturnShoppingCartUserControl : UserControl
    {
        private Customer currentCustomer;
        private FurnitureController furnitureController;
        private RentalTransactionController rentalTransactionController;
        private ReturnTransactionController returnTransactionController;
        private ReturnTransaction returnTransaction = new ReturnTransaction();
        private List<ReturnCart> returnCartItemList = new List<ReturnCart>();
        private DataGridViewButtonColumn btnRemove = new DataGridViewButtonColumn();

        /// <summary>
        /// Contructor of Return Shopping cart
        /// </summary>
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

            this.txtLateFee.ReadOnly = true;
            this.txtRefundTotal.ReadOnly = true;

            returnItemBindingSource.DataSource = returnCartItemList;
            //this.addReturn(1, 1, 1);
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

            ReturnCart returnCartItem = new ReturnCart();
            returnCartItem.RentalID = rentalId;
            returnCartItem.FurnitureID = furniture.FurnitureID;
            returnCartItem.SerialNo = furniture.SerialNumber;
            returnCartItem.ItemRented = furniture.ItemDescription;
            returnCartItem.Style = furniture.FurnitureStyle;
            returnCartItem.Quantity = returnQuantity;
            returnCartItem.LateFee = 0;
            returnCartItem.Refund = 0;

            int totalQuantity = returnQuantity;
            bool itemNotFoundInCart = true;
            foreach(ReturnCart returnItem in returnCartItemList)
            {
                if (returnItem.RentalID == rentalId && furniture.FurnitureID == furnitureId)
                {
                    returnItem.Quantity += returnQuantity;
                    totalQuantity = returnItem.Quantity;
                    itemNotFoundInCart = false;

                    if (dueDate > DateTime.Now) // refund amount
                    {
                        int days = (dueDate - DateTime.Now).Days;
                        returnItem.Refund = (dailyRentalRate * days * totalQuantity);
                    }
                    else if (dueDate < DateTime.Now) // late fee
                    {
                        int days = (DateTime.Now - dueDate).Days;
                        returnItem.LateFee = (dailyFineRate * days * totalQuantity);
                    }
                }
            }
            

            if (itemNotFoundInCart)
            {
                if (dueDate > DateTime.Now) // refund amount
                {
                    int days = (dueDate - DateTime.Now).Days;
                    returnCartItem.Refund = (dailyRentalRate * days * totalQuantity);
                }
                else if (dueDate < DateTime.Now) // late fee
                {
                    int days = (DateTime.Now - dueDate).Days;
                    returnCartItem.LateFee = (dailyFineRate * days * totalQuantity);
                }

                returnCartItemList.Add(returnCartItem);
            }

            returnTransaction.LateFee = CalculateLateFee();
            returnTransaction.RefundAmount = CalculateRefundAmount();

            txtLateFee.Text = Convert.ToString(returnTransaction.LateFee);
            txtRefundTotal.Text = Convert.ToString(returnTransaction.RefundAmount);

            returnItemBindingSource.DataSource = null;
            returnItemBindingSource.DataSource = this.returnCartItemList;
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
            if (this.returnCartItemList.Count==0)
            {
                MessageBox.Show("Return cart is empty!", "Warning");
                return;
            }
            DialogResult RentalConfirmDialog = MessageBox.Show("Are you ready to submit?", "Return Confirmation", MessageBoxButtons.YesNo);
            if (RentalConfirmDialog == DialogResult.Yes)
            {
                bool result = this.returnTransactionController.PostReturnTransaction(this.returnTransaction, this.returnCartItemList);
                MessageBox.Show("Return transaction (ID: " + this.returnTransaction.ReturnTransactionID + ") " +
                    "are successfully posted", "Success");

                // update inventory
                if (result)
                {
                    foreach (ReturnCart returnItem in this.returnCartItemList)
                    {
                        this.furnitureController.UpdateInventory(returnItem.FurnitureID, returnItem.Quantity);
                    }
                }

                this.returnCartItemList.Clear();
                returnItemBindingSource.DataSource = new List<ReturnCart>();
                txtLateFee.Text = "0";
                txtRefundTotal.Text = "0";
            }
        }

        private void dgvCartReturn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvCartReturn.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {                
                this.dgvCartReturn.Rows.RemoveAt(e.RowIndex);
                returnTransaction.LateFee = CalculateLateFee();
                returnTransaction.RefundAmount = CalculateRefundAmount();

                txtLateFee.Text = Convert.ToString(returnTransaction.LateFee);
                txtRefundTotal.Text = Convert.ToString(returnTransaction.RefundAmount);
            }
        }

        /*
        private void button1_Click(object sender, EventArgs e)
        {
            int count = this.returnCartItemList.Count + 1;
            this.addReturn(1, 1, 1);
        }*/
    }
}