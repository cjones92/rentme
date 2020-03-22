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
using FurnitureRentals.Controller;

namespace FurnitureRentals.User_Controls
{
    public partial class ManageEmployeeUserControl : UserControl
    {
        private readonly EmployeeController employeeController;
        private Employee employee;
        private bool dateChosen;
        public ManageEmployeeUserControl()
        {
            InitializeComponent();
            this.employeeController = new EmployeeController();
            this.employee = new Employee();
            this.dateChosen = false;
        }


        private void ManageEmployeeUserControl_Load(object sender, EventArgs e)
        {
            string[] states = new string[]
        {
                "AL", "AK", "AZ", "AR", "CA",
                "CO", "CT", "DE", "FL", "GA",
                "HI", "ID", "IL", "IN", "IA",
                "KS", "KY", "LA", "ME", "MD",
                "MA", "MI", "MN", "MS", "MO",
                "MT", "NE", "NV", "NH", "NJ",
                "NM", "NY", "NC", "ND", "OH",
                "OK", "OR", "PA", "RI", "SC",
                "SD", "TN", "TX", "UT", "VT",
                "VA", "WA", "WV", "WI", "WY"
        };

            foreach (string state in states)
            {
                cbxState.Items.Add(state);
            }

            if (cbxState.SelectedIndex < 0)
            {
                cbxState.SelectedIndex = 0;
            }

            if (cbxGender.SelectedIndex < 0)
            {
                cbxGender.SelectedIndex = 0;
            }

            if (cbxStatus.SelectedIndex < 0)
            {
                cbxStatus.SelectedIndex = 0;
            }

            dtDateOfBirth.MaxDate = DateTime.Today;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFirstName.Text = "";
            txtMiddleName.Text = "";
            txtLastName.Text = "";
            cbxGender.SelectedIndex = 0;
            dtDateOfBirth.Value = DateTime.Now;
            txtHomePhone.Text = "";
            txtAddress1.Text = "";
            txtAddress2.Text = "";
            txtCity.Text = "";
            cbxState.SelectedIndex = 0;
            txtPostalCode.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";
            cbxStatus.SelectedIndex = 0;
            //btnRegister.Enabled = false;
            btnUpdate.Enabled = false;
            btnClear.Enabled = true;
        }





    }
}
