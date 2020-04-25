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
    /// Logic for view of customer rental transactions
    /// </summary>
    public partial class ViewCustomerRentalTransactionsUserControl : UserControl
    {
        Customer currentCustomer;
        Employee currentEmployee;
        List<RentalTransaction> transactionList;
        FurnitureController furnitureController;
        ReturnShoppingCartUserControl returnCart;


        /// <summary>
        /// Controller
        /// </summary>
        /// <param name="returnCart"></param>

        public ViewCustomerRentalTransactionsUserControl()
        {
            InitializeComponent();
            this.currentCustomer = new Customer();
            this.transactionList = new List<RentalTransaction>();
            this.furnitureController = new FurnitureController();
            this.currentEmployee = new Employee();


        }

        /// <summary>
        /// Sets current employee
        /// </summary>
        /// <param name="employee">employee object</param>
        public void SetCurrentEmployee(Employee employee)
        {
            this.currentEmployee = employee;
        }


        /// <summary>
        /// Sets return cart
        /// </summary>
        /// <param name="returnCart">ReturnCart object</param>
        public void SetReturnCart(ReturnShoppingCartUserControl returnCart)
        {
            this.returnCart = returnCart;
        }


        /// <summary>
        /// Set current customer
        /// </summary>
        /// <param name="customer">customer object</param>
        public void SetCurrentCustomer(Customer customer)
        {
            this.currentCustomer = customer;
            this.ActualNameLabel.Text = customer.FirstName + " " + customer.LastName;
            this.ActualIDLabel.Text = customer.CustomerId + "";
        }

        /// <summary>
        /// Loads grid for rental transactions
        /// </summary>
        public void LoadRentalTransactionDataGridView()
        {
            try
            {
                RentalTransactionDataGridView.AllowUserToAddRows = false;
                RentalTransactionDataGridView.RowHeadersVisible = false;

                transactionList = this.furnitureController.GetRentalTransactionsByCustomerID(this.currentCustomer.CustomerId);

                foreach (RentalTransaction transaction in transactionList)
                {
                    int totalRentalSpan = (int)(transaction.DueDate - transaction.RentalDate).TotalDays;
                    if (totalRentalSpan == 0)
                    {
                        totalRentalSpan = 1;
                    }
                    decimal dailyRate = transaction.TotalDue / totalRentalSpan;

                    int daysSinceRental = (int)(DateTime.Today - transaction.RentalDate).TotalDays;

                    transaction.CurrentAmountDue = dailyRate * daysSinceRental;
                    if (transaction.CurrentAmountDue > transaction.TotalDue || daysSinceRental == 0)
                    {
                        transaction.CurrentAmountDue = transaction.TotalDue;
                    }
                }

                rentalTransactionBindingSource.DataSource = transactionList;

                foreach (DataGridViewRow row in RentalTransactionDataGridView.Rows)
                {
                    RentalTransaction transaction = (RentalTransaction)row.DataBoundItem;
                }

                RentalTransactionDataGridView.AutoResizeColumns();
                RentalTransactionDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                RentalTransactionDataGridView.AutoResizeRows();
                RentalTransactionDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

                int width = 0;

                foreach (DataGridViewColumn column in RentalTransactionDataGridView.Columns)
                {
                    width += column.Width;
                }
                RentalTransactionDataGridView.Width = width;

            }
            catch (Exception)
            {
                MessageBox.Show("There was a problem reaching the database. Please check the database connection.");
            }

        }

        private void RentalTransactionDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (RentalTransactionDataGridView.CurrentCell.ColumnIndex.Equals(0) && e.RowIndex != -1)
            {
                try
                {

                    RentalItemsFormDialog formDialog = new RentalItemsFormDialog(int.Parse(RentalTransactionDataGridView.CurrentCell.Value.ToString()), this.returnCart);
                    formDialog.SetReturnCartValues(this.returnCart.GetReturnCartItemList());
                    formDialog.SetCurrentEmployee(this.currentEmployee);

                    DialogResult addedResult = formDialog.ShowDialog();

                    if (addedResult == DialogResult.OK)
                    {


                        List<Furniture> list = formDialog.GetReturnedFurniture();
                        foreach (Furniture furniture in list)
                        {

                            this.returnCart.addReturn(furniture.RentalTransactionID, furniture.RentalItemID, furniture.FurnitureID, furniture.QuantityBeingReturned);

                        }

                        formDialog.Dispose();

                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("The database could not be reached. Please try again");
                }
            }
        }
    }
}
