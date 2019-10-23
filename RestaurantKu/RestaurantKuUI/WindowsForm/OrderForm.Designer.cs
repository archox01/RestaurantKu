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
            this.OrderFormLabel = new System.Windows.Forms.Label();
            this.MinumanDataGrid = new System.Windows.Forms.DataGridView();
            this.MenuNameLabel = new System.Windows.Forms.Label();
            this.MenuPriceLabel = new System.Windows.Forms.Label();
            this.MenuQtyLabel = new System.Windows.Forms.Label();
            this.MenuMakananTextBox = new System.Windows.Forms.TextBox();
            this.HargaMakananTextBox = new System.Windows.Forms.TextBox();
            this.QtyMakananTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.MinumanPB = new System.Windows.Forms.PictureBox();
            this.MakananPB = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.QtyMinumanTextBox = new System.Windows.Forms.TextBox();
            this.HargaMinumanTextBox = new System.Windows.Forms.TextBox();
            this.MenuMinumanTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MakananDataGrid = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.PaymentProcessButton = new System.Windows.Forms.Button();
            this.MenuMakananColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HargaMakananColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdMakananColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MenuNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MenuQtyColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MenuHargaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MenuTotalColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MenuMinumanColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HargaMinumanColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdMinumanColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhotoMinumanColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhotoMakananColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.MinumanDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinumanPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MakananPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MakananDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // OrderFormLabel
            // 
            this.OrderFormLabel.AutoSize = true;
            this.OrderFormLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.OrderFormLabel.Location = new System.Drawing.Point(463, 23);
            this.OrderFormLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.OrderFormLabel.Name = "OrderFormLabel";
            this.OrderFormLabel.Size = new System.Drawing.Size(225, 46);
            this.OrderFormLabel.TabIndex = 0;
            this.OrderFormLabel.Text = "Order Form";
            // 
            // MinumanDataGrid
            // 
            this.MinumanDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MinumanDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MenuMinumanColumn,
            this.HargaMinumanColumn,
            this.IdMinumanColumn,
            this.PhotoMinumanColumn});
            this.MinumanDataGrid.Location = new System.Drawing.Point(22, 84);
            this.MinumanDataGrid.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.MinumanDataGrid.Name = "MinumanDataGrid";
            this.MinumanDataGrid.RowTemplate.Height = 28;
            this.MinumanDataGrid.Size = new System.Drawing.Size(496, 137);
            this.MinumanDataGrid.TabIndex = 1;
            // 
            // MenuNameLabel
            // 
            this.MenuNameLabel.AutoSize = true;
            this.MenuNameLabel.Location = new System.Drawing.Point(204, 236);
            this.MenuNameLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.MenuNameLabel.Name = "MenuNameLabel";
            this.MenuNameLabel.Size = new System.Drawing.Size(49, 20);
            this.MenuNameLabel.TabIndex = 3;
            this.MenuNameLabel.Text = "Menu";
            // 
            // MenuPriceLabel
            // 
            this.MenuPriceLabel.AutoSize = true;
            this.MenuPriceLabel.Location = new System.Drawing.Point(204, 265);
            this.MenuPriceLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.MenuPriceLabel.Name = "MenuPriceLabel";
            this.MenuPriceLabel.Size = new System.Drawing.Size(53, 20);
            this.MenuPriceLabel.TabIndex = 4;
            this.MenuPriceLabel.Text = "Harga";
            // 
            // MenuQtyLabel
            // 
            this.MenuQtyLabel.AutoSize = true;
            this.MenuQtyLabel.Location = new System.Drawing.Point(204, 293);
            this.MenuQtyLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.MenuQtyLabel.Name = "MenuQtyLabel";
            this.MenuQtyLabel.Size = new System.Drawing.Size(76, 20);
            this.MenuQtyLabel.TabIndex = 5;
            this.MenuQtyLabel.Text = "Kuantitas";
            // 
            // MenuMakananTextBox
            // 
            this.MenuMakananTextBox.Location = new System.Drawing.Point(830, 236);
            this.MenuMakananTextBox.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.MenuMakananTextBox.Name = "MenuMakananTextBox";
            this.MenuMakananTextBox.Size = new System.Drawing.Size(155, 26);
            this.MenuMakananTextBox.TabIndex = 6;
            // 
            // HargaMakananTextBox
            // 
            this.HargaMakananTextBox.Location = new System.Drawing.Point(830, 265);
            this.HargaMakananTextBox.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.HargaMakananTextBox.Name = "HargaMakananTextBox";
            this.HargaMakananTextBox.Size = new System.Drawing.Size(155, 26);
            this.HargaMakananTextBox.TabIndex = 7;
            // 
            // QtyMakananTextBox
            // 
            this.QtyMakananTextBox.Location = new System.Drawing.Point(830, 293);
            this.QtyMakananTextBox.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.QtyMakananTextBox.Name = "QtyMakananTextBox";
            this.QtyMakananTextBox.Size = new System.Drawing.Size(155, 26);
            this.QtyMakananTextBox.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(454, 256);
            this.button1.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 34);
            this.button1.TabIndex = 16;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // MinumanPB
            // 
            this.MinumanPB.Location = new System.Drawing.Point(22, 225);
            this.MinumanPB.Name = "MinumanPB";
            this.MinumanPB.Size = new System.Drawing.Size(169, 100);
            this.MinumanPB.TabIndex = 18;
            this.MinumanPB.TabStop = false;
            // 
            // MakananPB
            // 
            this.MakananPB.Location = new System.Drawing.Point(566, 225);
            this.MakananPB.Name = "MakananPB";
            this.MakananPB.Size = new System.Drawing.Size(169, 100);
            this.MakananPB.TabIndex = 27;
            this.MakananPB.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(998, 256);
            this.button2.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(64, 34);
            this.button2.TabIndex = 26;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // QtyMinumanTextBox
            // 
            this.QtyMinumanTextBox.Location = new System.Drawing.Point(287, 287);
            this.QtyMinumanTextBox.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.QtyMinumanTextBox.Name = "QtyMinumanTextBox";
            this.QtyMinumanTextBox.Size = new System.Drawing.Size(155, 26);
            this.QtyMinumanTextBox.TabIndex = 25;
            // 
            // HargaMinumanTextBox
            // 
            this.HargaMinumanTextBox.Location = new System.Drawing.Point(287, 259);
            this.HargaMinumanTextBox.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.HargaMinumanTextBox.Name = "HargaMinumanTextBox";
            this.HargaMinumanTextBox.Size = new System.Drawing.Size(155, 26);
            this.HargaMinumanTextBox.TabIndex = 24;
            // 
            // MenuMinumanTextBox
            // 
            this.MenuMinumanTextBox.Location = new System.Drawing.Point(287, 230);
            this.MenuMinumanTextBox.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.MenuMinumanTextBox.Name = "MenuMinumanTextBox";
            this.MenuMinumanTextBox.Size = new System.Drawing.Size(155, 26);
            this.MenuMinumanTextBox.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(748, 293);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Kuantitas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(748, 265);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Harga";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(748, 236);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Menu";
            // 
            // MakananDataGrid
            // 
            this.MakananDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MakananDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MenuMakananColumn,
            this.HargaMakananColumn,
            this.IdMakananColumn,
            this.PhotoMakananColumn});
            this.MakananDataGrid.Location = new System.Drawing.Point(566, 84);
            this.MakananDataGrid.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.MakananDataGrid.Name = "MakananDataGrid";
            this.MakananDataGrid.RowTemplate.Height = 28;
            this.MakananDataGrid.Size = new System.Drawing.Size(496, 137);
            this.MakananDataGrid.TabIndex = 19;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MenuNameColumn,
            this.MenuQtyColumn,
            this.MenuHargaColumn,
            this.MenuTotalColumn});
            this.dataGridView2.Location = new System.Drawing.Point(22, 364);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(866, 164);
            this.dataGridView2.TabIndex = 28;
            // 
            // PaymentProcessButton
            // 
            this.PaymentProcessButton.Location = new System.Drawing.Point(919, 429);
            this.PaymentProcessButton.Name = "PaymentProcessButton";
            this.PaymentProcessButton.Size = new System.Drawing.Size(87, 41);
            this.PaymentProcessButton.TabIndex = 29;
            this.PaymentProcessButton.Text = "Process";
            this.PaymentProcessButton.UseVisualStyleBackColor = true;
            // 
            // MenuMakananColumn
            // 
            this.MenuMakananColumn.HeaderText = "Menu";
            this.MenuMakananColumn.Name = "MenuMakananColumn";
            // 
            // HargaMakananColumn
            // 
            this.HargaMakananColumn.HeaderText = "Harga";
            this.HargaMakananColumn.Name = "HargaMakananColumn";
            // 
            // IdMakananColumn
            // 
            this.IdMakananColumn.HeaderText = "MenuId";
            this.IdMakananColumn.Name = "IdMakananColumn";
            this.IdMakananColumn.Visible = false;
            // 
            // MenuNameColumn
            // 
            this.MenuNameColumn.HeaderText = "Menu";
            this.MenuNameColumn.Name = "MenuNameColumn";
            // 
            // MenuQtyColumn
            // 
            this.MenuQtyColumn.HeaderText = "Kuantitas";
            this.MenuQtyColumn.Name = "MenuQtyColumn";
            // 
            // MenuHargaColumn
            // 
            this.MenuHargaColumn.HeaderText = "Harga";
            this.MenuHargaColumn.Name = "MenuHargaColumn";
            // 
            // MenuTotalColumn
            // 
            this.MenuTotalColumn.HeaderText = "Total";
            this.MenuTotalColumn.Name = "MenuTotalColumn";
            // 
            // MenuMinumanColumn
            // 
            this.MenuMinumanColumn.HeaderText = "Menu";
            this.MenuMinumanColumn.Name = "MenuMinumanColumn";
            // 
            // HargaMinumanColumn
            // 
            this.HargaMinumanColumn.HeaderText = "Harga";
            this.HargaMinumanColumn.Name = "HargaMinumanColumn";
            // 
            // IdMinumanColumn
            // 
            this.IdMinumanColumn.HeaderText = "MenuId";
            this.IdMinumanColumn.Name = "IdMinumanColumn";
            this.IdMinumanColumn.Visible = false;
            // 
            // PhotoMinumanColumn
            // 
            this.PhotoMinumanColumn.HeaderText = "Photo";
            this.PhotoMinumanColumn.Name = "PhotoMinumanColumn";
            this.PhotoMinumanColumn.Visible = false;
            // 
            // PhotoMakananColumn
            // 
            this.PhotoMakananColumn.HeaderText = "Photo";
            this.PhotoMakananColumn.Name = "PhotoMakananColumn";
            this.PhotoMakananColumn.Visible = false;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(1083, 540);
            this.Controls.Add(this.PaymentProcessButton);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.MakananPB);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.QtyMinumanTextBox);
            this.Controls.Add(this.HargaMinumanTextBox);
            this.Controls.Add(this.MenuMinumanTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MakananDataGrid);
            this.Controls.Add(this.MinumanPB);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.QtyMakananTextBox);
            this.Controls.Add(this.HargaMakananTextBox);
            this.Controls.Add(this.MenuMakananTextBox);
            this.Controls.Add(this.MenuQtyLabel);
            this.Controls.Add(this.MenuPriceLabel);
            this.Controls.Add(this.MenuNameLabel);
            this.Controls.Add(this.MinumanDataGrid);
            this.Controls.Add(this.OrderFormLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.Name = "OrderForm";
            this.Text = "Order Form";
            ((System.ComponentModel.ISupportInitialize)(this.MinumanDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinumanPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MakananPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MakananDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label OrderFormLabel;
        private System.Windows.Forms.DataGridView MinumanDataGrid;
        private System.Windows.Forms.Label MenuNameLabel;
        private System.Windows.Forms.Label MenuPriceLabel;
        private System.Windows.Forms.Label MenuQtyLabel;
        private System.Windows.Forms.TextBox MenuMakananTextBox;
        private System.Windows.Forms.TextBox HargaMakananTextBox;
        private System.Windows.Forms.TextBox QtyMakananTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox MinumanPB;
        private System.Windows.Forms.PictureBox MakananPB;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox QtyMinumanTextBox;
        private System.Windows.Forms.TextBox HargaMinumanTextBox;
        private System.Windows.Forms.TextBox MenuMinumanTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView MakananDataGrid;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button PaymentProcessButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn MenuMakananColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn HargaMakananColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMakananColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MenuNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MenuQtyColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MenuHargaColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MenuTotalColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MenuMinumanColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn HargaMinumanColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMinumanColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhotoMinumanColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhotoMakananColumn;
    }
}