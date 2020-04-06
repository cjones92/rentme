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
        List<Furniture> furnitureList;
        public CustomerRentalShoppingCartUserControl()
        {
            InitializeComponent();
            this.furnitureList = new List<Furniture>();
        }

       private void LoadRentalDataGridView()
        {
            try
            {
                RentalDataGridView.AllowUserToAddRows = false;
                RentalDataGridView.RowHeadersVisible = false;
              
                
                RentalDataGridView.DataSource = furnitureList;
               

                foreach (DataGridViewRow row in RentalDataGridView.Rows)
                {
                    Furniture furniture = (Furniture)row.DataBoundItem;
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

            }
            catch (Exception)
            {
                MessageBox.Show("There was a problem reaching the database. Please check the database connection.");
            }
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
    }
}
