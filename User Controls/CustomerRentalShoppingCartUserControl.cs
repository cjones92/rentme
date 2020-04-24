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
using FurnitureRentals.View;
using Microsoft.VisualBasic.ApplicationServices;
using FurnitureRentals.Controller;

namespace FurnitureRentals.User_Controls
{
    /// <summary>
    /// Logic for customer rental cart
    /// </summary>
    public partial class CustomerRentalShoppingCartUserControl : UserControl

    {
        FurnitureController furnitureController;
        Employee currentEmployee;
        Customer currentCustomer;
        List<Furniture> furnitureList;

        /// <summary>
        /// Controller
        /// </summary>
        public CustomerRentalShoppingCartUserControl()
        {
            InitializeComponent();
            this.furnitureController = new FurnitureController();
            this.furnitureList = new List<Furniture>();
            this.currentCustomer = new Customer();
            this.DaysRentingTextBox.Text = "1";
            this.RentalDataGridView.EditMode = DataGridViewEditMode.EditOnKeystroke;
            
            
        }

        /// <summary>
        /// sets current employee
        /// </summary>
        /// <param name="employee">employee object</param>
        public void SetCurrentEmployee(Employee employee)
        {
            this.currentEmployee = employee;
        }

        /// <summary>
        /// sets current customer
        /// </summary>
        /// <param name="customer">customer object</param>
        public void SetCurrentCustomer(Customer customer)
        {
            this.currentCustomer = customer;
            this.ActualNameLabel.Text = customer.FirstName + " " + customer.LastName;
            this.ActualIDLabel.Text = customer.CustomerId + "";
        }

       private void LoadRentalDataGridView()
        {
            try
            {
                if (this.DaysRentingTextBox.TextLength == 0)
                {
                    MessageBox.Show("There must be a value for days to properly calculate rental transaction costs.");
                }
                else
                {

                    RentalDataGridView.AutoGenerateColumns = false;
                    RentalDataGridView.AllowUserToAddRows = false;
                    RentalDataGridView.RowHeadersVisible = false;




                    var furnitureBindingList = new BindingList<Furniture>(furnitureList);
                    furnitureBindingList.AllowEdit = true;


                    RentalDataGridView.ReadOnly = false;
                    RentalDataGridView.DataSource = furnitureBindingList.Select(o => new
                    {
                        Item = o.ItemDescription,
                        Style = o.FurnitureStyle,
                        Remove = "X"
                    }).ToList(); ;

                    foreach (DataGridViewRow row in RentalDataGridView.Rows)
                    {
                        row.Cells[2].Value = furnitureBindingList[row.Index].QuantityOrdered;
                        row.Cells[3].Value = furnitureBindingList[row.Index].QuantityOrdered * furnitureBindingList[row.Index].DailyRentalRate * int.Parse(this.DaysRentingTextBox.Text);
                    }
                    RentalDataGridView.AutoResizeColumns();
                    RentalDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    RentalDataGridView.AutoResizeRows();
                    RentalDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

                    int width = 0;

                    foreach (DataGridViewColumn column in RentalDataGridView.Columns)
                    {
                        width += column.Width;
                    }
                    RentalDataGridView.Width = width;
                    this.FillInTotal();
                    foreach (Furniture furniture in furnitureList)
                    {
                        furniture.TotalRentalCost = furniture.TotalRentalCost / int.Parse(this.DaysRentingTextBox.Text);
                    }

                }
            }
            catch (Exception)
            {
                MessageBox.Show("There was a problem reaching the database. Please check the database connection.");
            }

        }

        private void TabulateRentalCosts()
        {
            foreach (Furniture furniture in furnitureList)
            {
                if (int.Parse(this.DaysRentingTextBox.Text) == 0)
                {
                    this.DaysRentingTextBox.Text = "1";
                }

                furniture.QuantityOrdered = int.Parse(RentalDataGridView.Rows[furnitureList.IndexOf(furniture)].Cells[2].Value.ToString());

                decimal rentalRate = this.furnitureList[furnitureList.IndexOf(furniture)].DailyRentalRate;
                furniture.TotalRentalCost = furniture.QuantityOrdered * rentalRate;
                furniture.TotalRentalCost = furniture.TotalRentalCost * int.Parse(this.DaysRentingTextBox.Text);
            }
        }

        

