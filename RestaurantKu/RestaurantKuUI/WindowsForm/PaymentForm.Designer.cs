namespace RestaurantKuUI
{
    partial class PaymentForm
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
            this.PaymentFormTitleLabel = new System.Windows.Forms.Label();
            this.OrderIdLabel = new System.Windows.Forms.Label();
            this.OrderIdComboBox = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MenuNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QtyMenuColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HargaMenuColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalHargaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentTypeLabel = new System.Windows.Forms.Label();
            this.NomorRekeningLabel = new System.Windows.Forms.Label();
            this.NamaBankLabel = new System.Windows.Forms.Label();
            this.TotalHargaLabel = new System.Windows.Forms.Label();
            this.PembayaranViaTextBox = new System.Windows.Forms.ComboBox();
            this.NamaBankComboBox = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.NomorHargaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // PaymentFormTitleLabel
            // 
            this.PaymentFormTitleLabel.AutoSize = true;
            this.PaymentFormTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.PaymentFormTitleLabel.Location = new System.Drawing.Point(294, 42);
            this.PaymentFormTitleLabel.Name = "PaymentFormTitleLabel";
            this.PaymentFormTitleLabel.Size = new System.Drawing.Size(339, 37);
            this.PaymentFormTitleLabel.TabIndex = 0;
            this.PaymentFormTitleLabel.Text = "Pembayaran Makanan";
            // 
            // OrderIdLabel
            // 
            this.OrderIdLabel.AutoSize = true;
            this.OrderIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.OrderIdLabel.Location = new System.Drawing.Point(161, 104);
            this.OrderIdLabel.Name = "OrderIdLabel";
            this.OrderIdLabel.Size = new System.Drawing.Size(120, 29);
            this.OrderIdLabel.TabIndex = 1;
            this.OrderIdLabel.Text = "Order Id : ";
            // 
            // OrderIdComboBox
            // 
            this.OrderIdComboBox.FormattingEnabled = true;
            this.OrderIdComboBox.Location = new System.Drawing.Point(301, 104);
            this.OrderIdComboBox.Name = "OrderIdComboBox";
            this.OrderIdComboBox.Size = new System.Drawing.Size(320, 28);
            this.OrderIdComboBox.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MenuNameColumn,
            this.QtyMenuColumn,
            this.HargaMenuColumn,
            this.TotalHargaColumn});
            this.dataGridView1.Location = new System.Drawing.Point(42, 177);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(781, 150);
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
            // HargaMenuColumn
            // 
            this.HargaMenuColumn.HeaderText = "Harga";
            this.HargaMenuColumn.Name = "HargaMenuColumn";
            // 
            // TotalHargaColumn
            // 
            this.TotalHargaColumn.HeaderText = "Total";
            this.TotalHargaColumn.Name = "TotalHargaColumn";
            // 
            // PaymentTypeLabel
            // 
            this.PaymentTypeLabel.AutoSize = true;
            this.PaymentTypeLabel.Location = new System.Drawing.Point(166, 380);
            this.PaymentTypeLabel.Name = "PaymentTypeLabel";
            this.PaymentTypeLabel.Size = new System.Drawing.Size(125, 20);
            this.PaymentTypeLabel.TabIndex = 4;
            this.PaymentTypeLabel.Text = "Pembayaran Via";
            // 
            // NomorRekeningLabel
            // 
            this.NomorRekeningLabel.AutoSize = true;
            this.NomorRekeningLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NomorRekeningLabel.Location = new System.Drawing.Point(166, 419);
            this.NomorRekeningLabel.Name = "NomorRekeningLabel";
            this.NomorRekeningLabel.Size = new System.Drawing.Size(128, 20);
            this.NomorRekeningLabel.TabIndex = 5;
            this.NomorRekeningLabel.Text = "Nomor Rekening";
            // 
            // NamaBankLabel
            // 
            this.NamaBankLabel.AutoSize = true;
            this.NamaBankLabel.Location = new System.Drawing.Point(166, 462);
            this.NamaBankLabel.Name = "NamaBankLabel";
            this.NamaBankLabel.Size = new System.Drawing.Size(92, 20);
            this.NamaBankLabel.TabIndex = 6;
            this.NamaBankLabel.Text = "Nama Bank";
            // 
            // TotalHargaLabel
            // 
            this.TotalHargaLabel.AutoSize = true;
            this.TotalHargaLabel.Location = new System.Drawing.Point(565, 340);
            this.TotalHargaLabel.Name = "TotalHargaLabel";
            this.TotalHargaLabel.Size = new System.Drawing.Size(56, 20);
            this.TotalHargaLabel.TabIndex = 7;
            this.TotalHargaLabel.Text = "Total : ";
            // 
            // PembayaranViaTextBox
            // 
            this.PembayaranViaTextBox.FormattingEnabled = true;
            this.PembayaranViaTextBox.Location = new System.Drawing.Point(324, 372);
            this.PembayaranViaTextBox.Name = "PembayaranViaTextBox";
            this.PembayaranViaTextBox.Size = new System.Drawing.Size(220, 28);
            this.PembayaranViaTextBox.TabIndex = 8;
            // 
            // NamaBankComboBox
            // 
            this.NamaBankComboBox.FormattingEnabled = true;
            this.NamaBankComboBox.Location = new System.Drawing.Point(324, 454);
            this.NamaBankComboBox.Name = "NamaBankComboBox";
            this.NamaBankComboBox.Size = new System.Drawing.Size(220, 28);
            this.NamaBankComboBox.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(324, 412);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(220, 26);
            this.textBox1.TabIndex = 10;
            // 
            // NomorHargaLabel
            // 
            this.NomorHargaLabel.AutoSize = true;
            this.NomorHargaLabel.Location = new System.Drawing.Point(627, 340);
            this.NomorHargaLabel.Name = "NomorHargaLabel";
            this.NomorHargaLabel.Size = new System.Drawing.Size(73, 20);
            this.NomorHargaLabel.TabIndex = 11;
            this.NomorHargaLabel.Text = "< Rp. 0 >";
            // 
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(867, 613);
            this.Controls.Add(this.NomorHargaLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.NamaBankComboBox);
            this.Controls.Add(this.PembayaranViaTextBox);
            this.Controls.Add(this.TotalHargaLabel);
            this.Controls.Add(this.NamaBankLabel);
            this.Controls.Add(this.NomorRekeningLabel);
            this.Controls.Add(this.PaymentTypeLabel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.OrderIdComboBox);
            this.Controls.Add(this.OrderIdLabel);
            this.Controls.Add(this.PaymentFormTitleLabel);
            this.Name = "PaymentForm";
            this.Text = "PaymentForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PaymentFormTitleLabel;
        private System.Windows.Forms.Label OrderIdLabel;
        private System.Windows.Forms.ComboBox OrderIdComboBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MenuNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn QtyMenuColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn HargaMenuColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalHargaColumn;
        private System.Windows.Forms.Label PaymentTypeLabel;
        private System.Windows.Forms.Label NomorRekeningLabel;
        private System.Windows.Forms.Label NamaBankLabel;
        private System.Windows.Forms.Label TotalHargaLabel;
        private System.Windows.Forms.ComboBox PembayaranViaTextBox;
        private System.Windows.Forms.ComboBox NamaBankComboBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label NomorHargaLabel;
    }
}