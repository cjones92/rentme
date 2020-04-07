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

namespace FurnitureRentals.User_Controls
{
    public partial class CustomerRentalShoppingCartUserControl : UserControl

    {
        Customer currentCustomer;
        List<Furniture> furnitureList;
        public CustomerRentalShoppingCartUserControl()
        {
            InitializeComponent();
            this.furnitureList = new List<Furniture>();
            this.currentCustomer = new Customer();
            
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
    }
}
