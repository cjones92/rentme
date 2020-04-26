namespace FurnitureRentals.View
{
    partial class SubmitTransactionDialog
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
            this.ReturnButton = new System.Windows.Forms.Button();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.SubmitTransactionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ReturnButton
            // 
            this.ReturnButton.Font = new System.Drawing.Font("Calibri", 10.2F);
            this.ReturnButton.Location = new System.Drawing.Point(171, 112);
            this.ReturnButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(100, 38);
            this.ReturnButton.TabIndex = 5;
            this.ReturnButton.Text = "Return";
            this.ReturnButton.UseVisualStyleBackColor = true;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Font = new System.Drawing.Font("Calibri", 10.2F);
            this.ConfirmButton.Location = new System.Drawing.Point(279, 112);
            this.ConfirmButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(100, 38);
            this.ConfirmButton.TabIndex = 4;
            this.ConfirmButton.Text = "Confirm";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // SubmitTransactionLabel
            // 
            this.SubmitTransactionLabel.AutoSize = true;
            this.SubmitTransactionLabel.Font = new System.Drawing.Font("Calibri", 10.2F);
            this.SubmitTransactionLabel.Location = new System.Drawing.Point(106, 63);
            this.SubmitTransactionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SubmitTransactionLabel.Name = "SubmitTransactionLabel";
            this.SubmitTransactionLabel.Size = new System.Drawing.Size(370, 21);
            this.SubmitTransactionLabel.TabIndex = 3;
            this.SubmitTransactionLabel.Text = "Are you sure you want to transmit this transaction?";
            // 
            // SubmitTransactionDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 238);
            this.Controls.Add(this.ReturnButton);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.SubmitTransactionLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SubmitTransactionDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SubmitTransactionDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ReturnButton;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.Label SubmitTransactionLabel;
    }
}