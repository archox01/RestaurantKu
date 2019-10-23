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
            this.EmpDataGrid = new System.Windows.Forms.DataGridView();
            this.restaurantEmployeeModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EmployeeEmailTextBox = new System.Windows.Forms.TextBox();
            this.EmployeePasswordTextBox = new System.Windows.Forms.TextBox();
            this.EmployeeHandphoneTextBox = new System.Windows.Forms.TextBox();
            this.EmployeeNameTextBox = new System.Windows.Forms.TextBox();
            this.InsertDataButton = new System.Windows.Forms.Button();
            this.UpdateDataButton = new System.Windows.Forms.Button();
            this.DeleteDataButton = new System.Windows.Forms.Button();
            this.EmployeePositionValue = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.EmpDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantEmployeeModelBindingSource)).BeginInit();
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
            this.EmployeeNameLabel.Location = new System.Drawing.Point(256, 373);
            this.EmployeeNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EmployeeNameLabel.Name = "EmployeeNameLabel";
            this.EmployeeNameLabel.Size = new System.Drawing.Size(51, 20);
            this.EmployeeNameLabel.TabIndex = 1;
            this.EmployeeNameLabel.Text = "Name";
            // 
            // EmployeeHandphoneLabel
            // 
            this.EmployeeHandphoneLabel.AutoSize = true;
            this.EmployeeHandphoneLabel.Location = new System.Drawing.Point(256, 407);
            this.EmployeeHandphoneLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EmployeeHandphoneLabel.Name = "EmployeeHandphoneLabel";
            this.EmployeeHandphoneLabel.Size = new System.Drawing.Size(93, 20);
            this.EmployeeHandphoneLabel.TabIndex = 2;
            this.EmployeeHandphoneLabel.Text = "Handphone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(256, 337);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password";
            // 
            // EmployeePositionLabel
            // 
            this.EmployeePositionLabel.AutoSize = true;
            this.EmployeePositionLabel.Location = new System.Drawing.Point(256, 442);
            this.EmployeePositionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EmployeePositionLabel.Name = "EmployeePositionLabel";
            this.EmployeePositionLabel.Size = new System.Drawing.Size(65, 20);
            this.EmployeePositionLabel.TabIndex = 4;
            this.EmployeePositionLabel.Text = "Position";
            // 
            // EmployeeEmailLabel
            // 
            this.EmployeeEmailLabel.AutoSize = true;
            this.EmployeeEmailLabel.Location = new System.Drawing.Point(256, 300);
            this.EmployeeEmailLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EmployeeEmailLabel.Name = "EmployeeEmailLabel";
            this.EmployeeEmailLabel.Size = new System.Drawing.Size(48, 20);
            this.EmployeeEmailLabel.TabIndex = 5;
            this.EmployeeEmailLabel.Text = "Email";
            // 
            // EmpDataGrid
            // 
            this.EmpDataGrid.BackgroundColor = System.Drawing.Color.Silver;
            this.EmpDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmpDataGrid.Location = new System.Drawing.Point(26, 80);
            this.EmpDataGrid.Margin = new System.Windows.Forms.Padding(2);
            this.EmpDataGrid.MultiSelect = false;
            this.EmpDataGrid.Name = "EmpDataGrid";
            this.EmpDataGrid.ReadOnly = true;
            this.EmpDataGrid.RowTemplate.Height = 28;
            this.EmpDataGrid.Size = new System.Drawing.Size(852, 183);
            this.EmpDataGrid.TabIndex = 6;
            // 
            // EmployeeEmailTextBox
            // 
            this.EmployeeEmailTextBox.Location = new System.Drawing.Point(359, 296);
            this.EmployeeEmailTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.EmployeeEmailTextBox.Name = "EmployeeEmailTextBox";
            this.EmployeeEmailTextBox.Size = new System.Drawing.Size(135, 26);
            this.EmployeeEmailTextBox.TabIndex = 7;
            // 
            // EmployeePasswordTextBox
            // 
            this.EmployeePasswordTextBox.Location = new System.Drawing.Point(359, 333);
            this.EmployeePasswordTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.EmployeePasswordTextBox.Name = "EmployeePasswordTextBox";
            this.EmployeePasswordTextBox.Size = new System.Drawing.Size(135, 26);
            this.EmployeePasswordTextBox.TabIndex = 8;
            // 
            // EmployeeHandphoneTextBox
            // 
            this.EmployeeHandphoneTextBox.Location = new System.Drawing.Point(359, 403);
            this.EmployeeHandphoneTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.EmployeeHandphoneTextBox.Name = "EmployeeHandphoneTextBox";
            this.EmployeeHandphoneTextBox.Size = new System.Drawing.Size(135, 26);
            this.EmployeeHandphoneTextBox.TabIndex = 10;
            // 
            // EmployeeNameTextBox
            // 
            this.EmployeeNameTextBox.Location = new System.Drawing.Point(359, 368);
            this.EmployeeNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.EmployeeNameTextBox.Name = "EmployeeNameTextBox";
            this.EmployeeNameTextBox.Size = new System.Drawing.Size(135, 26);
            this.EmployeeNameTextBox.TabIndex = 9;
            // 
            // InsertDataButton
            // 
            this.InsertDataButton.Location = new System.Drawing.Point(538, 296);
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
            this.UpdateDataButton.Location = new System.Drawing.Point(538, 356);
            this.UpdateDataButton.Margin = new System.Windows.Forms.Padding(2);
            this.UpdateDataButton.Name = "UpdateDataButton";
            this.UpdateDataButton.Size = new System.Drawing.Size(77, 38);
            this.UpdateDataButton.TabIndex = 13;
            this.UpdateDataButton.Text = "Update";
            this.UpdateDataButton.UseVisualStyleBackColor = true;
            // 
            // DeleteDataButton
            // 
            this.DeleteDataButton.Location = new System.Drawing.Point(538, 407);
            this.DeleteDataButton.Margin = new System.Windows.Forms.Padding(2);
            this.DeleteDataButton.Name = "DeleteDataButton";
            this.DeleteDataButton.Size = new System.Drawing.Size(77, 38);
            this.DeleteDataButton.TabIndex = 14;
            this.DeleteDataButton.Text = "Delete";
            this.DeleteDataButton.UseVisualStyleBackColor = true;
            // 
            // EmployeePositionValue
            // 
            this.EmployeePositionValue.FormattingEnabled = true;
            this.EmployeePositionValue.Items.AddRange(new object[] {
            "cashier",
            "chef"});
            this.EmployeePositionValue.Location = new System.Drawing.Point(359, 442);
            this.EmployeePositionValue.Name = "EmployeePositionValue";
            this.EmployeePositionValue.Size = new System.Drawing.Size(135, 28);
            this.EmployeePositionValue.TabIndex = 15;
            // 
            // ManageEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(910, 495);
            this.Controls.Add(this.EmployeePositionValue);
            this.Controls.Add(this.DeleteDataButton);
            this.Controls.Add(this.UpdateDataButton);
            this.Controls.Add(this.InsertDataButton);
            this.Controls.Add(this.EmployeeHandphoneTextBox);
            this.Controls.Add(this.EmployeeNameTextBox);
            this.Controls.Add(this.EmployeePasswordTextBox);
            this.Controls.Add(this.EmployeeEmailTextBox);
            this.Controls.Add(this.EmpDataGrid);
            this.Controls.Add(this.EmployeeEmailLabel);
            this.Controls.Add(this.EmployeePositionLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EmployeeHandphoneLabel);
            this.Controls.Add(this.EmployeeNameLabel);
            this.Controls.Add(this.ManageEmployeeTitleLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManageEmployeeForm";
            this.Text = "ManageEmployeeForm";
            this.Load += new System.EventHandler(this.ManageEmployeeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EmpDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantEmployeeModelBindingSource)).EndInit();
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
        private System.Windows.Forms.DataGridView EmpDataGrid;
        private System.Windows.Forms.TextBox EmployeeEmailTextBox;
        private System.Windows.Forms.TextBox EmployeePasswordTextBox;
        private System.Windows.Forms.TextBox EmployeeHandphoneTextBox;
        private System.Windows.Forms.TextBox EmployeeNameTextBox;
        private System.Windows.Forms.Button InsertDataButton;
        private System.Windows.Forms.Button UpdateDataButton;
        private System.Windows.Forms.Button DeleteDataButton;
        private System.Windows.Forms.ComboBox EmployeePositionValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeePasswordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeHandPhoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeePositionDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource restaurantEmployeeModelBindingSource;
    }
}