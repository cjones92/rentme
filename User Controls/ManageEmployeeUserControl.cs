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

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (this.IsValidData())
            {
                try
                {
                    this.employee.FirstName = txtFirstName.Text;
                    this.employee.MiddleName = txtMiddleName.Text;
                    this.employee.LastName = txtLastName.Text;
                    this.employee.Sex = cbxGender.Text;
                    this.employee.DateOfBirth = dtDateOfBirth.Value.Date;
                    this.employee.Phone = txtHomePhone.Text;
                    this.employee.Address1 = txtAddress1.Text;
                    this.employee.Address2 = txtAddress2.Text;
                    this.employee.City = txtCity.Text;
                    this.employee.State = cbxState.Text;
                    this.employee.PostalCode = txtPostalCode.Text;
                    this.employee.UserName = txtUsername.Text;
                    this.employee.Password = txtPassword.Text;
                    this.employee.Status = cbxStatus.Text;

                    bool isRegistered = this.employeeController.RegisterEmployee(this.employee);

                    if (isRegistered)
                    {
                        MessageBox.Show("Employee has been created successfully.", "Registration Complete");
                    }
                    else
                    {
                        MessageBox.Show("Employee could not be registered at this time");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
            }
        }


        private bool IsValidData()
        {

            if (txtFirstName.Text == "" ||
                txtLastName.Text == "" ||
                !dateChosen ||
                txtHomePhone.Text == "" ||
                txtAddress1.Text == "" ||
                txtCity.Text == "" ||
                txtPostalCode.Text == "" ||
                cbxGender.Text == "" ||
                cbxState.Text == "" ||
                txtUsername.Text == "" ||
                txtPassword.Text == "" ||
                cbxStatus.Text == "")
            {
                MessageBox.Show("Some fields on your form are empty. Please check your information.");
                return false;
            }

            else if (txtFirstName.Text.Length > 45)
            {
                MessageBox.Show("First Name cannot be longer than 45 characters.", "Invalid First Name");
                return false;
            }
            else if (txtLastName.Text.Length > 45)
            {
                MessageBox.Show("Last Name cannot be longer than 45 characters.", "Invalid Last Name");
                return false;
            }
            else if (txtAddress1.Text.Length > 250)
            {
                MessageBox.Show("Street Address cannot be longer than 250 characters.", "Invalid Street Address");
                return false;
            }

            else if (txtCity.Text.Length > 45)
            {
                MessageBox.Show("City cannot be longer than 45 characters.", "Invalid City");
                return false;
            }
            else if (txtPostalCode.Text.Length < 5 || txtPostalCode.Text.Length > 10)
            {
                MessageBox.Show("Zip code must be at least 5 digits and no more than 10.", "Invalid Zip Code");
                return false;
            }

            else if (txtUsername.Text.Length > 45)
            {
                MessageBox.Show("Username cannot be longer than 45 characters", "Invalid Username");
                return false;
            }
            else if (txtPassword.Text.Length > 45)
            {
                MessageBox.Show("Password cannot be longer than 45 characters", "Invalid Password");
                return false;
            }
            else

            {
                return true;
            }
        }

        private void dtDateOfBirth_ValueChanged(object sender, EventArgs e)
        {
            dateChosen = true;
        }
    }
}
