namespace FurnitureRentals.User_Controls
{
    partial class CustomerRentalShoppingCartUserControl
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
            this.FurnitureSearchButton = new System.Windows.Forms.Button();
            this.EmptyCartButton = new System.Windows.Forms.Button();
            this.RentalTotalTextBox = new System.Windows.Forms.TextBox();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SubmitRentalButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // FurnitureSearchButton
            // 
            this.FurnitureSearchButton.Location = new System.Drawing.Point(35, 37);
            this.FurnitureSearchButton.Name = "FurnitureSearchButton";
            this.FurnitureSearchButton.Size = new System.Drawing.Size(101, 23);
            this.FurnitureSearchButton.TabIndex = 0;
            this.FurnitureSearchButton.Text = "Look Up Furniture";
            this.FurnitureSearchButton.UseVisualStyleBackColor = true;
            // 
            // EmptyCartButton
            // 
            this.EmptyCartButton.Location = new System.Drawing.Point(142, 37);
            this.EmptyCartButton.Name = "EmptyCartButton";
            this.EmptyCartButton.Size = new System.Drawing.Size(75, 23);
            this.EmptyCartButton.TabIndex = 1;
            this.EmptyCartButton.Text = "Clear Cart";
            this.EmptyCartButton.UseVisualStyleBackColor = true;
            // 
            // RentalTotalTextBox
            // 
            this.RentalTotalTextBox.Location = new System.Drawing.Point(402, 330);
            this.RentalTotalTextBox.Name = "RentalTotalTextBox";
            this.RentalTotalTextBox.Size = new System.Drawing.Size(100, 20);
            this.RentalTotalTextBox.TabIndex = 2;
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Location = new System.Drawing.Point(362, 337);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(34, 13);
            this.TotalLabel.TabIndex = 3;
            this.TotalLabel.Text = "Total:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(35, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(467, 215);
            this.dataGridView1.TabIndex = 4;
            // 
            // SubmitRentalButton
            // 
            this.SubmitRentalButton.Location = new System.Drawing.Point(427, 356);
            this.SubmitRentalButton.Name = "SubmitRentalButton";
            this.SubmitRentalButton.Size = new System.Drawing.Size(75, 23);
            this.SubmitRentalButton.TabIndex = 5;
            this.SubmitRentalButton.Text = "Submit Order";
            this.SubmitRentalButton.UseVisualStyleBackColor = true;
            // 
            // CustomerRentalShoppingCartUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SubmitRentalButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.TotalLabel);
            this.Controls.Add(this.RentalTotalTextBox);
            this.Controls.Add(this.EmptyCartButton);
            this.Controls.Add(this.FurnitureSearchButton);
            this.Name = "CustomerRentalShoppingCartUserControl";
            this.Size = new System.Drawing.Size(555, 399);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button FurnitureSearchButton;
        private System.Windows.Forms.Button EmptyCartButton;
        private System.Windows.Forms.TextBox RentalTotalTextBox;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button SubmitRentalButton;
    }
}
