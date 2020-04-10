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
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityBeingOrdered = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.furnitureBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SerialNumberTextBox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.CloseFurnitureButton = new System.Windows.Forms.Button();
            this.CategoryDescriptionComboBox = new System.Windows.Forms.ComboBox();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.StyleDescriptionComboBox = new System.Windows.Forms.ComboBox();
            this.styleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.FurnitureDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.furnitureBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.styleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchOptionsComboBox
            // 
            this.SearchOptionsComboBox.FormattingEnabled = true;
            this.SearchOptionsComboBox.Location = new System.Drawing.Point(156, 34);
            this.SearchOptionsComboBox.Name = "SearchOptionsComboBox";
            this.SearchOptionsComboBox.Size = new System.Drawing.Size(121, 21);
            this.SearchOptionsComboBox.TabIndex = 12;
            this.SearchOptionsComboBox.SelectedIndexChanged += new System.EventHandler(this.SearchOptionsComboBox_SelectedIndexChanged);
            // 
            // SerialNumberLabel
            // 
            this.SerialNumberLabel.AutoSize = true;
            this.SerialNumberLabel.Location = new System.Drawing.Point(338, 42);
            this.SerialNumberLabel.Name = "SerialNumberLabel";
            this.SerialNumberLabel.Size = new System.Drawing.Size(76, 13);
            this.SerialNumberLabel.TabIndex = 16;
            this.SerialNumberLabel.Text = "Serial Number:";
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Location = new System.Drawing.Point(362, 41);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(52, 13);
            this.CategoryLabel.TabIndex = 17;
            this.CategoryLabel.Text = "Category:";
            // 
            // StyleLabel
            // 
            this.StyleLabel.AutoSize = true;
            this.StyleLabel.Location = new System.Drawing.Point(381, 41);
            this.StyleLabel.Name = "StyleLabel";
            this.StyleLabel.Size = new System.Drawing.Size(33, 13);
            this.StyleLabel.TabIndex = 18;
            this.StyleLabel.Text = "Style:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
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
            this.dataGridViewTextBoxColumn2,
            this.QuantityBeingOrdered});
            this.FurnitureDataGridView.DataSource = this.furnitureBindingSource;
            this.FurnitureDataGridView.Location = new System.Drawing.Point(95, 95);
            this.FurnitureDataGridView.Name = "FurnitureDataGridView";
            this.FurnitureDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.FurnitureDataGridView.Size = new System.Drawing.Size(446, 220);
            this.FurnitureDataGridView.TabIndex = 20;
            this.FurnitureDataGridView.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.FurnitureDataGridView_CellValidating);
            this.FurnitureDataGridView.CurrentCellDirtyStateChanged += new System.EventHandler(this.FurnitureDataGridView_CurrentCellDirtyStateChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "SerialNumber";
            this.dataGridViewTextBoxColumn1.HeaderText = "SerialNumber";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ItemDescription";
            this.dataGridViewTextBoxColumn6.HeaderText = "ItemDescription";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "FurnitureStyle";
            this.dataGridViewTextBoxColumn3.HeaderText = "FurnitureStyle";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Quantity";
            this.dataGridViewTextBoxColumn2.HeaderText = "Quantity";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // QuantityBeingOrdered
            // 
            this.QuantityBeingOrdered.HeaderText = "Quantity Being Ordered";
            this.QuantityBeingOrdered.Name = "QuantityBeingOrdered";
            // 
            // furnitureBindingSource
            // 
            this.furnitureBindingSource.DataSource = typeof(FurnitureRentals.Model.Furniture);
            // 
            // SerialNumberTextBox
            // 
            this.SerialNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.furnitureBindingSource, "SerialNumber", true));
            this.SerialNumberTextBox.Location = new System.Drawing.Point(420, 35);
            this.SerialNumberTextBox.Name = "SerialNumberTextBox";
            this.SerialNumberTextBox.Size = new System.Drawing.Size(121, 20);
            this.SerialNumberTextBox.TabIndex = 23;
            this.SerialNumberTextBox.TextChanged += new System.EventHandler(this.SerialNumberTextBox_TextChanged);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(365, 333);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 24;
            this.AddButton.Text = "Add to Cart";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // CloseFurnitureButton
            // 
            this.CloseFurnitureButton.Location = new System.Drawing.Point(466, 333);
            this.CloseFurnitureButton.Name = "CloseFurnitureButton";
            this.CloseFurnitureButton.Size = new System.Drawing.Size(75, 23);
            this.CloseFurnitureButton.TabIndex = 25;
            this.CloseFurnitureButton.Text = "Close";
            this.CloseFurnitureButton.UseVisualStyleBackColor = true;
            this.CloseFurnitureButton.Click += new System.EventHandler(this.CloseFurnitureButton_Click);
            // 
            // CategoryDescriptionComboBox
            // 
            this.CategoryDescriptionComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.categoryBindingSource, "CategoryDescription", true));
            this.CategoryDescriptionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CategoryDescriptionComboBox.FormattingEnabled = true;
            this.CategoryDescriptionComboBox.Location = new System.Drawing.Point(420, 34);
            this.CategoryDescriptionComboBox.Name = "CategoryDescriptionComboBox";
            this.CategoryDescriptionComboBox.Size = new System.Drawing.Size(121, 21);
            this.CategoryDescriptionComboBox.TabIndex = 26;
            this.CategoryDescriptionComboBox.SelectionChangeCommitted += new System.EventHandler(this.CategoryDescriptionComboBox_SelectedIndexChanged);
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataSource = typeof(FurnitureRentals.Model.Category);
            // 
            // StyleDescriptionComboBox
            // 
            this.StyleDescriptionComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.styleBindingSource, "StyleDescription", true));
            this.StyleDescriptionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StyleDescriptionComboBox.FormattingEnabled = true;
            this.StyleDescriptionComboBox.Location = new System.Drawing.Point(420, 34);
            this.StyleDescriptionComboBox.Name = "StyleDescriptionComboBox";
            this.StyleDescriptionComboBox.Size = new System.Drawing.Size(121, 21);
            this.StyleDescriptionComboBox.TabIndex = 27;
            this.StyleDescriptionComboBox.SelectedIndexChanged += new System.EventHandler(this.StyleDescriptionComboBox_SelectedIndexChanged);
            // 
            // styleBindingSource
            // 
            this.styleBindingSource.DataSource = typeof(FurnitureRentals.Model.Style);
            // 
            // FurnitureSearchFormDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 392);
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
            this.Name = "FurnitureSearchFormDialog";
            this.Text = "FurnitureSearchForm";
            ((System.ComponentModel.ISupportInitialize)(this.FurnitureDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.furnitureBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.styleBindingSource)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityBeingOrdered;
    }
}