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
        private List<Employee> employeeList;
        private int employeeId;
        private ToolTip toolTip;

        public ManageEmployeeUserControl()
        {
            InitializeComponent();
            this.employeeController = new EmployeeController();
            this.employee = new Employee();
            this.dateChosen = false;
            txtSearch.Focus();
            // employeeId = 0;
            employeeList = new List<Employee>();
            toolTip = new ToolTip();
        }


        private void ManageEmployeeUserControl_Load(object sender, EventArgs e)
        {
            cbxSearch.SelectedIndex = 0;

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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            employeeId = 0;
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
                    employeeId = Convert.ToInt32(txtSearch.Text);
                    if (txtSearch.Text.Length < 10 || txtSearch.Text.Length > 10)
                    {
                        errorMessage = "Please enter valid phone number.";
                        txtSearch.Focus();
                    }

                    employeeList = this.employeeController.GetEmployees("", txtSearch.Text, -1);
                }
                catch (FormatException)
                {
                    errorMessage = "Invalid phone number.";
                    txtSearch.Focus();
                }
            }
            else if (searchCriteria == "Employee ID")
            {
                try
                {
                    employeeId = Convert.ToInt32(txtSearch.Text);
                    if (employeeId < 0)
                    {
                        errorMessage = "Invalid Employee ID";
                        txtSearch.Focus();
                    }

                    employeeList = this.employeeController.GetEmployees("", "", employeeId);
                }
                catch (FormatException)
                {
                    errorMessage = "Invalid Employee ID";
                    txtSearch.Focus();
                }
            }
            else
            {
                employeeList = this.employeeController.GetEmployees(txtSearch.Text, "", 0);
            }
            if (errorMessage.Length > 0)
            {
                MessageBox.Show(errorMessage, "Error");
            }
            else if (employeeList.Count == 0)
            {
                MessageBox.Show("Employee doesn't exist. Please check your information.", "Error");
                btnRegister.Enabled = true;
                btnUpdate.Enabled = false;
            }
            else if (employeeList.Count == 1)
            {
                this.populateEmployeeData(employeeList[0]);
            }
            else if (employeeList.Count > 1)
            {
                View.EmployeeTableView employeeTableView = new View.EmployeeTableView();
                employeeTableView.RefreshEmployeesDataView(employeeList);
                employeeTableView.StartPosition = FormStartPosition.CenterParent;
                employeeTableView.ShowDialog();
                int selectedIndex = employeeTableView.GetSelectedRowIndex();
                if (employeeTableView.DialogResult == DialogResult.OK && selectedIndex > -1)
                {
                    this.populateEmployeeData(employeeList[selectedIndex]);
                }
            }
        }



        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchCriteria = cbxSearch.SelectedItem.ToString();
            if (searchCriteria == "Phone Number")
            {
                toolTip.Show("Please enter only number without any dashes", txtSearch);
            }
            else if (searchCriteria == "Employee ID")
            {
                toolTip.Show("Please enter only numbers", txtSearch);
            }
            else
            {
                toolTip.Show("Please leave a space between first name and last name", txtSearch);
            }

        }


        private void populateEmployeeData(Employee employee)
        {
            btnRegister.Enabled = false;
            btnUpdate.Enabled = true;

            employeeId = employee.EmployeeID;
            txtFirstName.Text = employee.FirstName;
            txtMiddleName.Text = employee.MiddleName;
            txtLastName.Text = employee.LastName;
            cbxGender.SelectedItem = employee.Sex;
            dtDateOfBirth.Value = employee.DateOfBirth;
            txtHomePhone.Text = employee.Phone;
            txtAddress1.Text = employee.Address1;
            txtAddress2.Text = employee.Address2;
            txtCity.Text = employee.City;
            cbxState.Text = employee.State;
            txtPostalCode.Text = employee.PostalCode;
            txtUsername.Text = employee.UserName;
            txtPassword.Text = employee.Password;
            cbxStatus.Text = employee.Status;
        }



        private void btnClear_Click(object sender, EventArgs e)
        {
            cbxSearch.SelectedIndex = 0;
            txtSearch.Text = "";
            txtFirstName.Text = "";
            txtMiddleName.Text = "";
            txtLastName.Text = "";
            cbxGender.SelectedIndex = 0;
            dtDateOfBirth.Value = DateTime.Today;
            txtHomePhone.Text = "";
            txtAddress1.Text = "";
            txtAddress2.Text = "";
            txtCity.Text = "";
            cbxState.SelectedIndex = 0;
            txtPostalCode.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";
            cbxStatus.SelectedIndex = 0;
            btnRegister.Enabled = true;
            btnUpdate.Enabled = false;
            btnClear.Enabled = true;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

            if (this.IsValidData())
            {
                try
                {
                    Employee employee = new Employee();
                    employee.FirstName = txtFirstName.Text;
                    employee.MiddleName = txtMiddleName.Text;
                    employee.LastName = txtLastName.Text;
                    employee.Sex = cbxGender.Text;
                    employee.DateOfBirth = dtDateOfBirth.Value.Date;
                    employee.Phone = txtHomePhone.Text;
                    employee.Address1 = txtAddress1.Text;
                    employee.Address2 = txtAddress2.Text;
                    employee.City = txtCity.Text;
                    employee.State = cbxState.Text;
                    employee.PostalCode = txtPostalCode.Text;
                    employee.UserName = txtUsername.Text;
                    employee.Password = txtPassword.Text;
                    employee.Status = cbxStatus.Text;

                    String name = employee.FirstName + " " + employee.LastName;
                    // String phoneNumber = this.employee.Phone;
                    // if (this.isEmployeeExist(name))
                    // {
                    //     MessageBox.Show("Employee already exists.", "Info");
                    // }


                    bool isRegistered = this.employeeController.RegisterEmployee(employee);

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

        private bool isEmployeeExist(String name)
        {
            //String phonenumber = txtHomePhone.Text;
            List<Employee> customerList = this.employeeController.GetEmployees(name, "", 0);

            //  this.employee = this.employeeController.GetEmployee(name, phonenumber, 0);
            if (employeeList.Count > 0)
            {
                return true;
            }

            return false;
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (this.IsValidData())
            {
                try
                {
                    this.employee.FirstName = txtFirstName.Text;
                    this.employee.MiddleName = txtMiddleName.Text;
                    this.employee.LastName = txtLastName.Text;
                    this.employee.Sex = cbxGender.SelectedItem.ToString();
                    this.employee.DateOfBirth = dtDateOfBirth.Value;
                    this.employee.Address1 = txtAddress1.Text;
                    this.employee.Address2 = txtAddress2.Text;
                    this.employee.City = txtCity.Text;
                    this.employee.State = cbxState.Text;
                    this.employee.PostalCode = txtPostalCode.Text;
                    this.employee.Phone = txtHomePhone.Text;
                    this.employee.UserName = txtUsername.Text;
                    this.employee.Password = txtPassword.Text;
                    this.employee.Status = cbxStatus.Text;

                    bool isUpdated = EmployeeController.UpdateEmployee(this.employee);


                    if (isUpdated)
                    {
                        MessageBox.Show("Employee is updated successfully!", "Success");
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


    }
}
