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
            this.LoginButton = new System.Windows.Forms.Button();
            this.ErrorMessageLabel = new System.Windows.Forms.Label();
            this.LoginChoiceLabel = new System.Windows.Forms.Label();
            this.UserLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LoginCloseButton = new System.Windows.Forms.Button();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SignInComboBox
            // 
            this.SignInComboBox.FormattingEnabled = true;
            this.SignInComboBox.Location = new System.Drawing.Point(165, 65);
            this.SignInComboBox.Name = "SignInComboBox";
            this.SignInComboBox.Size = new System.Drawing.Size(151, 21);
            this.SignInComboBox.TabIndex = 0;
            this.SignInComboBox.SelectedIndexChanged += new System.EventHandler(this.SignInComboBox_SelectedIndexChanged);
            // 
            // UserNameTextBox
            // 
            this.UserNameTextBox.Location = new System.Drawing.Point(165, 107);
            this.UserNameTextBox.Name = "UserNameTextBox";
            this.UserNameTextBox.Size = new System.Drawing.Size(151, 20);
            this.UserNameTextBox.TabIndex = 1;
            this.UserNameTextBox.TextChanged += new System.EventHandler(this.UserNameTextBox_TextChanged);
            // 
            // PasswordMaskedTextBox
            // 
            this.PasswordMaskedTextBox.Location = new System.Drawing.Point(165, 146);
            this.PasswordMaskedTextBox.Name = "PasswordMaskedTextBox";
            this.PasswordMaskedTextBox.Size = new System.Drawing.Size(151, 20);
            this.PasswordMaskedTextBox.TabIndex = 2;
            this.PasswordMaskedTextBox.TextChanged += new System.EventHandler(this.PasswordMaskedTextBox_TextChanged);
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(165, 210);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(74, 31);
            this.LoginButton.TabIndex = 4;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // ErrorMessageLabel
            // 
            this.ErrorMessageLabel.AutoSize = true;
            this.ErrorMessageLabel.Location = new System.Drawing.Point(245, 335);
            this.ErrorMessageLabel.Name = "ErrorMessageLabel";
            this.ErrorMessageLabel.Size = new System.Drawing.Size(0, 13);
            this.ErrorMessageLabel.TabIndex = 5;
            // 
            // LoginChoiceLabel
            // 
            this.LoginChoiceLabel.AutoSize = true;
            this.LoginChoiceLabel.Location = new System.Drawing.Point(80, 73);
            this.LoginChoiceLabel.Name = "LoginChoiceLabel";
            this.LoginChoiceLabel.Size = new System.Drawing.Size(55, 13);
            this.LoginChoiceLabel.TabIndex = 7;
            this.LoginChoiceLabel.Text = "Log In As:";
            // 
            // UserLabel
            // 
            this.UserLabel.AutoSize = true;
            this.UserLabel.Location = new System.Drawing.Point(72, 114);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(63, 13);
            this.UserLabel.TabIndex = 8;
            this.UserLabel.Text = "User Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Password:";
            // 
            // LoginCloseButton
            // 
            this.LoginCloseButton.Location = new System.Drawing.Point(246, 210);
            this.LoginCloseButton.Name = "LoginCloseButton";
            this.LoginCloseButton.Size = new System.Drawing.Size(70, 31);
            this.LoginCloseButton.TabIndex = 10;
            this.LoginCloseButton.Text = "Close";
            this.LoginCloseButton.UseVisualStyleBackColor = true;
            this.LoginCloseButton.Click += new System.EventHandler(this.LoginCloseButton_Click);
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.Location = new System.Drawing.Point(83, 182);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.ErrorLabel.TabIndex = 11;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 312);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.LoginCloseButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UserLabel);
            this.Controls.Add(this.LoginChoiceLabel);
            this.Controls.Add(this.ErrorMessageLabel);
            this.Controls.Add(this.LoginButton);
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
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Label ErrorMessageLabel;
        private System.Windows.Forms.Label LoginChoiceLabel;
        private System.Windows.Forms.Label UserLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LoginCloseButton;
        private System.Windows.Forms.Label ErrorLabel;
    }
}