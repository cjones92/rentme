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
            btnRegister.Enabled = true;
            btnUpdate.Enabled = true;
            txtSearch.Focus();
        }

        private void ManageCustomerUserControl_Load(object sender, EventArgs e)
        {
            cbxSearch.SelectedIndex = 0;
            cbxGender.SelectedIndex = 0;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            this.clearAllFields();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchCriteria = cbxSearch.SelectedItem.ToString();
            string searchString = txtSearch.Text;
            Customer customer = null;

            string errorMessage = "";
            if (searchString.Trim().Length == 0)
            {
                errorMessage = "Please enter " + searchCriteria;
                txtSearch.Focus();
            }
            else if (searchCriteria == "First Name Last Name")
            {
                customer = this.customerController.GetCustomer(txtSearch.Text, "", 0);
            }
            else if (searchCriteria == "Phone Number")
            {
                customer = this.customerController.GetCustomer("", txtSearch.Text, 0);
            }
            else
            {
                try
                {
                    int customerId = Convert.ToInt32(txtSearch.Text);
                    if (customerId < 1)
                    {
                        errorMessage = "Invalid Customer ID entered";
                    }

                    customer = this.customerController.GetCustomer("", "", customerId);
                }
                catch (ArgumentException)
                {
                    errorMessage = "Invalid Customer ID entered";
                }
            }

            if (errorMessage.Length > 0)
            {
                MessageBox.Show(errorMessage, "Error");
            }
            else if (customer == null)
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
            this.clearAllFields();
            cbxSearch.SelectedIndex = 0;
            txtSearch.Text = "";
            btnRegister.Enabled = true;
            btnUpdate.Enabled = true;
        }

        private void clearAllFields()
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
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                Customer customer = new Customer();
                customer.FirstName = txtFirstName.Text;
                customer.MiddleName = txtMiddleName.Text;
                customer.LastName = txtLastName.Text;
                customer.Gender = cbxGender.SelectedItem.ToString();
                customer.DateOfBirth = dtDateOfBirth.Value;
                customer.Address1 = txtAddress1.Text;
                customer.Address2 = txtAddress2.Text;
                customer.City = txtCity.Text;
                customer.State = txtState.Text;
                customer.PostalCode = txtPostalCode.Text;
                customer.HomePhone = txtHomePhone.Text;

                string errorMessage = this.isValidate(customer);
                if (errorMessage.Length > 0)
                {
                    MessageBox.Show(errorMessage, "Error");
                    return;
                }

                String name = customer.FirstName + " " + customer.LastName;
                String phoneNumber = customer.HomePhone;
                if (this.isCustomerExist(name, phoneNumber))
                {
                    MessageBox.Show("Customer already exists!", "Info");
                }
                else if (this.customerController.RegisterCustomer(customer))
                {
                    MessageBox.Show("Customer registered successfully!", "Success");
                }
                else
                {
                    MessageBox.Show("Unable to register the customer!", "Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
        }

        private string isValidate(Customer customer)
        {
            string errorMessage = "";
            if (customer.FirstName.Trim().Length == 0)
            {
                txtFirstName.Focus();
                errorMessage = "Please enter first name!";
            }
            else if (customer.LastName.Trim().Length == 0)
            {
                txtLastName.Focus();
                errorMessage = "Please enter last name!";
            }
            else if (customer.HomePhone.Trim().Length == 0)
            {
                txtHomePhone.Focus();
                errorMessage = "Please enter phone number!";
            }
            else if (customer.HomePhone.Trim().Length > 0)
            {
                try
                {
                    Convert.ToInt64(customer.HomePhone);
                }
                catch (FormatException)
                {
                    txtHomePhone.Focus();
                    errorMessage = "Please enter valid phone number!";
                }
            }
            else if (customer.Address1.Trim().Length == 0)
            {
                txtAddress1.Focus();
                errorMessage = "Please enter address!";
            }
            else if (customer.City.Trim().Length == 0)
            {
                txtCity.Focus();
                errorMessage = "Please enter city!";
            }
            else if (customer.State.Trim().Length == 0)
            {
                txtState.Focus();
                errorMessage = "Please enter state!";
            }
            else if (customer.PostalCode.Trim().Length == 0)
            {
                txtPostalCode.Focus();
                errorMessage = "Please enter postal code!";
            }

            return errorMessage;
        }

        private Boolean isCustomerExist(String name, String phoneNumber)
        {
            Customer customer = this.customerController.GetCustomer(name, "", 0);
            if (customer != null)
            {
                return true;
            }

            customer = this.customerController.GetCustomer("", phoneNumber, 0);
            if (customer != null)
            {
                return true;
            }

            return false;
        }
    }
}
