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
              
                
                RentalDataGridView.DataSource = furnitureList.Select(o => new
                { Column1 = o.ItemDescription, Column2 = o.FurnitureStyle, Column3 = o.QuantityAvailable, Column4 = o.TotalRentalCost
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
          
        }

        private void FurnitureSearchButton_Click(object sender, EventArgs e)
        {
            FurnitureSearchFormDialog furnitureSearchForm = new FurnitureSearchFormDialog();
            DialogResult addedResult = furnitureSearchForm.ShowDialog();

            if (addedResult == DialogResult.OK)
            {
                furnitureList = furnitureSearchForm.GetSelectedFurniture();
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
            RentalTransaction transaction = new RentalTransaction();
            transaction.CustomerID = this.currentCustomer.CustomerId;
            transaction.RentalDate = DateTime.Today;
            transaction.DueDate = transaction.RentalDate.AddDays(furnitureList[0].DaysRented);
            transaction.TotalDue = decimal.Parse(this.RentalTotalTextBox.Text.Substring(2));
            transaction.CheckedOutByID = this.currentEmployee.EmployeeID;
            MessageBox.Show(this.currentEmployee.EmployeeID + "");
            transaction.Status = "Pending";
            MessageBox.Show(this.furnitureController.EnterRentalTransaction(transaction, furnitureList));
             
            
        }
    }
}
