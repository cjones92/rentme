namespace FurnitureRentals.View
{
    partial class AdminMainFormWithUserControls
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbCtrlAdminForm = new System.Windows.Forms.TabControl();
            this.tbPgEmployee = new System.Windows.Forms.TabPage();
            this.tbPgReport = new System.Windows.Forms.TabPage();
            this.manageEmployeeUserControl1 = new FurnitureRentals.User_Controls.ManageEmployeeUserControl();
            this.tbCtrlAdminForm.SuspendLayout();
            this.tbPgEmployee.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbCtrlAdminForm
            // 
            this.tbCtrlAdminForm.Controls.Add(this.tbPgEmployee);
            this.tbCtrlAdminForm.Controls.Add(this.tbPgReport);
            this.tbCtrlAdminForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbCtrlAdminForm.Location = new System.Drawing.Point(0, 0);
            this.tbCtrlAdminForm.Name = "tbCtrlAdminForm";
            this.tbCtrlAdminForm.SelectedIndex = 0;
            this.tbCtrlAdminForm.Size = new System.Drawing.Size(1027, 700);
            this.tbCtrlAdminForm.TabIndex = 0;
            // 
            // tbPgEmployee
            // 
            this.tbPgEmployee.Controls.Add(this.manageEmployeeUserControl1);
            this.tbPgEmployee.Location = new System.Drawing.Point(4, 25);
            this.tbPgEmployee.Name = "tbPgEmployee";
            this.tbPgEmployee.Padding = new System.Windows.Forms.Padding(3);
            this.tbPgEmployee.Size = new System.Drawing.Size(1019, 671);
            this.tbPgEmployee.TabIndex = 0;
            this.tbPgEmployee.Text = "Employee";
            this.tbPgEmployee.UseVisualStyleBackColor = true;
            // 
            // tbPgReport
            // 
            this.tbPgReport.Location = new System.Drawing.Point(4, 25);
            this.tbPgReport.Name = "tbPgReport";
            this.tbPgReport.Padding = new System.Windows.Forms.Padding(3);
            this.tbPgReport.Size = new System.Drawing.Size(826, 394);
            this.tbPgReport.TabIndex = 1;
            this.tbPgReport.Text = "Report";
            this.tbPgReport.UseVisualStyleBackColor = true;
            // 
            // manageEmployeeUserControl1
            // 
            this.manageEmployeeUserControl1.Location = new System.Drawing.Point(-6, 5);
            this.manageEmployeeUserControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.manageEmployeeUserControl1.Name = "manageEmployeeUserControl1";
            this.manageEmployeeUserControl1.Size = new System.Drawing.Size(1522, 1031);
            this.manageEmployeeUserControl1.TabIndex = 0;
            // 
            // AdminMainFormWithUserControls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 700);
            this.Controls.Add(this.tbCtrlAdminForm);
            this.Name = "AdminMainFormWithUserControls";
            this.Text = "AdminMainFormWithUserControls";
            this.tbCtrlAdminForm.ResumeLayout(false);
            this.tbPgEmployee.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbCtrlAdminForm;
        private System.Windows.Forms.TabPage tbPgEmployee;
        private User_Controls.ManageEmployeeUserControl manageEmployeeUserControl1;
        private System.Windows.Forms.TabPage tbPgReport;
    }
}