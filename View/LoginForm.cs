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
        public LoginForm()
        {
            InitializeComponent();
            this.LoadSignInComboBox();
        }

        private void LoadSignInComboBox()
        {
            List<string> signInList = new List<string> { "Administrator", "Employee" };
            this.SignInComboBox.DataSource = signInList;
        }
    }
}
