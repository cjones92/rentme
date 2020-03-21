namespace FurnitureRentals.View
{
    partial class LoginForm
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
            this.SignInComboBox = new System.Windows.Forms.ComboBox();
            this.UserNameTextBox = new System.Windows.Forms.TextBox();
            this.PasswordMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // SignInComboBox
            // 
            this.SignInComboBox.FormattingEnabled = true;
            this.SignInComboBox.Location = new System.Drawing.Point(245, 111);
            this.SignInComboBox.Name = "SignInComboBox";
            this.SignInComboBox.Size = new System.Drawing.Size(121, 21);
            this.SignInComboBox.TabIndex = 0;
            // 
            // UserNameTextBox
            // 
            this.UserNameTextBox.Location = new System.Drawing.Point(245, 166);
            this.UserNameTextBox.Name = "UserNameTextBox";
            this.UserNameTextBox.Size = new System.Drawing.Size(121, 20);
            this.UserNameTextBox.TabIndex = 1;
            // 
            // PasswordMaskedTextBox
            // 
            this.PasswordMaskedTextBox.Location = new System.Drawing.Point(245, 217);
            this.PasswordMaskedTextBox.Name = "PasswordMaskedTextBox";
            this.PasswordMaskedTextBox.Size = new System.Drawing.Size(121, 20);
            this.PasswordMaskedTextBox.TabIndex = 2;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PasswordMaskedTextBox);
            this.Controls.Add(this.UserNameTextBox);
            this.Controls.Add(this.SignInComboBox);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox SignInComboBox;
        private System.Windows.Forms.TextBox UserNameTextBox;
        private System.Windows.Forms.MaskedTextBox PasswordMaskedTextBox;
    }
}