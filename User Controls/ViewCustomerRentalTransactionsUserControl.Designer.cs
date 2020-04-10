namespace FurnitureRentals.User_Controls
{
    partial class ViewCustomerRentalTransactionsUserControl
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewCustomerRentalTransactionsUserControl));
            this.rentalTransactionBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.rentalTransactionBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.CustomerName = new System.Windows.Forms.Label();
            this.ActualNameLabel = new System.Windows.Forms.Label();
            this.MemberIDLabel = new System.Windows.Forms.Label();
            this.ActualIDLabel = new System.Windows.Forms.Label();
            this.RentalTransactionDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentalTransactionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.rentalTransactionBindingNavigator)).BeginInit();
            this.rentalTransactionBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RentalTransactionDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentalTransactionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rentalTransactionBindingNavigator
            // 
            this.rentalTransactionBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.rentalTransactionBindingNavigator.BindingSource = this.rentalTransactionBindingSource;
            this.rentalTransactionBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.rentalTransactionBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.rentalTransactionBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.rentalTransactionBindingNavigatorSaveItem});
            this.rentalTransactionBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.rentalTransactionBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.rentalTransactionBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.rentalTransactionBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.rentalTransactionBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.rentalTransactionBindingNavigator.Name = "rentalTransactionBindingNavigator";
            this.rentalTransactionBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.rentalTransactionBindingNavigator.Size = new System.Drawing.Size(711, 25);
            this.rentalTransactionBindingNavigator.TabIndex = 0;
            this.rentalTransactionBindingNavigator.Text = "bindingNavigator1";
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
            // rentalTransactionBindingNavigatorSaveItem
            // 
            this.rentalTransactionBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.rentalTransactionBindingNavigatorSaveItem.Enabled = false;
            this.rentalTransactionBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("rentalTransactionBindingNavigatorSaveItem.Image")));
            this.rentalTransactionBindingNavigatorSaveItem.Name = "rentalTransactionBindingNavigatorSaveItem";
            this.rentalTransactionBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.rentalTransactionBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // CustomerName
            // 
            this.CustomerName.AutoSize = true;
            this.CustomerName.Location = new System.Drawing.Point(19, 43);
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.Size = new System.Drawing.Size(85, 13);
            this.CustomerName.TabIndex = 7;
            this.CustomerName.Text = "Customer Name:";
            // 
            // ActualNameLabel
            // 
            this.ActualNameLabel.AutoSize = true;
            this.ActualNameLabel.Location = new System.Drawing.Point(110, 43);
            this.ActualNameLabel.Name = "ActualNameLabel";
            this.ActualNameLabel.Size = new System.Drawing.Size(35, 13);
            this.ActualNameLabel.TabIndex = 9;
            this.ActualNameLabel.Text = "label1";
            // 
            // MemberIDLabel
            // 
            this.MemberIDLabel.AutoSize = true;
            this.MemberIDLabel.Location = new System.Drawing.Point(39, 67);
            this.MemberIDLabel.Name = "MemberIDLabel";
            this.MemberIDLabel.Size = new System.Drawing.Size(65, 13);
            this.MemberIDLabel.TabIndex = 10;
            this.MemberIDLabel.Text = "Member ID: ";
            // 
            // ActualIDLabel
            // 
            this.ActualIDLabel.AutoSize = true;
            this.ActualIDLabel.Location = new System.Drawing.Point(110, 67);
            this.ActualIDLabel.Name = "ActualIDLabel";
            this.ActualIDLabel.Size = new System.Drawing.Size(35, 13);
            this.ActualIDLabel.TabIndex = 11;
            this.ActualIDLabel.Text = "label2";
            // 
            // RentalTransactionDataGridView
            // 
            this.RentalTransactionDataGridView.AutoGenerateColumns = false;
            this.RentalTransactionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RentalTransactionDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.RentalTransactionDataGridView.DataSource = this.rentalTransactionBindingSource;
            this.RentalTransactionDataGridView.Location = new System.Drawing.Point(41, 136);
            this.RentalTransactionDataGridView.Name = "RentalTransactionDataGridView";
            this.RentalTransactionDataGridView.Size = new System.Drawing.Size(644, 220);
            this.RentalTransactionDataGridView.TabIndex = 11;
            this.RentalTransactionDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RentalTransactionDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "RentalID";
            this.dataGridViewTextBoxColumn1.HeaderText = "RentalID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "RentalDate";
            this.dataGridViewTextBoxColumn3.HeaderText = "RentalDate";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DueDate";
            this.dataGridViewTextBoxColumn4.HeaderText = "DueDate";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "TotalDue";
            this.dataGridViewTextBoxColumn5.HeaderText = "TotalDue";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "CurrentAmountDue";
            this.dataGridViewTextBoxColumn7.HeaderText = "CurrentAmountDue";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Status";
            this.dataGridViewTextBoxColumn8.HeaderText = "Status";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // rentalTransactionBindingSource
            // 
            this.rentalTransactionBindingSource.DataSource = typeof(FurnitureRentals.Model.RentalTransaction);
            // 
            // ViewCustomerRentalTransactionsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RentalTransactionDataGridView);
            this.Controls.Add(this.ActualIDLabel);
            this.Controls.Add(this.MemberIDLabel);
            this.Controls.Add(this.ActualNameLabel);
            this.Controls.Add(this.CustomerName);
            this.Controls.Add(this.rentalTransactionBindingNavigator);
            this.Name = "ViewCustomerRentalTransactionsUserControl";
            this.Size = new System.Drawing.Size(711, 376);
            ((System.ComponentModel.ISupportInitialize)(this.rentalTransactionBindingNavigator)).EndInit();
            this.rentalTransactionBindingNavigator.ResumeLayout(false);
            this.rentalTransactionBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RentalTransactionDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentalTransactionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource rentalTransactionBindingSource;
        private System.Windows.Forms.BindingNavigator rentalTransactionBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton rentalTransactionBindingNavigatorSaveItem;
        private System.Windows.Forms.Label CustomerName;
        private System.Windows.Forms.Label ActualNameLabel;
        private System.Windows.Forms.Label MemberIDLabel;
        private System.Windows.Forms.Label ActualIDLabel;
        private System.Windows.Forms.DataGridView RentalTransactionDataGridView;
        private System.Windows.Forms.DataGridViewLinkColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}
