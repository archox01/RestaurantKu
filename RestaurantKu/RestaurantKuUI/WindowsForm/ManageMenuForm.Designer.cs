namespace RestaurantKuUI
{
    partial class ManageMenuForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ManageEmployeeTitleLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MenuIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MenuNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MenuPriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MenuJKColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MenuNamaLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MenuHargaLabel = new System.Windows.Forms.Label();
            this.MenuJKLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.InsertMenuButton = new System.Windows.Forms.Button();
            this.UpdateMenuButton = new System.Windows.Forms.Button();
            this.DeleteMenuButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ManageEmployeeTitleLabel
            // 
            this.ManageEmployeeTitleLabel.AutoSize = true;
            this.ManageEmployeeTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ManageEmployeeTitleLabel.Location = new System.Drawing.Point(260, 18);
            this.ManageEmployeeTitleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ManageEmployeeTitleLabel.Name = "ManageEmployeeTitleLabel";
            this.ManageEmployeeTitleLabel.Size = new System.Drawing.Size(340, 29);
            this.ManageEmployeeTitleLabel.TabIndex = 1;
            this.ManageEmployeeTitleLabel.Text = "Restaurant Menu Management";
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MenuIdColumn,
            this.MenuNameColumn,
            this.MenuPriceColumn,
            this.MenuJKColumn});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.Location = new System.Drawing.Point(15, 58);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(699, 224);
            this.dataGridView1.TabIndex = 2;
            // 
            // MenuIdColumn
            // 
            this.MenuIdColumn.HeaderText = "Menu Id";
            this.MenuIdColumn.Name = "MenuIdColumn";
            // 
            // MenuNameColumn
            // 
            this.MenuNameColumn.HeaderText = "Name";
            this.MenuNameColumn.Name = "MenuNameColumn";
            // 
            // MenuPriceColumn
            // 
            this.MenuPriceColumn.HeaderText = "Price";
            this.MenuPriceColumn.Name = "MenuPriceColumn";
            // 
            // MenuJKColumn
            // 
            this.MenuJKColumn.HeaderText = "Jenis Konsumsi";
            this.MenuJKColumn.Name = "MenuJKColumn";
            // 
            // MenuNamaLabel
            // 
            this.MenuNamaLabel.AutoSize = true;
            this.MenuNamaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.MenuNamaLabel.Location = new System.Drawing.Point(370, 345);
            this.MenuNamaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MenuNamaLabel.Name = "MenuNamaLabel";
            this.MenuNamaLabel.Size = new System.Drawing.Size(64, 25);
            this.MenuNamaLabel.TabIndex = 3;
            this.MenuNamaLabel.Text = "Nama";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(370, 302);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Menu Id";
            // 
            // MenuHargaLabel
            // 
            this.MenuHargaLabel.AutoSize = true;
            this.MenuHargaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.MenuHargaLabel.Location = new System.Drawing.Point(370, 385);
            this.MenuHargaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MenuHargaLabel.Name = "MenuHargaLabel";
            this.MenuHargaLabel.Size = new System.Drawing.Size(65, 25);
            this.MenuHargaLabel.TabIndex = 4;
            this.MenuHargaLabel.Text = "Harga";
            // 
            // MenuJKLabel
            // 
            this.MenuJKLabel.AutoSize = true;
            this.MenuJKLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.MenuJKLabel.Location = new System.Drawing.Point(368, 427);
            this.MenuJKLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MenuJKLabel.Name = "MenuJKLabel";
            this.MenuJKLabel.Size = new System.Drawing.Size(151, 25);
            this.MenuJKLabel.TabIndex = 4;
            this.MenuJKLabel.Text = "Jenis Konsumsi";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(15, 302);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(343, 223);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // InsertMenuButton
            // 
            this.InsertMenuButton.Location = new System.Drawing.Point(374, 465);
            this.InsertMenuButton.Margin = new System.Windows.Forms.Padding(2);
            this.InsertMenuButton.Name = "InsertMenuButton";
            this.InsertMenuButton.Size = new System.Drawing.Size(73, 36);
            this.InsertMenuButton.TabIndex = 6;
            this.InsertMenuButton.Text = "Insert";
            this.InsertMenuButton.UseVisualStyleBackColor = true;
            // 
            // UpdateMenuButton
            // 
            this.UpdateMenuButton.Location = new System.Drawing.Point(484, 465);
            this.UpdateMenuButton.Margin = new System.Windows.Forms.Padding(2);
            this.UpdateMenuButton.Name = "UpdateMenuButton";
            this.UpdateMenuButton.Size = new System.Drawing.Size(73, 36);
            this.UpdateMenuButton.TabIndex = 7;
            this.UpdateMenuButton.Text = "Update";
            this.UpdateMenuButton.UseVisualStyleBackColor = true;
            // 
            // DeleteMenuButton
            // 
            this.DeleteMenuButton.Location = new System.Drawing.Point(586, 465);
            this.DeleteMenuButton.Margin = new System.Windows.Forms.Padding(2);
            this.DeleteMenuButton.Name = "DeleteMenuButton";
            this.DeleteMenuButton.Size = new System.Drawing.Size(73, 36);
            this.DeleteMenuButton.TabIndex = 8;
            this.DeleteMenuButton.Text = "Delete";
            this.DeleteMenuButton.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(535, 302);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(145, 26);
            this.textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(535, 345);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(145, 26);
            this.textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(535, 384);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(145, 26);
            this.textBox3.TabIndex = 10;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Makanan",
            "Minuman"});
            this.comboBox1.Location = new System.Drawing.Point(535, 426);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(145, 28);
            this.comboBox1.TabIndex = 11;
            // 
            // ManageMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(730, 538);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.DeleteMenuButton);
            this.Controls.Add(this.UpdateMenuButton);
            this.Controls.Add(this.InsertMenuButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.MenuJKLabel);
            this.Controls.Add(this.MenuHargaLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MenuNamaLabel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ManageEmployeeTitleLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "ManageMenuForm";
            this.Text = "ManageMenuForm";
            this.Load += new System.EventHandler(this.ManageMenuForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ManageEmployeeTitleLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MenuIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MenuNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MenuPriceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MenuJKColumn;
        private System.Windows.Forms.Label MenuNamaLabel;
        private System.Windows.Forms.Label MenuHargaLabel;
        private System.Windows.Forms.Label MenuJKLabel;
        private System.Windows.Forms.Button InsertMenuButton;
        private System.Windows.Forms.Button UpdateMenuButton;
        private System.Windows.Forms.Button DeleteMenuButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}