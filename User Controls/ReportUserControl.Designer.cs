namespace FurnitureRentals.User_Controls
{
    partial class ReportUserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.labelBeginDate = new System.Windows.Forms.Label();
            this.labelEndDate = new System.Windows.Forms.Label();
            this.startDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.endDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.btnRunReport = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sp_mostPopularFurnitureRentedDuringDatesTableAdapter = new FurnitureRentals._cs6232_g1DataSet1TableAdapters.sp_mostPopularFurnitureRentedDuringDatesTableAdapter();
            this._cs6232_g1DataSet1 = new FurnitureRentals._cs6232_g1DataSet1();
            this.sp_mostPopularFurnitureRentedDuringDatesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this._cs6232_g1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_mostPopularFurnitureRentedDuringDatesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelBeginDate
            // 
            this.labelBeginDate.AutoSize = true;
            this.labelBeginDate.Location = new System.Drawing.Point(28, 13);
            this.labelBeginDate.Name = "labelBeginDate";
            this.labelBeginDate.Size = new System.Drawing.Size(82, 17);
            this.labelBeginDate.TabIndex = 0;
            this.labelBeginDate.Text = "Begin Date:";
            // 
            // labelEndDate
            // 
            this.labelEndDate.AutoSize = true;
            this.labelEndDate.Location = new System.Drawing.Point(246, 13);
            this.labelEndDate.Name = "labelEndDate";
            this.labelEndDate.Size = new System.Drawing.Size(71, 17);
            this.labelEndDate.TabIndex = 1;
            this.labelEndDate.Text = "End Date:";
            // 
            // startDateTimePicker
            // 
            this.startDateTimePicker.CustomFormat = "yyyy-MM-dd";
            this.startDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startDateTimePicker.Location = new System.Drawing.Point(116, 8);
            this.startDateTimePicker.Name = "startDateTimePicker";
            this.startDateTimePicker.Size = new System.Drawing.Size(113, 22);
            this.startDateTimePicker.TabIndex = 2;
            // 
            // endDateTimePicker
            // 
            this.endDateTimePicker.CustomFormat = "yyyy-MM-dd";
            this.endDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endDateTimePicker.Location = new System.Drawing.Point(336, 8);
            this.endDateTimePicker.Name = "endDateTimePicker";
            this.endDateTimePicker.Size = new System.Drawing.Size(113, 22);
            this.endDateTimePicker.TabIndex = 3;
            // 
            // btnRunReport
            // 
            this.btnRunReport.Location = new System.Drawing.Point(530, 7);
            this.btnRunReport.Name = "btnRunReport";
            this.btnRunReport.Size = new System.Drawing.Size(137, 23);
            this.btnRunReport.TabIndex = 4;
            this.btnRunReport.Text = "Generate Report";
            this.btnRunReport.UseVisualStyleBackColor = true;
            this.btnRunReport.Click += new System.EventHandler(this.btnRunReport_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(846, 533);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // reportViewer
            // 
            reportDataSource1.Name = "ReportDataSet";
            reportDataSource1.Value = this.sp_mostPopularFurnitureRentedDuringDatesBindingSource;
            this.reportViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer.LocalReport.ReportEmbeddedResource = "FurnitureRentals.FurnitureRentalsReportView.rdlc";
            this.reportViewer.Location = new System.Drawing.Point(0, 59);
            this.reportViewer.Name = "reportViewer";
            this.reportViewer.ServerReport.BearerToken = null;
            this.reportViewer.Size = new System.Drawing.Size(985, 456);
            this.reportViewer.TabIndex = 6;
            // 
            // sp_mostPopularFurnitureRentedDuringDatesTableAdapter
            // 
            this.sp_mostPopularFurnitureRentedDuringDatesTableAdapter.ClearBeforeFill = true;
            // 
            // _cs6232_g1DataSet1
            // 
            this._cs6232_g1DataSet1.DataSetName = "_cs6232_g1DataSet1";
            this._cs6232_g1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sp_mostPopularFurnitureRentedDuringDatesBindingSource
            // 
            this.sp_mostPopularFurnitureRentedDuringDatesBindingSource.DataMember = "sp_mostPopularFurnitureRentedDuringDates";
            this.sp_mostPopularFurnitureRentedDuringDatesBindingSource.DataSource = this._cs6232_g1DataSet1;
            // 
            // ReportUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.reportViewer);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRunReport);
            this.Controls.Add(this.endDateTimePicker);
            this.Controls.Add(this.startDateTimePicker);
            this.Controls.Add(this.labelEndDate);
            this.Controls.Add(this.labelBeginDate);
            this.Name = "ReportUserControl";
            this.Size = new System.Drawing.Size(988, 559);
            this.Load += new System.EventHandler(this.Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this._cs6232_g1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_mostPopularFurnitureRentedDuringDatesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelBeginDate;
        private System.Windows.Forms.Label labelEndDate;
        private System.Windows.Forms.DateTimePicker startDateTimePicker;
        private System.Windows.Forms.DateTimePicker endDateTimePicker;
        private System.Windows.Forms.Button btnRunReport;
        private System.Windows.Forms.Button btnClear;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
        private _cs6232_g1DataSet1TableAdapters.sp_mostPopularFurnitureRentedDuringDatesTableAdapter sp_mostPopularFurnitureRentedDuringDatesTableAdapter;
        private _cs6232_g1DataSet1 _cs6232_g1DataSet1;
        private System.Windows.Forms.BindingSource sp_mostPopularFurnitureRentedDuringDatesBindingSource;
    }
}
