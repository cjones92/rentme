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
            this.tabManageCustomerUserControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabManageCustomerUserControl
            // 
            this.tabManageCustomerUserControl.Controls.Add(this.tabPage1);
            this.tabManageCustomerUserControl.Location = new System.Drawing.Point(9, 26);
            this.tabManageCustomerUserControl.Margin = new System.Windows.Forms.Padding(2);
            this.tabManageCustomerUserControl.Name = "tabManageCustomerUserControl";
            this.tabManageCustomerUserControl.SelectedIndex = 0;
            this.tabManageCustomerUserControl.Size = new System.Drawing.Size(817, 412);
            this.tabManageCustomerUserControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(809, 386);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Manage Customer";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 448);
            this.Controls.Add(this.tabManageCustomerUserControl);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.tabManageCustomerUserControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabManageCustomerUserControl;
        private System.Windows.Forms.TabPage tabPage1;
    }
}

