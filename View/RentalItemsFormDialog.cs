using FurnitureRentals.Controller;
using FurnitureRentals.Model;
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
    public partial class RentalItemsFormDialog : Form
    {
        FurnitureController furnitureController;
        int transactionID;
        public RentalItemsFormDialog(int transactionID)
        {
            InitializeComponent();
            this.furnitureController = new FurnitureController();
            this.transactionID = transactionID;
            this.LoadRentalItemDataGridView();
        }

        

        
        private void LoadRentalItemDataGridView()
        {
            List<Furniture> rentalItemList = new List<Furniture>();
            
                RentalItemDataGridView.AllowUserToAddRows = false;
                RentalItemDataGridView.RowHeadersVisible = false;
            MessageBox.Show("" + this.transactionID);
                rentalItemList = this.furnitureController.GetRentalItemByTransactionID(this.transactionID);
                furnitureBindingSource.DataSource = rentalItemList;

                foreach (DataGridViewRow row in RentalItemDataGridView.Rows)
                {
                    RentalTransaction transaction = (RentalTransaction)row.DataBoundItem;
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
           




        
    }

    }

