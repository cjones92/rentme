﻿using FurnitureRentals.Controller;
using FurnitureRentals.Model;
using FurnitureRentals.User_Controls;
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
    /// Logic for rental items form 
    /// </summary>
    public partial class RentalItemsFormDialog : Form
    {
        List<Furniture> rentalItemList;
        List<Furniture> returnItemList;
        FurnitureController furnitureController;
        RentalTransactionController rentalTransactionController;
        int transactionID;
        ReturnShoppingCartUserControl returnCart;
        Employee currentEmployee;

        /// <summary>
        /// controller
        /// </summary>
        /// <param name="transactionID">transaction id</param>
        /// <param name="returnShoppingCart">cart</param>
        public RentalItemsFormDialog(int transactionID, ReturnShoppingCartUserControl returnShoppingCart)
        {
            InitializeComponent();
            this.furnitureController = new FurnitureController();
            this.rentalTransactionController = new RentalTransactionController();
            this.transactionID = transactionID;
            this.currentEmployee = new Employee();
            this.rentalItemList = this.rentalTransactionController.GetRentalItemByTransactionID(this.transactionID);
            this.returnItemList = new List<Furniture>();
            this.returnCart = returnShoppingCart;

            this.RentalItemDataGridView.AllowUserToAddRows = false;
            this.RentalItemDataGridView.RowHeadersVisible = false;
            this.RentalItemDataGridView.DefaultCellStyle.WrapMode = DataGridViewTriState.False;
            this.RentalItemDataGridView.AutoResizeColumns();
            this.RentalItemDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            this.RentalItemDataGridView.AutoResizeRows();
            this.RentalItemDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            this.RentalItemDataGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        /// <summary>
        /// Sets current employee
        /// </summary>
        /// <param name="employee">employee object</param>
        public void SetCurrentEmployee(Employee employee)
        {
            this.currentEmployee = employee;
            this.SetEmployeeLabels();
        }

        private void SetEmployeeLabels()
        {
            this.ActualNameLabel.Text = this.currentEmployee.FirstName + " " + this.currentEmployee.LastName;
            this.ActualIDLabel.Text = "" + this.currentEmployee.EmployeeID;
        }

        /// <summary>
        /// Sets quantities found in return cart
        /// </summary>
        /// <param name="list">list of ReturnCart objects</param>
        public void SetReturnCartValues(List<ReturnCart> list)
        {
            if (this.returnItemList != null)
            {

                foreach (Furniture furniture in this.rentalItemList)
                {
                    foreach (ReturnCart returnedfurniture in list)
                    {
                        if (returnedfurniture.FurnitureID == furniture.FurnitureID && returnedfurniture.RentalID == furniture.RentalTransactionID)
                        {
                            furniture.QuantityBeingReturned = returnedfurniture.Quantity;
                        }
                    }
                }
                this.LoadRentalItemDataGridView();

            }
        }


        /// <summary>
        /// Loads RentalDataGridView
        /// </summary>
        public void LoadRentalItemDataGridView()
        {
            try
            {
                RentalItemDataGridView.AllowUserToAddRows = false;
                RentalItemDataGridView.RowHeadersVisible = false;
                RentalItemDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                foreach (Furniture furniture in this.rentalItemList)
                {
                    furniture.QuantityAlreadyReturned = this.furnitureController.GetQuantityReturned(furniture.RentalItemID);
                }


                furnitureBindingSource.DataSource = rentalItemList;

                foreach (DataGridViewRow row in RentalItemDataGridView.Rows)
                {
                    Furniture rentalItem = (Furniture)row.DataBoundItem;

                }

                /*
                RentalItemDataGridView.AutoResizeColumns();
                RentalItemDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                RentalItemDataGridView.AutoResizeRows();
                RentalItemDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

                int width = 0;


                foreach (DataGridViewColumn column in RentalItemDataGridView.Columns)
                {
                    width += column.Width;
                }
                RentalItemDataGridView.Width = width;
                */
            }
            catch (Exception)
            {
                MessageBox.Show("The database could not be reached. Please try again");
            }
        }


        private void ItemsToReturnButton_Click(object sender, EventArgs e)
        {
            if (this.RentalItemDataGridView.SelectedRows.Count == 1 && RentalItemDataGridView.SelectedRows[0].Cells[6].Value == null)
            {
                MessageBox.Show("Please enter a value for quantity");
            }

            else if (this.RentalItemDataGridView.SelectedRows.Count > 0)
            {
                MessageBox.Show("The items will now be submitted.");
                this.DialogResult = DialogResult.OK;
            }

        }

        /// <summary>
        /// Gets list of returned furniture
        /// </summary>
        /// <returns>list of furniture</returns>
        public List<Furniture> GetReturnedFurniture()
        {
            foreach (DataGridViewRow row in RentalItemDataGridView.Rows)
            {
                if (row.Cells[6].Value != null)
                {
                    row.Selected = true;
                }
                else
                {
                    row.Selected = false;
                }
            }

            foreach (DataGridViewRow selectedRow in this.RentalItemDataGridView.SelectedRows)
            {
                if (selectedRow.Cells[6].Value == null)
                {
                    MessageBox.Show("Please enter a value for quantity wanted in row " + (selectedRow.Index + 1));

                }

                else if (int.Parse(selectedRow.Cells[6].Value.ToString()) <= 0)
                {
                    MessageBox.Show("Value being returned must be higher than zero");
                }

                else
                {
                    Furniture selectedFurniture = this.rentalItemList[RentalItemDataGridView.Rows[selectedRow.Index].Index];
                    selectedFurniture.QuantityBeingReturned = int.Parse(selectedRow.Cells[6].Value.ToString());

                    this.returnItemList.Add(selectedFurniture);
                }
            }

            return this.returnItemList;
        }


        private void RentalItemDataGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            int i;
            int quantityOrdered = int.Parse(RentalItemDataGridView.Rows[RentalItemDataGridView.CurrentCell.RowIndex].Cells[3].Value.ToString());
            int quantityToBeReturned = 0;
            int quantityAlreadyReturned = int.Parse(RentalItemDataGridView.Rows[RentalItemDataGridView.CurrentCell.RowIndex].Cells[4].Value.ToString());
            int quantityAvailable = 0;


            if (RentalItemDataGridView.SelectedRows.Count > 0 && RentalItemDataGridView.Rows[RentalItemDataGridView.CurrentCell.RowIndex].Cells[6].Value != null && int.TryParse(Convert.ToString(e.FormattedValue), out i))
            {


                quantityToBeReturned = int.Parse(RentalItemDataGridView.Rows[RentalItemDataGridView.CurrentCell.RowIndex].Cells[6].Value.ToString());

                RentalItemDataGridView.Rows[RentalItemDataGridView.CurrentCell.RowIndex].Selected = true;
            }

            if ((int.TryParse(Convert.ToString(e.FormattedValue), out i)) && (!string.IsNullOrEmpty(e.FormattedValue.ToString())))
            {
                quantityAlreadyReturned = int.Parse(RentalItemDataGridView.Rows[RentalItemDataGridView.CurrentCell.RowIndex].Cells[4].Value.ToString());
                quantityAvailable = int.Parse(RentalItemDataGridView.Rows[RentalItemDataGridView.CurrentCell.RowIndex].Cells[3].Value.ToString()) - int.Parse(RentalItemDataGridView.Rows[RentalItemDataGridView.CurrentCell.RowIndex].Cells[4].Value.ToString()) - int.Parse(RentalItemDataGridView.Rows[RentalItemDataGridView.CurrentCell.RowIndex].Cells[5].Value.ToString());
            }

            if (e.ColumnIndex == 6)
            {
                if (string.IsNullOrEmpty(e.FormattedValue.ToString()))
                {

                }

                else if (!int.TryParse(Convert.ToString(e.FormattedValue), out i) || int.Parse(Convert.ToString(e.FormattedValue)) <= 0)
                {
                    e.Cancel = true;
                    MessageBox.Show("Please enter an integer value greater than 0");

                }
                else if (quantityToBeReturned > quantityAvailable)
                {
                    e.Cancel = true;
                    MessageBox.Show("You cannot return more than what was ordered and/or already in the cart.");
                }
                else
                {

                }
            }
        }

        private void RentalItemDataGridView_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (RentalItemDataGridView.IsCurrentCellDirty)
            {
                RentalItemDataGridView.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }
    }
}

