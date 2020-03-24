﻿using FurnitureRentals.Controller;
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
            this.customerController = new CustomerController();
            btnRegister.Enabled = true;
            btnUpdate.Enabled = true;
            txtSearch.Focus();
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
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            txtFirstName.ReadOnly = false;
            txtLastName.ReadOnly = false;
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
                cbxState.SelectedItem = customer.State;
                txtPostalCode.Text = customer.PostalCode;
                btnRegister.Enabled = false;
                btnUpdate.Enabled = true;

                txtFirstName.ReadOnly = true;
                txtLastName.ReadOnly = true;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.clearAllFields();
            cbxSearch.SelectedIndex = 0;
            txtSearch.Text = "";
            btnRegister.Enabled = true;
            btnUpdate.Enabled = true;

            txtFirstName.ReadOnly = false;
            txtLastName.ReadOnly = false;
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
                customer.State = cbxState.SelectedItem.ToString();
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
                errorMessage = "Please enter valid first name!";
            }
            else if (customer.LastName.Trim().Length == 0)
            {
                txtLastName.Focus();
                errorMessage = "Please enter valid last name!";
            }
            else if (customer.HomePhone.Trim().Length == 0)
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

            if (customer.HomePhone.Trim().Length > 0)
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

            if (customer.PostalCode.Trim().Length > 0)
            {
                string postalCode = customer.PostalCode.Trim();
                String firstPart = postalCode.Substring(0, 5);
                try
                {
                    Convert.ToInt64(firstPart);
                }
                catch (FormatException)
                {
                    txtHomePhone.Focus();
                    errorMessage = "Please enter valid postal code!";
                    return errorMessage;
                }

                String secondPart = "";
                if (postalCode.Length > 5)
                {
                    secondPart = postalCode.Substring(5, 1);
                    if (secondPart != "-")
                    {
                        txtHomePhone.Focus();
                        errorMessage = "Please enter valid postal code!";
                        return errorMessage;
                    }
                }

                String thirdPart = "";
                if (postalCode.Length == 10)
                {
                    thirdPart = postalCode.Substring(6);
                    try
                    {
                        Convert.ToInt64(thirdPart);
                    }
                    catch (FormatException)
                    {
                        txtHomePhone.Focus();
                        errorMessage = "Please enter valid postal code!";
                        return errorMessage;
                    }
                }
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                String name = txtFirstName.Text + " " + txtLastName.Text;
                Customer customer = this.customerController.GetCustomer(name, "", 0);

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

                if (this.customerController.UpdateCustomer(customer))
                {
                    MessageBox.Show("Customer updated successfully!", "Success");
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
    }
}
