using FurnitureRentals.Model;
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
    /// <summary>
    /// Logic for AdminMainFormWithUserControls
    /// </summary>
    public partial class AdminMainFormWithUserControls : Form
    {
        Administrator loggedInAdministrator;
        /// <summary>
        /// Constructor
        /// </summary>
        public AdminMainFormWithUserControls()
        {
            InitializeComponent();
            this.loggedInAdministrator = new Administrator();
        }

        /// <summary>
        /// Sets logged in label
        /// </summary>
        /// <param name="name"></param>
        public void SetLoggedInLabelText(string name)
        {
            if (name == null)
            {
                throw new ArgumentNullException("Name cannot be null");
            }
            this.LoggedInLabel.Text = name;
        }

        /// <summary>
        /// Sets current administrator
        /// </summary>
        /// <param name="administrator">administrator object</param>
        public void SetCurrentAdministrator(Administrator administrator)
        {
            this.loggedInAdministrator = administrator;
            
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
        /// This method dictates the closing of the form when the X button is hit on the main form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AdminMainFormWithUserControls_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult == DialogResult.Cancel)
            {
                System.Windows.Forms.Application.Exit();
            }
        }
    }
}

