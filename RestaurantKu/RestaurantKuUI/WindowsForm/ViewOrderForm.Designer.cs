namespace RestaurantKuUI
{
    partial class ViewOrderForm
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
            this.OrderIdLabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MenuNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QtyMenuColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusMenuColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HargaMenuColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.Location = new System.Drawing.Point(395, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "View Order";
            // 
            // OrderIdLabel
            // 
            this.OrderIdLabel.AutoSize = true;
            this.OrderIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.OrderIdLabel.Location = new System.Drawing.Point(267, 131);
            this.OrderIdLabel.Name = "OrderIdLabel";
            this.OrderIdLabel.Size = new System.Drawing.Size(86, 25);
            this.OrderIdLabel.TabIndex = 1;
            this.OrderIdLabel.Text = "ID Order";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(402, 131);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(235, 28);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.Text = " ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MenuNameColumn,
            this.QtyMenuColumn,
            this.StatusMenuColumn,
            this.HargaMenuColumn});
            this.dataGridView1.Location = new System.Drawing.Point(86, 189);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(793, 198);
            this.dataGridView1.TabIndex = 3;
            // 
            // MenuNameColumn
            // 
            this.MenuNameColumn.HeaderText = "Menu";
            this.MenuNameColumn.Name = "MenuNameColumn";
            // 
            // QtyMenuColumn
            // 
            this.QtyMenuColumn.HeaderText = "Kuantitas";
            this.QtyMenuColumn.Name = "QtyMenuColumn";
            // 
            // StatusMenuColumn
            // 
            this.StatusMenuColumn.HeaderText = "Status";
            this.StatusMenuColumn.Name = "StatusMenuColumn";
            // 
            // HargaMenuColumn
            // 
            this.HargaMenuColumn.HeaderText = "Harga";
            this.HargaMenuColumn.Name = "HargaMenuColumn";
            this.HargaMenuColumn.Visible = false;
            // 
            // ViewOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(970, 671);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.OrderIdLabel);
            this.Controls.Add(this.label1);
            this.Name = "ViewOrderForm";
            this.Text = "ViewOrderForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label OrderIdLabel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MenuNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn QtyMenuColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusMenuColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn HargaMenuColumn;
    }
}