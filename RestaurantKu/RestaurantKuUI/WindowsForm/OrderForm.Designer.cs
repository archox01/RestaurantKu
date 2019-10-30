namespace RestaurantKuUI
{
    partial class OrderForm
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
            this.OrderFormLabel = new System.Windows.Forms.Label();
            this.MenuMakananTextBox = new System.Windows.Forms.TextBox();
            this.HargaMakananTextBox = new System.Windows.Forms.TextBox();
            this.QtyMakananTextBox = new System.Windows.Forms.TextBox();
            this.AddDataButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TotalHargaLabel = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.PaymentProcessButton = new System.Windows.Forms.Button();
            this.MakananPB = new System.Windows.Forms.PictureBox();
            this.MakananDataGrid = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CariButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.ColMId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPhoto = new System.Windows.Forms.DataGridViewImageColumn();
            this.ColPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuInformationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MakananPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MakananDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuInformationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // OrderFormLabel
            // 
            this.OrderFormLabel.AutoSize = true;
            this.OrderFormLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.OrderFormLabel.Location = new System.Drawing.Point(340, 9);
            this.OrderFormLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.OrderFormLabel.Name = "OrderFormLabel";
            this.OrderFormLabel.Size = new System.Drawing.Size(225, 46);
            this.OrderFormLabel.TabIndex = 0;
            this.OrderFormLabel.Text = "Order Form";
            // 
            // MenuMakananTextBox
            // 
            this.MenuMakananTextBox.Location = new System.Drawing.Point(896, 308);
            this.MenuMakananTextBox.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.MenuMakananTextBox.Name = "MenuMakananTextBox";
            this.MenuMakananTextBox.Size = new System.Drawing.Size(155, 30);
            this.MenuMakananTextBox.TabIndex = 6;
            // 
            // HargaMakananTextBox
            // 
            this.HargaMakananTextBox.Location = new System.Drawing.Point(896, 353);
            this.HargaMakananTextBox.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.HargaMakananTextBox.Name = "HargaMakananTextBox";
            this.HargaMakananTextBox.Size = new System.Drawing.Size(155, 30);
            this.HargaMakananTextBox.TabIndex = 7;
            // 
            // QtyMakananTextBox
            // 
            this.QtyMakananTextBox.Location = new System.Drawing.Point(896, 396);
            this.QtyMakananTextBox.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.QtyMakananTextBox.Name = "QtyMakananTextBox";
            this.QtyMakananTextBox.Size = new System.Drawing.Size(155, 30);
            this.QtyMakananTextBox.TabIndex = 8;
            // 
            // AddDataButton
            // 
            this.AddDataButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.AddDataButton.Location = new System.Drawing.Point(1059, 313);
            this.AddDataButton.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.AddDataButton.Name = "AddDataButton";
            this.AddDataButton.Size = new System.Drawing.Size(79, 47);
            this.AddDataButton.TabIndex = 26;
            this.AddDataButton.Text = "Add";
            this.AddDataButton.UseVisualStyleBackColor = true;
            this.AddDataButton.Click += new System.EventHandler(this.AddDataButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(726, 396);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 25);
            this.label1.TabIndex = 22;
            this.label1.Text = "Kuantitas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(726, 356);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 25);
            this.label2.TabIndex = 21;
            this.label2.Text = "Harga";
            // 
            // TotalHargaLabel
            // 
            this.TotalHargaLabel.AutoSize = true;
            this.TotalHargaLabel.Location = new System.Drawing.Point(1042, 681);
            this.TotalHargaLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.TotalHargaLabel.Name = "TotalHargaLabel";
            this.TotalHargaLabel.Size = new System.Drawing.Size(56, 25);
            this.TotalHargaLabel.TabIndex = 20;
            this.TotalHargaLabel.Text = "Total";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 471);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(1124, 196);
            this.dataGridView2.TabIndex = 28;
            // 
            // PaymentProcessButton
            // 
            this.PaymentProcessButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.PaymentProcessButton.Location = new System.Drawing.Point(792, 673);
            this.PaymentProcessButton.Name = "PaymentProcessButton";
            this.PaymentProcessButton.Size = new System.Drawing.Size(93, 41);
            this.PaymentProcessButton.TabIndex = 29;
            this.PaymentProcessButton.Text = "Process";
            this.PaymentProcessButton.UseVisualStyleBackColor = true;
            this.PaymentProcessButton.Click += new System.EventHandler(this.PaymentProcessButton_Click);
            // 
            // MakananPB
            // 
            this.MakananPB.Location = new System.Drawing.Point(12, 273);
            this.MakananPB.Name = "MakananPB";
            this.MakananPB.Size = new System.Drawing.Size(312, 192);
            this.MakananPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MakananPB.TabIndex = 27;
            this.MakananPB.TabStop = false;
            // 
            // MakananDataGrid
            // 
            this.MakananDataGrid.AutoGenerateColumns = false;
            this.MakananDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MakananDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColMId,
            this.ColName,
            this.ColPrice,
            this.ColPhoto,
            this.ColPath});
            this.MakananDataGrid.DataSource = this.menuInformationBindingSource;
            this.MakananDataGrid.Location = new System.Drawing.Point(12, 75);
            this.MakananDataGrid.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.MakananDataGrid.Name = "MakananDataGrid";
            this.MakananDataGrid.RowTemplate.Height = 28;
            this.MakananDataGrid.Size = new System.Drawing.Size(1126, 187);
            this.MakananDataGrid.TabIndex = 19;
            this.MakananDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MakananDataGrid_CellContentClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(418, 313);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(231, 30);
            this.textBox1.TabIndex = 30;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(343, 316);
            this.label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 25);
            this.label4.TabIndex = 20;
            this.label4.Text = "Menu";
            // 
            // CariButton
            // 
            this.CariButton.Location = new System.Drawing.Point(566, 353);
            this.CariButton.Name = "CariButton";
            this.CariButton.Size = new System.Drawing.Size(83, 41);
            this.CariButton.TabIndex = 31;
            this.CariButton.Text = "Cari";
            this.CariButton.UseVisualStyleBackColor = true;
            this.CariButton.Click += new System.EventHandler(this.CariButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(726, 311);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 25);
            this.label3.TabIndex = 20;
            this.label3.Text = "Nama";
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(1059, 374);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(88, 47);
            this.DeleteButton.TabIndex = 32;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // ColMId
            // 
            this.ColMId.DataPropertyName = "MenuId";
            this.ColMId.HeaderText = "MenuId";
            this.ColMId.Name = "ColMId";
            this.ColMId.Visible = false;
            // 
            // ColName
            // 
            this.ColName.DataPropertyName = "Name";
            this.ColName.HeaderText = "Name";
            this.ColName.Name = "ColName";
            // 
            // ColPrice
            // 
            this.ColPrice.DataPropertyName = "price";
            this.ColPrice.HeaderText = "price";
            this.ColPrice.Name = "ColPrice";
            // 
            // ColPhoto
            // 
            this.ColPhoto.DataPropertyName = "photo";
            this.ColPhoto.HeaderText = "photo";
            this.ColPhoto.Name = "ColPhoto";
            this.ColPhoto.Visible = false;
            // 
            // ColPath
            // 
            this.ColPath.DataPropertyName = "PhotoPath";
            this.ColPath.HeaderText = "PhotoPath";
            this.ColPath.Name = "ColPath";
            this.ColPath.Visible = false;
            // 
            // menuInformationBindingSource
            // 
            this.menuInformationBindingSource.DataSource = typeof(RestaurantKuUI.SupportThings.MenuInformation);
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(1159, 746);
            this.Controls.Add(this.AddDataButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.CariButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.PaymentProcessButton);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.MakananPB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TotalHargaLabel);
            this.Controls.Add(this.MakananDataGrid);
            this.Controls.Add(this.QtyMakananTextBox);
            this.Controls.Add(this.HargaMakananTextBox);
            this.Controls.Add(this.MenuMakananTextBox);
            this.Controls.Add(this.OrderFormLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Name = "OrderForm";
            this.Text = "Order Form";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MakananPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MakananDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuInformationBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label OrderFormLabel;
        private System.Windows.Forms.TextBox MenuMakananTextBox;
        private System.Windows.Forms.TextBox HargaMakananTextBox;
        private System.Windows.Forms.TextBox QtyMakananTextBox;
        private System.Windows.Forms.Button AddDataButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label TotalHargaLabel;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button PaymentProcessButton;
        private System.Windows.Forms.PictureBox MakananPB;
        private System.Windows.Forms.DataGridView MakananDataGrid;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button CariButton;
        private System.Windows.Forms.BindingSource menuInformationBindingSource;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPrice;
        private System.Windows.Forms.DataGridViewImageColumn ColPhoto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPath;
        private System.Windows.Forms.Button DeleteButton;
    }
}