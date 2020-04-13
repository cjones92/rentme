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
            this.ManageCustomerTab = new System.Windows.Forms.TabPage();
            this.ShoppingCartTab = new System.Windows.Forms.TabPage();
            this.TemporaryShoppingCartLabel = new System.Windows.Forms.Label();
            this.ViewRentalsTab = new System.Windows.Forms.TabPage();
            this.ViewReturnsTab = new System.Windows.Forms.TabPage();
            this.ReturnsCartTab = new System.Windows.Forms.TabPage();
            this.LoggedInLabel = new System.Windows.Forms.Label();
            this.LogoutLinkLabel = new System.Windows.Forms.LinkLabel();
            this.UserLoggedInLabel = new System.Windows.Forms.Label();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.ActualUserNameLabel = new System.Windows.Forms.Label();
            this.FullNameLabel = new System.Windows.Forms.Label();
            this.manageCustomerUserControl1 = new FurnitureRentals.User_Controls.ManageCustomerUserControl();
            this.customerRentalShoppingCartUserControl1 = new FurnitureRentals.User_Controls.CustomerRentalShoppingCartUserControl();
            this.viewCustomerRentalTransactionsUserControl2 = new FurnitureRentals.User_Controls.ViewCustomerRentalTransactionsUserControl();
            this.viewReturnTransactionsUserControl1 = new FurnitureRentals.User_Controls.ViewReturnTransactionsUserControl();
            this.returnShoppingCartUserControl1 = new FurnitureRentals.User_Controls.ReturnShoppingCartUserControl();
            this.tabManageCustomerUserControl.SuspendLayout();
            this.ManageCustomerTab.SuspendLayout();
            this.ShoppingCartTab.SuspendLayout();
            this.ViewRentalsTab.SuspendLayout();
            this.ViewReturnsTab.SuspendLayout();
            this.ReturnsCartTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabManageCustomerUserControl
            // 
            this.tabManageCustomerUserControl.Controls.Add(this.ManageCustomerTab);
            this.tabManageCustomerUserControl.Controls.Add(this.ShoppingCartTab);
            this.tabManageCustomerUserControl.Controls.Add(this.ViewRentalsTab);
            this.tabManageCustomerUserControl.Controls.Add(this.ViewReturnsTab);
            this.tabManageCustomerUserControl.Controls.Add(this.ReturnsCartTab);
            this.tabManageCustomerUserControl.Location = new System.Drawing.Point(9, 39);
            this.tabManageCustomerUserControl.Margin = new System.Windows.Forms.Padding(2);
            this.tabManageCustomerUserControl.Name = "tabManageCustomerUserControl";
            this.tabManageCustomerUserControl.SelectedIndex = 0;
            this.tabManageCustomerUserControl.Size = new System.Drawing.Size(817, 533);
            this.tabManageCustomerUserControl.TabIndex = 0;
            this.tabManageCustomerUserControl.SelectedIndexChanged += new System.EventHandler(this.Tabs_SelectedIndexChanged);
            // 
            // ManageCustomerTab
            // 
            this.ManageCustomerTab.Controls.Add(this.manageCustomerUserControl1);
            this.ManageCustomerTab.Location = new System.Drawing.Point(4, 22);
            this.ManageCustomerTab.Margin = new System.Windows.Forms.Padding(2);
            this.ManageCustomerTab.Name = "ManageCustomerTab";
            this.ManageCustomerTab.Padding = new System.Windows.Forms.Padding(2);
            this.ManageCustomerTab.Size = new System.Drawing.Size(809, 507);
            this.ManageCustomerTab.TabIndex = 0;
            this.ManageCustomerTab.Text = "Manage Customer";
            this.ManageCustomerTab.UseVisualStyleBackColor = true;
            // 
            // ShoppingCartTab
            // 
            this.ShoppingCartTab.Controls.Add(this.customerRentalShoppingCartUserControl1);
            this.ShoppingCartTab.Controls.Add(this.TemporaryShoppingCartLabel);
            this.ShoppingCartTab.Location = new System.Drawing.Point(4, 22);
            this.ShoppingCartTab.Name = "ShoppingCartTab";
            this.ShoppingCartTab.Padding = new System.Windows.Forms.Padding(3);
            this.ShoppingCartTab.Size = new System.Drawing.Size(809, 503);
            this.ShoppingCartTab.TabIndex = 1;
            this.ShoppingCartTab.Text = "Shopping Cart";
            this.ShoppingCartTab.UseVisualStyleBackColor = true;
            // 
            // TemporaryShoppingCartLabel
            // 
            this.TemporaryShoppingCartLabel.Location = new System.Drawing.Point(0, 0);
            this.TemporaryShoppingCartLabel.Name = "TemporaryShoppingCartLabel";
            this.TemporaryShoppingCartLabel.Size = new System.Drawing.Size(100, 23);
            this.TemporaryShoppingCartLabel.TabIndex = 3;
            // 
            // ViewRentalsTab
            // 
            this.ViewRentalsTab.Controls.Add(this.viewCustomerRentalTransactionsUserControl2);
            this.ViewRentalsTab.Location = new System.Drawing.Point(4, 22);
            this.ViewRentalsTab.Name = "ViewRentalsTab";
            this.ViewRentalsTab.Size = new System.Drawing.Size(809, 503);
            this.ViewRentalsTab.TabIndex = 2;
            this.ViewRentalsTab.Text = "View Rentals";
            // 
            // ViewReturnsTab
            // 
            this.ViewReturnsTab.Controls.Add(this.viewReturnTransactionsUserControl1);
            this.ViewReturnsTab.Location = new System.Drawing.Point(4, 22);
            this.ViewReturnsTab.Margin = new System.Windows.Forms.Padding(2);
            this.ViewReturnsTab.Name = "ViewReturnsTab";
            this.ViewReturnsTab.Padding = new System.Windows.Forms.Padding(2);
            this.ViewReturnsTab.Size = new System.Drawing.Size(809, 503);
            this.ViewReturnsTab.TabIndex = 3;
            this.ViewReturnsTab.Text = "View Returns";
            this.ViewReturnsTab.UseVisualStyleBackColor = true;
            // 
            // ReturnsCartTab
            // 
            this.ReturnsCartTab.Controls.Add(this.returnShoppingCartUserControl1);
            this.ReturnsCartTab.Location = new System.Drawing.Point(4, 22);
            this.ReturnsCartTab.Margin = new System.Windows.Forms.Padding(2);
            this.ReturnsCartTab.Name = "ReturnsCartTab";
            this.ReturnsCartTab.Padding = new System.Windows.Forms.Padding(2);
            this.ReturnsCartTab.Size = new System.Drawing.Size(809, 503);
            this.ReturnsCartTab.TabIndex = 4;
            this.ReturnsCartTab.Text = "Return Cart";
            this.ReturnsCartTab.UseVisualStyleBackColor = true;
            // 
            // LoggedInLabel
            // 
            this.LoggedInLabel.AutoSize = true;
            this.LoggedInLabel.Font = new System.Drawing.Font("Calibri", 10.2F);
            this.LoggedInLabel.Location = new System.Drawing.Point(728, 26);
            this.LoggedInLabel.Name = "LoggedInLabel";
            this.LoggedInLabel.Size = new System.Drawing.Size(87, 17);
            this.LoggedInLabel.TabIndex = 1;
            this.LoggedInLabel.Text = "Not Logged In";
            // 
            // LogoutLinkLabel
            // 
            this.LogoutLinkLabel.AutoSize = true;
            this.LogoutLinkLabel.Font = new System.Drawing.Font("Calibri", 10.2F);
            this.LogoutLinkLabel.Location = new System.Drawing.Point(535, 39);
            this.LogoutLinkLabel.Name = "LogoutLinkLabel";
            this.LogoutLinkLabel.Size = new System.Drawing.Size(52, 17);
            this.LogoutLinkLabel.TabIndex = 3;
            this.LogoutLinkLabel.TabStop = true;
            this.LogoutLinkLabel.Text = "Log Out";
            this.LogoutLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LogoutLinkLabel_LinkClicked);
            // 
            // UserLoggedInLabel
            // 
            this.UserLoggedInLabel.AutoSize = true;
            this.UserLoggedInLabel.Font = new System.Drawing.Font("Calibri", 10.2F);
            this.UserLoggedInLabel.Location = new System.Drawing.Point(535, 9);
            this.UserLoggedInLabel.Name = "UserLoggedInLabel";
            this.UserLoggedInLabel.Size = new System.Drawing.Size(87, 17);
            this.UserLoggedInLabel.TabIndex = 4;
            this.UserLoggedInLabel.Text = "Logged in as : ";
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Font = new System.Drawing.Font("Calibri", 10.2F);
            this.UserNameLabel.Location = new System.Drawing.Point(647, 9);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(75, 17);
            this.UserNameLabel.TabIndex = 5;
            this.UserNameLabel.Text = "User Name:";
            // 
            // ActualUserNameLabel
            // 
            this.ActualUserNameLabel.AutoSize = true;
            this.ActualUserNameLabel.Font = new System.Drawing.Font("Calibri", 10.2F);
            this.ActualUserNameLabel.Location = new System.Drawing.Point(728, 9);
            this.ActualUserNameLabel.Name = "ActualUserNameLabel";
            this.ActualUserNameLabel.Size = new System.Drawing.Size(87, 17);
            this.ActualUserNameLabel.TabIndex = 6;
            this.ActualUserNameLabel.Text = "Not Logged In";
            // 
            // FullNameLabel
            // 
            this.FullNameLabel.AutoSize = true;
            this.FullNameLabel.Font = new System.Drawing.Font("Calibri", 10.2F);
            this.FullNameLabel.Location = new System.Drawing.Point(676, 26);
            this.FullNameLabel.Name = "FullNameLabel";
            this.FullNameLabel.Size = new System.Drawing.Size(46, 17);
            this.FullNameLabel.TabIndex = 7;
            this.FullNameLabel.Text = "Name:";
            // 
            // manageCustomerUserControl1
            // 
            this.manageCustomerUserControl1.Location = new System.Drawing.Point(26, 3);
            this.manageCustomerUserControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.manageCustomerUserControl1.Name = "manageCustomerUserControl1";
            this.manageCustomerUserControl1.Size = new System.Drawing.Size(685, 513);
            this.manageCustomerUserControl1.TabIndex = 0;
            // 
            // customerRentalShoppingCartUserControl1
            // 
            this.customerRentalShoppingCartUserControl1.Location = new System.Drawing.Point(100, 25);
            this.customerRentalShoppingCartUserControl1.Margin = new System.Windows.Forms.Padding(4);
            this.customerRentalShoppingCartUserControl1.Name = "customerRentalShoppingCartUserControl1";
            this.customerRentalShoppingCartUserControl1.Size = new System.Drawing.Size(599, 430);
            this.customerRentalShoppingCartUserControl1.TabIndex = 2;
            // 
            // viewCustomerRentalTransactionsUserControl2
            // 
            this.viewCustomerRentalTransactionsUserControl2.Location = new System.Drawing.Point(32, 3);
            this.viewCustomerRentalTransactionsUserControl2.Name = "viewCustomerRentalTransactionsUserControl2";
            this.viewCustomerRentalTransactionsUserControl2.Size = new System.Drawing.Size(711, 376);
            this.viewCustomerRentalTransactionsUserControl2.TabIndex = 0;
            // 
            // viewReturnTransactionsUserControl1
            // 
            this.viewReturnTransactionsUserControl1.Location = new System.Drawing.Point(0, 2);
            this.viewReturnTransactionsUserControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.viewReturnTransactionsUserControl1.Name = "viewReturnTransactionsUserControl1";
            this.viewReturnTransactionsUserControl1.Size = new System.Drawing.Size(772, 448);
            this.viewReturnTransactionsUserControl1.TabIndex = 0;
            // 
            // returnShoppingCartUserControl1
            // 
            this.returnShoppingCartUserControl1.Location = new System.Drawing.Point(0, 0);
            this.returnShoppingCartUserControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.returnShoppingCartUserControl1.Name = "returnShoppingCartUserControl1";
            this.returnShoppingCartUserControl1.Size = new System.Drawing.Size(806, 504);
            this.returnShoppingCartUserControl1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 570);
            this.Controls.Add(this.FullNameLabel);
            this.Controls.Add(this.ActualUserNameLabel);
            this.Controls.Add(this.UserNameLabel);
            this.Controls.Add(this.UserLoggedInLabel);
            this.Controls.Add(this.LogoutLinkLabel);
            this.Controls.Add(this.LoggedInLabel);
            this.Controls.Add(this.tabManageCustomerUserControl);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "Furniture Rentals";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.tabManageCustomerUserControl.ResumeLayout(false);
            this.ManageCustomerTab.ResumeLayout(false);
            this.ShoppingCartTab.ResumeLayout(false);
            this.ViewRentalsTab.ResumeLayout(false);
            this.ViewReturnsTab.ResumeLayout(false);
            this.ReturnsCartTab.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabManageCustomerUserControl;
        private System.Windows.Forms.TabPage ManageCustomerTab;
        private User_Controls.ManageCustomerUserControl manageCustomerUserControl1;
        private System.Windows.Forms.Label LoggedInLabel;
        private System.Windows.Forms.LinkLabel LogoutLinkLabel;
        private System.Windows.Forms.Label UserLoggedInLabel;
        private System.Windows.Forms.TabPage ShoppingCartTab;
        private System.Windows.Forms.Label TemporaryShoppingCartLabel;
        private User_Controls.CustomerRentalShoppingCartUserControl customerRentalShoppingCartUserControl1;
        private System.Windows.Forms.TabPage ViewRentalsTab;
        public User_Controls.ViewCustomerRentalTransactionsUserControl viewCustomerRentalTransactionsUserControl1;
        private System.Windows.Forms.TabPage ViewReturnsTab;
        private User_Controls.ViewReturnTransactionsUserControl viewReturnTransactionsUserControl1;
        private System.Windows.Forms.TabPage ReturnsCartTab;
        private User_Controls.ReturnShoppingCartUserControl returnShoppingCartUserControl1;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.Label ActualUserNameLabel;
        private System.Windows.Forms.Label FullNameLabel;
        private User_Controls.ViewCustomerRentalTransactionsUserControl viewCustomerRentalTransactionsUserControl2;
    }
}

