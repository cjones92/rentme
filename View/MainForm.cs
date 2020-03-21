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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
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
    }
}
