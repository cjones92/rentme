using FurnitureRentals.Controller;
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
        FurnitureController furnitureController;
        int transactionID;
        ReturnShoppingCartUserControl returnCart;

        /// <summary>
        /// controller
        /// </summary>
        /// <param name="transactionID">transaction id</param>
        /// <param name="returnShoppingCart">cart</param>
        public RentalItemsFormDialog(int transactionID, ReturnShoppingCartUserControl returnShoppingCart)
        {
            InitializeComponent();
            this.furnitureController = new FurnitureController();
            this.transactionID = transactionID;
            this.LoadRentalItemDataGridView();
            rentalItemList = this.furnitureController.GetRentalItemByTransactionID(this.transactionID);
            this.returnCart = returnShoppingCart;

        }




        private void LoadRentalItemDataGridView()
        {


            RentalItemDataGridView.AllowUserToAddRows = false;
            RentalItemDataGridView.RowHeadersVisible = false;
            RentalItemDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            this.rentalItemList = this.furnitureController.GetRentalItemByTransactionID(this.transactionID);
            furnitureBindingSource.DataSource = rentalItemList;

            foreach (DataGridViewRow row in RentalItemDataGridView.Rows)
            {
                Furniture rentalItem = (Furniture)row.DataBoundItem;
            }

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

        }

        private void ItemsToReturnButton_Click(object sender, EventArgs e)
        {
            
            if (this.GetReturnedFurniture().Count > 0)
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
            List<Furniture> returnedItemList = new List<Furniture>();

            foreach (DataGridViewRow row in RentalItemDataGridView.Rows)
            {
                if (row.Cells[3].Value != null)
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
                    if (selectedRow.Cells[3].Value == null)
                    {
                        MessageBox.Show("Please enter a value for quantity wanted in row " + (selectedRow.Index + 1));


                    }


                    else
                    {
                        Furniture selectedFurniture = this.rentalItemList[RentalItemDataGridView.Rows[selectedRow.Index].Index];



                        selectedFurniture.QuantityBeingReturned = int.Parse(selectedRow.Cells[3].Value.ToString());


                        returnedItemList.Add(selectedFurniture);
                    }
                }
            
            return returnedItemList;
        }
        private void RentalItemDataGridView_CellValidating(object sender,
                                         DataGridViewCellValidatingEventArgs e)
        {
            int i;
            int quantityToBeReturned = 0;
            int quantityAvailable = 0;
            if (RentalItemDataGridView.SelectedRows.Count > 0 && RentalItemDataGridView.Rows[RentalItemDataGridView.CurrentCell.RowIndex].Cells[3].Value != null && int.TryParse(Convert.ToString(e.FormattedValue), out i))
            {
                
                quantityToBeReturned = int.Parse(RentalItemDataGridView.Rows[RentalItemDataGridView.CurrentCell.RowIndex].Cells[3].Value.ToString());
               
                RentalItemDataGridView.Rows[RentalItemDataGridView.CurrentCell.RowIndex].Selected = true;
            }

            if ((int.TryParse(Convert.ToString(e.FormattedValue), out i)) && (!string.IsNullOrEmpty(e.FormattedValue.ToString())))
            {
                quantityAvailable = int.Parse(RentalItemDataGridView.Rows[RentalItemDataGridView.CurrentCell.RowIndex].Cells[2].Value.ToString());
            }

            if (e.ColumnIndex == 3)
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
                    MessageBox.Show("You cannot order more than the amount available.");
                }
                else
                {

                }
            }
        }

        private void RentalItemDataGridView_CurrentCellDirtyStateChanged(object sender,
    EventArgs e)
        {
            if (RentalItemDataGridView.IsCurrentCellDirty)
            {
                RentalItemDataGridView.CommitEdit(DataGridViewDataErrorContexts.Commit);


            }
        }
    }

    }

