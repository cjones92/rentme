﻿using FurnitureRentals.Model;
using FurnitureRentals.User_Controls;
using FurnitureRentals.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FurnitureRentals
{
    /// <summary>
    /// Logic for main form
    /// </summary>
    public partial class MainForm : Form
    {
        Employee loggedInEmployee;

        /// <summary>
        /// Class constructor
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            this.loggedInEmployee = new Employee();
        }

        /// <summary>
        /// This method resets the label for the name of the logged in person
        /// </summary>
        /// <param name="name">name to be reset to</param>
        public void SetLoggedInLabelText(string name)
        {
            if (name == null)
            {
                throw new ArgumentNullException("Name cannot be null");
            }
            this.LoggedInLabel.Text = name;
        }

        /// <summary>
        /// Sets the user name
        /// </summary>
        /// <param name="name">name</param>
        public void SetUserNameText(string name)
        {
            if (name == null)
            {
                throw new ArgumentNullException("Name cannot be null");
            }
            this.ActualUserNameLabel.Text = name;
        }

        /// <summary>
        /// This method dictates the closing of the form when the X button is hit on the main form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult == DialogResult.Cancel)
            {
                System.Windows.Forms.Application.Exit();
            }
        }

        /// <summary>
        /// This method hides the main form and opens the cleared login form when the link is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LogoutLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;

        }

        /// <summary>
        /// Gets current return shopping cart
        /// </summary>
        /// <returns>return shopping cart</returns>
        public ReturnShoppingCartUserControl GetReturnShoppingCartUserControl()
        {
            return this.returnShoppingCartUserControl1;
        }

        /// <summary>
        /// sets current employee
        /// </summary>
        /// <param name="employee">employee object</param>
        public void SetCurrentEmployee(Employee employee)
        {
            this.loggedInEmployee = employee;
            this.customerRentalShoppingCartUserControl1.SetCurrentEmployee(employee);
            this.viewCustomerRentalTransactionsUserControl2.SetCurrentEmployee(employee);
        }

        private void Tabs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.manageCustomerUserControl1.GetCurrentCustomer() == null || this.manageCustomerUserControl1.GetCurrentCustomer().CustomerId<1)
            {
                if(this.tabManageCustomerUserControl.SelectedTab.Text != "Manage Customer") { 
                    MessageBox.Show("Please select customer", "Information");
                }
                this.tabManageCustomerUserControl.SelectTab(0);
                return;
            }

            this.customerRentalShoppingCartUserControl1.SetCurrentCustomer(this.manageCustomerUserControl1.GetCurrentCustomer());
            this.viewCustomerRentalTransactionsUserControl2.SetCurrentCustomer(this.manageCustomerUserControl1.GetCurrentCustomer());
            this.viewCustomerRentalTransactionsUserControl2.LoadRentalTransactionDataGridView();
            this.viewCustomerRentalTransactionsUserControl2.SetReturnCart(this.returnShoppingCartUserControl1);

            this.viewReturnTransactionsUserControl1.SetCurrentCustomer(this.manageCustomerUserControl1.GetCurrentCustomer());
            this.returnShoppingCartUserControl1.SetCurrentCustomer(this.loggedInEmployee.EmployeeID, this.manageCustomerUserControl1.GetCurrentCustomer());
        }



    }



}
