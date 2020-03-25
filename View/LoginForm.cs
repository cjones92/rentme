﻿using FurnitureRentals.Controller;
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
    public partial class LoginForm : Form
    {
        private EmployeeController employeeController;
        private AdminstratorController adminstratorController;
        private MainForm CurrentMainForm;
        private AdminMainFormWithUserControls CurrentAdminForm;
        public LoginForm()
        {
            InitializeComponent();
            this.LoadSignInComboBox();
            this.employeeController = new EmployeeController();
            this.adminstratorController = new AdminstratorController();
            this.CurrentAdminForm = new AdminMainFormWithUserControls();
            PasswordMaskedTextBox.UseSystemPasswordChar = true;
        }

        private void LoadSignInComboBox()
        {
            List<string> signInList = new List<string> { "Administrator", "Employee" };
            this.SignInComboBox.DataSource = signInList;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (((string)this.SignInComboBox.SelectedValue == "Employee" && this.employeeController.EmployeeLogin(this.UserNameTextBox.Text, this.PasswordMaskedTextBox.Text)) ||
                (string)this.SignInComboBox.SelectedValue == "Administrator" && this.adminstratorController.AdministratorLogin(this.UserNameTextBox.Text, this.PasswordMaskedTextBox.Text))
            {

                if ((string)this.SignInComboBox.SelectedValue == "Employee")
                {
                    if (this.CurrentMainForm == null)
                    {
                        this.CurrentMainForm = new MainForm();
                    }

                    this.CurrentMainForm.SetLoggedInLabelText(this.UserNameTextBox.Text);
                    this.Hide();
                    DialogResult exitMethodResult = this.CurrentMainForm.ShowDialog();

                    this.UserNameTextBox.ResetText();
                    this.PasswordMaskedTextBox.ResetText();

                    if (this.CurrentMainForm.DialogResult == DialogResult.OK)
                    {
                        this.Show();
                    }
                } else
                {
                    if (this.CurrentAdminForm == null)
                    {
                        this.CurrentAdminForm = new AdminMainFormWithUserControls();
                    }

                    this.CurrentAdminForm.SetLoggedInLabelText(this.UserNameTextBox.Text);
                    this.Hide();
                    DialogResult exitMethodResult = this.CurrentAdminForm.ShowDialog();

                    this.UserNameTextBox.ResetText();
                    this.PasswordMaskedTextBox.ResetText();
                }

                if (this.CurrentAdminForm.DialogResult == DialogResult.OK)
                {
                    this.Show();
                }

            }
            else
            {
                ErrorMessageLabel.ForeColor = Color.Red;
                ErrorMessageLabel.Text = "Invalid username/password";

            }

        }










    }
    }

