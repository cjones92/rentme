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
            this.UserLoggedInLabel = new System.Windows.Forms.Label();
            this.LogoutLinkLabel = new System.Windows.Forms.LinkLabel();
            this.LoggedInLabel = new System.Windows.Forms.Label();
            this.manageEmployeeUserControl1 = new FurnitureRentals.User_Controls.ManageEmployeeUserControl();
            this.tbCtrlAdminForm.SuspendLayout();
            this.tbPgEmployee.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbCtrlAdminForm
            // 
            this.tbCtrlAdminForm.Controls.Add(this.tbPgEmployee);
            this.tbCtrlAdminForm.Controls.Add(this.tbPgReport);
            this.tbCtrlAdminForm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbCtrlAdminForm.Location = new System.Drawing.Point(0, 29);
            this.tbCtrlAdminForm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbCtrlAdminForm.Name = "tbCtrlAdminForm";
            this.tbCtrlAdminForm.SelectedIndex = 0;
            this.tbCtrlAdminForm.Size = new System.Drawing.Size(772, 560);
            this.tbCtrlAdminForm.TabIndex = 0;
            // 
            // tbPgEmployee
            // 
            this.tbPgEmployee.Controls.Add(this.manageEmployeeUserControl1);
            this.tbPgEmployee.Location = new System.Drawing.Point(4, 22);
            this.tbPgEmployee.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbPgEmployee.Name = "tbPgEmployee";
            this.tbPgEmployee.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbPgEmployee.Size = new System.Drawing.Size(764, 534);
            this.tbPgEmployee.TabIndex = 0;
            this.tbPgEmployee.Text = "Employee";
            this.tbPgEmployee.UseVisualStyleBackColor = true;
            // 
            // tbPgReport
            // 
            this.tbPgReport.Location = new System.Drawing.Point(4, 22);
            this.tbPgReport.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbPgReport.Name = "tbPgReport";
            this.tbPgReport.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbPgReport.Size = new System.Drawing.Size(764, 534);
            this.tbPgReport.TabIndex = 1;
            this.tbPgReport.Text = "Report";
            this.tbPgReport.UseVisualStyleBackColor = true;
            // 
            // UserLoggedInLabel
            // 
            this.UserLoggedInLabel.AutoSize = true;
            this.UserLoggedInLabel.Location = new System.Drawing.Point(1, 7);
            this.UserLoggedInLabel.Name = "UserLoggedInLabel";
            this.UserLoggedInLabel.Size = new System.Drawing.Size(76, 13);
            this.UserLoggedInLabel.TabIndex = 5;
            this.UserLoggedInLabel.Text = "Logged In As: ";
            // 
            // LogoutLinkLabel
            // 
            this.LogoutLinkLabel.AutoSize = true;
            this.LogoutLinkLabel.Location = new System.Drawing.Point(640, 13);
            this.LogoutLinkLabel.Name = "LogoutLinkLabel";
            this.LogoutLinkLabel.Size = new System.Drawing.Size(45, 13);
            this.LogoutLinkLabel.TabIndex = 6;
            this.LogoutLinkLabel.TabStop = true;
            this.LogoutLinkLabel.Text = "Log Out";
            this.LogoutLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LogoutLinkLabel_LinkClicked);
            // 
            // LoggedInLabel
            // 
            this.LoggedInLabel.AutoSize = true;
            this.LoggedInLabel.Location = new System.Drawing.Point(104, 7);
            this.LoggedInLabel.Name = "LoggedInLabel";
            this.LoggedInLabel.Size = new System.Drawing.Size(75, 13);
            this.LoggedInLabel.TabIndex = 7;
            this.LoggedInLabel.Text = "Not Logged In";
            // 
            // manageEmployeeUserControl1
            // 
            this.manageEmployeeUserControl1.Location = new System.Drawing.Point(-4, 4);
            this.manageEmployeeUserControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.manageEmployeeUserControl1.Name = "manageEmployeeUserControl1";
            this.manageEmployeeUserControl1.Size = new System.Drawing.Size(1142, 838);
            this.manageEmployeeUserControl1.TabIndex = 0;
            // 
            // AdminMainFormWithUserControls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 589);
            this.Controls.Add(this.LoggedInLabel);
            this.Controls.Add(this.LogoutLinkLabel);
            this.Controls.Add(this.UserLoggedInLabel);
            this.Controls.Add(this.tbCtrlAdminForm);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AdminMainFormWithUserControls";
            this.Text = "AdminMainFormWithUserControls";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminMainFormWithUserControls_FormClosing);
            this.tbCtrlAdminForm.ResumeLayout(false);
            this.tbPgEmployee.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tbCtrlAdminForm;
        private System.Windows.Forms.TabPage tbPgEmployee;
        private User_Controls.ManageEmployeeUserControl manageEmployeeUserControl1;
        private System.Windows.Forms.TabPage tbPgReport;
        private System.Windows.Forms.Label UserLoggedInLabel;
        private System.Windows.Forms.LinkLabel LogoutLinkLabel;
        private System.Windows.Forms.Label LoggedInLabel;
    }
}