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
    public partial class SubmitTransactionDialog : Form
    {
        public SubmitTransactionDialog()
        {
            InitializeComponent();
        }

        private void UpdatedDescriptionLabel_Click(object sender, EventArgs e)
        {

        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            
                this.DialogResult = DialogResult.OK;
            
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
