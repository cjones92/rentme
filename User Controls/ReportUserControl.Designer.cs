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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.sp_mostPopularFurnitureRentedDuringDatesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._cs6232_g1DataSet1 = new FurnitureRentals._cs6232_g1DataSet1();
            this.labelBeginDate = new System.Windows.Forms.Label();
            this.labelEndDate = new System.Windows.Forms.Label();
            this.startDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.endDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.btnRunReport = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sp_mostPopularFurnitureRentedDuringDatesTableAdapter = new FurnitureRentals._cs6232_g1DataSet1TableAdapters.sp_mostPopularFurnitureRentedDuringDatesTableAdapter();
            this.labelReportName = new System.Windows.Forms.Label();
            this.lblBeginDateSelected = new System.Windows.Forms.Label();
            this.lblBeginDateValue = new System.Windows.Forms.Label();
            this.lblEndDateSelected = new System.Windows.Forms.Label();
            this.lblEndDateValue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sp_mostPopularFurnitureRentedDuringDatesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._cs6232_g1DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // sp_mostPopularFurnitureRentedDuringDatesBindingSource
            // 
            this.sp_mostPopularFurnitureRentedDuringDatesBindingSource.DataMember = "sp_mostPopularFurnitureRentedDuringDates";
            this.sp_mostPopularFurnitureRentedDuringDatesBindingSource.DataSource = this._cs6232_g1DataSet1;
            // 
            // _cs6232_g1DataSet1
            // 
            this._cs6232_g1DataSet1.DataSetName = "_cs6232_g1DataSet1";
            this._cs6232_g1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelBeginDate
            // 
            this.labelBeginDate.AutoSize = true;
            this.labelBeginDate.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBeginDate.Location = new System.Drawing.Point(28, 13);
            this.labelBeginDate.Name = "labelBeginDate";
            this.labelBeginDate.Size = new System.Drawing.Size(89, 21);
            this.labelBeginDate.TabIndex = 0;
            this.labelBeginDate.Text = "Begin Date:";
            // 
            // labelEndDate
            // 
            this.labelEndDate.AutoSize = true;
            this.labelEndDate.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEndDate.Location = new System.Drawing.Point(253, 13);
            this.labelEndDate.Name = "labelEndDate";
            this.labelEndDate.Size = new System.Drawing.Size(77, 21);
            this.labelEndDate.TabIndex = 1;
            this.labelEndDate.Text = "End Date:";
            // 
            // startDateTimePicker
            // 
            this.startDateTimePicker.CustomFormat = "yyyy-MM-dd";
            this.startDateTimePicker.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startDateTimePicker.Location = new System.Drawing.Point(123, 12);
            this.startDateTimePicker.Name = "startDateTimePicker";
            this.startDateTimePicker.Size = new System.Drawing.Size(109, 28);
            this.startDateTimePicker.TabIndex = 2;
            // 
            // endDateTimePicker
            // 
            this.endDateTimePicker.CustomFormat = "yyyy-MM-dd";
            this.endDateTimePicker.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endDateTimePicker.Location = new System.Drawing.Point(336, 12);
            this.endDateTimePicker.Name = "endDateTimePicker";
            this.endDateTimePicker.Size = new System.Drawing.Size(110, 28);
            this.endDateTimePicker.TabIndex = 3;
            // 
            // btnRunReport
            // 
            this.btnRunReport.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRunReport.Location = new System.Drawing.Point(832, 7);
            this.btnRunReport.Name = "btnRunReport";
            this.btnRunReport.Size = new System.Drawing.Size(141, 31);
            this.btnRunReport.TabIndex = 4;
            this.btnRunReport.Text = "Generate Report";
            this.btnRunReport.UseVisualStyleBackColor = true;
            this.btnRunReport.Click += new System.EventHandler(this.btnRunReport_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(891, 533);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(82, 30);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // reportViewer
            // 
            reportDataSource2.Name = "ReportDataSet";
            reportDataSource2.Value = this.sp_mostPopularFurnitureRentedDuringDatesBindingSource;
            this.reportViewer.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer.LocalReport.ReportEmbeddedResource = "FurnitureRentals.FurnitureRentalsReportView.rdlc";
            this.reportViewer.Location = new System.Drawing.Point(17, 144);
            this.reportViewer.Name = "reportViewer";
            this.reportViewer.Padding = new System.Windows.Forms.Padding(10);
            this.reportViewer.ServerReport.BearerToken = null;
            this.reportViewer.Size = new System.Drawing.Size(982, 383);
            this.reportViewer.TabIndex = 6;
            // 
            // sp_mostPopularFurnitureRentedDuringDatesTableAdapter
            // 
            this.sp_mostPopularFurnitureRentedDuringDatesTableAdapter.ClearBeforeFill = true;
            // 
            // labelReportName
            // 
            this.labelReportName.AutoSize = true;
            this.labelReportName.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReportName.Location = new System.Drawing.Point(307, 57);
            this.labelReportName.Name = "labelReportName";
            this.labelReportName.Size = new System.Drawing.Size(388, 21);
            this.labelReportName.TabIndex = 5;
            this.labelReportName.Text = "Most Popular Furniture During Specified Dates Report ";
            // 
            // lblBeginDateSelected
            // 
            this.lblBeginDateSelected.AutoSize = true;
            this.lblBeginDateSelected.Location = new System.Drawing.Point(29, 80);
            this.lblBeginDateSelected.Name = "lblBeginDateSelected";
            this.lblBeginDateSelected.Size = new System.Drawing.Size(141, 17);
            this.lblBeginDateSelected.TabIndex = 8;
            this.lblBeginDateSelected.Text = "Begin Date Selected:";
            this.lblBeginDateSelected.Visible = false;
            // 
            // lblBeginDateValue
            // 
            this.lblBeginDateValue.AutoSize = true;
            this.lblBeginDateValue.Location = new System.Drawing.Point(221, 80);
            this.lblBeginDateValue.Name = "lblBeginDateValue";
            this.lblBeginDateValue.Size = new System.Drawing.Size(0, 17);
            this.lblBeginDateValue.TabIndex = 9;
            // 
            // lblEndDateSelected
            // 
            this.lblEndDateSelected.AutoSize = true;
            this.lblEndDateSelected.Location = new System.Drawing.Point(29, 108);
            this.lblEndDateSelected.Name = "lblEndDateSelected";
            this.lblEndDateSelected.Size = new System.Drawing.Size(130, 17);
            this.lblEndDateSelected.TabIndex = 10;
            this.lblEndDateSelected.Text = "End Date Selected:";
            this.lblEndDateSelected.Visible = false;
            // 
            // lblEndDateValue
            // 
            this.lblEndDateValue.AutoSize = true;
            this.lblEndDateValue.Location = new System.Drawing.Point(221, 108);
            this.lblEndDateValue.Name = "lblEndDateValue";
            this.lblEndDateValue.Size = new System.Drawing.Size(0, 17);
            this.lblEndDateValue.TabIndex = 11;
            // 
            // ReportUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblEndDateValue);
            this.Controls.Add(this.lblEndDateSelected);
            this.Controls.Add(this.lblBeginDateValue);
            this.Controls.Add(this.lblBeginDateSelected);
            this.Controls.Add(this.labelReportName);
            this.Controls.Add(this.reportViewer);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRunReport);
            this.Controls.Add(this.endDateTimePicker);
            this.Controls.Add(this.startDateTimePicker);
            this.Controls.Add(this.labelEndDate);
            this.Controls.Add(this.labelBeginDate);
            this.Name = "ReportUserControl";
            this.Size = new System.Drawing.Size(1013, 565);
            this.Load += new System.EventHandler(this.Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sp_mostPopularFurnitureRentedDuringDatesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._cs6232_g1DataSet1)).EndInit();
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
        private System.Windows.Forms.Label labelReportName;
        private System.Windows.Forms.Label lblBeginDateSelected;
        private System.Windows.Forms.Label lblBeginDateValue;
        private System.Windows.Forms.Label lblEndDateSelected;
        private System.Windows.Forms.Label lblEndDateValue;
    }
}
