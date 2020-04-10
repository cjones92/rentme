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
    public partial class CustomerRentalShoppingCartUserControl : UserControl

    {
        FurnitureController furnitureController;
        Employee currentEmployee;
        Customer currentCustomer;
        List<Furniture> furnitureList;
        public CustomerRentalShoppingCartUserControl()
        {
            InitializeComponent();
            this.furnitureController = new FurnitureController();
            this.furnitureList = new List<Furniture>();
            this.currentCustomer = new Customer();
            this.DaysRentingTextBox.Text = "1";
            
            
        }

        public void SetCurrentEmployee(Employee employee)
        {
            this.currentEmployee = employee;
        }

        public void SetCurrentCustomer(Customer customer)
        {
            this.currentCustomer = customer;
            this.ActualNameLabel.Text = customer.FirstName + " " + customer.LastName;
            this.ActualIDLabel.Text = customer.CustomerId + "";
        }

       private void LoadRentalDataGridView()
        {
            
                RentalDataGridView.AllowUserToAddRows = false;
                RentalDataGridView.RowHeadersVisible = false;
            MessageBox.Show(this.DaysRentingTextBox.Text);
            foreach (Furniture furniture in furnitureList)
            {   if (int.Parse(this.DaysRentingTextBox.Text) == 0)
                {
                    this.DaysRentingTextBox.Text = "1";
                }
                furniture.TotalRentalCost = furniture.TotalRentalCost * int.Parse(this.DaysRentingTextBox.Text);
            }
                
                RentalDataGridView.DataSource = furnitureList.Select(o => new
                { Column1 = o.ItemDescription, Column2 = o.FurnitureStyle, Column3 = o.QuantityOrdered, Column4 = o.TotalRentalCost
                }).ToList(); ;
               


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

        

        private void FurnitureSearchButton_Click(object sender, EventArgs e)
        {
            FurnitureSearchFormDialog furnitureSearchForm = new FurnitureSearchFormDialog();
          
            DialogResult addedResult = furnitureSearchForm.ShowDialog();
            furnitureSearchForm.SetCurrentFurnitureList(furnitureList);

            if (addedResult == DialogResult.OK)
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

        private void SubmitRentalButton_Click(object sender, EventArgs e)
        {
            if (this.currentCustomer.CustomerId <= 0)
            {
                MessageBox.Show("Please select a customer before adding items to the cart feature.");
            }
            else if (string.IsNullOrEmpty(this.RentalTotalTextBox.Text)) {
                MessageBox.Show("Please add items to the order before submitting it.");
            }
            else
            {
                RentalTransaction transaction = new RentalTransaction();
                transaction.CustomerID = this.currentCustomer.CustomerId;
                transaction.RentalDate = DateTime.Today;
                transaction.DueDate = transaction.RentalDate.AddDays(furnitureList[0].DaysRented);
                transaction.TotalDue = decimal.Parse(this.RentalTotalTextBox.Text.Substring(2));
                transaction.CheckedOutByID = this.currentEmployee.EmployeeID;
                
                transaction.Status = "Pending";
                this.furnitureController.EnterRentalTransaction(transaction, furnitureList);
            }
            
        }

        private void DaysRentingTextBox_TextChanged(object sender, EventArgs e)
        {
            int value;
            if (int.TryParse(this.DaysRentingTextBox.Text, out value)) {
               

                this.LoadRentalDataGridView();
           } else if (!int.TryParse(this.DaysRentingTextBox.Text, out value) && this.DaysRentingTextBox.Text.Length > 1)
            {
                MessageBox.Show("Please enter integers (single numbers without decimal places) for the number of days rented");
            }
        }
    }
}
