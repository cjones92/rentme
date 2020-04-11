namespace FurnitureRentals.User_Controls
{
    partial class ReturnShoppingCartUserControl
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.MemberIDLabel = new System.Windows.Forms.Label();
            this.lblMemberId = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.CustomerName = new System.Windows.Forms.Label();
            this.dgvCartReturn = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.TotalLateFee = new System.Windows.Forms.Label();
            this.TotalRefund = new System.Windows.Forms.Label();
            this.txtLateFee = new System.Windows.Forms.TextBox();
            this.txtRefundTotal = new System.Windows.Forms.TextBox();
            this.rentalIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serialNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemRentedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.styleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.returnQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lateFeeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.refundDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.returnItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCartReturn)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.returnItemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.83582F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.16418F));
            this.tableLayoutPanel1.Controls.Add(this.MemberIDLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblMemberId, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblCustomerName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.CustomerName, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(25, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(469, 49);
            this.tableLayoutPanel1.TabIndex = 19;
            // 
            // MemberIDLabel
            // 
            this.MemberIDLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.MemberIDLabel.AutoSize = true;
            this.MemberIDLabel.Font = new System.Drawing.Font("Calibri", 10.2F);
            this.MemberIDLabel.Location = new System.Drawing.Point(48, 26);
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
            this.lblMemberId.Location = new System.Drawing.Point(157, 26);
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
            this.lblCustomerName.Location = new System.Drawing.Point(157, 1);
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
            this.CustomerName.Location = new System.Drawing.Point(17, 1);
            this.CustomerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.Size = new System.Drawing.Size(132, 21);
            this.CustomerName.TabIndex = 18;
            this.CustomerName.Text = "Customer Name :";
            // 
            // dgvCartReturn
            // 
            this.dgvCartReturn.AllowUserToAddRows = false;
            this.dgvCartReturn.AllowUserToDeleteRows = false;
            this.dgvCartReturn.AutoGenerateColumns = false;
            this.dgvCartReturn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCartReturn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rentalIDDataGridViewTextBoxColumn,
            this.serialNoDataGridViewTextBoxColumn,
            this.itemRentedDataGridViewTextBoxColumn,
            this.styleDataGridViewTextBoxColumn,
            this.returnQuantityDataGridViewTextBoxColumn,
            this.lateFeeDataGridViewTextBoxColumn,
            this.refundDataGridViewTextBoxColumn});
            this.dgvCartReturn.DataSource = this.returnItemBindingSource;
            this.dgvCartReturn.Location = new System.Drawing.Point(25, 110);
            this.dgvCartReturn.Name = "dgvCartReturn";
            this.dgvCartReturn.ReadOnly = true;
            this.dgvCartReturn.RowHeadersWidth = 51;
            this.dgvCartReturn.RowTemplate.Height = 24;
            this.dgvCartReturn.Size = new System.Drawing.Size(994, 366);
            this.dgvCartReturn.TabIndex = 18;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.txtRefundTotal, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.TotalLateFee, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.TotalRefund, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtLateFee, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(667, 482);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(352, 70);
            this.tableLayoutPanel2.TabIndex = 20;
            // 
            // TotalLateFee
            // 
            this.TotalLateFee.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.TotalLateFee.AutoSize = true;
            this.TotalLateFee.Font = new System.Drawing.Font("Calibri", 10.2F);
            this.TotalLateFee.Location = new System.Drawing.Point(33, 7);
            this.TotalLateFee.Name = "TotalLateFee";
            this.TotalLateFee.Size = new System.Drawing.Size(140, 21);
            this.TotalLateFee.TabIndex = 0;
            this.TotalLateFee.Text = "Total Late Fee ($) : ";
            // 
            // TotalRefund
            // 
            this.TotalRefund.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.TotalRefund.AutoSize = true;
            this.TotalRefund.Font = new System.Drawing.Font("Calibri", 10.2F);
            this.TotalRefund.Location = new System.Drawing.Point(41, 42);
            this.TotalRefund.Name = "TotalRefund";
            this.TotalRefund.Size = new System.Drawing.Size(132, 21);
            this.TotalRefund.TabIndex = 1;
            this.TotalRefund.Text = "Total Refund ($) : ";
            // 
            // txtLateFee
            // 
            this.txtLateFee.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtLateFee.Font = new System.Drawing.Font("Calibri", 10.2F);
            this.txtLateFee.Location = new System.Drawing.Point(186, 3);
            this.txtLateFee.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.txtLateFee.Name = "txtLateFee";
            this.txtLateFee.Size = new System.Drawing.Size(163, 28);
            this.txtLateFee.TabIndex = 2;
            // 
            // txtRefundTotal
            // 
            this.txtRefundTotal.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtRefundTotal.Font = new System.Drawing.Font("Calibri", 10.2F);
            this.txtRefundTotal.Location = new System.Drawing.Point(186, 38);
            this.txtRefundTotal.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.txtRefundTotal.Name = "txtRefundTotal";
            this.txtRefundTotal.Size = new System.Drawing.Size(163, 28);
            this.txtRefundTotal.TabIndex = 3;
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
            // serialNoDataGridViewTextBoxColumn
            // 
            this.serialNoDataGridViewTextBoxColumn.DataPropertyName = "SerialNo";
            this.serialNoDataGridViewTextBoxColumn.HeaderText = "SerialNo";
            this.serialNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.serialNoDataGridViewTextBoxColumn.Name = "serialNoDataGridViewTextBoxColumn";
            this.serialNoDataGridViewTextBoxColumn.ReadOnly = true;
            this.serialNoDataGridViewTextBoxColumn.Width = 125;
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
            // returnQuantityDataGridViewTextBoxColumn
            // 
            this.returnQuantityDataGridViewTextBoxColumn.DataPropertyName = "ReturnQuantity";
            this.returnQuantityDataGridViewTextBoxColumn.HeaderText = "ReturnQuantity";
            this.returnQuantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.returnQuantityDataGridViewTextBoxColumn.Name = "returnQuantityDataGridViewTextBoxColumn";
            this.returnQuantityDataGridViewTextBoxColumn.ReadOnly = true;
            this.returnQuantityDataGridViewTextBoxColumn.Width = 125;
            // 
            // lateFeeDataGridViewTextBoxColumn
            // 
            this.lateFeeDataGridViewTextBoxColumn.DataPropertyName = "LateFee";
            this.lateFeeDataGridViewTextBoxColumn.HeaderText = "LateFee";
            this.lateFeeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lateFeeDataGridViewTextBoxColumn.Name = "lateFeeDataGridViewTextBoxColumn";
            this.lateFeeDataGridViewTextBoxColumn.ReadOnly = true;
            this.lateFeeDataGridViewTextBoxColumn.Width = 125;
            // 
            // refundDataGridViewTextBoxColumn
            // 
            this.refundDataGridViewTextBoxColumn.DataPropertyName = "Refund";
            this.refundDataGridViewTextBoxColumn.HeaderText = "Refund";
            this.refundDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.refundDataGridViewTextBoxColumn.Name = "refundDataGridViewTextBoxColumn";
            this.refundDataGridViewTextBoxColumn.ReadOnly = true;
            this.refundDataGridViewTextBoxColumn.Width = 125;
            // 
            // returnItemBindingSource
            // 
            this.returnItemBindingSource.DataSource = typeof(FurnitureRentals.Model.ReturnCart);
            // 
            // ReturnShoppingCartUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.dgvCartReturn);
            this.Name = "ReturnShoppingCartUserControl";
            this.Size = new System.Drawing.Size(1044, 577);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCartReturn)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.returnItemBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label MemberIDLabel;
        private System.Windows.Forms.Label lblMemberId;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label CustomerName;
        private System.Windows.Forms.DataGridView dgvCartReturn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentalIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemRentedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn styleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn returnQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lateFeeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn refundDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource returnItemBindingSource;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox txtRefundTotal;
        private System.Windows.Forms.Label TotalLateFee;
        private System.Windows.Forms.Label TotalRefund;
        private System.Windows.Forms.TextBox txtLateFee;
    }
}
