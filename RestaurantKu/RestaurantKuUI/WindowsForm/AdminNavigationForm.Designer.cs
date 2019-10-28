namespace RestaurantKuUI
{
    partial class AdminNavigationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminNavigationForm));
            this.WelcomeAdminLabel = new System.Windows.Forms.Label();
            this.AdminNameLabelValue = new System.Windows.Forms.Label();
            this.ManageEmployeeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ManageMenuButton = new System.Windows.Forms.Button();
            this.ManageMemberButton = new System.Windows.Forms.Button();
            this.ChangePasswordButton = new System.Windows.Forms.Button();
            this.LogOutButton = new System.Windows.Forms.Button();
            this.AdminProfileButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WelcomeAdminLabel
            // 
            this.WelcomeAdminLabel.AutoSize = true;
            this.WelcomeAdminLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeAdminLabel.Location = new System.Drawing.Point(92, 135);
            this.WelcomeAdminLabel.Name = "WelcomeAdminLabel";
            this.WelcomeAdminLabel.Size = new System.Drawing.Size(128, 25);
            this.WelcomeAdminLabel.TabIndex = 0;
            this.WelcomeAdminLabel.Text = "WELCOME :";
            this.WelcomeAdminLabel.Click += new System.EventHandler(this.WelcomeAdminLabel_Click);
            // 
            // AdminNameLabelValue
            // 
            this.AdminNameLabelValue.AutoSize = true;
            this.AdminNameLabelValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminNameLabelValue.Location = new System.Drawing.Point(219, 135);
            this.AdminNameLabelValue.Name = "AdminNameLabelValue";
            this.AdminNameLabelValue.Size = new System.Drawing.Size(163, 25);
            this.AdminNameLabelValue.TabIndex = 1;
            this.AdminNameLabelValue.Text = "<ADMIN NAME>";
            this.AdminNameLabelValue.Click += new System.EventHandler(this.AdminNameLabelValue_Click);
            // 
            // ManageEmployeeButton
            // 
            this.ManageEmployeeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManageEmployeeButton.Location = new System.Drawing.Point(97, 198);
            this.ManageEmployeeButton.Name = "ManageEmployeeButton";
            this.ManageEmployeeButton.Size = new System.Drawing.Size(137, 68);
            this.ManageEmployeeButton.TabIndex = 2;
            this.ManageEmployeeButton.Text = "Manage Employee";
            this.ManageEmployeeButton.UseVisualStyleBackColor = true;
            this.ManageEmployeeButton.Click += new System.EventHandler(this.ManageEmployeeButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(217, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "ADMIN PANEL";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ManageMenuButton
            // 
            this.ManageMenuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManageMenuButton.Location = new System.Drawing.Point(263, 198);
            this.ManageMenuButton.Name = "ManageMenuButton";
            this.ManageMenuButton.Size = new System.Drawing.Size(137, 68);
            this.ManageMenuButton.TabIndex = 5;
            this.ManageMenuButton.Text = "Manage Menu";
            this.ManageMenuButton.UseVisualStyleBackColor = true;
            this.ManageMenuButton.Click += new System.EventHandler(this.ManageMenuButton_Click);
            // 
            // ManageMemberButton
            // 
            this.ManageMemberButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManageMemberButton.Location = new System.Drawing.Point(444, 198);
            this.ManageMemberButton.Name = "ManageMemberButton";
            this.ManageMemberButton.Size = new System.Drawing.Size(137, 66);
            this.ManageMemberButton.TabIndex = 6;
            this.ManageMemberButton.Text = "Manage Member";
            this.ManageMemberButton.UseVisualStyleBackColor = true;
            this.ManageMemberButton.Click += new System.EventHandler(this.ManageMemberButton_Click);
            // 
            // ChangePasswordButton
            // 
            this.ChangePasswordButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangePasswordButton.Location = new System.Drawing.Point(263, 299);
            this.ChangePasswordButton.Name = "ChangePasswordButton";
            this.ChangePasswordButton.Size = new System.Drawing.Size(137, 72);
            this.ChangePasswordButton.TabIndex = 7;
            this.ChangePasswordButton.Text = "Change Password";
            this.ChangePasswordButton.UseVisualStyleBackColor = true;
            this.ChangePasswordButton.Click += new System.EventHandler(this.ChangePasswordButton_Click);
            // 
            // LogOutButton
            // 
            this.LogOutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOutButton.Location = new System.Drawing.Point(444, 299);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(137, 74);
            this.LogOutButton.TabIndex = 8;
            this.LogOutButton.Text = "Log Out";
            this.LogOutButton.UseVisualStyleBackColor = true;
            this.LogOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // AdminProfileButton
            // 
            this.AdminProfileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminProfileButton.Location = new System.Drawing.Point(97, 297);
            this.AdminProfileButton.Name = "AdminProfileButton";
            this.AdminProfileButton.Size = new System.Drawing.Size(137, 74);
            this.AdminProfileButton.TabIndex = 9;
            this.AdminProfileButton.Text = "Profile";
            this.AdminProfileButton.UseVisualStyleBackColor = true;
            this.AdminProfileButton.Click += new System.EventHandler(this.AdminProfileButton_Click);
            // 
            // AdminNavigationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(650, 431);
            this.Controls.Add(this.AdminProfileButton);
            this.Controls.Add(this.LogOutButton);
            this.Controls.Add(this.ChangePasswordButton);
            this.Controls.Add(this.ManageMemberButton);
            this.Controls.Add(this.ManageMenuButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ManageEmployeeButton);
            this.Controls.Add(this.AdminNameLabelValue);
            this.Controls.Add(this.WelcomeAdminLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AdminNavigationForm";
            this.Text = "AdminNavigationForm";
            this.Load += new System.EventHandler(this.AdminNavigationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WelcomeAdminLabel;
        private System.Windows.Forms.Label AdminNameLabelValue;
        private System.Windows.Forms.Button ManageEmployeeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ManageMenuButton;
        private System.Windows.Forms.Button ManageMemberButton;
        private System.Windows.Forms.Button ChangePasswordButton;
        private System.Windows.Forms.Button LogOutButton;
        private System.Windows.Forms.Button AdminProfileButton;
    }
}