        private void FurnitureSearchButton_Click(object sender, EventArgs e)
        {
            FurnitureSearchFormDialog furnitureSearchForm = new FurnitureSearchFormDialog();
          
            DialogResult addedResult = furnitureSearchForm.ShowDialog();
            furnitureSearchForm.SetCurrentFurnitureList(furnitureList);

            if (addedResult == DialogResult.OK )
            {
                List<Furniture> addedItems = furnitureSearchForm.GetSelectedFurniture();



                foreach (Furniture furniture in addedItems)
                {
                   
                    furnitureList.Add(furniture);
                    
                }
                this.LoadRentalDataGridView();
            }

        }

        private void FillInTotal()
        {
            
            decimal total = 0;
            foreach (DataGridViewRow row in RentalDataGridView.Rows)
            {
               
                total = total + decimal.Parse(row.Cells[3].Value.ToString());
            }

            this.RentalTotalTextBox.Text = "$ " + total;
        }

        private Boolean CheckRowQuantities()
        {
            int value;
            foreach (DataGridViewRow row in RentalDataGridView.Rows)
            {
                if (string.IsNullOrEmpty(row.Cells[2].Value.ToString()) || int.TryParse(row.Cells[2].Value.ToString(), out value) || int.Parse(row.Cells[2].Value.ToString()) <= 0)
                {
                    return false;

                }
            }
            return true;
        }

        private void SubmitRentalButton_Click(object sender, EventArgs e)
        { int value;
           
          
            
            
            
            if (this.currentCustomer.CustomerId <= 0)
            {
                MessageBox.Show("Please select a customer before adding items to the cart feature.");
            } else if(!this.CheckRowQuantities())
            {
                MessageBox.Show("Please make sure a positive integer value is entered for all quantities");
            }
            else if (string.IsNullOrEmpty(this.RentalTotalTextBox.Text)) {
                MessageBox.Show("Please add items to the order before submitting it.");
            } 
            else
            {
                SubmitTransactionDialog confirmTransactionForm = new SubmitTransactionDialog();

                DialogResult addedResult = confirmTransactionForm.ShowDialog();

                if (addedResult == DialogResult.OK && int.TryParse(this.DaysRentingTextBox.Text, out value) && int.Parse(this.DaysRentingTextBox.Text) > 0 && this.DaysRentingTextBox.Text.Length > 0)
                {

                    RentalTransaction transaction = new RentalTransaction();
                    transaction.CustomerID = this.currentCustomer.CustomerId;
                    transaction.RentalDate = DateTime.Today;
                    transaction.DueDate = transaction.RentalDate.AddDays(int.Parse(this.DaysRentingTextBox.Text));
                    transaction.TotalDue = decimal.Parse(this.RentalTotalTextBox.Text.Substring(2));
                    transaction.CheckedOutByID = this.currentEmployee.EmployeeID;

                    transaction.Status = "Pending";
                    this.furnitureController.EnterRentalTransaction(transaction, furnitureList);
                    MessageBox.Show("The transaction was successfully processed");
                } else
                {
                    MessageBox.Show("The transaction was not successfully processed. Please check all values to ensure that a transaction can be successful.");
                }
            }
            
        }

        private void DaysRentingTextBox_TextChanged(object sender, EventArgs e)
        {
           
            int value;
            if (!string.IsNullOrEmpty(this.DaysRentingTextBox.Text) && int.TryParse(this.DaysRentingTextBox.Text, out value) && int.Parse(this.DaysRentingTextBox.Text) > 0 && this.DaysRentingTextBox.Text.Length > 0) {
                
                this.LoadRentalDataGridView();
           } else if (!int.TryParse(this.DaysRentingTextBox.Text, out value) && this.DaysRentingTextBox.Text.Length > 0)
            {
                
                if (int.TryParse(this.DaysRentingTextBox.Text, out value) && int.Parse(this.DaysRentingTextBox.Text) <= 0) {
                    MessageBox.Show("Please only enter positive integers.");
                    this.DaysRentingTextBox.Text = "1";
                } else
                {
                    MessageBox.Show("Please enter positive integers for the number of days rented");
                    this.DaysRentingTextBox.Text = "1";
                }
            }
        }

