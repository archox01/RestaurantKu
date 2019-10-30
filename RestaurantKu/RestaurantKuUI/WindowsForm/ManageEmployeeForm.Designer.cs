namespace RestaurantKuUI
{
    partial class ManageEmployeeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageEmployeeForm));
            this.ManageEmployeeTitleLabel = new System.Windows.Forms.Label();
            this.EmployeeNameLabel = new System.Windows.Forms.Label();
            this.EmployeeHandphoneLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.EmployeePositionLabel = new System.Windows.Forms.Label();
            this.EmployeeEmailLabel = new System.Windows.Forms.Label();
            this.EmployeeEmailTextBox = new System.Windows.Forms.TextBox();
            this.EmployeePasswordTextBox = new System.Windows.Forms.TextBox();
            this.EmployeeHandphoneTextBox = new System.Windows.Forms.TextBox();
            this.EmployeeNameTextBox = new System.Windows.Forms.TextBox();
            this.InsertDataButton = new System.Windows.Forms.Button();
            this.UpdateDataButton = new System.Windows.Forms.Button();
            this.DeleteDataButton = new System.Windows.Forms.Button();
            this.EmployeePositionValue = new System.Windows.Forms.ComboBox();
            this.EmployeeIdTextBox = new System.Windows.Forms.TextBox();
            this.CariDataButton = new System.Windows.Forms.Button();
            this.EmployeeIdLabel = new System.Windows.Forms.Label();
            this.EmpDataGrid = new System.Windows.Forms.DataGridView();
            this.employeeInformationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ColId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.EmpDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeInformationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ManageEmployeeTitleLabel
            // 
            this.ManageEmployeeTitleLabel.AutoSize = true;
            this.ManageEmployeeTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.ManageEmployeeTitleLabel.Location = new System.Drawing.Point(215, 9);
            this.ManageEmployeeTitleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ManageEmployeeTitleLabel.Name = "ManageEmployeeTitleLabel";
            this.ManageEmployeeTitleLabel.Size = new System.Drawing.Size(483, 52);
            this.ManageEmployeeTitleLabel.TabIndex = 0;
            this.ManageEmployeeTitleLabel.Text = "Employee Management";
            // 
            // EmployeeNameLabel
            // 
            this.EmployeeNameLabel.AutoSize = true;
            this.EmployeeNameLabel.Location = new System.Drawing.Point(95, 359);
            this.EmployeeNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EmployeeNameLabel.Name = "EmployeeNameLabel";
            this.EmployeeNameLabel.Size = new System.Drawing.Size(51, 20);
            this.EmployeeNameLabel.TabIndex = 1;
            this.EmployeeNameLabel.Text = "Name";
            // 
            // EmployeeHandphoneLabel
            // 
            this.EmployeeHandphoneLabel.AutoSize = true;
            this.EmployeeHandphoneLabel.Location = new System.Drawing.Point(95, 393);
            this.EmployeeHandphoneLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EmployeeHandphoneLabel.Name = "EmployeeHandphoneLabel";
            this.EmployeeHandphoneLabel.Size = new System.Drawing.Size(93, 20);
            this.EmployeeHandphoneLabel.TabIndex = 2;
            this.EmployeeHandphoneLabel.Text = "Handphone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 323);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password";
            // 
            // EmployeePositionLabel
            // 
            this.EmployeePositionLabel.AutoSize = true;
            this.EmployeePositionLabel.Location = new System.Drawing.Point(95, 428);
            this.EmployeePositionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EmployeePositionLabel.Name = "EmployeePositionLabel";
            this.EmployeePositionLabel.Size = new System.Drawing.Size(65, 20);
            this.EmployeePositionLabel.TabIndex = 4;
            this.EmployeePositionLabel.Text = "Position";
            // 
            // EmployeeEmailLabel
            // 
            this.EmployeeEmailLabel.AutoSize = true;
            this.EmployeeEmailLabel.Location = new System.Drawing.Point(95, 286);
            this.EmployeeEmailLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EmployeeEmailLabel.Name = "EmployeeEmailLabel";
            this.EmployeeEmailLabel.Size = new System.Drawing.Size(48, 20);
            this.EmployeeEmailLabel.TabIndex = 5;
            this.EmployeeEmailLabel.Text = "Email";
            // 
            // EmployeeEmailTextBox
            // 
            this.EmployeeEmailTextBox.Location = new System.Drawing.Point(198, 282);
            this.EmployeeEmailTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.EmployeeEmailTextBox.Name = "EmployeeEmailTextBox";
            this.EmployeeEmailTextBox.Size = new System.Drawing.Size(135, 26);
            this.EmployeeEmailTextBox.TabIndex = 7;
            this.EmployeeEmailTextBox.Validated += new System.EventHandler(this.EmployeeEmailTextBox_Validated);
            // 
            // EmployeePasswordTextBox
            // 
            this.EmployeePasswordTextBox.Location = new System.Drawing.Point(198, 319);
            this.EmployeePasswordTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.EmployeePasswordTextBox.Name = "EmployeePasswordTextBox";
            this.EmployeePasswordTextBox.PasswordChar = '*';
            this.EmployeePasswordTextBox.Size = new System.Drawing.Size(135, 26);
            this.EmployeePasswordTextBox.TabIndex = 8;
            this.EmployeePasswordTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.EmployeePasswordTextBox_Validating);
            // 
            // EmployeeHandphoneTextBox
            // 
            this.EmployeeHandphoneTextBox.Location = new System.Drawing.Point(198, 389);
            this.EmployeeHandphoneTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.EmployeeHandphoneTextBox.Name = "EmployeeHandphoneTextBox";
            this.EmployeeHandphoneTextBox.Size = new System.Drawing.Size(135, 26);
            this.EmployeeHandphoneTextBox.TabIndex = 10;
            this.EmployeeHandphoneTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EmployeeHandphoneTextBox_KeyPress);
            this.EmployeeHandphoneTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.EmployeeHandphoneTextBox_Validating);
            // 
            // EmployeeNameTextBox
            // 
            this.EmployeeNameTextBox.Location = new System.Drawing.Point(198, 354);
            this.EmployeeNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.EmployeeNameTextBox.Name = "EmployeeNameTextBox";
            this.EmployeeNameTextBox.Size = new System.Drawing.Size(135, 26);
            this.EmployeeNameTextBox.TabIndex = 9;
            // 
            // InsertDataButton
            // 
            this.InsertDataButton.Location = new System.Drawing.Point(356, 313);
            this.InsertDataButton.Margin = new System.Windows.Forms.Padding(2);
            this.InsertDataButton.Name = "InsertDataButton";
            this.InsertDataButton.Size = new System.Drawing.Size(77, 38);
            this.InsertDataButton.TabIndex = 12;
            this.InsertDataButton.Text = "Insert";
            this.InsertDataButton.UseVisualStyleBackColor = true;
            this.InsertDataButton.Click += new System.EventHandler(this.InsertDataButton_Click);
            // 
            // UpdateDataButton
            // 
            this.UpdateDataButton.Location = new System.Drawing.Point(356, 361);
            this.UpdateDataButton.Margin = new System.Windows.Forms.Padding(2);
            this.UpdateDataButton.Name = "UpdateDataButton";
            this.UpdateDataButton.Size = new System.Drawing.Size(77, 38);
            this.UpdateDataButton.TabIndex = 13;
            this.UpdateDataButton.Text = "Update";
            this.UpdateDataButton.UseVisualStyleBackColor = true;
            this.UpdateDataButton.Click += new System.EventHandler(this.UpdateDataButton_Click);
            // 
            // DeleteDataButton
            // 
            this.DeleteDataButton.Location = new System.Drawing.Point(356, 410);
            this.DeleteDataButton.Margin = new System.Windows.Forms.Padding(2);
            this.DeleteDataButton.Name = "DeleteDataButton";
            this.DeleteDataButton.Size = new System.Drawing.Size(77, 38);
            this.DeleteDataButton.TabIndex = 14;
            this.DeleteDataButton.Text = "Delete";
            this.DeleteDataButton.UseVisualStyleBackColor = true;
            this.DeleteDataButton.Click += new System.EventHandler(this.DeleteDataButton_Click);
            // 
            // EmployeePositionValue
            // 
            this.EmployeePositionValue.FormattingEnabled = true;
            this.EmployeePositionValue.Location = new System.Drawing.Point(198, 428);
            this.EmployeePositionValue.Name = "EmployeePositionValue";
            this.EmployeePositionValue.Size = new System.Drawing.Size(135, 28);
            this.EmployeePositionValue.TabIndex = 15;
            // 
            // EmployeeIdTextBox
            // 
            this.EmployeeIdTextBox.Location = new System.Drawing.Point(587, 353);
            this.EmployeeIdTextBox.MaxLength = 10;
            this.EmployeeIdTextBox.Name = "EmployeeIdTextBox";
            this.EmployeeIdTextBox.Size = new System.Drawing.Size(191, 26);
            this.EmployeeIdTextBox.TabIndex = 16;
            // 
            // CariDataButton
            // 
            this.CariDataButton.Location = new System.Drawing.Point(793, 352);
            this.CariDataButton.Name = "CariDataButton";
            this.CariDataButton.Size = new System.Drawing.Size(75, 28);
            this.CariDataButton.TabIndex = 17;
            this.CariDataButton.Text = "Cari";
            this.CariDataButton.UseVisualStyleBackColor = true;
            this.CariDataButton.Click += new System.EventHandler(this.CariDataButton_Click);
            // 
            // EmployeeIdLabel
            // 
            this.EmployeeIdLabel.AutoSize = true;
            this.EmployeeIdLabel.Location = new System.Drawing.Point(484, 357);
            this.EmployeeIdLabel.Name = "EmployeeIdLabel";
            this.EmployeeIdLabel.Size = new System.Drawing.Size(97, 20);
            this.EmployeeIdLabel.TabIndex = 18;
            this.EmployeeIdLabel.Text = "Employee Id";
            // 
            // EmpDataGrid
            // 
            this.EmpDataGrid.AutoGenerateColumns = false;
            this.EmpDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmpDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColId,
            this.ColName,
            this.ColEmail,
            this.ColPassword,
            this.ColNumber,
            this.ColPosition});
            this.EmpDataGrid.DataSource = this.employeeInformationBindingSource;
            this.EmpDataGrid.Location = new System.Drawing.Point(12, 64);
            this.EmpDataGrid.Name = "EmpDataGrid";
            this.EmpDataGrid.RowTemplate.Height = 28;
            this.EmpDataGrid.Size = new System.Drawing.Size(884, 200);
            this.EmpDataGrid.TabIndex = 19;
            this.EmpDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EmpDataGrid_CellContentClick_1);
            // 
            // employeeInformationBindingSource
            // 
            this.employeeInformationBindingSource.DataSource = typeof(RestaurantKuUI.SupportThings.EmployeeInformation);
            // 
            // ColId
            // 
            this.ColId.DataPropertyName = "EmployeeId";
            this.ColId.HeaderText = "Id";
            this.ColId.Name = "ColId";
            // 
            // ColName
            // 
            this.ColName.DataPropertyName = "EmployeeName";
            this.ColName.HeaderText = "Name";
            this.ColName.MaxInputLength = 100;
            this.ColName.Name = "ColName";
            // 
            // ColEmail
            // 
            this.ColEmail.DataPropertyName = "EmployeeEmail";
            this.ColEmail.HeaderText = "Email";
            this.ColEmail.Name = "ColEmail";
            // 
            // ColPassword
            // 
            this.ColPassword.DataPropertyName = "EmployeePassword";
            this.ColPassword.HeaderText = "Password";
            this.ColPassword.Name = "ColPassword";
            this.ColPassword.Visible = false;
            // 
            // ColNumber
            // 
            this.ColNumber.DataPropertyName = "EmployeeeHandPhone";
            this.ColNumber.HeaderText = "HandPhone";
            this.ColNumber.Name = "ColNumber";
            // 
            // ColPosition
            // 
            this.ColPosition.DataPropertyName = "EmployeePosition";
            this.ColPosition.HeaderText = "Position";
            this.ColPosition.Name = "ColPosition";
            // 
            // ManageEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(908, 464);
            this.Controls.Add(this.EmpDataGrid);
            this.Controls.Add(this.EmployeeIdLabel);
            this.Controls.Add(this.CariDataButton);
            this.Controls.Add(this.EmployeeIdTextBox);
            this.Controls.Add(this.EmployeePositionValue);
            this.Controls.Add(this.DeleteDataButton);
            this.Controls.Add(this.UpdateDataButton);
            this.Controls.Add(this.InsertDataButton);
            this.Controls.Add(this.EmployeeHandphoneTextBox);
            this.Controls.Add(this.EmployeeNameTextBox);
            this.Controls.Add(this.EmployeePasswordTextBox);
            this.Controls.Add(this.EmployeeEmailTextBox);
            this.Controls.Add(this.EmployeeEmailLabel);
            this.Controls.Add(this.EmployeePositionLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EmployeeHandphoneLabel);
            this.Controls.Add(this.EmployeeNameLabel);
            this.Controls.Add(this.ManageEmployeeTitleLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(930, 520);
            this.Name = "ManageEmployeeForm";
            this.Text = "ManageEmployeeForm";
            this.Load += new System.EventHandler(this.ManageEmployeeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EmpDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeInformationBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ManageEmployeeTitleLabel;
        private System.Windows.Forms.Label EmployeeNameLabel;
        private System.Windows.Forms.Label EmployeeHandphoneLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label EmployeePositionLabel;
        private System.Windows.Forms.Label EmployeeEmailLabel;
        private System.Windows.Forms.TextBox EmployeeEmailTextBox;
        private System.Windows.Forms.TextBox EmployeePasswordTextBox;
        private System.Windows.Forms.TextBox EmployeeHandphoneTextBox;
        private System.Windows.Forms.TextBox EmployeeNameTextBox;
        private System.Windows.Forms.Button InsertDataButton;
        private System.Windows.Forms.Button UpdateDataButton;
        private System.Windows.Forms.Button DeleteDataButton;
        private System.Windows.Forms.ComboBox EmployeePositionValue;

        private System.Windows.Forms.TextBox EmployeeIdTextBox;
        private System.Windows.Forms.Button CariDataButton;
        private System.Windows.Forms.Label EmployeeIdLabel;
        private System.Windows.Forms.DataGridView EmpDataGrid;

        private System.Windows.Forms.BindingSource employeeInformationBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPosition;
    }
}