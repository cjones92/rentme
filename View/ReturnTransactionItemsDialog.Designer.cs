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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.MemberIDLabel = new System.Windows.Forms.Label();
            this.lblMemberId = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.CustomerName = new System.Windows.Forms.Label();
            this.returnTransactionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.returnTransactionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 102);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(742, 233);
            this.dataGridView1.TabIndex = 0;
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
            // returnTransactionBindingSource
            // 
            this.returnTransactionBindingSource.DataSource = typeof(FurnitureRentals.Model.ReturnTransaction);
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
            // ReturnTransactionItemsDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 402);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ReturnTransactionItemsDialog";
            this.Text = "ReturnTransactionItemsDialog";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.returnTransactionBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label MemberIDLabel;
        private System.Windows.Forms.Label lblMemberId;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label CustomerName;
        private System.Windows.Forms.BindingSource returnTransactionBindingSource;
        private System.Windows.Forms.Button btnClose;
    }
}