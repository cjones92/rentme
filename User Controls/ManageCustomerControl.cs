using FurnitureRentals.Controller;
using FurnitureRentals.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace FurnitureRentals.User_Controls
{
    /// <summary>
    /// Logic for Manage customer user control
    /// </summary>
    public partial class ManageCustomerUserControl : UserControl
    {
        private Customer currentCustomer;
        private ToolTip toolTip = new ToolTip();
        private readonly CustomerController customerController;
        private List<Customer> customerList = new List<Customer>();
        private int customerId = 0;
        private string phoneNumber = "";

        private string[] states = new string[]
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

        /// <summary>
        /// Constructor initializes the class level variables
        /// </summary>
        public ManageCustomerUserControl()
        {
            InitializeComponent();
            this.currentCustomer = new Customer();
            this.customerController = new CustomerController();
            btnRegister.Enabled = true;
            btnUpdate.Enabled = false;
            txtSearch.Focus();
        }

        public Customer GetCurrentCustomer()
        {
            return this.currentCustomer;
        }

        public void SetCurrentCustomer(Customer customer)
        {
            this.currentCustomer = customer;
        }

        private void ManageCustomerUserControl_Load(object sender, EventArgs e)
        {
            foreach (string state in states)
            {
                cbxState.Items.Add(state);
            }

            cbxSearch.SelectedIndex = 0;
            cbxGender.SelectedIndex = 0;
            cbxState.SelectedIndex = 0;
            cbxSearch.Focus();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchCriteria = cbxSearch.SelectedItem.ToString();
            if (searchCriteria == "Phone Number")
            {
                toolTip.Show("Please enter only number without any dashes", txtSearch);
            }
            else if (searchCriteria == "Customer ID")
            {
                toolTip.Show("Please enter only numbers", txtSearch);
            }
            else
            {
                toolTip.Show("Please leave a space between first name and last name", txtSearch);
            }

            this.clearAllFields();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            customerId = 0;
            string searchCriteria = cbxSearch.SelectedItem.ToString();
            string searchString = txtSearch.Text;

            string errorMessage = "";
            if (searchString.Trim().Length == 0)
            {
                errorMessage = "Please enter " + searchCriteria;
                txtSearch.Focus();
            }
            else if (searchCriteria == "Phone Number")
            {
                try
                {
                    long phoneNumber = Convert.ToInt64(txtSearch.Text);
                    if (txtSearch.Text.Length < 10 || txtSearch.Text.Length > 10)
                    {
                        errorMessage = "Please enter valid phone number!";
                        txtSearch.Focus();
                    }

                    customerList = this.customerController.GetCustomers("", txtSearch.Text, -1);
                }
                catch (FormatException)
                {
                    errorMessage = "Please enter valid phone number!";
                    txtSearch.Focus();
                }
            }
            else if (searchCriteria == "Customer ID")
            {
                try
                {
                    int customerId = Convert.ToInt32(txtSearch.Text);
                    if (customerId < 0)
                    {
                        errorMessage = "Please enter valid customer id!";
                        txtSearch.Focus();
                    }

                    customerList = this.customerController.GetCustomers("", "", customerId);
                }
                catch (FormatException)
                {
                    errorMessage = "Please enter valid customer id!";
                    txtSearch.Focus();
                }
            }
            else
            {
                customerList = this.customerController.GetCustomers(txtSearch.Text, "", 0);
            }

            if (errorMessage.Length > 0)
            {
                MessageBox.Show(errorMessage, "Error");
            }
            else if (customerList.Count == 0)
            {
                MessageBox.Show("Customer doesn't exist. Please register!", "Error");
                btnRegister.Enabled = true;
                btnUpdate.Enabled = false;
            }
            else if (customerList.Count == 1)
            {
                this.populateCustomerData(customerList[0]);
                this.SetCurrentCustomer(customerList[0]);
            }
            else if (customerList.Count > 1)
            {
                View.CustomerTableView customerTableView = new View.CustomerTableView();
                customerTableView.RefreshCustomersDataView(customerList);
                customerTableView.StartPosition = FormStartPosition.CenterParent;
                customerTableView.ShowDialog();
                int selectedIndex = customerTableView.GetSelectedRowIndex();
                if (customerTableView.DialogResult == DialogResult.OK && selectedIndex > -1)
                {
                    this.populateCustomerData(customerList[selectedIndex]);
                    this.SetCurrentCustomer(customerList[selectedIndex]);
                }
            }
        }

        private void populateCustomerData(Customer customer)
        {
            btnRegister.Enabled = false;
            btnUpdate.Enabled = true;

            phoneNumber = customer.HomePhone;
            customerId = customer.CustomerId;
            txtFirstName.Text = customer.FirstName;
            txtMiddleName.Text = customer.MiddleName;
            txtLastName.Text = customer.LastName;
            cbxGender.SelectedItem = customer.Gender;
            dtDateOfBirth.Value = customer.DateOfBirth;
            txtHomePhone.Text = customer.HomePhone;
            txtAddress1.Text = customer.Address1;
            txtAddress2.Text = customer.Address2;
            txtCity.Text = customer.City;
            cbxState.SelectedItem = customer.State;
            txtPostalCode.Text = customer.PostalCode;
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
                customer.State = cbxState.SelectedItem.ToString();
                customer.PostalCode = txtPostalCode.Text;
                customer.HomePhone = txtHomePhone.Text;

                string errorMessage = this.isValidate(customer);
                if (errorMessage.Length > 0)
                {
                    MessageBox.Show(errorMessage, "Error");
                    return;
                }

                if (this.isCustomerExist(customer.HomePhone))
                {
                    MessageBox.Show("Customer already exists!", "Error");
                }
                else if (this.customerController.RegisterCustomer(customer))
                {
                    MessageBox.Show("Customer (ID: "+ customer.CustomerId + ") registered successfully!", "Success");
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                String name = txtFirstName.Text + " " + txtLastName.Text;
                Customer customer = new Customer();
                customer.CustomerId = this.customerId;
                customer.FirstName = txtFirstName.Text;
                customer.MiddleName = txtMiddleName.Text;
                customer.LastName = txtLastName.Text;
                customer.Gender = cbxGender.SelectedItem.ToString();
                customer.DateOfBirth = dtDateOfBirth.Value;
                customer.Address1 = txtAddress1.Text;
                customer.Address2 = txtAddress2.Text;
                customer.City = txtCity.Text;
                customer.State = cbxState.SelectedItem.ToString();
                customer.PostalCode = txtPostalCode.Text;
                customer.HomePhone = txtHomePhone.Text;

                string errorMessage = this.isValidate(customer);
                if (errorMessage.Length > 0)
                {
                    MessageBox.Show(errorMessage, "Error");
                    return;
                }

                if (phoneNumber!= customer.HomePhone && this.isCustomerExist(customer.HomePhone))
                {
                    MessageBox.Show("Phone number associated with different customer!", "Error");
                    txtHomePhone.Focus();
                }
                else if (this.customerController.UpdateCustomer(customer))
                {
                    MessageBox.Show("Customer (ID: "+customer.CustomerId+") updated successfully!", "Success");
                }
                else
                {
                    MessageBox.Show("Unable to updated the customer!", "Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.clearAllFields();
            cbxSearch.SelectedIndex = 0;
            txtSearch.Text = "";
            btnRegister.Enabled = true;
            btnUpdate.Enabled = false;
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
            cbxState.SelectedIndex = 0;
            txtPostalCode.Text = "";
            btnRegister.Enabled = true;
            btnUpdate.Enabled = false;
        }

        private string isValidate(Customer customer)
        {
            string errorMessage = "";
            if (customer.FirstName.Trim().Length == 0)
            {
                txtFirstName.Focus();
                errorMessage = "Please enter valid first name!";
            }
            else if (customer.LastName.Trim().Length == 0)
            {
                txtLastName.Focus();
                errorMessage = "Please enter valid last name!";
            }
            else {
                if(dtDateOfBirth.Value >= DateTime.Now)
                {
                    errorMessage = "Customer needs to be atleast 18 years old!";
                } 
                else
                {
                    DateTime dateOfBirth = dtDateOfBirth.Value;
                    DateTime dateOfBirth18 = new DateTime(dateOfBirth.Year + 18, dateOfBirth.Month, dateOfBirth.Day);

                    if (dateOfBirth18 > DateTime.Now)
                    {
                        errorMessage = "Customer needs to be atleast 18 years old!";
                    }
                }
            }

            if(errorMessage.Length>0)
            {
                return errorMessage;
            } 
            
            if (customer.HomePhone.Trim().Length == 0)
            {
                txtHomePhone.Focus();
                errorMessage = "Please enter valid phone number!";
            }
            else if (customer.Address1.Trim().Length == 0)
            {
                txtAddress1.Focus();
                errorMessage = "Please enter valid address1!";
            }
            else if (customer.City.Trim().Length == 0)
            {
                txtCity.Focus();
                errorMessage = "Please enter city!";
            }
            else if (customer.PostalCode.Trim().Length == 0 ||
                customer.PostalCode.Trim().Length < 5 ||
                customer.PostalCode.Trim().Length == 6 ||
                (customer.PostalCode.Trim().Length > 6 && customer.PostalCode.Trim().Length < 10))
            {
                txtPostalCode.Focus();
                errorMessage = "Please enter valid postal code!";
            }

            if(errorMessage.Length>0)
            {
                return errorMessage;
            } 
            
            if (customer.HomePhone.Trim().Length != 10)
            {
                txtHomePhone.Focus();
                errorMessage = "Please enter valid phone number!";
            }
            else
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

            if (errorMessage.Length > 0)
            {
                return errorMessage;
            }

            if (customer.PostalCode.Trim().Length == 5)
            {
                string postalCode = customer.PostalCode.Trim();
                try
                {
                    Convert.ToInt64(postalCode);
                }
                catch (FormatException)
                {
                    txtPostalCode.Focus();
                    errorMessage = "Please enter valid postal code!";
                }
            }
            else if (customer.PostalCode.Trim().Length == 10)
            {
                string postalCode = customer.PostalCode.Trim();
                String firstPart = postalCode.Substring(0, 5);
                String secondPart = postalCode.Substring(5, 1);
                String thirdPart = postalCode.Substring(6);

                try
                {
                    Convert.ToInt64(firstPart);
                }
                catch (FormatException)
                {
                    txtPostalCode.Focus();
                    errorMessage = "Please enter valid postal code!";
                }

                if (secondPart != "-")
                {
                    txtPostalCode.Focus();
                    errorMessage = "Please enter valid postal code!";
                }

                try
                {
                    Convert.ToInt64(thirdPart);
                }
                catch (FormatException)
                {
                    txtPostalCode.Focus();
                    errorMessage = "Please enter valid postal code!";
                }
            }
            else
            {
                txtPostalCode.Focus();
                errorMessage = "Please enter valid postal code!";
            }

            return errorMessage;
        }

        private Boolean isCustomerExist(String phoneNumber)
        {
            List<Customer> customerList = this.customerController.GetCustomers("", phoneNumber, 0);
            if (customerList.Count > 0)
            {
                return true;
            }

            return false;
        }

        private void cbxSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.clearAllFields();
            txtSearch.Text = "";
            btnRegister.Enabled = true;
            btnUpdate.Enabled = false;
        }
    }
}