        private void RentalDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (RentalDataGridView.CurrentCell.ColumnIndex.Equals(4) && e.RowIndex != -1)
            {
                furnitureList.RemoveAt(RentalDataGridView.CurrentCell.RowIndex);
                
                this.LoadRentalDataGridView();
            } else if (RentalDataGridView.CurrentCell.ColumnIndex.Equals(2) && e.RowIndex != -1)
            {

                RentalDataGridView.Rows[RentalDataGridView.CurrentCell.RowIndex].Selected = true;

            }
        }

        private void EmptyCartButton_Click(object sender, EventArgs e)
        {
            this.DaysRentingTextBox.Text = "1";
            this.RentalTotalTextBox.ResetText();
            furnitureList.Clear();
            this.RentalDataGridView.DataSource = null;
        }

        private void RentalDataGridView_CellValidating(object sender,
                                         DataGridViewCellValidatingEventArgs e)
        {

            if (e.ColumnIndex == 2)
            {
                int i;
                int quantityToBeOrdered = 1;
                int quantityAvailable = 1;
                if (RentalDataGridView.Rows[RentalDataGridView.CurrentCell.RowIndex].Cells[2].Value != null && int.TryParse(Convert.ToString(e.FormattedValue), out i))
                {
                    if (int.Parse((Convert.ToString(e.FormattedValue))) > 0)
                    {
                        quantityToBeOrdered = int.Parse(RentalDataGridView.Rows[RentalDataGridView.CurrentCell.RowIndex].Cells[2].Value.ToString());
                    }

                }
                if (RentalDataGridView.Rows.Count == furnitureList.Count)
                {
                    quantityAvailable = furnitureList[RentalDataGridView.CurrentCell.RowIndex].Quantity;
                }

                if (string.IsNullOrEmpty(e.FormattedValue.ToString()))
                {

                }

                else if (!int.TryParse(Convert.ToString(e.FormattedValue), out i))
                {
                    
                    MessageBox.Show("Please enter a numeric value");
                    furnitureList[RentalDataGridView.CurrentCell.RowIndex].QuantityOrdered = furnitureList[RentalDataGridView.CurrentCell.RowIndex].QuantityOrdered;
                    e.Cancel = false;
                }
                 
                else if (quantityToBeOrdered > quantityAvailable)
                {
                    
                    MessageBox.Show("You cannot order more than the amount available.");
                    furnitureList[RentalDataGridView.CurrentCell.RowIndex].QuantityOrdered = furnitureList[RentalDataGridView.CurrentCell.RowIndex].QuantityOrdered;
                    e.Cancel = false;
                }
                else
                {
                    furnitureList[RentalDataGridView.CurrentCell.RowIndex].QuantityOrdered = quantityToBeOrdered;
                    
                    
                }
            }
        }

        private void DaysRented_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)) e.Handled = true;         //Just Digits
            if (e.KeyChar == (char)8) e.Handled = false;            //Allow Backspace
                        
        }

        private void RentalDataGridView_CurrentCellDirtyStateChanged(object sender,
    EventArgs e)
        {
            if (RentalDataGridView.IsCurrentCellDirty)
            {
                
                RentalDataGridView.CommitEdit(DataGridViewDataErrorContexts.Commit);
                RentalDataGridView.EndEdit();
               


            }
        }

        private void RentalDataGridView_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            int value;
            
            if (!RentalDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected)
            {
                return;
            }

            if (int.TryParse(this.DaysRentingTextBox.Text, out value) && int.Parse(this.DaysRentingTextBox.Text) <= 0)
            {
                MessageBox.Show("Quantity ordered must be positive");

            }
            else if (int.TryParse(this.DaysRentingTextBox.Text, out value) && int.Parse(this.DaysRentingTextBox.Text) > 0 && this.DaysRentingTextBox.Text.Length > 0)
            {

                this.LoadRentalDataGridView();
            }
            
        }

        private void RentalDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int value = 0;
            if(RentalDataGridView.IsCurrentCellDirty && RentalDataGridView.CurrentCell.Value != null && int.TryParse(RentalDataGridView.CurrentCell.Value.ToString(), out value) && int.Parse(RentalDataGridView.CurrentCell.Value.ToString()) > 0)
            {
                this.LoadRentalDataGridView();
            }
        }
    }
}
