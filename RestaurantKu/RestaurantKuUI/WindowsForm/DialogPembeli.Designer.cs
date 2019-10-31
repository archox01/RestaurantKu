namespace RestaurantKuUI.WindowsForm
{
    partial class DialogPembeli
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TB = new System.Windows.Forms.TextBox();
            this.memberInformationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.memberIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.handPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.joinDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberInformationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.memberIdDataGridViewTextBoxColumn,
            this.memberNameDataGridViewTextBoxColumn,
            this.memberEmailDataGridViewTextBoxColumn,
            this.handPhoneDataGridViewTextBoxColumn,
            this.joinDateDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.memberInformationBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(29, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1135, 322);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // TB
            // 
            this.TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.TB.ForeColor = System.Drawing.Color.Silver;
            this.TB.Location = new System.Drawing.Point(367, 35);
            this.TB.Name = "TB";
            this.TB.Size = new System.Drawing.Size(505, 39);
            this.TB.TabIndex = 1;
            this.TB.Text = "Masukkan Email / Nama";
            this.TB.TextChanged += new System.EventHandler(this.TB_TextChanged);
            this.TB.Enter += new System.EventHandler(this.TB_Enter);
            this.TB.Leave += new System.EventHandler(this.TB_Leave);
            // 
            // memberInformationBindingSource
            // 
            this.memberInformationBindingSource.DataSource = typeof(RestaurantKuUI.SupportThings.MemberInformation);
            // 
            // memberIdDataGridViewTextBoxColumn
            // 
            this.memberIdDataGridViewTextBoxColumn.DataPropertyName = "MemberId";
            this.memberIdDataGridViewTextBoxColumn.HeaderText = "MemberId";
            this.memberIdDataGridViewTextBoxColumn.Name = "memberIdDataGridViewTextBoxColumn";
            // 
            // memberNameDataGridViewTextBoxColumn
            // 
            this.memberNameDataGridViewTextBoxColumn.DataPropertyName = "MemberName";
            this.memberNameDataGridViewTextBoxColumn.HeaderText = "MemberName";
            this.memberNameDataGridViewTextBoxColumn.Name = "memberNameDataGridViewTextBoxColumn";
            // 
            // memberEmailDataGridViewTextBoxColumn
            // 
            this.memberEmailDataGridViewTextBoxColumn.DataPropertyName = "MemberEmail";
            this.memberEmailDataGridViewTextBoxColumn.HeaderText = "MemberEmail";
            this.memberEmailDataGridViewTextBoxColumn.Name = "memberEmailDataGridViewTextBoxColumn";
            // 
            // handPhoneDataGridViewTextBoxColumn
            // 
            this.handPhoneDataGridViewTextBoxColumn.DataPropertyName = "HandPhone";
            this.handPhoneDataGridViewTextBoxColumn.HeaderText = "HandPhone";
            this.handPhoneDataGridViewTextBoxColumn.Name = "handPhoneDataGridViewTextBoxColumn";
            // 
            // joinDateDataGridViewTextBoxColumn
            // 
            this.joinDateDataGridViewTextBoxColumn.DataPropertyName = "JoinDate";
            this.joinDateDataGridViewTextBoxColumn.HeaderText = "JoinDate";
            this.joinDateDataGridViewTextBoxColumn.Name = "joinDateDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // DialogPembeli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 430);
            this.Controls.Add(this.TB);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DialogPembeli";
            this.Text = "DialogPembeli";
            this.Load += new System.EventHandler(this.DialogPembeli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberInformationBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox TB;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn handPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn joinDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource memberInformationBindingSource;
    }
}