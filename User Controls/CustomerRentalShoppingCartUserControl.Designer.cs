﻿namespace FurnitureRentals.User_Controls
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
            this.RentalDataGridView = new System.Windows.Forms.DataGridView();
            this.SubmitRentalButton = new System.Windows.Forms.Button();
            this.CustomerName = new System.Windows.Forms.Label();
            this.MemberIDLabel = new System.Windows.Forms.Label();
            this.ActualNameLabel = new System.Windows.Forms.Label();
            this.ActualIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.RentalDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // FurnitureSearchButton
            // 
            this.FurnitureSearchButton.Location = new System.Drawing.Point(35, 55);
            this.FurnitureSearchButton.Name = "FurnitureSearchButton";
            this.FurnitureSearchButton.Size = new System.Drawing.Size(101, 23);
            this.FurnitureSearchButton.TabIndex = 0;
            this.FurnitureSearchButton.Text = "Look Up Furniture";
            this.FurnitureSearchButton.UseVisualStyleBackColor = true;
            this.FurnitureSearchButton.Click += new System.EventHandler(this.FurnitureSearchButton_Click);
            // 
            // EmptyCartButton
            // 
            this.EmptyCartButton.Location = new System.Drawing.Point(142, 55);
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
            // RentalDataGridView
            // 
            this.RentalDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RentalDataGridView.Location = new System.Drawing.Point(35, 98);
            this.RentalDataGridView.Name = "RentalDataGridView";
            this.RentalDataGridView.Size = new System.Drawing.Size(467, 215);
            this.RentalDataGridView.TabIndex = 4;
            // 
            // SubmitRentalButton
            // 
            this.SubmitRentalButton.Location = new System.Drawing.Point(427, 356);
            this.SubmitRentalButton.Name = "SubmitRentalButton";
            this.SubmitRentalButton.Size = new System.Drawing.Size(75, 23);
            this.SubmitRentalButton.TabIndex = 5;
            this.SubmitRentalButton.Text = "Submit Order";
            this.SubmitRentalButton.UseVisualStyleBackColor = true;
            this.SubmitRentalButton.Click += new System.EventHandler(this.SubmitRentalButton_Click);
            // 
            // CustomerName
            // 
            this.CustomerName.AutoSize = true;
            this.CustomerName.Location = new System.Drawing.Point(35, 15);
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.Size = new System.Drawing.Size(85, 13);
            this.CustomerName.TabIndex = 6;
            this.CustomerName.Text = "Customer Name:";
            // 
            // MemberIDLabel
            // 
            this.MemberIDLabel.AutoSize = true;
            this.MemberIDLabel.Location = new System.Drawing.Point(38, 36);
            this.MemberIDLabel.Name = "MemberIDLabel";
            this.MemberIDLabel.Size = new System.Drawing.Size(65, 13);
            this.MemberIDLabel.TabIndex = 7;
            this.MemberIDLabel.Text = "Member ID: ";
            // 
            // ActualNameLabel
            // 
            this.ActualNameLabel.AutoSize = true;
            this.ActualNameLabel.Location = new System.Drawing.Point(126, 15);
            this.ActualNameLabel.Name = "ActualNameLabel";
            this.ActualNameLabel.Size = new System.Drawing.Size(35, 13);
            this.ActualNameLabel.TabIndex = 8;
            this.ActualNameLabel.Text = "label1";
            // 
            // ActualIDLabel
            // 
            this.ActualIDLabel.AutoSize = true;
            this.ActualIDLabel.Location = new System.Drawing.Point(110, 36);
            this.ActualIDLabel.Name = "ActualIDLabel";
            this.ActualIDLabel.Size = new System.Drawing.Size(35, 13);
            this.ActualIDLabel.TabIndex = 9;
            this.ActualIDLabel.Text = "label2";
            // 
            // CustomerRentalShoppingCartUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ActualIDLabel);
            this.Controls.Add(this.ActualNameLabel);
            this.Controls.Add(this.MemberIDLabel);
            this.Controls.Add(this.CustomerName);
            this.Controls.Add(this.SubmitRentalButton);
            this.Controls.Add(this.RentalDataGridView);
            this.Controls.Add(this.TotalLabel);
            this.Controls.Add(this.RentalTotalTextBox);
            this.Controls.Add(this.EmptyCartButton);
            this.Controls.Add(this.FurnitureSearchButton);
            this.Name = "CustomerRentalShoppingCartUserControl";
            this.Size = new System.Drawing.Size(555, 399);
            ((System.ComponentModel.ISupportInitialize)(this.RentalDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button FurnitureSearchButton;
        private System.Windows.Forms.Button EmptyCartButton;
        private System.Windows.Forms.TextBox RentalTotalTextBox;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.DataGridView RentalDataGridView;
        private System.Windows.Forms.Button SubmitRentalButton;
        private System.Windows.Forms.Label CustomerName;
        private System.Windows.Forms.Label MemberIDLabel;
        private System.Windows.Forms.Label ActualNameLabel;
        private System.Windows.Forms.Label ActualIDLabel;
    }
}