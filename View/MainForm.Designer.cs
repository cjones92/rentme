﻿namespace FurnitureRentals
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
            this.RentalsShoppingCartTab = new System.Windows.Forms.TabPage();
            this.customerRentalShoppingCartUserControl1 = new FurnitureRentals.User_Controls.CustomerRentalShoppingCartUserControl();
            this.TemporaryShoppingCartLabel = new System.Windows.Forms.Label();
            this.ViewRentalsTab = new System.Windows.Forms.TabPage();
            this.viewCustomerRentalTransactionsUserControl1 = new FurnitureRentals.User_Controls.ViewCustomerRentalTransactionsUserControl();
            this.viewReturnsTab = new System.Windows.Forms.TabPage();
            this.viewReturnTransactionsUserControl1 = new FurnitureRentals.User_Controls.ViewReturnTransactionsUserControl();
            this.LoggedInLabel = new System.Windows.Forms.Label();
            this.LogoutLinkLabel = new System.Windows.Forms.LinkLabel();
            this.UserLoggedInLabel = new System.Windows.Forms.Label();
            this.tabManageCustomerUserControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.RentalsShoppingCartTab.SuspendLayout();
            this.ViewRentalsTab.SuspendLayout();
            this.viewReturnsTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabManageCustomerUserControl
            // 
            this.tabManageCustomerUserControl.Controls.Add(this.tabPage1);
            this.tabManageCustomerUserControl.Controls.Add(this.RentalsShoppingCartTab);
            this.tabManageCustomerUserControl.Controls.Add(this.ViewRentalsTab);
            this.tabManageCustomerUserControl.Controls.Add(this.viewReturnsTab);
            this.tabManageCustomerUserControl.Location = new System.Drawing.Point(9, 37);
            this.tabManageCustomerUserControl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabManageCustomerUserControl.Name = "tabManageCustomerUserControl";
            this.tabManageCustomerUserControl.SelectedIndex = 0;
            this.tabManageCustomerUserControl.Size = new System.Drawing.Size(817, 535);
            this.tabManageCustomerUserControl.TabIndex = 0;
            this.tabManageCustomerUserControl.SelectedIndexChanged += new System.EventHandler(this.Tabs_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.manageCustomerUserControl1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Size = new System.Drawing.Size(809, 509);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Manage Customer";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // manageCustomerUserControl1
            // 
            this.manageCustomerUserControl1.Location = new System.Drawing.Point(26, 3);
            this.manageCustomerUserControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.manageCustomerUserControl1.Name = "manageCustomerUserControl1";
            this.manageCustomerUserControl1.Size = new System.Drawing.Size(685, 513);
            this.manageCustomerUserControl1.TabIndex = 0;
            // 
            // RentalsShoppingCartTab
            // 
            this.RentalsShoppingCartTab.Controls.Add(this.customerRentalShoppingCartUserControl1);
            this.RentalsShoppingCartTab.Controls.Add(this.TemporaryShoppingCartLabel);
            this.RentalsShoppingCartTab.Location = new System.Drawing.Point(4, 22);
            this.RentalsShoppingCartTab.Name = "RentalsShoppingCartTab";
            this.RentalsShoppingCartTab.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.RentalsShoppingCartTab.Size = new System.Drawing.Size(809, 509);
            this.RentalsShoppingCartTab.TabIndex = 1;
            this.RentalsShoppingCartTab.Text = "Rentals Shopping Cart";
            this.RentalsShoppingCartTab.UseVisualStyleBackColor = true;
            // 
            // customerRentalShoppingCartUserControl1
            // 
            this.customerRentalShoppingCartUserControl1.Location = new System.Drawing.Point(100, 25);
            this.customerRentalShoppingCartUserControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.customerRentalShoppingCartUserControl1.Name = "customerRentalShoppingCartUserControl1";
            this.customerRentalShoppingCartUserControl1.Size = new System.Drawing.Size(599, 430);
            this.customerRentalShoppingCartUserControl1.TabIndex = 2;
            // 
            // TemporaryShoppingCartLabel
            // 
            this.TemporaryShoppingCartLabel.AutoSize = true;
            this.TemporaryShoppingCartLabel.Location = new System.Drawing.Point(27, 25);
            this.TemporaryShoppingCartLabel.Name = "TemporaryShoppingCartLabel";
            this.TemporaryShoppingCartLabel.Size = new System.Drawing.Size(0, 13);
            this.TemporaryShoppingCartLabel.TabIndex = 1;
            // 
            // ViewRentalsTab
            // 
            this.ViewRentalsTab.Controls.Add(this.viewCustomerRentalTransactionsUserControl1);
            this.ViewRentalsTab.Location = new System.Drawing.Point(4, 22);
            this.ViewRentalsTab.Name = "ViewRentalsTab";
            this.ViewRentalsTab.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.ViewRentalsTab.Size = new System.Drawing.Size(809, 509);
            this.ViewRentalsTab.TabIndex = 2;
            this.ViewRentalsTab.Text = "View Rentals";
            this.ViewRentalsTab.UseVisualStyleBackColor = true;
            // 
            // viewCustomerRentalTransactionsUserControl1
            // 
            this.viewCustomerRentalTransactionsUserControl1.Location = new System.Drawing.Point(34, 6);
            this.viewCustomerRentalTransactionsUserControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.viewCustomerRentalTransactionsUserControl1.Name = "viewCustomerRentalTransactionsUserControl1";
            this.viewCustomerRentalTransactionsUserControl1.Size = new System.Drawing.Size(711, 363);
            this.viewCustomerRentalTransactionsUserControl1.TabIndex = 0;
            // 
            // viewReturnsTab
            // 
            this.viewReturnsTab.Controls.Add(this.viewReturnTransactionsUserControl1);
            this.viewReturnsTab.Location = new System.Drawing.Point(4, 22);
            this.viewReturnsTab.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.viewReturnsTab.Name = "viewReturnsTab";
            this.viewReturnsTab.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.viewReturnsTab.Size = new System.Drawing.Size(809, 509);
            this.viewReturnsTab.TabIndex = 3;
            this.viewReturnsTab.Text = "View Returns";
            this.viewReturnsTab.UseVisualStyleBackColor = true;
            // 
            // viewReturnTransactionsUserControl1
            // 
            this.viewReturnTransactionsUserControl1.Location = new System.Drawing.Point(0, 2);
            this.viewReturnTransactionsUserControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.viewReturnTransactionsUserControl1.Name = "viewReturnTransactionsUserControl1";
            this.viewReturnTransactionsUserControl1.Size = new System.Drawing.Size(772, 448);
            this.viewReturnTransactionsUserControl1.TabIndex = 0;
            // 
            // LoggedInLabel
            // 
            this.LoggedInLabel.AutoSize = true;
            this.LoggedInLabel.Location = new System.Drawing.Point(668, 5);
            this.LoggedInLabel.Name = "LoggedInLabel";
            this.LoggedInLabel.Size = new System.Drawing.Size(75, 13);
            this.LoggedInLabel.TabIndex = 1;
            this.LoggedInLabel.Text = "Not Logged In";
            // 
            // LogoutLinkLabel
            // 
            this.LogoutLinkLabel.AutoSize = true;
            this.LogoutLinkLabel.Location = new System.Drawing.Point(669, 21);
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
            this.UserLoggedInLabel.Location = new System.Drawing.Point(591, 5);
            this.UserLoggedInLabel.Name = "UserLoggedInLabel";
            this.UserLoggedInLabel.Size = new System.Drawing.Size(77, 13);
            this.UserLoggedInLabel.TabIndex = 4;
            this.UserLoggedInLabel.Text = "Logged in as : ";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 570);
            this.Controls.Add(this.UserLoggedInLabel);
            this.Controls.Add(this.LogoutLinkLabel);
            this.Controls.Add(this.LoggedInLabel);
            this.Controls.Add(this.tabManageCustomerUserControl);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.Text = "Furniture Rentals";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.tabManageCustomerUserControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.RentalsShoppingCartTab.ResumeLayout(false);
            this.RentalsShoppingCartTab.PerformLayout();
            this.ViewRentalsTab.ResumeLayout(false);
            this.viewReturnsTab.ResumeLayout(false);
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
        private System.Windows.Forms.TabPage RentalsShoppingCartTab;
        private System.Windows.Forms.Label TemporaryShoppingCartLabel;
        private User_Controls.CustomerRentalShoppingCartUserControl customerRentalShoppingCartUserControl1;
        private System.Windows.Forms.TabPage ViewRentalsTab;
        private User_Controls.ViewCustomerRentalTransactionsUserControl viewCustomerRentalTransactionsUserControl1;
        private System.Windows.Forms.TabPage viewReturnsTab;
        private User_Controls.ViewReturnTransactionsUserControl viewReturnTransactionsUserControl1;
    }
}

