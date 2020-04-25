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
    /// <summary>
    /// Class that defines a table view with 
    /// a list of employees having same first and last name.
    /// </summary>
    public partial class EmployeeTableView : Form
    {
        private int selectedRowIndex = -1;

        /// <summary>
        /// Class constructor.
        /// </summary>
        public EmployeeTableView()
        {
            InitializeComponent();
        }

        private void EmployeeTableView_Load(object sender, EventArgs e)
        {
            employeeDataGridView.ClearSelection();
        }

        /// <summary>
        /// Updates the data in the view.
        /// </summary>
        /// <param name="employeeList"></param>
        public void RefreshEmployeesDataView(List<Employee> employeeList)
        {
            this.employeeDataGridView.DataSource = employeeList;
        }

        /// <summary>
        /// Returns the current selected index.
        /// </summary>
        /// <returns>selectedRowIndex</returns>
        public int GetSelectedRowIndex()
        {
            return selectedRowIndex;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void employeeDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRowIndex = employeeDataGridView.CurrentRow.Index;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Dispose();
        }
    }
}
