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
            this.labelBeginDate = new System.Windows.Forms.Label();
            this.labelEndDate = new System.Windows.Forms.Label();
            this.startDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.endDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.btnRunReport = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelBeginDate
            // 
            this.labelBeginDate.AutoSize = true;
            this.labelBeginDate.Location = new System.Drawing.Point(28, 30);
            this.labelBeginDate.Name = "labelBeginDate";
            this.labelBeginDate.Size = new System.Drawing.Size(82, 17);
            this.labelBeginDate.TabIndex = 0;
            this.labelBeginDate.Text = "Begin Date:";
            // 
            // labelEndDate
            // 
            this.labelEndDate.AutoSize = true;
            this.labelEndDate.Location = new System.Drawing.Point(289, 30);
            this.labelEndDate.Name = "labelEndDate";
            this.labelEndDate.Size = new System.Drawing.Size(71, 17);
            this.labelEndDate.TabIndex = 1;
            this.labelEndDate.Text = "End Date:";
            // 
            // startDateTimePicker
            // 
            this.startDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.startDateTimePicker.Location = new System.Drawing.Point(116, 25);
            this.startDateTimePicker.Name = "startDateTimePicker";
            this.startDateTimePicker.Size = new System.Drawing.Size(113, 22);
            this.startDateTimePicker.TabIndex = 2;
            // 
            // endDateTimePicker
            // 
            this.endDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.endDateTimePicker.Location = new System.Drawing.Point(380, 25);
            this.endDateTimePicker.Name = "endDateTimePicker";
            this.endDateTimePicker.Size = new System.Drawing.Size(113, 22);
            this.endDateTimePicker.TabIndex = 3;
            // 
            // btnRunReport
            // 
            this.btnRunReport.Location = new System.Drawing.Point(356, 68);
            this.btnRunReport.Name = "btnRunReport";
            this.btnRunReport.Size = new System.Drawing.Size(137, 23);
            this.btnRunReport.TabIndex = 4;
            this.btnRunReport.Text = "Generate Report";
            this.btnRunReport.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(401, 256);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // ReportUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRunReport);
            this.Controls.Add(this.endDateTimePicker);
            this.Controls.Add(this.startDateTimePicker);
            this.Controls.Add(this.labelEndDate);
            this.Controls.Add(this.labelBeginDate);
            this.Name = "ReportUserControl";
            this.Size = new System.Drawing.Size(556, 291);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelBeginDate;
        private System.Windows.Forms.Label labelEndDate;
        private System.Windows.Forms.DateTimePicker startDateTimePicker;
        private System.Windows.Forms.DateTimePicker endDateTimePicker;
        private System.Windows.Forms.Button btnRunReport;
        private System.Windows.Forms.Button btnClose;
    }
}
