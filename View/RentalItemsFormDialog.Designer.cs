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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RentalItemsFormDialog));
            this.furnitureBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.furnitureBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.RentalItemDataGridView = new System.Windows.Forms.DataGridView();
            this.SerialNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityAlreadyReturned = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityBeingReturned = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityReturned = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemsToReturnButton = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.furnitureBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EmployeeNameLabel = new System.Windows.Forms.Label();
            this.EmployeeIDLabel = new System.Windows.Forms.Label();
            this.ActualNameLabel = new System.Windows.Forms.Label();
            this.ActualIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.furnitureBindingNavigator)).BeginInit();
            this.furnitureBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RentalItemDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.furnitureBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // furnitureBindingNavigator
            // 
            this.furnitureBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.furnitureBindingNavigator.BindingSource = this.furnitureBindingSource;
            this.furnitureBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.furnitureBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.furnitureBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.furnitureBindingNavigatorSaveItem});
            this.furnitureBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.furnitureBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.furnitureBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.furnitureBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.furnitureBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.furnitureBindingNavigator.Name = "furnitureBindingNavigator";
            this.furnitureBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.furnitureBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.furnitureBindingNavigator.TabIndex = 0;
            this.furnitureBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // furnitureBindingNavigatorSaveItem
            // 
            this.furnitureBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.furnitureBindingNavigatorSaveItem.Enabled = false;
            this.furnitureBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("furnitureBindingNavigatorSaveItem.Image")));
            this.furnitureBindingNavigatorSaveItem.Name = "furnitureBindingNavigatorSaveItem";
            this.furnitureBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.furnitureBindingNavigatorSaveItem.Text = "Save Data";
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
            this.RentalItemDataGridView.Location = new System.Drawing.Point(39, 78);
            this.RentalItemDataGridView.Name = "RentalItemDataGridView";
            this.RentalItemDataGridView.Size = new System.Drawing.Size(645, 220);
            this.RentalItemDataGridView.TabIndex = 1;
            this.RentalItemDataGridView.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.RentalItemDataGridView_CellValidating);
            this.RentalItemDataGridView.CurrentCellDirtyStateChanged += new System.EventHandler(this.RentalItemDataGridView_CurrentCellDirtyStateChanged);
            // 
            // SerialNumber
            // 
            this.SerialNumber.DataPropertyName = "SerialNumber";
            this.SerialNumber.HeaderText = "Serial Number";
            this.SerialNumber.Name = "SerialNumber";
            // 
            // QuantityAlreadyReturned
            // 
            this.QuantityAlreadyReturned.DataPropertyName = "QuantityAlreadyReturned";
            this.QuantityAlreadyReturned.HeaderText = "Quantity Already Returned";
            this.QuantityAlreadyReturned.Name = "QuantityAlreadyReturned";
            this.QuantityAlreadyReturned.ReadOnly = true;
            // 
            // QuantityBeingReturned
            // 
            this.QuantityBeingReturned.DataPropertyName = "QuantityBeingReturned";
            this.QuantityBeingReturned.HeaderText = "Quantity In Cart";
            this.QuantityBeingReturned.Name = "QuantityBeingReturned";
            this.QuantityBeingReturned.ReadOnly = true;
            // 
            // QuantityReturned
            // 
            this.QuantityReturned.HeaderText = "Quantity Returning";
            this.QuantityReturned.Name = "QuantityReturned";
            // 
            // ItemsToReturnButton
            // 
            this.ItemsToReturnButton.Location = new System.Drawing.Point(433, 348);
            this.ItemsToReturnButton.Name = "ItemsToReturnButton";
            this.ItemsToReturnButton.Size = new System.Drawing.Size(109, 23);
            this.ItemsToReturnButton.TabIndex = 2;
            this.ItemsToReturnButton.Text = "Add To Returns";
            this.ItemsToReturnButton.UseVisualStyleBackColor = true;
            this.ItemsToReturnButton.Click += new System.EventHandler(this.ItemsToReturnButton_Click);
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "ItemDescription";
            this.dataGridViewTextBoxColumn10.HeaderText = "Item Description";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "FurnitureStyle";
            this.dataGridViewTextBoxColumn4.HeaderText = "Furniture Style";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "QuantityOrdered";
            this.dataGridViewTextBoxColumn3.HeaderText = "Quantity Ordered";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // furnitureBindingSource
            // 
            this.furnitureBindingSource.DataSource = typeof(FurnitureRentals.Model.Furniture);
            // 
            // EmployeeNameLabel
            // 
            this.EmployeeNameLabel.AutoSize = true;
            this.EmployeeNameLabel.Location = new System.Drawing.Point(39, 29);
            this.EmployeeNameLabel.Name = "EmployeeNameLabel";
            this.EmployeeNameLabel.Size = new System.Drawing.Size(87, 13);
            this.EmployeeNameLabel.TabIndex = 3;
            this.EmployeeNameLabel.Text = "Employee Name:";
            // 
            // EmployeeIDLabel
            // 
            this.EmployeeIDLabel.AutoSize = true;
            this.EmployeeIDLabel.Location = new System.Drawing.Point(39, 51);
            this.EmployeeIDLabel.Name = "EmployeeIDLabel";
            this.EmployeeIDLabel.Size = new System.Drawing.Size(70, 13);
            this.EmployeeIDLabel.TabIndex = 4;
            this.EmployeeIDLabel.Text = "Employee ID:";
            // 
            // ActualNameLabel
            // 
            this.ActualNameLabel.AutoSize = true;
            this.ActualNameLabel.Location = new System.Drawing.Point(132, 29);
            this.ActualNameLabel.Name = "ActualNameLabel";
            this.ActualNameLabel.Size = new System.Drawing.Size(75, 13);
            this.ActualNameLabel.TabIndex = 5;
            this.ActualNameLabel.Text = "Not Logged In";
            // 
            // ActualIDLabel
            // 
            this.ActualIDLabel.AutoSize = true;
            this.ActualIDLabel.Location = new System.Drawing.Point(115, 51);
            this.ActualIDLabel.Name = "ActualIDLabel";
            this.ActualIDLabel.Size = new System.Drawing.Size(75, 13);
            this.ActualIDLabel.TabIndex = 6;
            this.ActualIDLabel.Text = "Not Logged In";
            // 
            // RentalItemsFormDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ActualIDLabel);
            this.Controls.Add(this.ActualNameLabel);
            this.Controls.Add(this.EmployeeIDLabel);
            this.Controls.Add(this.EmployeeNameLabel);
            this.Controls.Add(this.ItemsToReturnButton);
            this.Controls.Add(this.RentalItemDataGridView);
            this.Controls.Add(this.furnitureBindingNavigator);
            this.Name = "RentalItemsFormDialog";
            this.Text = "RentalItemsFormDialog";
            ((System.ComponentModel.ISupportInitialize)(this.furnitureBindingNavigator)).EndInit();
            this.furnitureBindingNavigator.ResumeLayout(false);
            this.furnitureBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RentalItemDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.furnitureBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource furnitureBindingSource;
        private System.Windows.Forms.BindingNavigator furnitureBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton furnitureBindingNavigatorSaveItem;
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