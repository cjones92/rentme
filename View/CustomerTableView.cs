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
    partial class CustomerTableView : Form
    {
        private int selectedRowIndex = -1;

        public CustomerTableView()
        {
            InitializeComponent();
        }

        private void CustomerTableView_Load(object sender, EventArgs e)
        {
            customerDataGridView.ClearSelection();
        }

        public void RefreshCustomersDataView(List<Customer> customerList)
        {
            this.customerDataGridView.DataSource = customerList;
        }

        /// <summary>
        /// Method that returns the current selected index
        /// </summary>
        /// <returns></returns>
        public int GetSelectedRowIndex()
        {
            return selectedRowIndex;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void customerDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRowIndex = customerDataGridView.CurrentRow.Index;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Dispose();
        }
    }
}
