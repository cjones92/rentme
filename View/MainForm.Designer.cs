namespace FurnitureRentals
{
    partial class MainForm
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
            this.tabManageCustomerUserControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.manageCustomerUserControl1 = new FurnitureRentals.User_Controls.ManageCustomerUserControl();
            this.tabManageCustomerUserControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabManageCustomerUserControl
            // 
            this.tabManageCustomerUserControl.Controls.Add(this.tabPage1);
            this.tabManageCustomerUserControl.Location = new System.Drawing.Point(12, 32);
            this.tabManageCustomerUserControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabManageCustomerUserControl.Name = "tabManageCustomerUserControl";
            this.tabManageCustomerUserControl.SelectedIndex = 0;
            this.tabManageCustomerUserControl.Size = new System.Drawing.Size(1089, 654);
            this.tabManageCustomerUserControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.manageCustomerUserControl1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(1081, 625);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Manage Customer";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // manageCustomerUserControl1
            // 
            this.manageCustomerUserControl1.Location = new System.Drawing.Point(35, 4);
            this.manageCustomerUserControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.manageCustomerUserControl1.Name = "manageCustomerUserControl1";
            this.manageCustomerUserControl1.Size = new System.Drawing.Size(913, 631);
            this.manageCustomerUserControl1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 690);
            this.Controls.Add(this.tabManageCustomerUserControl);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "Furniture Rentals";
            this.tabManageCustomerUserControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabManageCustomerUserControl;
        private System.Windows.Forms.TabPage tabPage1;
        private User_Controls.ManageCustomerUserControl manageCustomerUserControl1;
    }
}

