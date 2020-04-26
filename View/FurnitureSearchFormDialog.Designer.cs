namespace FurnitureRentals.View
{
    partial class FurnitureSearchFormDialog
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
            this.SearchOptionsComboBox = new System.Windows.Forms.ComboBox();
            this.SerialNumberLabel = new System.Windows.Forms.Label();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.StyleLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.FurnitureDataGridView = new System.Windows.Forms.DataGridView();
            this.DailyRentalRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityBeingOrdered = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SerialNumberTextBox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.CloseFurnitureButton = new System.Windows.Forms.Button();
            this.CategoryDescriptionComboBox = new System.Windows.Forms.ComboBox();
            this.StyleDescriptionComboBox = new System.Windows.Forms.ComboBox();
            this.styleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.furnitureBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.FurnitureDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.styleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.furnitureBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchOptionsComboBox
            // 
            this.SearchOptionsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SearchOptionsComboBox.Font = new System.Drawing.Font("Calibri", 10.2F);
            this.SearchOptionsComboBox.FormattingEnabled = true;
            this.SearchOptionsComboBox.Location = new System.Drawing.Point(201, 43);
            this.SearchOptionsComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SearchOptionsComboBox.Name = "SearchOptionsComboBox";
            this.SearchOptionsComboBox.Size = new System.Drawing.Size(203, 29);
            this.SearchOptionsComboBox.TabIndex = 12;
            this.SearchOptionsComboBox.SelectedIndexChanged += new System.EventHandler(this.SearchOptionsComboBox_SelectedIndexChanged);
            // 
            // SerialNumberLabel
            // 
            this.SerialNumberLabel.AutoSize = true;
            this.SerialNumberLabel.Font = new System.Drawing.Font("Calibri", 10.2F);
            this.SerialNumberLabel.Location = new System.Drawing.Point(445, 47);
            this.SerialNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SerialNumberLabel.Name = "SerialNumberLabel";
            this.SerialNumberLabel.Size = new System.Drawing.Size(114, 21);
            this.SerialNumberLabel.TabIndex = 16;
            this.SerialNumberLabel.Text = "Serial Number:";
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Font = new System.Drawing.Font("Calibri", 10.2F);
            this.CategoryLabel.Location = new System.Drawing.Point(482, 47);
            this.CategoryLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(77, 21);
            this.CategoryLabel.TabIndex = 17;
            this.CategoryLabel.Text = "Category:";
            // 
            // StyleLabel
            // 
            this.StyleLabel.AutoSize = true;
            this.StyleLabel.Font = new System.Drawing.Font("Calibri", 10.2F);
            this.StyleLabel.Location = new System.Drawing.Point(508, 47);
            this.StyleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StyleLabel.Name = "StyleLabel";
            this.StyleLabel.Size = new System.Drawing.Size(49, 21);
            this.StyleLabel.TabIndex = 18;
            this.StyleLabel.Text = "Style:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10.2F);
            this.label1.Location = new System.Drawing.Point(105, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 21);
            this.label1.TabIndex = 19;
            this.label1.Text = "Search by:";
            // 
            // FurnitureDataGridView
            // 
            this.FurnitureDataGridView.AutoGenerateColumns = false;
            this.FurnitureDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FurnitureDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn3,
            this.DailyRentalRate,
            this.dataGridViewTextBoxColumn2,
            this.QuantityBeingOrdered});
            this.FurnitureDataGridView.DataSource = this.furnitureBindingSource;
            this.FurnitureDataGridView.Location = new System.Drawing.Point(29, 116);
            this.FurnitureDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FurnitureDataGridView.Name = "FurnitureDataGridView";
            this.FurnitureDataGridView.RowHeadersWidth = 51;
            this.FurnitureDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.FurnitureDataGridView.Size = new System.Drawing.Size(845, 271);
            this.FurnitureDataGridView.TabIndex = 20;
            this.FurnitureDataGridView.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.FurnitureDataGridView_CellValidating);
            this.FurnitureDataGridView.CurrentCellDirtyStateChanged += new System.EventHandler(this.FurnitureDataGridView_CurrentCellDirtyStateChanged);
            // 
            // DailyRentalRate
            // 
            this.DailyRentalRate.DataPropertyName = "DailyRentalRate";
            this.DailyRentalRate.HeaderText = "Daily Rental Rate";
            this.DailyRentalRate.MinimumWidth = 6;
            this.DailyRentalRate.Name = "DailyRentalRate";
            this.DailyRentalRate.ReadOnly = true;
            this.DailyRentalRate.Width = 125;
            // 
            // QuantityBeingOrdered
            // 
            this.QuantityBeingOrdered.HeaderText = "Quantity Being Ordered";
            this.QuantityBeingOrdered.MinimumWidth = 6;
            this.QuantityBeingOrdered.Name = "QuantityBeingOrdered";
            this.QuantityBeingOrdered.Width = 125;
            // 
            // SerialNumberTextBox
            // 
            this.SerialNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.furnitureBindingSource, "SerialNumber", true));
            this.SerialNumberTextBox.Font = new System.Drawing.Font("Calibri", 10.2F);
            this.SerialNumberTextBox.Location = new System.Drawing.Point(576, 43);
            this.SerialNumberTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SerialNumberTextBox.Name = "SerialNumberTextBox";
            this.SerialNumberTextBox.Size = new System.Drawing.Size(181, 28);
            this.SerialNumberTextBox.TabIndex = 23;
            this.SerialNumberTextBox.TextChanged += new System.EventHandler(this.SerialNumberTextBox_TextChanged);
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Calibri", 10.2F);
            this.AddButton.Location = new System.Drawing.Point(748, 395);
            this.AddButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(126, 39);
            this.AddButton.TabIndex = 24;
            this.AddButton.Text = "Add to Cart";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // CloseFurnitureButton
            // 
            this.CloseFurnitureButton.Font = new System.Drawing.Font("Calibri", 10.2F);
            this.CloseFurnitureButton.Location = new System.Drawing.Point(748, 442);
            this.CloseFurnitureButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CloseFurnitureButton.Name = "CloseFurnitureButton";
            this.CloseFurnitureButton.Size = new System.Drawing.Size(126, 39);
            this.CloseFurnitureButton.TabIndex = 25;
            this.CloseFurnitureButton.Text = "Close";
            this.CloseFurnitureButton.UseVisualStyleBackColor = true;
            this.CloseFurnitureButton.Click += new System.EventHandler(this.CloseFurnitureButton_Click);
            // 
            // CategoryDescriptionComboBox
            // 
            this.CategoryDescriptionComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.categoryBindingSource, "CategoryDescription", true));
            this.CategoryDescriptionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CategoryDescriptionComboBox.Font = new System.Drawing.Font("Calibri", 10.2F);
            this.CategoryDescriptionComboBox.FormattingEnabled = true;
            this.CategoryDescriptionComboBox.Location = new System.Drawing.Point(575, 43);
            this.CategoryDescriptionComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CategoryDescriptionComboBox.Name = "CategoryDescriptionComboBox";
            this.CategoryDescriptionComboBox.Size = new System.Drawing.Size(181, 29);
            this.CategoryDescriptionComboBox.TabIndex = 26;
            this.CategoryDescriptionComboBox.SelectionChangeCommitted += new System.EventHandler(this.CategoryDescriptionComboBox_SelectedIndexChanged);
            // 
            // StyleDescriptionComboBox
            // 
            this.StyleDescriptionComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.styleBindingSource, "StyleDescription", true));
            this.StyleDescriptionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StyleDescriptionComboBox.Font = new System.Drawing.Font("Calibri", 10.2F);
            this.StyleDescriptionComboBox.FormattingEnabled = true;
            this.StyleDescriptionComboBox.Location = new System.Drawing.Point(575, 42);
            this.StyleDescriptionComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.StyleDescriptionComboBox.Name = "StyleDescriptionComboBox";
            this.StyleDescriptionComboBox.Size = new System.Drawing.Size(181, 29);
            this.StyleDescriptionComboBox.TabIndex = 27;
            this.StyleDescriptionComboBox.SelectedIndexChanged += new System.EventHandler(this.StyleDescriptionComboBox_SelectedIndexChanged);
            // 
            // styleBindingSource
            // 
            this.styleBindingSource.DataSource = typeof(FurnitureRentals.Model.Style);
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataSource = typeof(FurnitureRentals.Model.Category);
            // 
            // furnitureBindingSource
            // 
            this.furnitureBindingSource.DataSource = typeof(FurnitureRentals.Model.Furniture);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "SerialNumber";
            this.dataGridViewTextBoxColumn1.HeaderText = "Serial Number";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ItemDescription";
            this.dataGridViewTextBoxColumn6.HeaderText = "Item Description";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "FurnitureStyle";
            this.dataGridViewTextBoxColumn3.HeaderText = "Furniture Style";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Quantity";
            this.dataGridViewTextBoxColumn2.HeaderText = "Quantity";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // FurnitureSearchFormDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 494);
            this.Controls.Add(this.StyleDescriptionComboBox);
            this.Controls.Add(this.CategoryDescriptionComboBox);
            this.Controls.Add(this.CloseFurnitureButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.SerialNumberTextBox);
            this.Controls.Add(this.FurnitureDataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StyleLabel);
            this.Controls.Add(this.CategoryLabel);
            this.Controls.Add(this.SerialNumberLabel);
            this.Controls.Add(this.SearchOptionsComboBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FurnitureSearchFormDialog";
            this.Text = "FurnitureSearchForm";
            ((System.ComponentModel.ISupportInitialize)(this.FurnitureDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.styleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
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
        private System.Windows.Forms.DataGridView FurnitureDataGridView;
        private System.Windows.Forms.TextBox SerialNumberTextBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button CloseFurnitureButton;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private System.Windows.Forms.ComboBox CategoryDescriptionComboBox;
        private System.Windows.Forms.BindingSource styleBindingSource;
        private System.Windows.Forms.ComboBox StyleDescriptionComboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn DailyRentalRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityBeingOrdered;
    }
}