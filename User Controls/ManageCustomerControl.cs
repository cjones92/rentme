using FurnitureRentals.Controller;
using FurnitureRentals.Model;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace FurnitureRentals.User_Controls
{
    /// <summary>
    /// Class adds a new incident to the in-memory database
    /// </summary>
    public partial class ManageCustomerUserControl : UserControl
    {
        private readonly CustomerController customerController;

        /// <summary>
        /// Constructor initializes the class level variables
        /// </summary>
        public ManageCustomerUserControl()
        {
            InitializeComponent();
            this.customerController = new CustomerController();
            btnRegister.Enabled = false;
            btnUpdate.Enabled = false;
        }

        private void ManageCustomerUserControl_Load(object sender, EventArgs e)
        {
            cbxSearch.SelectedIndex = 0;
            cbxGender.SelectedIndex = 0;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchCriteria = cbxSearch.SelectedItem.ToString();
            string searchString = txtSearch.Text;
            Customer customer = null;

            if (searchCriteria == "First Name Last Name")
            {
                customer = this.customerController.GetCustomer(txtSearch.Text, "", 0);
            }
            else if (searchCriteria == "Phone Number")
            {
                customer = this.customerController.GetCustomer("", txtSearch.Text, 0);
            }
            else
            {
                int customerId = Convert.ToInt32(txtSearch.Text);
                if(customerId<1)
                {
                    MessageBox.Show("Invalid Customer ID entered", "Error");
                }

                customer = this.customerController.GetCustomer("", "", customerId);
            }

            if(customer==null)
            {
                MessageBox.Show("Customer doesn't exist. Please register!", "Error");
                btnRegister.Enabled = true;
                btnUpdate.Enabled = false;
            } 
            else
            {
                txtFirstName.Text = customer.FirstName;
                txtMiddleName.Text = customer.MiddleName;
                txtLastName.Text = customer.LastName;
                cbxGender.SelectedItem = customer.Gender;
                dtDateOfBirth.Value = customer.DateOfBirth;
                txtHomePhone.Text = customer.HomePhone;
                txtAddress1.Text = customer.Address1;
                txtAddress2.Text = customer.Address2;
                txtCity.Text = customer.City;
                txtState.Text = customer.State;
                txtPostalCode.Text = customer.PostalCode;
                btnRegister.Enabled = false;
                btnUpdate.Enabled = true;
            }
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
            txtState.Text = "";
            txtPostalCode.Text = "";
            btnRegister.Enabled = false;
            btnUpdate.Enabled = false;

            cbxSearch.SelectedIndex = 0;
            txtSearch.Text = "";
        }
    }
}
