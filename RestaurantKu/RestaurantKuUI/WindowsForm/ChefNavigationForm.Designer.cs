namespace RestaurantKuUI
{
    partial class ChefNavigationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChefNavigationForm));
            this.ViewOrderFormButton = new System.Windows.Forms.Button();
            this.ChefProfileButton = new System.Windows.Forms.Button();
            this.LogOutButton = new System.Windows.Forms.Button();
            this.ChangePasswordButton = new System.Windows.Forms.Button();
            this.CashierPanelLabel = new System.Windows.Forms.Label();
            this.ChefNameLabelValue = new System.Windows.Forms.Label();
            this.WelcomeAdminLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ViewOrderFormButton
            // 
            this.ViewOrderFormButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ViewOrderFormButton.Location = new System.Drawing.Point(272, 165);
            this.ViewOrderFormButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ViewOrderFormButton.Name = "ViewOrderFormButton";
            this.ViewOrderFormButton.Size = new System.Drawing.Size(112, 62);
            this.ViewOrderFormButton.TabIndex = 26;
            this.ViewOrderFormButton.Text = "View Order";
            this.ViewOrderFormButton.UseVisualStyleBackColor = true;
            this.ViewOrderFormButton.Click += new System.EventHandler(this.ViewOrderFormButton_Click);
            // 
            // ChefProfileButton
            // 
            this.ChefProfileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ChefProfileButton.Location = new System.Drawing.Point(115, 163);
            this.ChefProfileButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ChefProfileButton.Name = "ChefProfileButton";
            this.ChefProfileButton.Size = new System.Drawing.Size(112, 64);
            this.ChefProfileButton.TabIndex = 24;
            this.ChefProfileButton.Text = "View Profile";
            this.ChefProfileButton.UseVisualStyleBackColor = true;
            this.ChefProfileButton.Click += new System.EventHandler(this.ChefProfileButton_Click);
            // 
            // LogOutButton
            // 
            this.LogOutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LogOutButton.Location = new System.Drawing.Point(272, 241);
            this.LogOutButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(112, 64);
            this.LogOutButton.TabIndex = 23;
            this.LogOutButton.Text = "Log Out";
            this.LogOutButton.UseVisualStyleBackColor = true;
            this.LogOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // ChangePasswordButton
            // 
            this.ChangePasswordButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ChangePasswordButton.Location = new System.Drawing.Point(115, 241);
            this.ChangePasswordButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ChangePasswordButton.Name = "ChangePasswordButton";
            this.ChangePasswordButton.Size = new System.Drawing.Size(112, 64);
            this.ChangePasswordButton.TabIndex = 22;
            this.ChangePasswordButton.Text = "Change Password";
            this.ChangePasswordButton.UseVisualStyleBackColor = true;
            this.ChangePasswordButton.Click += new System.EventHandler(this.ChangePasswordButton_Click);
            // 
            // CashierPanelLabel
            // 
            this.CashierPanelLabel.AutoSize = true;
            this.CashierPanelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.CashierPanelLabel.Location = new System.Drawing.Point(131, 49);
            this.CashierPanelLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CashierPanelLabel.Name = "CashierPanelLabel";
            this.CashierPanelLabel.Size = new System.Drawing.Size(219, 37);
            this.CashierPanelLabel.TabIndex = 21;
            this.CashierPanelLabel.Text = "CHEF PANEL";
            // 
            // ChefNameLabelValue
            // 
            this.ChefNameLabelValue.AutoSize = true;
            this.ChefNameLabelValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ChefNameLabelValue.Location = new System.Drawing.Point(213, 104);
            this.ChefNameLabelValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ChefNameLabelValue.Name = "ChefNameLabelValue";
            this.ChefNameLabelValue.Size = new System.Drawing.Size(153, 25);
            this.ChefNameLabelValue.TabIndex = 20;
            this.ChefNameLabelValue.Text = "<CHEF NAME>";
            // 
            // WelcomeAdminLabel
            // 
            this.WelcomeAdminLabel.AutoSize = true;
            this.WelcomeAdminLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.WelcomeAdminLabel.Location = new System.Drawing.Point(72, 104);
            this.WelcomeAdminLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.WelcomeAdminLabel.Name = "WelcomeAdminLabel";
            this.WelcomeAdminLabel.Size = new System.Drawing.Size(128, 25);
            this.WelcomeAdminLabel.TabIndex = 19;
            this.WelcomeAdminLabel.Text = "WELCOME :";
            // 
            // ChefNavigationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(474, 359);
            this.Controls.Add(this.LogOutButton);
            this.Controls.Add(this.ViewOrderFormButton);
            this.Controls.Add(this.ChefProfileButton);
            this.Controls.Add(this.ChangePasswordButton);
            this.Controls.Add(this.CashierPanelLabel);
            this.Controls.Add(this.ChefNameLabelValue);
            this.Controls.Add(this.WelcomeAdminLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ChefNavigationForm";
            this.Text = "Chef Navigation Form";
            this.Load += new System.EventHandler(this.ChefNavigationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ViewOrderFormButton;
        private System.Windows.Forms.Button ChefProfileButton;
        private System.Windows.Forms.Button LogOutButton;
        private System.Windows.Forms.Button ChangePasswordButton;
        private System.Windows.Forms.Label CashierPanelLabel;
        private System.Windows.Forms.Label ChefNameLabelValue;
        private System.Windows.Forms.Label WelcomeAdminLabel;
    }
}