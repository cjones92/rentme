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
            this.ShoppingCartTab = new System.Windows.Forms.TabPage();
            this.customerRentalShoppingCartUserControl1 = new FurnitureRentals.User_Controls.CustomerRentalShoppingCartUserControl();
            this.TemporaryShoppingCartLabel = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.viewCustomerRentalTransactionsUserControl1 = new FurnitureRentals.User_Controls.ViewCustomerRentalTransactionsUserControl();
            this.viewReturnsTab = new System.Windows.Forms.TabPage();
            this.viewReturnTransactionsUserControl1 = new FurnitureRentals.User_Controls.ViewReturnTransactionsUserControl();
            this.tabReturnCart = new System.Windows.Forms.TabPage();
            this.returnShoppingCartUserControl1 = new FurnitureRentals.User_Controls.ReturnShoppingCartUserControl();
            this.LoggedInLabel = new System.Windows.Forms.Label();
            this.LogoutLinkLabel = new System.Windows.Forms.LinkLabel();
            this.UserLoggedInLabel = new System.Windows.Forms.Label();
            this.tabManageCustomerUserControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.ShoppingCartTab.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.viewReturnsTab.SuspendLayout();
            this.tabReturnCart.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabManageCustomerUserControl
            // 
            this.tabManageCustomerUserControl.Controls.Add(this.tabPage1);
            this.tabManageCustomerUserControl.Controls.Add(this.ShoppingCartTab);
            this.tabManageCustomerUserControl.Controls.Add(this.tabPage2);
            this.tabManageCustomerUserControl.Controls.Add(this.viewReturnsTab);
            this.tabManageCustomerUserControl.Controls.Add(this.tabReturnCart);
            this.tabManageCustomerUserControl.Location = new System.Drawing.Point(12, 45);
            this.tabManageCustomerUserControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabManageCustomerUserControl.Name = "tabManageCustomerUserControl";
            this.tabManageCustomerUserControl.SelectedIndex = 0;
            this.tabManageCustomerUserControl.Size = new System.Drawing.Size(1089, 659);
            this.tabManageCustomerUserControl.TabIndex = 0;
            this.tabManageCustomerUserControl.SelectedIndexChanged += new System.EventHandler(this.Tabs_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.manageCustomerUserControl1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(1081, 630);
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
            // ShoppingCartTab
            // 
            this.ShoppingCartTab.Controls.Add(this.customerRentalShoppingCartUserControl1);
            this.ShoppingCartTab.Controls.Add(this.TemporaryShoppingCartLabel);
            this.ShoppingCartTab.Location = new System.Drawing.Point(4, 25);
            this.ShoppingCartTab.Margin = new System.Windows.Forms.Padding(4);
            this.ShoppingCartTab.Name = "ShoppingCartTab";
            this.ShoppingCartTab.Padding = new System.Windows.Forms.Padding(4);
            this.ShoppingCartTab.Size = new System.Drawing.Size(1081, 630);
            this.ShoppingCartTab.TabIndex = 1;
            this.ShoppingCartTab.Text = "Shopping Cart";
            this.ShoppingCartTab.UseVisualStyleBackColor = true;
            // 
            // customerRentalShoppingCartUserControl1
            // 
            this.customerRentalShoppingCartUserControl1.Location = new System.Drawing.Point(133, 31);
            this.customerRentalShoppingCartUserControl1.Margin = new System.Windows.Forms.Padding(5);
            this.customerRentalShoppingCartUserControl1.Name = "customerRentalShoppingCartUserControl1";
            this.customerRentalShoppingCartUserControl1.Size = new System.Drawing.Size(799, 529);
            this.customerRentalShoppingCartUserControl1.TabIndex = 2;
            // 
            // TemporaryShoppingCartLabel
            // 
            this.TemporaryShoppingCartLabel.AutoSize = true;
            this.TemporaryShoppingCartLabel.Location = new System.Drawing.Point(36, 31);
            this.TemporaryShoppingCartLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TemporaryShoppingCartLabel.Name = "TemporaryShoppingCartLabel";
            this.TemporaryShoppingCartLabel.Size = new System.Drawing.Size(0, 17);
            this.TemporaryShoppingCartLabel.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.viewCustomerRentalTransactionsUserControl1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1081, 630);
            this.tabPage2.TabIndex = 2;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // viewCustomerRentalTransactionsUserControl1
            // 
            this.viewCustomerRentalTransactionsUserControl1.Location = new System.Drawing.Point(45, 7);
            this.viewCustomerRentalTransactionsUserControl1.Margin = new System.Windows.Forms.Padding(5);
            this.viewCustomerRentalTransactionsUserControl1.Name = "viewCustomerRentalTransactionsUserControl1";
            this.viewCustomerRentalTransactionsUserControl1.Size = new System.Drawing.Size(948, 447);
            this.viewCustomerRentalTransactionsUserControl1.TabIndex = 0;
            // 
            // viewReturnsTab
            // 
            this.viewReturnsTab.Controls.Add(this.viewReturnTransactionsUserControl1);
            this.viewReturnsTab.Location = new System.Drawing.Point(4, 25);
            this.viewReturnsTab.Name = "viewReturnsTab";
            this.viewReturnsTab.Padding = new System.Windows.Forms.Padding(3);
            this.viewReturnsTab.Size = new System.Drawing.Size(1081, 630);
            this.viewReturnsTab.TabIndex = 3;
            this.viewReturnsTab.Text = "View Returns";
            this.viewReturnsTab.UseVisualStyleBackColor = true;
            // 
            // viewReturnTransactionsUserControl1
            // 
            this.viewReturnTransactionsUserControl1.Location = new System.Drawing.Point(0, 3);
            this.viewReturnTransactionsUserControl1.Name = "viewReturnTransactionsUserControl1";
            this.viewReturnTransactionsUserControl1.Size = new System.Drawing.Size(1029, 552);
            this.viewReturnTransactionsUserControl1.TabIndex = 0;
            // 
            // tabReturnCart
            // 
            this.tabReturnCart.Controls.Add(this.returnShoppingCartUserControl1);
            this.tabReturnCart.Location = new System.Drawing.Point(4, 25);
            this.tabReturnCart.Name = "tabReturnCart";
            this.tabReturnCart.Padding = new System.Windows.Forms.Padding(3);
            this.tabReturnCart.Size = new System.Drawing.Size(1081, 630);
            this.tabReturnCart.TabIndex = 4;
            this.tabReturnCart.Text = "Return Cart";
            this.tabReturnCart.UseVisualStyleBackColor = true;
            // 
            // returnShoppingCartUserControl1
            // 
            this.returnShoppingCartUserControl1.Location = new System.Drawing.Point(0, 0);
            this.returnShoppingCartUserControl1.Name = "returnShoppingCartUserControl1";
            this.returnShoppingCartUserControl1.Size = new System.Drawing.Size(1075, 620);
            this.returnShoppingCartUserControl1.TabIndex = 0;
            // 
            // LoggedInLabel
            // 
            this.LoggedInLabel.AutoSize = true;
            this.LoggedInLabel.Font = new System.Drawing.Font("Calibri", 10.2F);
            this.LoggedInLabel.Location = new System.Drawing.Point(891, 6);
            this.LoggedInLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LoggedInLabel.Name = "LoggedInLabel";
            this.LoggedInLabel.Size = new System.Drawing.Size(106, 21);
            this.LoggedInLabel.TabIndex = 1;
            this.LoggedInLabel.Text = "Not Logged In";
            // 
            // LogoutLinkLabel
            // 
            this.LogoutLinkLabel.AutoSize = true;
            this.LogoutLinkLabel.Font = new System.Drawing.Font("Calibri", 10.2F);
            this.LogoutLinkLabel.Location = new System.Drawing.Point(892, 30);
            this.LogoutLinkLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LogoutLinkLabel.Name = "LogoutLinkLabel";
            this.LogoutLinkLabel.Size = new System.Drawing.Size(64, 21);
            this.LogoutLinkLabel.TabIndex = 3;
            this.LogoutLinkLabel.TabStop = true;
            this.LogoutLinkLabel.Text = "Log Out";
            this.LogoutLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LogoutLinkLabel_LinkClicked);
            // 
            // UserLoggedInLabel
            // 
            this.UserLoggedInLabel.AutoSize = true;
            this.UserLoggedInLabel.Font = new System.Drawing.Font("Calibri", 10.2F);
            this.UserLoggedInLabel.Location = new System.Drawing.Point(776, 6);
            this.UserLoggedInLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UserLoggedInLabel.Name = "UserLoggedInLabel";
            this.UserLoggedInLabel.Size = new System.Drawing.Size(108, 21);
            this.UserLoggedInLabel.TabIndex = 4;
            this.UserLoggedInLabel.Text = "Logged in as : ";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 702);
            this.Controls.Add(this.UserLoggedInLabel);
            this.Controls.Add(this.LogoutLinkLabel);
            this.Controls.Add(this.LoggedInLabel);
            this.Controls.Add(this.tabManageCustomerUserControl);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "Furniture Rentals";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.tabManageCustomerUserControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ShoppingCartTab.ResumeLayout(false);
            this.ShoppingCartTab.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.viewReturnsTab.ResumeLayout(false);
            this.tabReturnCart.ResumeLayout(false);
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
        private System.Windows.Forms.Label TemporaryShoppingCartLabel;
        private User_Controls.CustomerRentalShoppingCartUserControl customerRentalShoppingCartUserControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private User_Controls.ViewCustomerRentalTransactionsUserControl viewCustomerRentalTransactionsUserControl1;
        private System.Windows.Forms.TabPage viewReturnsTab;
        private User_Controls.ViewReturnTransactionsUserControl viewReturnTransactionsUserControl1;
        private System.Windows.Forms.TabPage tabReturnCart;
        private User_Controls.ReturnShoppingCartUserControl returnShoppingCartUserControl1;
    }
}

