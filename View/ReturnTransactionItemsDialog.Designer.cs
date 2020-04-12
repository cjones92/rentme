namespace FurnitureRentals.View
{
    partial class ReturnTransactionItemsDialog
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
            this.dgReturnItems = new System.Windows.Forms.DataGridView();
            this.cs6232g1ViewReturnsDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.MemberIDLabel = new System.Windows.Forms.Label();
            this.lblMemberId = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.CustomerName = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.returnTransactionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rentalTransactionViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rentalIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemRentedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.styleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.returnedQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgReturnItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cs6232g1ViewReturnsDataSetBindingSource)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.returnTransactionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentalTransactionViewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgReturnItems
            // 
            this.dgReturnItems.AllowUserToAddRows = false;
            this.dgReturnItems.AllowUserToDeleteRows = false;
            this.dgReturnItems.AutoGenerateColumns = false;
            this.dgReturnItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgReturnItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rentalIDDataGridViewTextBoxColumn,
            this.itemRentedDataGridViewTextBoxColumn,
            this.styleDataGridViewTextBoxColumn,
            this.totalQuantityDataGridViewTextBoxColumn,
            this.returnedQuantityDataGridViewTextBoxColumn});
            this.dgReturnItems.DataSource = this.rentalTransactionViewBindingSource;
            this.dgReturnItems.Location = new System.Drawing.Point(12, 102);
            this.dgReturnItems.Name = "dgReturnItems";
            this.dgReturnItems.ReadOnly = true;
            this.dgReturnItems.RowHeadersWidth = 51;
            this.dgReturnItems.RowTemplate.Height = 24;
            this.dgReturnItems.Size = new System.Drawing.Size(742, 233);
            this.dgReturnItems.TabIndex = 0;
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 27);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(469, 49);
            this.tableLayoutPanel1.TabIndex = 18;
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
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Calibri", 10.2F);
            this.btnClose.Location = new System.Drawing.Point(645, 358);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(109, 32);
            this.btnClose.TabIndex = 19;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // returnTransactionBindingSource
            // 
            this.returnTransactionBindingSource.DataSource = typeof(FurnitureRentals.Model.ReturnTransaction);
            // 
            // rentalTransactionViewBindingSource
            // 
            this.rentalTransactionViewBindingSource.DataSource = typeof(FurnitureRentals.Model.ReturnItemView);
            // 
            // rentalIDDataGridViewTextBoxColumn
            // 
            this.rentalIDDataGridViewTextBoxColumn.DataPropertyName = "RentalID";
            this.rentalIDDataGridViewTextBoxColumn.HeaderText = "RentalID";
            this.rentalIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rentalIDDataGridViewTextBoxColumn.Name = "rentalIDDataGridViewTextBoxColumn";
            this.rentalIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.rentalIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // itemRentedDataGridViewTextBoxColumn
            // 
            this.itemRentedDataGridViewTextBoxColumn.DataPropertyName = "ItemRented";
            this.itemRentedDataGridViewTextBoxColumn.HeaderText = "ItemRented";
            this.itemRentedDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.itemRentedDataGridViewTextBoxColumn.Name = "itemRentedDataGridViewTextBoxColumn";
            this.itemRentedDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemRentedDataGridViewTextBoxColumn.Width = 125;
            // 
            // styleDataGridViewTextBoxColumn
            // 
            this.styleDataGridViewTextBoxColumn.DataPropertyName = "Style";
            this.styleDataGridViewTextBoxColumn.HeaderText = "Style";
            this.styleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.styleDataGridViewTextBoxColumn.Name = "styleDataGridViewTextBoxColumn";
            this.styleDataGridViewTextBoxColumn.ReadOnly = true;
            this.styleDataGridViewTextBoxColumn.Width = 125;
            // 
            // totalQuantityDataGridViewTextBoxColumn
            // 
            this.totalQuantityDataGridViewTextBoxColumn.DataPropertyName = "TotalQuantity";
            this.totalQuantityDataGridViewTextBoxColumn.HeaderText = "TotalQuantity";
            this.totalQuantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalQuantityDataGridViewTextBoxColumn.Name = "totalQuantityDataGridViewTextBoxColumn";
            this.totalQuantityDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalQuantityDataGridViewTextBoxColumn.Width = 125;
            // 
            // returnedQuantityDataGridViewTextBoxColumn
            // 
            this.returnedQuantityDataGridViewTextBoxColumn.DataPropertyName = "ReturnedQuantity";
            this.returnedQuantityDataGridViewTextBoxColumn.HeaderText = "ReturnedQuantity";
            this.returnedQuantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.returnedQuantityDataGridViewTextBoxColumn.Name = "returnedQuantityDataGridViewTextBoxColumn";
            this.returnedQuantityDataGridViewTextBoxColumn.ReadOnly = true;
            this.returnedQuantityDataGridViewTextBoxColumn.Width = 125;
            // 
            // ReturnTransactionItemsDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 399);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.dgReturnItems);
            this.Name = "ReturnTransactionItemsDialog";
            this.Text = "ReturnTransactionItemsDialog";
            ((System.ComponentModel.ISupportInitialize)(this.dgReturnItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cs6232g1ViewReturnsDataSetBindingSource)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.returnTransactionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentalTransactionViewBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgReturnItems;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label MemberIDLabel;
        private System.Windows.Forms.Label lblMemberId;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label CustomerName;
        private System.Windows.Forms.BindingSource returnTransactionBindingSource;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.BindingSource cs6232g1ViewReturnsDataSetBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentalIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemRentedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn styleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn returnedQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource rentalTransactionViewBindingSource;
    }
}