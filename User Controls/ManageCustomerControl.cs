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

        public event EventHandler DataSaved;

        /// <summary>
        /// Constructor initializes the class level variables
        /// </summary>
        public ManageCustomerUserControl()
        {
            InitializeComponent();
            
        }
        
    }
}
