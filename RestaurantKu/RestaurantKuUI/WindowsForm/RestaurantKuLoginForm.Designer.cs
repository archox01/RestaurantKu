namespace RestaurantKuUI
{
    partial class RestaurantKuLoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RestaurantKuLoginForm));
            this.RestaurantKuLoginLabel = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.EmailTextBoxValue = new System.Windows.Forms.TextBox();
            this.PasswordTextBoxValue = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RestaurantKuLoginLabel
            // 
            this.RestaurantKuLoginLabel.AutoSize = true;
            this.RestaurantKuLoginLabel.Font = new System.Drawing.Font("Segoe UI Black", 30F, System.Drawing.FontStyle.Bold);
            this.RestaurantKuLoginLabel.ForeColor = System.Drawing.Color.Red;
            this.RestaurantKuLoginLabel.Location = new System.Drawing.Point(16, 32);
            this.RestaurantKuLoginLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RestaurantKuLoginLabel.Name = "RestaurantKuLoginLabel";
            this.RestaurantKuLoginLabel.Size = new System.Drawing.Size(737, 81);
            this.RestaurantKuLoginLabel.TabIndex = 0;
            this.RestaurantKuLoginLabel.Text = "RESTAURANTKU LOGIN";
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.UsernameLabel.ForeColor = System.Drawing.Color.Red;
            this.UsernameLabel.Location = new System.Drawing.Point(117, 67);
            this.UsernameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(77, 32);
            this.UsernameLabel.TabIndex = 1;
            this.UsernameLabel.Text = "Email";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.PasswordLabel.ForeColor = System.Drawing.Color.Red;
            this.PasswordLabel.Location = new System.Drawing.Point(117, 104);
            this.PasswordLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(123, 32);
            this.PasswordLabel.TabIndex = 2;
            this.PasswordLabel.Text = "Password";
            // 
            // EmailTextBoxValue
            // 
            this.EmailTextBoxValue.Location = new System.Drawing.Point(265, 67);
            this.EmailTextBoxValue.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.EmailTextBoxValue.Name = "EmailTextBoxValue";
            this.EmailTextBoxValue.Size = new System.Drawing.Size(150, 29);
            this.EmailTextBoxValue.TabIndex = 3;
            // 
            // PasswordTextBoxValue
            // 
            this.PasswordTextBoxValue.Location = new System.Drawing.Point(265, 107);
            this.PasswordTextBoxValue.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.PasswordTextBoxValue.Name = "PasswordTextBoxValue";
            this.PasswordTextBoxValue.Size = new System.Drawing.Size(150, 29);
            this.PasswordTextBoxValue.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LoginButton);
            this.groupBox1.Controls.Add(this.PasswordTextBoxValue);
            this.groupBox1.Controls.Add(this.EmailTextBoxValue);
            this.groupBox1.Controls.Add(this.UsernameLabel);
            this.groupBox1.Controls.Add(this.PasswordLabel);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.ForeColor = System.Drawing.Color.Orange;
            this.groupBox1.Location = new System.Drawing.Point(115, 142);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox1.Size = new System.Drawing.Size(561, 204);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = resources.GetString("groupBox1.Text");
            // 
            // LoginButton
            // 
            this.LoginButton.ForeColor = System.Drawing.Color.OrangeRed;
            this.LoginButton.Location = new System.Drawing.Point(338, 150);
            this.LoginButton.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(77, 28);
            this.LoginButton.TabIndex = 5;
            this.LoginButton.Text = "LOGIN";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // RestaurantKuLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(770, 426);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.RestaurantKuLoginLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RestaurantKuLoginForm";
            this.Text = "RestaurantKu Login ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RestaurantKuLoginLabel;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox EmailTextBoxValue;
        private System.Windows.Forms.TextBox PasswordTextBoxValue;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button LoginButton;
    }
}

