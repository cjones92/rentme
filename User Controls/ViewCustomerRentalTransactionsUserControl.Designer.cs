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
            ((System.ComponentModel.ISupportInitialize)(this.RentalTransactionDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentalTransactionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // CustomerName
            // 
            this.CustomerName.AutoSize = true;
            this.CustomerName.Font = new System.Drawing.Font("Calibri", 10.2F);
            this.CustomerName.Location = new System.Drawing.Point(25, 21);
            this.CustomerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.Size = new System.Drawing.Size(128, 21);
            this.CustomerName.TabIndex = 7;
            this.CustomerName.Text = "Customer Name:";
            // 
            // ActualNameLabel
            // 
            this.ActualNameLabel.AutoSize = true;
            this.ActualNameLabel.Font = new System.Drawing.Font("Calibri", 10.2F);
            this.ActualNameLabel.Location = new System.Drawing.Point(163, 21);
            this.ActualNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ActualNameLabel.Name = "ActualNameLabel";
            this.ActualNameLabel.Size = new System.Drawing.Size(52, 21);
            this.ActualNameLabel.TabIndex = 9;
            this.ActualNameLabel.Text = "label1";
            // 
            // MemberIDLabel
            // 
            this.MemberIDLabel.AutoSize = true;
            this.MemberIDLabel.Font = new System.Drawing.Font("Calibri", 10.2F);
            this.MemberIDLabel.Location = new System.Drawing.Point(58, 50);
            this.MemberIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MemberIDLabel.Name = "MemberIDLabel";
            this.MemberIDLabel.Size = new System.Drawing.Size(97, 21);
            this.MemberIDLabel.TabIndex = 10;
            this.MemberIDLabel.Text = "Member ID: ";
            // 
            // ActualIDLabel
            // 
            this.ActualIDLabel.AutoSize = true;
            this.ActualIDLabel.Font = new System.Drawing.Font("Calibri", 10.2F);
            this.ActualIDLabel.Location = new System.Drawing.Point(163, 50);
            this.ActualIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ActualIDLabel.Name = "ActualIDLabel";
            this.ActualIDLabel.Size = new System.Drawing.Size(52, 21);
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
            this.RentalTransactionDataGridView.Location = new System.Drawing.Point(29, 122);
            this.RentalTransactionDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RentalTransactionDataGridView.Name = "RentalTransactionDataGridView";
            this.RentalTransactionDataGridView.RowHeadersWidth = 51;
            this.RentalTransactionDataGridView.Size = new System.Drawing.Size(842, 271);
            this.RentalTransactionDataGridView.TabIndex = 11;
            this.RentalTransactionDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RentalTransactionDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "RentalID";
            this.dataGridViewTextBoxColumn1.HeaderText = "RentalID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "RentalDate";
            this.dataGridViewTextBoxColumn3.HeaderText = "RentalDate";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DueDate";
            this.dataGridViewTextBoxColumn4.HeaderText = "DueDate";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "TotalDue";
            this.dataGridViewTextBoxColumn5.HeaderText = "TotalDue";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "CurrentAmountDue";
            this.dataGridViewTextBoxColumn7.HeaderText = "CurrentAmountDue";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Status";
            this.dataGridViewTextBoxColumn8.HeaderText = "Status";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // rentalTransactionBindingSource
            // 
            this.rentalTransactionBindingSource.DataSource = typeof(FurnitureRentals.Model.RentalTransaction);
            // 
            // ViewCustomerRentalTransactionsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RentalTransactionDataGridView);
            this.Controls.Add(this.ActualIDLabel);
            this.Controls.Add(this.MemberIDLabel);
            this.Controls.Add(this.ActualNameLabel);
            this.Controls.Add(this.CustomerName);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ViewCustomerRentalTransactionsUserControl";
            this.Size = new System.Drawing.Size(1044, 577);
            ((System.ComponentModel.ISupportInitialize)(this.RentalTransactionDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentalTransactionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource rentalTransactionBindingSource;
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
