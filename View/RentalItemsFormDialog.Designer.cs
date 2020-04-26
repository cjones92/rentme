namespace FurnitureRentals.View
{
    partial class RentalItemsFormDialog
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
            this.components = new System.ComponentModel.Container();
            this.RentalItemDataGridView = new System.Windows.Forms.DataGridView();
            this.SerialNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityAlreadyReturned = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityBeingReturned = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityReturned = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemsToReturnButton = new System.Windows.Forms.Button();
            this.EmployeeNameLabel = new System.Windows.Forms.Label();
            this.EmployeeIDLabel = new System.Windows.Forms.Label();
            this.ActualNameLabel = new System.Windows.Forms.Label();
            this.ActualIDLabel = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.furnitureBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.RentalItemDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.furnitureBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // RentalItemDataGridView
            // 
            this.RentalItemDataGridView.AutoGenerateColumns = false;
            this.RentalItemDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RentalItemDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn10,
            this.SerialNumber,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn3,
            this.QuantityAlreadyReturned,
            this.QuantityBeingReturned,
            this.QuantityReturned});
            this.RentalItemDataGridView.DataSource = this.furnitureBindingSource;
            this.RentalItemDataGridView.Location = new System.Drawing.Point(35, 103);
            this.RentalItemDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RentalItemDataGridView.Name = "RentalItemDataGridView";
            this.RentalItemDataGridView.RowHeadersWidth = 51;
            this.RentalItemDataGridView.Size = new System.Drawing.Size(989, 315);
            this.RentalItemDataGridView.TabIndex = 1;
            this.RentalItemDataGridView.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.RentalItemDataGridView_CellValidating);
            this.RentalItemDataGridView.CurrentCellDirtyStateChanged += new System.EventHandler(this.RentalItemDataGridView_CurrentCellDirtyStateChanged);
            // 
            // SerialNumber
            // 
            this.SerialNumber.DataPropertyName = "SerialNumber";
            this.SerialNumber.HeaderText = "Serial Number";
            this.SerialNumber.MinimumWidth = 6;
            this.SerialNumber.Name = "SerialNumber";
            this.SerialNumber.Width = 125;
            // 
            // QuantityAlreadyReturned
            // 
            this.QuantityAlreadyReturned.DataPropertyName = "QuantityAlreadyReturned";
            this.QuantityAlreadyReturned.HeaderText = "Quantity Already Returned";
            this.QuantityAlreadyReturned.MinimumWidth = 6;
            this.QuantityAlreadyReturned.Name = "QuantityAlreadyReturned";
            this.QuantityAlreadyReturned.ReadOnly = true;
            this.QuantityAlreadyReturned.Width = 125;
            // 
            // QuantityBeingReturned
            // 
            this.QuantityBeingReturned.DataPropertyName = "QuantityBeingReturned";
            this.QuantityBeingReturned.HeaderText = "Quantity In Cart";
            this.QuantityBeingReturned.MinimumWidth = 6;
            this.QuantityBeingReturned.Name = "QuantityBeingReturned";
            this.QuantityBeingReturned.ReadOnly = true;
            this.QuantityBeingReturned.Width = 125;
            // 
            // QuantityReturned
            // 
            this.QuantityReturned.HeaderText = "Quantity Returning";
            this.QuantityReturned.MinimumWidth = 6;
            this.QuantityReturned.Name = "QuantityReturned";
            this.QuantityReturned.Width = 125;
            // 
            // ItemsToReturnButton
            // 
            this.ItemsToReturnButton.Font = new System.Drawing.Font("Calibri", 10.2F);
            this.ItemsToReturnButton.Location = new System.Drawing.Point(879, 439);
            this.ItemsToReturnButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ItemsToReturnButton.Name = "ItemsToReturnButton";
            this.ItemsToReturnButton.Size = new System.Drawing.Size(145, 37);
            this.ItemsToReturnButton.TabIndex = 2;
            this.ItemsToReturnButton.Text = "Add To Returns";
            this.ItemsToReturnButton.UseVisualStyleBackColor = true;
            this.ItemsToReturnButton.Click += new System.EventHandler(this.ItemsToReturnButton_Click);
            // 
            // EmployeeNameLabel
            // 
            this.EmployeeNameLabel.AutoSize = true;
            this.EmployeeNameLabel.Font = new System.Drawing.Font("Calibri", 10.2F);
            this.EmployeeNameLabel.Location = new System.Drawing.Point(52, 36);
            this.EmployeeNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EmployeeNameLabel.Name = "EmployeeNameLabel";
            this.EmployeeNameLabel.Size = new System.Drawing.Size(128, 21);
            this.EmployeeNameLabel.TabIndex = 3;
            this.EmployeeNameLabel.Text = "Employee Name:";
            // 
            // EmployeeIDLabel
            // 
            this.EmployeeIDLabel.AutoSize = true;
            this.EmployeeIDLabel.Font = new System.Drawing.Font("Calibri", 10.2F);
            this.EmployeeIDLabel.Location = new System.Drawing.Point(79, 63);
            this.EmployeeIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EmployeeIDLabel.Name = "EmployeeIDLabel";
            this.EmployeeIDLabel.Size = new System.Drawing.Size(101, 21);
            this.EmployeeIDLabel.TabIndex = 4;
            this.EmployeeIDLabel.Text = "Employee ID:";
            // 
            // ActualNameLabel
            // 
            this.ActualNameLabel.AutoSize = true;
            this.ActualNameLabel.Font = new System.Drawing.Font("Calibri", 10.2F);
            this.ActualNameLabel.Location = new System.Drawing.Point(201, 36);
            this.ActualNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ActualNameLabel.Name = "ActualNameLabel";
            this.ActualNameLabel.Size = new System.Drawing.Size(106, 21);
            this.ActualNameLabel.TabIndex = 5;
            this.ActualNameLabel.Text = "Not Logged In";
            // 
            // ActualIDLabel
            // 
            this.ActualIDLabel.AutoSize = true;
            this.ActualIDLabel.Font = new System.Drawing.Font("Calibri", 10.2F);
            this.ActualIDLabel.Location = new System.Drawing.Point(201, 63);
            this.ActualIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ActualIDLabel.Name = "ActualIDLabel";
            this.ActualIDLabel.Size = new System.Drawing.Size(106, 21);
            this.ActualIDLabel.TabIndex = 6;
            this.ActualIDLabel.Text = "Not Logged In";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "ItemDescription";
            this.dataGridViewTextBoxColumn10.HeaderText = "Item Description";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "FurnitureStyle";
            this.dataGridViewTextBoxColumn4.HeaderText = "Furniture Style";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "QuantityOrdered";
            this.dataGridViewTextBoxColumn3.HeaderText = "Quantity Ordered";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // furnitureBindingSource
            // 
            this.furnitureBindingSource.DataSource = typeof(FurnitureRentals.Model.Furniture);
            // 
            // RentalItemsFormDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.ActualIDLabel);
            this.Controls.Add(this.ActualNameLabel);
            this.Controls.Add(this.EmployeeIDLabel);
            this.Controls.Add(this.EmployeeNameLabel);
            this.Controls.Add(this.ItemsToReturnButton);
            this.Controls.Add(this.RentalItemDataGridView);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "RentalItemsFormDialog";
            this.Text = "RentalItemsFormDialog";
            ((System.ComponentModel.ISupportInitialize)(this.RentalItemDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.furnitureBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource furnitureBindingSource;
        private System.Windows.Forms.DataGridView RentalItemDataGridView;
        private System.Windows.Forms.Button ItemsToReturnButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn SerialNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityAlreadyReturned;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityBeingReturned;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityReturned;
        private System.Windows.Forms.Label EmployeeNameLabel;
        private System.Windows.Forms.Label EmployeeIDLabel;
        private System.Windows.Forms.Label ActualNameLabel;
        private System.Windows.Forms.Label ActualIDLabel;
    }
}