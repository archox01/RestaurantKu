namespace RestaurantKuUI
{
    partial class ChangePasswordForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.OldPasswordLabel = new System.Windows.Forms.Label();
            this.NewPasswordLabel1 = new System.Windows.Forms.Label();
            this.ConfirmPasswordLabel1 = new System.Windows.Forms.Label();
            this.OldPasswordValueTextBox = new System.Windows.Forms.TextBox();
            this.NewPasswordValueTextBox = new System.Windows.Forms.TextBox();
            this.ConfirmPasswordValueTextBox = new System.Windows.Forms.TextBox();
            this.ChangePasswordButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(250, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(438, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHANGE PASSWORD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label2.Location = new System.Drawing.Point(31, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Welcome : ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.UserNameLabel.Location = new System.Drawing.Point(197, 160);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(258, 37);
            this.UserNameLabel.TabIndex = 2;
            this.UserNameLabel.Text = "<|USER NAME|>";
            this.UserNameLabel.Click += new System.EventHandler(this.UserNameLabel_Click);
            // 
            // OldPasswordLabel
            // 
            this.OldPasswordLabel.AutoSize = true;
            this.OldPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.OldPasswordLabel.Location = new System.Drawing.Point(163, 257);
            this.OldPasswordLabel.Name = "OldPasswordLabel";
            this.OldPasswordLabel.Size = new System.Drawing.Size(191, 32);
            this.OldPasswordLabel.TabIndex = 3;
            this.OldPasswordLabel.Text = "Old Password";
            // 
            // NewPasswordLabel1
            // 
            this.NewPasswordLabel1.AutoSize = true;
            this.NewPasswordLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.NewPasswordLabel1.Location = new System.Drawing.Point(163, 326);
            this.NewPasswordLabel1.Name = "NewPasswordLabel1";
            this.NewPasswordLabel1.Size = new System.Drawing.Size(202, 32);
            this.NewPasswordLabel1.TabIndex = 4;
            this.NewPasswordLabel1.Text = "New Password";
            // 
            // ConfirmPasswordLabel1
            // 
            this.ConfirmPasswordLabel1.AutoSize = true;
            this.ConfirmPasswordLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.ConfirmPasswordLabel1.Location = new System.Drawing.Point(163, 388);
            this.ConfirmPasswordLabel1.Name = "ConfirmPasswordLabel1";
            this.ConfirmPasswordLabel1.Size = new System.Drawing.Size(245, 32);
            this.ConfirmPasswordLabel1.TabIndex = 5;
            this.ConfirmPasswordLabel1.Text = "Confirm Password";
            // 
            // OldPasswordValueTextBox
            // 
            this.OldPasswordValueTextBox.Location = new System.Drawing.Point(422, 245);
            this.OldPasswordValueTextBox.Name = "OldPasswordValueTextBox";
            this.OldPasswordValueTextBox.Size = new System.Drawing.Size(349, 44);
            this.OldPasswordValueTextBox.TabIndex = 6;
            // 
            // NewPasswordValueTextBox
            // 
            this.NewPasswordValueTextBox.Location = new System.Drawing.Point(422, 314);
            this.NewPasswordValueTextBox.Name = "NewPasswordValueTextBox";
            this.NewPasswordValueTextBox.Size = new System.Drawing.Size(349, 44);
            this.NewPasswordValueTextBox.TabIndex = 7;
            // 
            // ConfirmPasswordValueTextBox
            // 
            this.ConfirmPasswordValueTextBox.Location = new System.Drawing.Point(422, 376);
            this.ConfirmPasswordValueTextBox.Name = "ConfirmPasswordValueTextBox";
            this.ConfirmPasswordValueTextBox.Size = new System.Drawing.Size(349, 44);
            this.ConfirmPasswordValueTextBox.TabIndex = 8;
            // 
            // ChangePasswordButton
            // 
            this.ChangePasswordButton.Location = new System.Drawing.Point(608, 456);
            this.ChangePasswordButton.Name = "ChangePasswordButton";
            this.ChangePasswordButton.Size = new System.Drawing.Size(156, 54);
            this.ChangePasswordButton.TabIndex = 9;
            this.ChangePasswordButton.Text = "Change";
            this.ChangePasswordButton.UseVisualStyleBackColor = true;

            // 
            // ChangePasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(918, 563);
            this.Controls.Add(this.ChangePasswordButton);
            this.Controls.Add(this.ConfirmPasswordValueTextBox);
            this.Controls.Add(this.NewPasswordValueTextBox);
            this.Controls.Add(this.OldPasswordValueTextBox);
            this.Controls.Add(this.ConfirmPasswordLabel1);
            this.Controls.Add(this.NewPasswordLabel1);
            this.Controls.Add(this.OldPasswordLabel);
            this.Controls.Add(this.UserNameLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "ChangePasswordForm";
            this.Text = " Change Password Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.Label OldPasswordLabel;
        private System.Windows.Forms.Label NewPasswordLabel1;
        private System.Windows.Forms.Label ConfirmPasswordLabel1;
        private System.Windows.Forms.TextBox OldPasswordValueTextBox;
        private System.Windows.Forms.TextBox NewPasswordValueTextBox;
        private System.Windows.Forms.TextBox ConfirmPasswordValueTextBox;
        private System.Windows.Forms.Button ChangePasswordButton;
    }
}