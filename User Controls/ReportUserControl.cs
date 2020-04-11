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
            if (startDateTimePicker.Value.Date > endDateTimePicker.Value.Date)
            {
                MessageBox.Show("Start Date must be before End Date", "Invalid Date Range");
            }
            else
            {
                try
                {
                    //fill with report from dataset --sp_mostPopularFurnitureRentedDuringDatesTableAdapter
                    this.sp_mostPopularFurnitureRentedDuringDatesTableAdapter.Fill(
                        this._cs6232_g1DataSet1.sp_mostPopularFurnitureRentedDuringDates,
                        startDateTimePicker.Value, endDateTimePicker.Value);
                    reportViewer.RefreshReport();
                }
                catch (Exception)
                {
                    MessageBox.Show("Database error: Unable to retrieve report information.", "Error");
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }
    }
}
