namespace FurnitureRentals.View
{
    partial class FurnitureSearchForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FurnitureSearchForm));
            this.SearchOptionsComboBox = new System.Windows.Forms.ComboBox();
            this.SerialNumberLabel = new System.Windows.Forms.Label();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.StyleLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.furnitureBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.furnitureBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.FurnitureDataGridView = new System.Windows.Forms.DataGridView();
            this.furnitureStyleComboBox = new System.Windows.Forms.ComboBox();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.SerialNumberTextBox = new System.Windows.Forms.TextBox();
            this.furnitureBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.furnitureBindingNavigator)).BeginInit();
            this.furnitureBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FurnitureDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.furnitureBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchOptionsComboBox
            // 
            this.SearchOptionsComboBox.FormattingEnabled = true;
            this.SearchOptionsComboBox.Location = new System.Drawing.Point(173, 67);
            this.SearchOptionsComboBox.Name = "SearchOptionsComboBox";
            this.SearchOptionsComboBox.Size = new System.Drawing.Size(121, 21);
            this.SearchOptionsComboBox.TabIndex = 12;
            this.SearchOptionsComboBox.SelectedIndexChanged += new System.EventHandler(this.SearchOptionsComboBox_SelectedIndexChanged);
            // 
            // SerialNumberLabel
            // 
            this.SerialNumberLabel.AutoSize = true;
            this.SerialNumberLabel.Location = new System.Drawing.Point(406, 70);
            this.SerialNumberLabel.Name = "SerialNumberLabel";
            this.SerialNumberLabel.Size = new System.Drawing.Size(73, 13);
            this.SerialNumberLabel.TabIndex = 16;
            this.SerialNumberLabel.Text = "Serial Number";
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Location = new System.Drawing.Point(406, 71);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(49, 13);
            this.CategoryLabel.TabIndex = 17;
            this.CategoryLabel.Text = "Category";
            // 
            // StyleLabel
            // 
            this.StyleLabel.AutoSize = true;
            this.StyleLabel.Location = new System.Drawing.Point(406, 71);
            this.StyleLabel.Name = "StyleLabel";
            this.StyleLabel.Size = new System.Drawing.Size(30, 13);
            this.StyleLabel.TabIndex = 18;
            this.StyleLabel.Text = "Style";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Search Option";
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
            this.furnitureBindingNavigator.Size = new System.Drawing.Size(845, 25);
            this.furnitureBindingNavigator.TabIndex = 20;
            this.furnitureBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
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
            // FurnitureDataGridView
            // 
            this.FurnitureDataGridView.AutoGenerateColumns = false;
            this.FurnitureDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FurnitureDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn2});
            this.FurnitureDataGridView.DataSource = this.furnitureBindingSource;
            this.FurnitureDataGridView.Location = new System.Drawing.Point(79, 153);
            this.FurnitureDataGridView.Name = "FurnitureDataGridView";
            this.FurnitureDataGridView.Size = new System.Drawing.Size(446, 220);
            this.FurnitureDataGridView.TabIndex = 20;
            // 
            // furnitureStyleComboBox
            // 
            this.furnitureStyleComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.furnitureBindingSource, "FurnitureStyle", true));
            this.furnitureStyleComboBox.FormattingEnabled = true;
            this.furnitureStyleComboBox.Location = new System.Drawing.Point(586, 71);
            this.furnitureStyleComboBox.Name = "furnitureStyleComboBox";
            this.furnitureStyleComboBox.Size = new System.Drawing.Size(121, 21);
            this.furnitureStyleComboBox.TabIndex = 21;
            this.furnitureStyleComboBox.SelectedIndexChanged += new System.EventHandler(this.furnitureStyleComboBox_SelectedIndexChanged);
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.furnitureBindingSource, "Category", true));
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(586, 72);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(121, 21);
            this.categoryComboBox.TabIndex = 22;
            this.categoryComboBox.SelectedIndexChanged += new System.EventHandler(this.categoryComboBox_SelectedIndexChanged);
            // 
            // SerialNumberTextBox
            // 
            this.SerialNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.furnitureBindingSource, "SerialNumber", true));
            this.SerialNumberTextBox.Location = new System.Drawing.Point(607, 72);
            this.SerialNumberTextBox.Name = "SerialNumberTextBox";
            this.SerialNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.SerialNumberTextBox.TabIndex = 23;
            this.SerialNumberTextBox.TextChanged += new System.EventHandler(this.SerialNumberTextBox_TextChanged);
            // 
            // furnitureBindingSource
            // 
            this.furnitureBindingSource.DataSource = typeof(FurnitureRentals.Model.Furniture);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "SerialNumber";
            this.dataGridViewTextBoxColumn1.HeaderText = "SerialNumber";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ItemDescription";
            this.dataGridViewTextBoxColumn6.HeaderText = "ItemDescription";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "FurnitureStyle";
            this.dataGridViewTextBoxColumn3.HeaderText = "FurnitureStyle";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Quantity";
            this.dataGridViewTextBoxColumn2.HeaderText = "Quantity";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // FurnitureSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 471);
            this.Controls.Add(this.SerialNumberTextBox);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.furnitureStyleComboBox);
            this.Controls.Add(this.FurnitureDataGridView);
            this.Controls.Add(this.furnitureBindingNavigator);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StyleLabel);
            this.Controls.Add(this.CategoryLabel);
            this.Controls.Add(this.SerialNumberLabel);
            this.Controls.Add(this.SearchOptionsComboBox);
            this.Name = "FurnitureSearchForm";
            this.Text = "FurnitureSearchForm";
            ((System.ComponentModel.ISupportInitialize)(this.furnitureBindingNavigator)).EndInit();
            this.furnitureBindingNavigator.ResumeLayout(false);
            this.furnitureBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FurnitureDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.furnitureBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox SearchOptionsComboBox;
        private System.Windows.Forms.Label SerialNumberLabel;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.Label StyleLabel;
        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.DataGridView FurnitureDataGridView;
        private System.Windows.Forms.ComboBox furnitureStyleComboBox;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.TextBox SerialNumberTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}