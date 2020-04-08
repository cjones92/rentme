﻿using System;
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
    public partial class ViewCustomerRentalTransactionsUserControl : UserControl
    {
        Customer currentCustomer;
        List<RentalTransaction> transactionList;
        FurnitureController furnitureController;
        public ViewCustomerRentalTransactionsUserControl()
        {
            InitializeComponent();
            this.currentCustomer = new Customer();
            this.transactionList = new List<RentalTransaction>();
            this.furnitureController = new FurnitureController();
        }



        public void SetCurrentCustomer(Customer customer)
        {
            this.currentCustomer = customer;
            this.ActualNameLabel.Text = customer.FirstName + " " + customer.LastName;
            this.ActualIDLabel.Text = customer.CustomerId + "";
        }

        public void LoadIncidentGridView()
        {
            try
            {
                RentalTransactionDataGridView.AllowUserToAddRows = false;
                RentalTransactionDataGridView.RowHeadersVisible = false;

                transactionList = this.furnitureController.GetRentalTransactionsByCustomerID(this.currentCustomer.CustomerId);
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
                RentalItemsFormDialog formDialog = new RentalItemsFormDialog(int.Parse(RentalTransactionDataGridView.CurrentCell.Value.ToString()));
               
                DialogResult addedResult = formDialog.ShowDialog();
            }
        }
    }
}
