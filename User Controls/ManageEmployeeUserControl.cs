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
    /// <summary>
    /// Logic for ManageEmployeeUserControl
    /// </summary>
    public partial class ManageEmployeeUserControl : UserControl
    {
        private readonly EmployeeController employeeController;
        private Employee employee;
        private bool dateChosen;
        private List<Employee> employeeList;
        private int employeeId;
        private ToolTip toolTip;

        /// <summary>
        /// Class constructor.
        /// </summary>
        public ManageEmployeeUserControl()
        {
            InitializeComponent();
            this.employeeController = new EmployeeController();
            this.employee = new Employee();
            this.dateChosen = false;
            txtSearch.Focus();
            employeeList = new List<Employee>();
            toolTip = new ToolTip();
            this.employeeId = 0;
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
                    long phoneNumber = Convert.ToInt64(txtSearch.Text);
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
                    string errorMessage = isValidPhoneNumberAndZip(employee);
                    if (errorMessage.Length > 0)
                    {
                        MessageBox.Show(errorMessage, "Error");
                        return;
                    }

                    bool isRegistered = this.employeeController.RegisterEmployee(employee);
                    if (isRegistered)
                    {
                        MessageBox.Show("Employee has been created successfully. EmployeeID: " + employee.EmployeeID, "Registration Complete");
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

        private string isValidPhoneNumberAndZip(Employee employee)
        {
            string errorMessage = "";
            if (employee.Phone.Trim().Length > 0)
            {
                if (employee.Phone.Trim().Length != 10)
                {
                    txtHomePhone.Focus();
                    errorMessage = "Please enter valid phone number";
                }
                else
                {
                    try
                    {
                        Convert.ToInt64(employee.Phone);
                    }
                    catch (FormatException)
                    {
                        txtHomePhone.Focus();
                        errorMessage = "Please enter valid phone number.";
                    }
                }

            }

            if (employee.PostalCode.Trim().Length > 0)
            {
                string postalCode = employee.PostalCode.Trim();
                String firstPart = postalCode.Substring(0, 5);
                try
                {
                    Convert.ToInt64(firstPart);
                }
                catch (FormatException)
                {
                    txtPostalCode.Focus();
                    errorMessage = "Please enter valid postal code.";
                    return errorMessage;
                }

                String secondPart = "";
                if (postalCode.Length > 5)
                {
                    secondPart = postalCode.Substring(5, 1);
                    if (secondPart != "-")
                    {
                        txtPostalCode.Focus();
                        errorMessage = "Please enter valid postal code.";
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
                        txtPostalCode.Focus();
                        errorMessage = "Please enter valid postal code.";
                        return errorMessage;
                    }
                }
            }

            return errorMessage;

        }

        private bool IsValidData()
        {
            DateTime dateOfBirth = dtDateOfBirth.Value;
            DateTime dateOfBirth18 = new DateTime(dateOfBirth.Year + 18, dateOfBirth.Month, dateOfBirth.Day);

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

            else if (txtFirstName.Text.Trim().Length > 45)
            {
                MessageBox.Show("First Name cannot be longer than 45 characters.", "Invalid First Name");
                return false;
            }
            else if (txtLastName.Text.Trim().Length > 45)
            {
                MessageBox.Show("Last Name cannot be longer than 45 characters.", "Invalid Last Name");
                return false;
            }
            else if (dateOfBirth18 > DateTime.Today)
            {
                MessageBox.Show("Employee must be at least 18 years old.", "Invalid Date Of Birth");
                return false;
            }
            else if (txtAddress1.Text.Trim().Length > 250)
            {
                MessageBox.Show("Street Address cannot be longer than 250 characters.", "Invalid Street Address");
                return false;
            }
            else if (txtCity.Text.Trim().Length > 45)
            {
                MessageBox.Show("City cannot be longer than 45 characters.", "Invalid City");
                return false;
            }
            else if (txtPostalCode.Text.Trim().Length == 0 ||
                txtPostalCode.Text.Trim().Length < 5 ||
                txtPostalCode.Text.Trim().Length == 6 ||
                (txtPostalCode.Text.Trim().Length > 6 && txtPostalCode.Text.Trim().Length < 10))
            {
                txtPostalCode.Focus();
                MessageBox.Show("Please enter valid postal code.", "Invalid Zip Code");
                return false;
            }
            else if (txtUsername.Text.Trim().Length > 45)
            {
                MessageBox.Show("Username cannot be longer than 45 characters", "Invalid Username");
                return false;
            }
            else if (txtPassword.Text.Trim().Length > 45)
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

        private void clearAllFields()
        {
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
            txtPostalCode.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";
            cbxStatus.SelectedIndex = 0;
            btnRegister.Enabled = true;
            btnUpdate.Enabled = false;
            btnClear.Enabled = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (this.IsValidData())
            {
                try
                {
                    Employee employee = new Employee();
                    employee.EmployeeID = this.employeeId;
                    employee.FirstName = txtFirstName.Text;
                    employee.MiddleName = txtMiddleName.Text;
                    employee.LastName = txtLastName.Text;
                    employee.Sex = cbxGender.SelectedItem.ToString();
                    employee.DateOfBirth = dtDateOfBirth.Value;
                    employee.Address1 = txtAddress1.Text;
                    employee.Address2 = txtAddress2.Text;
                    employee.City = txtCity.Text;
                    employee.State = cbxState.Text;
                    employee.PostalCode = txtPostalCode.Text;
                    employee.Phone = txtHomePhone.Text;
                    employee.UserName = txtUsername.Text;
                    employee.Password = txtPassword.Text;
                    employee.Status = cbxStatus.Text;

                    string errorMessage = isValidPhoneNumberAndZip(employee);
                    if (errorMessage.Length > 0)
                    {
                        MessageBox.Show(errorMessage, "Error");
                        return;
                    }


                    bool isUpdated = EmployeeController.UpdateEmployee(employee);


                    if (isUpdated)
                    {
                        MessageBox.Show("Employee is updated successfully! EmployeeID: " + employee.EmployeeID, "Success");
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

        private void cbxSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            clearAllFields();
        }
    }
}
