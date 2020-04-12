namespace FurnitureRentals.User_Controls
{
    partial class ViewReturnTransactionsUserControl
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
            this.lblMemberId = new System.Windows.Forms.Label();
            this.MemberIDLabel = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.dgvViewReturns = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.CustomerName = new System.Windows.Forms.Label();
            this.returnIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.returnDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentalIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemRentedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.styleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.returnedQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lateFeeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.refundDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.returnTransactionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewReturns)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.returnTransactionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMemberId
            // 
            this.lblMemberId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblMemberId.AutoSize = true;
            this.lblMemberId.Font = new System.Drawing.Font("Calibri", 10.2F);
            this.lblMemberId.Location = new System.Drawing.Point(159, 26);
            this.lblMemberId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMemberId.Name = "lblMemberId";
            this.lblMemberId.Size = new System.Drawing.Size(52, 21);
            this.lblMemberId.TabIndex = 15;
            this.lblMemberId.Text = "label2";
            // 
            // MemberIDLabel
            // 
            this.MemberIDLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.MemberIDLabel.AutoSize = true;
            this.MemberIDLabel.Font = new System.Drawing.Font("Calibri", 10.2F);
            this.MemberIDLabel.Location = new System.Drawing.Point(50, 26);
            this.MemberIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MemberIDLabel.Name = "MemberIDLabel";
            this.MemberIDLabel.Size = new System.Drawing.Size(101, 21);
            this.MemberIDLabel.TabIndex = 14;
            this.MemberIDLabel.Text = "Member ID : ";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Calibri", 10.2F);
            this.lblCustomerName.Location = new System.Drawing.Point(159, 1);
            this.lblCustomerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(52, 21);
            this.lblCustomerName.TabIndex = 13;
            this.lblCustomerName.Text = "label1";
            // 
            // dgvViewReturns
            // 
            this.dgvViewReturns.AllowUserToAddRows = false;
            this.dgvViewReturns.AllowUserToDeleteRows = false;
            this.dgvViewReturns.AutoGenerateColumns = false;
            this.dgvViewReturns.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewReturns.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.returnIDDataGridViewTextBoxColumn,
            this.returnDateDataGridViewTextBoxColumn,
            this.rentalIDDataGridViewTextBoxColumn,
            this.itemRentedDataGridViewTextBoxColumn,
            this.styleDataGridViewTextBoxColumn,
            this.totalQuantityDataGridViewTextBoxColumn,
            this.returnedQuantityDataGridViewTextBoxColumn,
            this.lateFeeDataGridViewTextBoxColumn,
            this.refundDataGridViewTextBoxColumn});
            this.dgvViewReturns.DataSource = this.returnTransactionBindingSource;
            this.dgvViewReturns.Location = new System.Drawing.Point(29, 113);
            this.dgvViewReturns.Name = "dgvViewReturns";
            this.dgvViewReturns.ReadOnly = true;
            this.dgvViewReturns.RowHeadersWidth = 51;
            this.dgvViewReturns.RowTemplate.Height = 24;
            this.dgvViewReturns.Size = new System.Drawing.Size(994, 338);
            this.dgvViewReturns.TabIndex = 16;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.04904F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.95096F));
            this.tableLayoutPanel1.Controls.Add(this.MemberIDLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblMemberId, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblCustomerName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.CustomerName, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(29, 19);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(469, 49);
            this.tableLayoutPanel1.TabIndex = 17;
            // 
            // CustomerName
            // 
            this.CustomerName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.CustomerName.AutoSize = true;
            this.CustomerName.Font = new System.Drawing.Font("Calibri", 10.2F);
            this.CustomerName.Location = new System.Drawing.Point(19, 1);
            this.CustomerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.Size = new System.Drawing.Size(132, 21);
            this.CustomerName.TabIndex = 18;
            this.CustomerName.Text = "Customer Name :";
            // 
            // returnIDDataGridViewTextBoxColumn
            // 
            this.returnIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.returnIDDataGridViewTextBoxColumn.DataPropertyName = "ReturnID";
            this.returnIDDataGridViewTextBoxColumn.HeaderText = "Return ID";
            this.returnIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.returnIDDataGridViewTextBoxColumn.Name = "returnIDDataGridViewTextBoxColumn";
            this.returnIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.returnIDDataGridViewTextBoxColumn.Width = 97;
            // 
            // returnDateDataGridViewTextBoxColumn
            // 
            this.returnDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.returnDateDataGridViewTextBoxColumn.DataPropertyName = "ReturnDate";
            this.returnDateDataGridViewTextBoxColumn.HeaderText = "Return Date";
            this.returnDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.returnDateDataGridViewTextBoxColumn.Name = "returnDateDataGridViewTextBoxColumn";
            this.returnDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.returnDateDataGridViewTextBoxColumn.Width = 114;
            // 
            // rentalIDDataGridViewTextBoxColumn
            // 
            this.rentalIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.rentalIDDataGridViewTextBoxColumn.DataPropertyName = "RentalID";
            this.rentalIDDataGridViewTextBoxColumn.HeaderText = "Rental ID";
            this.rentalIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rentalIDDataGridViewTextBoxColumn.Name = "rentalIDDataGridViewTextBoxColumn";
            this.rentalIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.rentalIDDataGridViewTextBoxColumn.Width = 95;
            // 
            // itemRentedDataGridViewTextBoxColumn
            // 
            this.itemRentedDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.itemRentedDataGridViewTextBoxColumn.DataPropertyName = "ItemRented";
            this.itemRentedDataGridViewTextBoxColumn.HeaderText = "Item Rented";
            this.itemRentedDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.itemRentedDataGridViewTextBoxColumn.Name = "itemRentedDataGridViewTextBoxColumn";
            this.itemRentedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // styleDataGridViewTextBoxColumn
            // 
            this.styleDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.styleDataGridViewTextBoxColumn.DataPropertyName = "Style";
            this.styleDataGridViewTextBoxColumn.HeaderText = "Style";
            this.styleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.styleDataGridViewTextBoxColumn.Name = "styleDataGridViewTextBoxColumn";
            this.styleDataGridViewTextBoxColumn.ReadOnly = true;
            this.styleDataGridViewTextBoxColumn.Width = 68;
            // 
            // totalQuantityDataGridViewTextBoxColumn
            // 
            this.totalQuantityDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.totalQuantityDataGridViewTextBoxColumn.DataPropertyName = "TotalQuantity";
            this.totalQuantityDataGridViewTextBoxColumn.HeaderText = "Qty(Total)";
            this.totalQuantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalQuantityDataGridViewTextBoxColumn.Name = "totalQuantityDataGridViewTextBoxColumn";
            this.totalQuantityDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalQuantityDataGridViewTextBoxColumn.Width = 101;
            // 
            // returnedQuantityDataGridViewTextBoxColumn
            // 
            this.returnedQuantityDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.returnedQuantityDataGridViewTextBoxColumn.DataPropertyName = "ReturnedQuantity";
            this.returnedQuantityDataGridViewTextBoxColumn.HeaderText = "Qty(Returned)";
            this.returnedQuantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.returnedQuantityDataGridViewTextBoxColumn.Name = "returnedQuantityDataGridViewTextBoxColumn";
            this.returnedQuantityDataGridViewTextBoxColumn.ReadOnly = true;
            this.returnedQuantityDataGridViewTextBoxColumn.Width = 128;
            // 
            // lateFeeDataGridViewTextBoxColumn
            // 
            this.lateFeeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.lateFeeDataGridViewTextBoxColumn.DataPropertyName = "LateFee";
            this.lateFeeDataGridViewTextBoxColumn.HeaderText = "LateFee($)";
            this.lateFeeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lateFeeDataGridViewTextBoxColumn.Name = "lateFeeDataGridViewTextBoxColumn";
            this.lateFeeDataGridViewTextBoxColumn.ReadOnly = true;
            this.lateFeeDataGridViewTextBoxColumn.Width = 107;
            // 
            // refundDataGridViewTextBoxColumn
            // 
            this.refundDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.refundDataGridViewTextBoxColumn.DataPropertyName = "Refund";
            this.refundDataGridViewTextBoxColumn.HeaderText = "Refund($)";
            this.refundDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.refundDataGridViewTextBoxColumn.Name = "refundDataGridViewTextBoxColumn";
            this.refundDataGridViewTextBoxColumn.ReadOnly = true;
            this.refundDataGridViewTextBoxColumn.Width = 101;
            // 
            // returnTransactionBindingSource
            // 
            this.returnTransactionBindingSource.DataSource = typeof(FurnitureRentals.Model.ReturnTransactionView);
            // 
            // ViewReturnTransactionsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.dgvViewReturns);
            this.Name = "ViewReturnTransactionsUserControl";
            this.Size = new System.Drawing.Size(1044, 465);
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewReturns)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.returnTransactionBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblMemberId;
        private System.Windows.Forms.Label MemberIDLabel;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.DataGridView dgvViewReturns;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label CustomerName;
        private System.Windows.Forms.BindingSource returnTransactionBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn returnIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn returnDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentalIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemRentedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn styleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn returnedQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lateFeeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn refundDataGridViewTextBoxColumn;
    }
}
