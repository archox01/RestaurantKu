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
            this.ManageMemberTitleLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MemberIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MemberNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MemberEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MemberJoinDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MemberPasswordColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MemberCCNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MemberBankNumberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MemberIdLabel = new System.Windows.Forms.Label();
            this.MemberNameLabel = new System.Windows.Forms.Label();
            this.MemberEmailLabel = new System.Windows.Forms.Label();
            this.MemberJoinDateLabel = new System.Windows.Forms.Label();
            this.MemberIdTextBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.InsertDataButton = new System.Windows.Forms.Button();
            this.UpdateDataButton = new System.Windows.Forms.Button();
            this.DeleteDataButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ManageMemberTitleLabel
            // 
            this.ManageMemberTitleLabel.AutoSize = true;
            this.ManageMemberTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.ManageMemberTitleLabel.Location = new System.Drawing.Point(564, 44);
            this.ManageMemberTitleLabel.Name = "ManageMemberTitleLabel";
            this.ManageMemberTitleLabel.Size = new System.Drawing.Size(450, 52);
            this.ManageMemberTitleLabel.TabIndex = 1;
            this.ManageMemberTitleLabel.Text = "Member Management";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MemberIdColumn,
            this.MemberNameColumn,
            this.MemberEmail,
            this.MemberJoinDate,
            this.MemberPasswordColumn,
            this.MemberCCNumber,
            this.MemberBankNumberColumn});
            this.dataGridView1.Location = new System.Drawing.Point(42, 116);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1411, 498);
            this.dataGridView1.TabIndex = 2;
            // 
            // MemberIdColumn
            // 
            this.MemberIdColumn.HeaderText = "Member Id";
            this.MemberIdColumn.Name = "MemberIdColumn";
            // 
            // MemberNameColumn
            // 
            this.MemberNameColumn.HeaderText = "Name";
            this.MemberNameColumn.Name = "MemberNameColumn";
            // 
            // MemberEmail
            // 
            this.MemberEmail.HeaderText = "Email";
            this.MemberEmail.Name = "MemberEmail";
            // 
            // MemberJoinDate
            // 
            this.MemberJoinDate.HeaderText = "Join Date";
            this.MemberJoinDate.Name = "MemberJoinDate";
            // 
            // MemberPasswordColumn
            // 
            this.MemberPasswordColumn.HeaderText = "Password";
            this.MemberPasswordColumn.Name = "MemberPasswordColumn";
            this.MemberPasswordColumn.Visible = false;
            // 
            // MemberCCNumber
            // 
            this.MemberCCNumber.HeaderText = "MemberCCNumber";
            this.MemberCCNumber.Name = "MemberCCNumber";
            this.MemberCCNumber.Visible = false;
            // 
            // MemberBankNumberColumn
            // 
            this.MemberBankNumberColumn.HeaderText = "MemberBank";
            this.MemberBankNumberColumn.Name = "MemberBankNumberColumn";
            this.MemberBankNumberColumn.Visible = false;
            // 
            // MemberIdLabel
            // 
            this.MemberIdLabel.AutoSize = true;
            this.MemberIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.MemberIdLabel.Location = new System.Drawing.Point(337, 654);
            this.MemberIdLabel.Name = "MemberIdLabel";
            this.MemberIdLabel.Size = new System.Drawing.Size(208, 46);
            this.MemberIdLabel.TabIndex = 3;
            this.MemberIdLabel.Text = "Member Id";
            // 
            // MemberNameLabel
            // 
            this.MemberNameLabel.AutoSize = true;
            this.MemberNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.MemberNameLabel.Location = new System.Drawing.Point(337, 724);
            this.MemberNameLabel.Name = "MemberNameLabel";
            this.MemberNameLabel.Size = new System.Drawing.Size(126, 46);
            this.MemberNameLabel.TabIndex = 4;
            this.MemberNameLabel.Text = "Name";
            // 
            // MemberEmailLabel
            // 
            this.MemberEmailLabel.AutoSize = true;
            this.MemberEmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.MemberEmailLabel.Location = new System.Drawing.Point(337, 795);
            this.MemberEmailLabel.Name = "MemberEmailLabel";
            this.MemberEmailLabel.Size = new System.Drawing.Size(120, 46);
            this.MemberEmailLabel.TabIndex = 5;
            this.MemberEmailLabel.Text = "Email";
            // 
            // MemberJoinDateLabel
            // 
            this.MemberJoinDateLabel.AutoSize = true;
            this.MemberJoinDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.MemberJoinDateLabel.Location = new System.Drawing.Point(337, 852);
            this.MemberJoinDateLabel.Name = "MemberJoinDateLabel";
            this.MemberJoinDateLabel.Size = new System.Drawing.Size(189, 46);
            this.MemberJoinDateLabel.TabIndex = 6;
            this.MemberJoinDateLabel.Text = "Join Date";
            // 
            // MemberIdTextBox
            // 
            this.MemberIdTextBox.Location = new System.Drawing.Point(596, 654);
            this.MemberIdTextBox.Name = "MemberIdTextBox";
            this.MemberIdTextBox.Size = new System.Drawing.Size(262, 39);
            this.MemberIdTextBox.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(596, 852);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(262, 39);
            this.textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(596, 724);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(262, 39);
            this.textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(596, 795);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(262, 39);
            this.textBox3.TabIndex = 9;
            // 
            // InsertDataButton
            // 
            this.InsertDataButton.Location = new System.Drawing.Point(902, 654);
            this.InsertDataButton.Name = "InsertDataButton";
            this.InsertDataButton.Size = new System.Drawing.Size(132, 55);
            this.InsertDataButton.TabIndex = 10;
            this.InsertDataButton.Text = "Insert";
            this.InsertDataButton.UseVisualStyleBackColor = true;
            // 
            // UpdateDataButton
            // 
            this.UpdateDataButton.Location = new System.Drawing.Point(902, 745);
            this.UpdateDataButton.Name = "UpdateDataButton";
            this.UpdateDataButton.Size = new System.Drawing.Size(132, 55);
            this.UpdateDataButton.TabIndex = 11;
            this.UpdateDataButton.Text = "Update";
            this.UpdateDataButton.UseVisualStyleBackColor = true;
            // 
            // DeleteDataButton
            // 
            this.DeleteDataButton.Location = new System.Drawing.Point(902, 836);
            this.DeleteDataButton.Name = "DeleteDataButton";
            this.DeleteDataButton.Size = new System.Drawing.Size(132, 55);
            this.DeleteDataButton.TabIndex = 12;
            this.DeleteDataButton.Text = "Delete";
            this.DeleteDataButton.UseVisualStyleBackColor = true;
            // 
            // ManageMemberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(1519, 945);
            this.Controls.Add(this.DeleteDataButton);
            this.Controls.Add(this.UpdateDataButton);
            this.Controls.Add(this.InsertDataButton);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.MemberIdTextBox);
            this.Controls.Add(this.MemberJoinDateLabel);
            this.Controls.Add(this.MemberEmailLabel);
            this.Controls.Add(this.MemberNameLabel);
            this.Controls.Add(this.MemberIdLabel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ManageMemberTitleLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "ManageMemberForm";
            this.Text = "Manage Member Form";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ManageMemberTitleLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MemberIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MemberNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MemberEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn MemberJoinDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn MemberPasswordColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MemberCCNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn MemberBankNumberColumn;
        private System.Windows.Forms.Label MemberIdLabel;
        private System.Windows.Forms.Label MemberNameLabel;
        private System.Windows.Forms.Label MemberEmailLabel;
        private System.Windows.Forms.Label MemberJoinDateLabel;
        private System.Windows.Forms.TextBox MemberIdTextBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button InsertDataButton;
        private System.Windows.Forms.Button UpdateDataButton;
        private System.Windows.Forms.Button DeleteDataButton;
    }
}