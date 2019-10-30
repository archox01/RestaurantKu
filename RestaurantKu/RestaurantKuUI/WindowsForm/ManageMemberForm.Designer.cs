namespace RestaurantKuUI
{
    partial class ManageMemberForm
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
            this.ManageMemberTitleLabel = new System.Windows.Forms.Label();
            this.MemberIdLabel = new System.Windows.Forms.Label();
            this.MemberNameLabel = new System.Windows.Forms.Label();
            this.MemberEmailLabel = new System.Windows.Forms.Label();
            this.MemberJoinDateLabel = new System.Windows.Forms.Label();
            this.MemberIdTextBox = new System.Windows.Forms.TextBox();
            this.MemberPasswordText = new System.Windows.Forms.TextBox();
            this.MemberNameText = new System.Windows.Forms.TextBox();
            this.MemberEmailText = new System.Windows.Forms.TextBox();
            this.InsertDataButton = new System.Windows.Forms.Button();
            this.UpdateDataButton = new System.Windows.Forms.Button();
            this.DeleteDataButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.CellNumberLabel = new System.Windows.Forms.Label();
            this.CellNumberText = new System.Windows.Forms.TextBox();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.AddressText = new System.Windows.Forms.RichTextBox();
            this.JoinDateTime = new System.Windows.Forms.DateTimePicker();
            this.DataGridM = new System.Windows.Forms.DataGridView();
            this.ColId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColHP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColJoin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColBankName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAcc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDeleted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberInformationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberInformationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ManageMemberTitleLabel
            // 
            this.ManageMemberTitleLabel.AutoSize = true;
            this.ManageMemberTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.ManageMemberTitleLabel.Location = new System.Drawing.Point(177, 9);
            this.ManageMemberTitleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ManageMemberTitleLabel.Name = "ManageMemberTitleLabel";
            this.ManageMemberTitleLabel.Size = new System.Drawing.Size(450, 52);
            this.ManageMemberTitleLabel.TabIndex = 1;
            this.ManageMemberTitleLabel.Text = "Member Management";
            // 
            // MemberIdLabel
            // 
            this.MemberIdLabel.AutoSize = true;
            this.MemberIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.MemberIdLabel.Location = new System.Drawing.Point(198, 98);
            this.MemberIdLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MemberIdLabel.Name = "MemberIdLabel";
            this.MemberIdLabel.Size = new System.Drawing.Size(88, 20);
            this.MemberIdLabel.TabIndex = 3;
            this.MemberIdLabel.Text = "Member Id";
            // 
            // MemberNameLabel
            // 
            this.MemberNameLabel.AutoSize = true;
            this.MemberNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.MemberNameLabel.Location = new System.Drawing.Point(41, 311);
            this.MemberNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MemberNameLabel.Name = "MemberNameLabel";
            this.MemberNameLabel.Size = new System.Drawing.Size(53, 20);
            this.MemberNameLabel.TabIndex = 4;
            this.MemberNameLabel.Text = "Name";
            // 
            // MemberEmailLabel
            // 
            this.MemberEmailLabel.AutoSize = true;
            this.MemberEmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.MemberEmailLabel.Location = new System.Drawing.Point(43, 348);
            this.MemberEmailLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MemberEmailLabel.Name = "MemberEmailLabel";
            this.MemberEmailLabel.Size = new System.Drawing.Size(51, 20);
            this.MemberEmailLabel.TabIndex = 5;
            this.MemberEmailLabel.Text = "Email";
            // 
            // MemberJoinDateLabel
            // 
            this.MemberJoinDateLabel.AutoSize = true;
            this.MemberJoinDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.MemberJoinDateLabel.Location = new System.Drawing.Point(45, 423);
            this.MemberJoinDateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MemberJoinDateLabel.Name = "MemberJoinDateLabel";
            this.MemberJoinDateLabel.Size = new System.Drawing.Size(81, 20);
            this.MemberJoinDateLabel.TabIndex = 6;
            this.MemberJoinDateLabel.Text = "Join Date";
            // 
            // MemberIdTextBox
            // 
            this.MemberIdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.MemberIdTextBox.Location = new System.Drawing.Point(332, 92);
            this.MemberIdTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.MemberIdTextBox.Name = "MemberIdTextBox";
            this.MemberIdTextBox.Size = new System.Drawing.Size(150, 26);
            this.MemberIdTextBox.TabIndex = 7;
            // 
            // MemberPasswordText
            // 
            this.MemberPasswordText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.MemberPasswordText.Location = new System.Drawing.Point(186, 386);
            this.MemberPasswordText.Margin = new System.Windows.Forms.Padding(2);
            this.MemberPasswordText.Name = "MemberPasswordText";
            this.MemberPasswordText.PasswordChar = '*';
            this.MemberPasswordText.Size = new System.Drawing.Size(150, 26);
            this.MemberPasswordText.TabIndex = 8;
            // 
            // MemberNameText
            // 
            this.MemberNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.MemberNameText.Location = new System.Drawing.Point(186, 311);
            this.MemberNameText.Margin = new System.Windows.Forms.Padding(2);
            this.MemberNameText.Name = "MemberNameText";
            this.MemberNameText.Size = new System.Drawing.Size(150, 26);
            this.MemberNameText.TabIndex = 8;
            // 
            // MemberEmailText
            // 
            this.MemberEmailText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.MemberEmailText.Location = new System.Drawing.Point(186, 348);
            this.MemberEmailText.Margin = new System.Windows.Forms.Padding(2);
            this.MemberEmailText.Name = "MemberEmailText";
            this.MemberEmailText.Size = new System.Drawing.Size(150, 26);
            this.MemberEmailText.TabIndex = 9;
            // 
            // InsertDataButton
            // 
            this.InsertDataButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.InsertDataButton.Location = new System.Drawing.Point(221, 465);
            this.InsertDataButton.Margin = new System.Windows.Forms.Padding(2);
            this.InsertDataButton.Name = "InsertDataButton";
            this.InsertDataButton.Size = new System.Drawing.Size(74, 33);
            this.InsertDataButton.TabIndex = 10;
            this.InsertDataButton.Text = "Insert";
            this.InsertDataButton.UseVisualStyleBackColor = true;
            this.InsertDataButton.Click += new System.EventHandler(this.InsertDataButton_Click);
            // 
            // UpdateDataButton
            // 
            this.UpdateDataButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.UpdateDataButton.Location = new System.Drawing.Point(383, 465);
            this.UpdateDataButton.Margin = new System.Windows.Forms.Padding(2);
            this.UpdateDataButton.Name = "UpdateDataButton";
            this.UpdateDataButton.Size = new System.Drawing.Size(89, 33);
            this.UpdateDataButton.TabIndex = 11;
            this.UpdateDataButton.Text = "Update";
            this.UpdateDataButton.UseVisualStyleBackColor = true;
            this.UpdateDataButton.Click += new System.EventHandler(this.UpdateDataButton_Click);
            // 
            // DeleteDataButton
            // 
            this.DeleteDataButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.DeleteDataButton.Location = new System.Drawing.Point(537, 465);
            this.DeleteDataButton.Margin = new System.Windows.Forms.Padding(2);
            this.DeleteDataButton.Name = "DeleteDataButton";
            this.DeleteDataButton.Size = new System.Drawing.Size(74, 33);
            this.DeleteDataButton.TabIndex = 12;
            this.DeleteDataButton.Text = "Delete";
            this.DeleteDataButton.UseVisualStyleBackColor = true;
            this.DeleteDataButton.Click += new System.EventHandler(this.DeleteDataButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(509, 90);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(102, 31);
            this.SearchButton.TabIndex = 13;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.PasswordLabel.Location = new System.Drawing.Point(43, 386);
            this.PasswordLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(83, 20);
            this.PasswordLabel.TabIndex = 6;
            this.PasswordLabel.Text = "Password";
            // 
            // CellNumberLabel
            // 
            this.CellNumberLabel.AutoSize = true;
            this.CellNumberLabel.Location = new System.Drawing.Point(401, 311);
            this.CellNumberLabel.Name = "CellNumberLabel";
            this.CellNumberLabel.Size = new System.Drawing.Size(98, 19);
            this.CellNumberLabel.TabIndex = 14;
            this.CellNumberLabel.Text = "Cell Number";
            // 
            // CellNumberText
            // 
            this.CellNumberText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.CellNumberText.Location = new System.Drawing.Point(528, 304);
            this.CellNumberText.Margin = new System.Windows.Forms.Padding(2);
            this.CellNumberText.Name = "CellNumberText";
            this.CellNumberText.Size = new System.Drawing.Size(194, 26);
            this.CellNumberText.TabIndex = 8;
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.AddressLabel.Location = new System.Drawing.Point(401, 347);
            this.AddressLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(71, 20);
            this.AddressLabel.TabIndex = 5;
            this.AddressLabel.Text = "Address";
            // 
            // AddressText
            // 
            this.AddressText.Location = new System.Drawing.Point(528, 345);
            this.AddressText.Name = "AddressText";
            this.AddressText.Size = new System.Drawing.Size(301, 98);
            this.AddressText.TabIndex = 15;
            this.AddressText.Text = "";
            // 
            // JoinDateTime
            // 
            this.JoinDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.JoinDateTime.Location = new System.Drawing.Point(186, 423);
            this.JoinDateTime.Name = "JoinDateTime";
            this.JoinDateTime.Size = new System.Drawing.Size(313, 26);
            this.JoinDateTime.TabIndex = 16;
            // 
            // DataGridM
            // 
            this.DataGridM.AllowUserToAddRows = false;
            this.DataGridM.AllowUserToDeleteRows = false;
            this.DataGridM.AutoGenerateColumns = false;
            this.DataGridM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridM.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColId,
            this.ColName,
            this.ColEmail,
            this.ColPassword,
            this.ColHP,
            this.ColJoin,
            this.ColBankName,
            this.ColAcc,
            this.ColCC,
            this.ColAddress,
            this.ColDeleted});
            this.DataGridM.DataSource = this.memberInformationBindingSource;
            this.DataGridM.Location = new System.Drawing.Point(12, 121);
            this.DataGridM.MultiSelect = false;
            this.DataGridM.Name = "DataGridM";
            this.DataGridM.ReadOnly = true;
            this.DataGridM.RowTemplate.Height = 28;
            this.DataGridM.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridM.Size = new System.Drawing.Size(817, 169);
            this.DataGridM.TabIndex = 17;
            this.DataGridM.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridM_CellContentClick_1);
            // 
            // ColId
            // 
            this.ColId.DataPropertyName = "MemberId";
            this.ColId.HeaderText = "Id";
            this.ColId.Name = "ColId";
            this.ColId.ReadOnly = true;
            this.ColId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColName
            // 
            this.ColName.DataPropertyName = "MemberName";
            this.ColName.HeaderText = "Name";
            this.ColName.Name = "ColName";
            this.ColName.ReadOnly = true;
            // 
            // ColEmail
            // 
            this.ColEmail.DataPropertyName = "MemberEmail";
            this.ColEmail.HeaderText = "Email";
            this.ColEmail.Name = "ColEmail";
            this.ColEmail.ReadOnly = true;
            // 
            // ColPassword
            // 
            this.ColPassword.DataPropertyName = "MemberPassword";
            this.ColPassword.HeaderText = "Password";
            this.ColPassword.Name = "ColPassword";
            this.ColPassword.ReadOnly = true;
            // 
            // ColHP
            // 
            this.ColHP.DataPropertyName = "HandPhone";
            this.ColHP.HeaderText = "Hand Phone";
            this.ColHP.Name = "ColHP";
            this.ColHP.ReadOnly = true;
            // 
            // ColJoin
            // 
            this.ColJoin.DataPropertyName = "JoinDate";
            this.ColJoin.HeaderText = "Join Date";
            this.ColJoin.Name = "ColJoin";
            this.ColJoin.ReadOnly = true;
            // 
            // ColBankName
            // 
            this.ColBankName.DataPropertyName = "BankName";
            this.ColBankName.HeaderText = "Bank Name";
            this.ColBankName.Name = "ColBankName";
            this.ColBankName.ReadOnly = true;
            this.ColBankName.Visible = false;
            // 
            // ColAcc
            // 
            this.ColAcc.DataPropertyName = "AccNumber";
            this.ColAcc.HeaderText = "AccNumber";
            this.ColAcc.Name = "ColAcc";
            this.ColAcc.ReadOnly = true;
            this.ColAcc.Visible = false;
            // 
            // ColCC
            // 
            this.ColCC.DataPropertyName = "CCNumber";
            this.ColCC.HeaderText = "CCNumber";
            this.ColCC.Name = "ColCC";
            this.ColCC.ReadOnly = true;
            this.ColCC.Visible = false;
            // 
            // ColAddress
            // 
            this.ColAddress.DataPropertyName = "Address";
            this.ColAddress.HeaderText = "Address";
            this.ColAddress.Name = "ColAddress";
            this.ColAddress.ReadOnly = true;
            // 
            // ColDeleted
            // 
            this.ColDeleted.DataPropertyName = "Deleted";
            this.ColDeleted.HeaderText = "Deleted";
            this.ColDeleted.Name = "ColDeleted";
            this.ColDeleted.ReadOnly = true;
            this.ColDeleted.Visible = false;
            // 
            // memberInformationBindingSource
            // 
            this.memberInformationBindingSource.DataSource = typeof(RestaurantKuUI.SupportThings.MemberInformation);
            // 
            // ManageMemberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(841, 514);
            this.Controls.Add(this.DataGridM);
            this.Controls.Add(this.JoinDateTime);
            this.Controls.Add(this.AddressText);
            this.Controls.Add(this.CellNumberLabel);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.DeleteDataButton);
            this.Controls.Add(this.UpdateDataButton);
            this.Controls.Add(this.InsertDataButton);
            this.Controls.Add(this.MemberEmailText);
            this.Controls.Add(this.CellNumberText);
            this.Controls.Add(this.MemberNameText);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.MemberPasswordText);
            this.Controls.Add(this.MemberIdTextBox);
            this.Controls.Add(this.AddressLabel);
            this.Controls.Add(this.MemberJoinDateLabel);
            this.Controls.Add(this.MemberEmailLabel);
            this.Controls.Add(this.MemberNameLabel);
            this.Controls.Add(this.MemberIdLabel);
            this.Controls.Add(this.ManageMemberTitleLabel);
            this.Font = new System.Drawing.Font("Arial", 8.25F);
            this.Name = "ManageMemberForm";
            this.Text = "Manage Member Form";
            this.Load += new System.EventHandler(this.ManageMemberForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberInformationBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ManageMemberTitleLabel;
        private System.Windows.Forms.Label MemberIdLabel;
        private System.Windows.Forms.Label MemberNameLabel;
        private System.Windows.Forms.Label MemberEmailLabel;
        private System.Windows.Forms.Label MemberJoinDateLabel;
        private System.Windows.Forms.TextBox MemberIdTextBox;
        private System.Windows.Forms.TextBox MemberPasswordText;
        private System.Windows.Forms.TextBox MemberNameText;
        private System.Windows.Forms.TextBox MemberEmailText;
        private System.Windows.Forms.Button InsertDataButton;
        private System.Windows.Forms.Button UpdateDataButton;
        private System.Windows.Forms.Button DeleteDataButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label CellNumberLabel;
        private System.Windows.Forms.TextBox CellNumberText;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.RichTextBox AddressText;
        private System.Windows.Forms.DateTimePicker JoinDateTime;
        private System.Windows.Forms.DataGridView DataGridM;
        private System.Windows.Forms.BindingSource memberInformationBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColHP;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColJoin;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColBankName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAcc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDeleted;
    }
}