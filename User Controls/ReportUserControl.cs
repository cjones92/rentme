using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FurnitureRentals.User_Controls
{
    public partial class ReportUserControl : UserControl
    {
        public ReportUserControl()
        {
            InitializeComponent();
        }

        private void Report_Load(object sender, EventArgs e)
        {
            startDateTimePicker.MaxDate = DateTime.Today;
            endDateTimePicker.MaxDate = DateTime.Today;
        }

        private void btnRunReport_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }
    }
}
