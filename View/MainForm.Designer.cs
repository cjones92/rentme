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
            this.LoggedInLabel = new System.Windows.Forms.Label();
            this.LogoutLinkLabel = new System.Windows.Forms.LinkLabel();
            this.UserLoggedInLabel = new System.Windows.Forms.Label();
            this.manageCustomerUserControl1 = new FurnitureRentals.User_Controls.ManageCustomerUserControl();
            this.ShoppingCartTab = new System.Windows.Forms.TabPage();
            this.FurnitureSearchButton = new System.Windows.Forms.Button();
            this.tabManageCustomerUserControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.ShoppingCartTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabManageCustomerUserControl
            // 
            this.tabManageCustomerUserControl.Controls.Add(this.tabPage1);
            this.tabManageCustomerUserControl.Controls.Add(this.ShoppingCartTab);
            this.tabManageCustomerUserControl.Location = new System.Drawing.Point(9, 26);
            this.tabManageCustomerUserControl.Margin = new System.Windows.Forms.Padding(2);
            this.tabManageCustomerUserControl.Name = "tabManageCustomerUserControl";
            this.tabManageCustomerUserControl.SelectedIndex = 0;
            this.tabManageCustomerUserControl.Size = new System.Drawing.Size(817, 531);
            this.tabManageCustomerUserControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.manageCustomerUserControl1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(809, 505);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Manage Customer";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // LoggedInLabel
            // 
            this.LoggedInLabel.AutoSize = true;
            this.LoggedInLabel.Location = new System.Drawing.Point(120, 9);
            this.LoggedInLabel.Name = "LoggedInLabel";
            this.LoggedInLabel.Size = new System.Drawing.Size(75, 13);
            this.LoggedInLabel.TabIndex = 1;
            this.LoggedInLabel.Text = "Not Logged In";
            // 
            // LogoutLinkLabel
            // 
            this.LogoutLinkLabel.AutoSize = true;
            this.LogoutLinkLabel.Location = new System.Drawing.Point(595, 11);
            this.LogoutLinkLabel.Name = "LogoutLinkLabel";
            this.LogoutLinkLabel.Size = new System.Drawing.Size(45, 13);
            this.LogoutLinkLabel.TabIndex = 3;
            this.LogoutLinkLabel.TabStop = true;
            this.LogoutLinkLabel.Text = "Log Out";
            this.LogoutLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LogoutLinkLabel_LinkClicked);
            // 
            // UserLoggedInLabel
            // 
            this.UserLoggedInLabel.AutoSize = true;
            this.UserLoggedInLabel.Location = new System.Drawing.Point(9, 8);
            this.UserLoggedInLabel.Name = "UserLoggedInLabel";
            this.UserLoggedInLabel.Size = new System.Drawing.Size(76, 13);
            this.UserLoggedInLabel.TabIndex = 4;
            this.UserLoggedInLabel.Text = "Logged In As: ";
            // 
            // manageCustomerUserControl1
            // 
            this.manageCustomerUserControl1.Location = new System.Drawing.Point(26, 3);
            this.manageCustomerUserControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.manageCustomerUserControl1.Name = "manageCustomerUserControl1";
            this.manageCustomerUserControl1.Size = new System.Drawing.Size(685, 513);
            this.manageCustomerUserControl1.TabIndex = 0;
            // 
            // ShoppingCartTab
            // 
            this.ShoppingCartTab.Controls.Add(this.FurnitureSearchButton);
            this.ShoppingCartTab.Location = new System.Drawing.Point(4, 22);
            this.ShoppingCartTab.Name = "ShoppingCartTab";
            this.ShoppingCartTab.Padding = new System.Windows.Forms.Padding(3);
            this.ShoppingCartTab.Size = new System.Drawing.Size(809, 505);
            this.ShoppingCartTab.TabIndex = 1;
            this.ShoppingCartTab.Text = "Shopping Cart";
            this.ShoppingCartTab.UseVisualStyleBackColor = true;
            // 
            // FurnitureSearchButton
            // 
            this.FurnitureSearchButton.Location = new System.Drawing.Point(40, 44);
            this.FurnitureSearchButton.Name = "FurnitureSearchButton";
            this.FurnitureSearchButton.Size = new System.Drawing.Size(75, 23);
            this.FurnitureSearchButton.TabIndex = 0;
            this.FurnitureSearchButton.Text = "Search";
            this.FurnitureSearchButton.UseVisualStyleBackColor = true;
            this.FurnitureSearchButton.Click += new System.EventHandler(this.FurnitureSearchButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 561);
            this.Controls.Add(this.UserLoggedInLabel);
            this.Controls.Add(this.LogoutLinkLabel);
            this.Controls.Add(this.LoggedInLabel);
            this.Controls.Add(this.tabManageCustomerUserControl);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "Furniture Rentals";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.tabManageCustomerUserControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ShoppingCartTab.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabManageCustomerUserControl;
        private System.Windows.Forms.TabPage tabPage1;
        private User_Controls.ManageCustomerUserControl manageCustomerUserControl1;
        private System.Windows.Forms.Label LoggedInLabel;
        private System.Windows.Forms.LinkLabel LogoutLinkLabel;
        private System.Windows.Forms.Label UserLoggedInLabel;
        private System.Windows.Forms.TabPage ShoppingCartTab;
        private System.Windows.Forms.Button FurnitureSearchButton;
    }
}

