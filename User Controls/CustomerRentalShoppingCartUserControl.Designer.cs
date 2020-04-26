namespace FurnitureRentals.User_Controls
{
    partial class CustomerRentalShoppingCartUserControl
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
            this.FurnitureSearchButton = new System.Windows.Forms.Button();
            this.EmptyCartButton = new System.Windows.Forms.Button();
            this.RentalTotalTextBox = new System.Windows.Forms.TextBox();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.RentalDataGridView = new System.Windows.Forms.DataGridView();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Style = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityAvailable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remove = new System.Windows.Forms.DataGridViewLinkColumn();
            this.SubmitRentalButton = new System.Windows.Forms.Button();
            this.CustomerName = new System.Windows.Forms.Label();
            this.MemberIDLabel = new System.Windows.Forms.Label();
            this.ActualNameLabel = new System.Windows.Forms.Label();
            this.ActualIDLabel = new System.Windows.Forms.Label();
            this.DaysRentingTextBox = new System.Windows.Forms.TextBox();
            this.DaysRentingLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.RentalDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // FurnitureSearchButton
            // 
            this.FurnitureSearchButton.Font = new System.Drawing.Font("Calibri", 10.2F);
            this.FurnitureSearchButton.Location = new System.Drawing.Point(19, 67);
            this.FurnitureSearchButton.Name = "FurnitureSearchButton";
            this.FurnitureSearchButton.Size = new System.Drawing.Size(136, 23);
            this.FurnitureSearchButton.TabIndex = 0;
            this.FurnitureSearchButton.Text = "Look Up Furniture";
            this.FurnitureSearchButton.UseVisualStyleBackColor = true;
            this.FurnitureSearchButton.Click += new System.EventHandler(this.FurnitureSearchButton_Click);
            // 
            // EmptyCartButton
            // 
            this.EmptyCartButton.Font = new System.Drawing.Font("Calibri", 10.2F);
            this.EmptyCartButton.Location = new System.Drawing.Point(171, 67);
            this.EmptyCartButton.Name = "EmptyCartButton";
            this.EmptyCartButton.Size = new System.Drawing.Size(75, 23);
            this.EmptyCartButton.TabIndex = 1;
            this.EmptyCartButton.Text = "Clear Cart";
            this.EmptyCartButton.UseVisualStyleBackColor = true;
            this.EmptyCartButton.Click += new System.EventHandler(this.EmptyCartButton_Click);
            // 
            // RentalTotalTextBox
            // 
            this.RentalTotalTextBox.Font = new System.Drawing.Font("Calibri", 10.2F);
            this.RentalTotalTextBox.Location = new System.Drawing.Point(499, 344);
            this.RentalTotalTextBox.Name = "RentalTotalTextBox";
            this.RentalTotalTextBox.ReadOnly = true;
            this.RentalTotalTextBox.Size = new System.Drawing.Size(100, 24);
            this.RentalTotalTextBox.TabIndex = 2;
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Font = new System.Drawing.Font("Calibri", 10.2F);
            this.TotalLabel.Location = new System.Drawing.Point(436, 347);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(40, 17);
            this.TotalLabel.TabIndex = 3;
            this.TotalLabel.Text = "Total:";
            // 
            // RentalDataGridView
            // 
            this.RentalDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RentalDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Item,
            this.Style,
            this.Quantity,
            this.QuantityAvailable,
            this.TotalCost,
            this.Remove});
            this.RentalDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.RentalDataGridView.Location = new System.Drawing.Point(19, 101);
            this.RentalDataGridView.Name = "RentalDataGridView";
            this.RentalDataGridView.RowHeadersWidth = 51;
            this.RentalDataGridView.Size = new System.Drawing.Size(579, 215);
            this.RentalDataGridView.TabIndex = 4;
            this.RentalDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RentalDataGridView_CellContentClick);
            this.RentalDataGridView.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.RentalDataGridView_CellValidated);
            this.RentalDataGridView.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.RentalDataGridView_CellValidating);
            this.RentalDataGridView.CurrentCellDirtyStateChanged += new System.EventHandler(this.RentalDataGridView_CurrentCellDirtyStateChanged);
            this.RentalDataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RentalDataGridView_KeyDown);
            // 
            // Item
            // 
            this.Item.DataPropertyName = "Item";
            this.Item.HeaderText = "Item";
            this.Item.MinimumWidth = 6;
            this.Item.Name = "Item";
            this.Item.ReadOnly = true;
            this.Item.Width = 125;
            // 
            // Style
            // 
            this.Style.DataPropertyName = "Style";
            this.Style.HeaderText = "Style";
            this.Style.MinimumWidth = 6;
            this.Style.Name = "Style";
            this.Style.ReadOnly = true;
            this.Style.Width = 150;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity Ordering";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            this.Quantity.Width = 125;
            // 
            // QuantityAvailable
            // 
            this.QuantityAvailable.DataPropertyName = "QuantityAvailable";
            this.QuantityAvailable.HeaderText = "Quantity In Stock";
            this.QuantityAvailable.Name = "QuantityAvailable";
            this.QuantityAvailable.ReadOnly = true;
            // 
            // TotalCost
            // 
            this.TotalCost.HeaderText = "Total Cost";
            this.TotalCost.MinimumWidth = 6;
            this.TotalCost.Name = "TotalCost";
            this.TotalCost.ReadOnly = true;
            this.TotalCost.Width = 125;
            // 
            // Remove
            // 
            this.Remove.DataPropertyName = "Remove";
            this.Remove.HeaderText = "Remove";
            this.Remove.MinimumWidth = 6;
            this.Remove.Name = "Remove";
            this.Remove.ReadOnly = true;
            this.Remove.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Remove.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Remove.Text = "X";
            this.Remove.Width = 125;
            // 
            // SubmitRentalButton
            // 
            this.SubmitRentalButton.Font = new System.Drawing.Font("Calibri", 10.2F);
            this.SubmitRentalButton.Location = new System.Drawing.Point(499, 379);
            this.SubmitRentalButton.Name = "SubmitRentalButton";
            this.SubmitRentalButton.Size = new System.Drawing.Size(99, 31);
            this.SubmitRentalButton.TabIndex = 5;
            this.SubmitRentalButton.Text = "Submit Order";
            this.SubmitRentalButton.UseVisualStyleBackColor = true;
            this.SubmitRentalButton.Click += new System.EventHandler(this.SubmitRentalButton_Click);
            // 
            // CustomerName
            // 
            this.CustomerName.AutoSize = true;
            this.CustomerName.Font = new System.Drawing.Font("Calibri", 10.2F);
            this.CustomerName.Location = new System.Drawing.Point(24, 15);
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.Size = new System.Drawing.Size(103, 17);
            this.CustomerName.TabIndex = 6;
            this.CustomerName.Text = "Customer Name:";
            // 
            // MemberIDLabel
            // 
            this.MemberIDLabel.AutoSize = true;
            this.MemberIDLabel.Font = new System.Drawing.Font("Calibri", 10.2F);
            this.MemberIDLabel.Location = new System.Drawing.Point(47, 35);
            this.MemberIDLabel.Name = "MemberIDLabel";
            this.MemberIDLabel.Size = new System.Drawing.Size(80, 17);
            this.MemberIDLabel.TabIndex = 7;
            this.MemberIDLabel.Text = "Member ID: ";
            // 
            // ActualNameLabel
            // 
            this.ActualNameLabel.AutoSize = true;
            this.ActualNameLabel.Font = new System.Drawing.Font("Calibri", 10.2F);
            this.ActualNameLabel.Location = new System.Drawing.Point(136, 15);
            this.ActualNameLabel.Name = "ActualNameLabel";
            this.ActualNameLabel.Size = new System.Drawing.Size(42, 17);
            this.ActualNameLabel.TabIndex = 8;
            this.ActualNameLabel.Text = "label1";
            // 
            // ActualIDLabel
            // 
            this.ActualIDLabel.AutoSize = true;
            this.ActualIDLabel.Font = new System.Drawing.Font("Calibri", 10.2F);
            this.ActualIDLabel.Location = new System.Drawing.Point(136, 36);
            this.ActualIDLabel.Name = "ActualIDLabel";
            this.ActualIDLabel.Size = new System.Drawing.Size(42, 17);
            this.ActualIDLabel.TabIndex = 9;
            this.ActualIDLabel.Text = "label2";
            // 
            // DaysRentingTextBox
            // 
            this.DaysRentingTextBox.Font = new System.Drawing.Font("Calibri", 10.2F);
            this.DaysRentingTextBox.Location = new System.Drawing.Point(499, 70);
            this.DaysRentingTextBox.Name = "DaysRentingTextBox";
            this.DaysRentingTextBox.Size = new System.Drawing.Size(100, 24);
            this.DaysRentingTextBox.TabIndex = 10;
            this.DaysRentingTextBox.TextChanged += new System.EventHandler(this.DaysRentingTextBox_TextChanged);
            this.DaysRentingTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DaysRented_KeyPress);
            // 
            // DaysRentingLabel
            // 
            this.DaysRentingLabel.AutoSize = true;
            this.DaysRentingLabel.Font = new System.Drawing.Font("Calibri", 10.2F);
            this.DaysRentingLabel.Location = new System.Drawing.Point(340, 72);
            this.DaysRentingLabel.Name = "DaysRentingLabel";
            this.DaysRentingLabel.Size = new System.Drawing.Size(146, 17);
            this.DaysRentingLabel.TabIndex = 11;
            this.DaysRentingLabel.Text = "Number of Days Rented:";
            // 
            // CustomerRentalShoppingCartUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DaysRentingLabel);
            this.Controls.Add(this.DaysRentingTextBox);
            this.Controls.Add(this.ActualIDLabel);
            this.Controls.Add(this.ActualNameLabel);
            this.Controls.Add(this.MemberIDLabel);
            this.Controls.Add(this.CustomerName);
            this.Controls.Add(this.SubmitRentalButton);
            this.Controls.Add(this.RentalDataGridView);
            this.Controls.Add(this.TotalLabel);
            this.Controls.Add(this.RentalTotalTextBox);
            this.Controls.Add(this.EmptyCartButton);
            this.Controls.Add(this.FurnitureSearchButton);
            this.Name = "CustomerRentalShoppingCartUserControl";
            this.Size = new System.Drawing.Size(783, 469);
            ((System.ComponentModel.ISupportInitialize)(this.RentalDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button FurnitureSearchButton;
        private System.Windows.Forms.Button EmptyCartButton;
        private System.Windows.Forms.TextBox RentalTotalTextBox;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.DataGridView RentalDataGridView;
        private System.Windows.Forms.Button SubmitRentalButton;
        private System.Windows.Forms.Label CustomerName;
        private System.Windows.Forms.Label MemberIDLabel;
        private System.Windows.Forms.Label ActualNameLabel;
        private System.Windows.Forms.Label ActualIDLabel;
        private System.Windows.Forms.TextBox DaysRentingTextBox;
        private System.Windows.Forms.Label DaysRentingLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn Style;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityAvailable;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalCost;
        private System.Windows.Forms.DataGridViewLinkColumn Remove;
    }
}
