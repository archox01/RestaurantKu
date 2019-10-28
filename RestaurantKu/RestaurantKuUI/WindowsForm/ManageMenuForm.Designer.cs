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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ManageEmployeeTitleLabel = new System.Windows.Forms.Label();
            this.DGMenu = new System.Windows.Forms.DataGridView();
            this.menuIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.photoDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.photoPathDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuInformationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MenuNamaLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MenuHargaLabel = new System.Windows.Forms.Label();
            this.PictureLabel = new System.Windows.Forms.Label();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.InsertMenuButton = new System.Windows.Forms.Button();
            this.UpdateMenuButton = new System.Windows.Forms.Button();
            this.DeleteMenuButton = new System.Windows.Forms.Button();
            this.MenuIdText = new System.Windows.Forms.TextBox();
            this.NamaText = new System.Windows.Forms.TextBox();
            this.HargaText = new System.Windows.Forms.TextBox();
            this.PathText = new System.Windows.Forms.TextBox();
            this.BrowsePicButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuInformationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ManageEmployeeTitleLabel
            // 
            this.ManageEmployeeTitleLabel.AutoSize = true;
            this.ManageEmployeeTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ManageEmployeeTitleLabel.Location = new System.Drawing.Point(198, 9);
            this.ManageEmployeeTitleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ManageEmployeeTitleLabel.Name = "ManageEmployeeTitleLabel";
            this.ManageEmployeeTitleLabel.Size = new System.Drawing.Size(340, 29);
            this.ManageEmployeeTitleLabel.TabIndex = 1;
            this.ManageEmployeeTitleLabel.Text = "Restaurant Menu Management";
            // 
            // DGMenu
            // 
            this.DGMenu.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGMenu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGMenu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.menuIdDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.photoDataGridViewImageColumn,
            this.photoPathDataGridViewTextBoxColumn});
            this.DGMenu.DataSource = this.menuInformationBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGMenu.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGMenu.Location = new System.Drawing.Point(15, 58);
            this.DGMenu.Margin = new System.Windows.Forms.Padding(2);
            this.DGMenu.Name = "DGMenu";
            this.DGMenu.RowTemplate.Height = 28;
            this.DGMenu.Size = new System.Drawing.Size(705, 224);
            this.DGMenu.TabIndex = 2;
            this.DGMenu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGMenu_CellContentClick);
            // 
            // menuIdDataGridViewTextBoxColumn
            // 
            this.menuIdDataGridViewTextBoxColumn.DataPropertyName = "MenuId";
            this.menuIdDataGridViewTextBoxColumn.HeaderText = "MenuId";
            this.menuIdDataGridViewTextBoxColumn.Name = "menuIdDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // photoDataGridViewImageColumn
            // 
            this.photoDataGridViewImageColumn.DataPropertyName = "photo";
            this.photoDataGridViewImageColumn.HeaderText = "photo";
            this.photoDataGridViewImageColumn.Name = "photoDataGridViewImageColumn";
            this.photoDataGridViewImageColumn.Visible = false;
            // 
            // photoPathDataGridViewTextBoxColumn
            // 
            this.photoPathDataGridViewTextBoxColumn.DataPropertyName = "PhotoPath";
            this.photoPathDataGridViewTextBoxColumn.HeaderText = "PhotoPath";
            this.photoPathDataGridViewTextBoxColumn.Name = "photoPathDataGridViewTextBoxColumn";
            // 
            // menuInformationBindingSource
            // 
            this.menuInformationBindingSource.DataSource = typeof(RestaurantKuUI.SupportThings.MenuInformation);
            // 
            // MenuNamaLabel
            // 
            this.MenuNamaLabel.AutoSize = true;
            this.MenuNamaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.MenuNamaLabel.Location = new System.Drawing.Point(368, 380);
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
            this.label1.Location = new System.Drawing.Point(368, 304);
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
            this.MenuHargaLabel.Location = new System.Drawing.Point(368, 420);
            this.MenuHargaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MenuHargaLabel.Name = "MenuHargaLabel";
            this.MenuHargaLabel.Size = new System.Drawing.Size(65, 25);
            this.MenuHargaLabel.TabIndex = 4;
            this.MenuHargaLabel.Text = "Harga";
            // 
            // PictureLabel
            // 
            this.PictureLabel.AutoSize = true;
            this.PictureLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.PictureLabel.Location = new System.Drawing.Point(368, 462);
            this.PictureLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PictureLabel.Name = "PictureLabel";
            this.PictureLabel.Size = new System.Drawing.Size(72, 25);
            this.PictureLabel.TabIndex = 4;
            this.PictureLabel.Text = "Picture";
            // 
            // PictureBox
            // 
            this.PictureBox.Location = new System.Drawing.Point(15, 302);
            this.PictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(343, 223);
            this.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox.TabIndex = 5;
            this.PictureBox.TabStop = false;
            // 
            // InsertMenuButton
            // 
            this.InsertMenuButton.Location = new System.Drawing.Point(373, 500);
            this.InsertMenuButton.Margin = new System.Windows.Forms.Padding(2);
            this.InsertMenuButton.Name = "InsertMenuButton";
            this.InsertMenuButton.Size = new System.Drawing.Size(73, 36);
            this.InsertMenuButton.TabIndex = 6;
            this.InsertMenuButton.Text = "Insert";
            this.InsertMenuButton.UseVisualStyleBackColor = true;
            this.InsertMenuButton.Click += new System.EventHandler(this.InsertMenuButton_Click);
            // 
            // UpdateMenuButton
            // 
            this.UpdateMenuButton.Location = new System.Drawing.Point(484, 500);
            this.UpdateMenuButton.Margin = new System.Windows.Forms.Padding(2);
            this.UpdateMenuButton.Name = "UpdateMenuButton";
            this.UpdateMenuButton.Size = new System.Drawing.Size(73, 36);
            this.UpdateMenuButton.TabIndex = 7;
            this.UpdateMenuButton.Text = "Update";
            this.UpdateMenuButton.UseVisualStyleBackColor = true;
            // 
            // DeleteMenuButton
            // 
            this.DeleteMenuButton.Location = new System.Drawing.Point(586, 500);
            this.DeleteMenuButton.Margin = new System.Windows.Forms.Padding(2);
            this.DeleteMenuButton.Name = "DeleteMenuButton";
            this.DeleteMenuButton.Size = new System.Drawing.Size(73, 36);
            this.DeleteMenuButton.TabIndex = 8;
            this.DeleteMenuButton.Text = "Delete";
            this.DeleteMenuButton.UseVisualStyleBackColor = true;
            // 
            // MenuIdText
            // 
            this.MenuIdText.Location = new System.Drawing.Point(484, 303);
            this.MenuIdText.Margin = new System.Windows.Forms.Padding(2);
            this.MenuIdText.Name = "MenuIdText";
            this.MenuIdText.Size = new System.Drawing.Size(145, 26);
            this.MenuIdText.TabIndex = 9;
            // 
            // NamaText
            // 
            this.NamaText.Location = new System.Drawing.Point(484, 379);
            this.NamaText.Margin = new System.Windows.Forms.Padding(2);
            this.NamaText.Name = "NamaText";
            this.NamaText.Size = new System.Drawing.Size(145, 26);
            this.NamaText.TabIndex = 9;
            // 
            // HargaText
            // 
            this.HargaText.Location = new System.Drawing.Point(484, 419);
            this.HargaText.Margin = new System.Windows.Forms.Padding(2);
            this.HargaText.Name = "HargaText";
            this.HargaText.Size = new System.Drawing.Size(145, 26);
            this.HargaText.TabIndex = 10;
            // 
            // PathText
            // 
            this.PathText.Location = new System.Drawing.Point(484, 463);
            this.PathText.Name = "PathText";
            this.PathText.Size = new System.Drawing.Size(145, 26);
            this.PathText.TabIndex = 11;
            // 
            // BrowsePicButton
            // 
            this.BrowsePicButton.Location = new System.Drawing.Point(645, 461);
            this.BrowsePicButton.Name = "BrowsePicButton";
            this.BrowsePicButton.Size = new System.Drawing.Size(75, 30);
            this.BrowsePicButton.TabIndex = 12;
            this.BrowsePicButton.Text = "Browse";
            this.BrowsePicButton.UseVisualStyleBackColor = true;
            this.BrowsePicButton.Click += new System.EventHandler(this.BrowsePicButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(634, 299);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(85, 30);
            this.SearchButton.TabIndex = 13;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            // 
            // ManageMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(732, 536);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.BrowsePicButton);
            this.Controls.Add(this.PathText);
            this.Controls.Add(this.HargaText);
            this.Controls.Add(this.NamaText);
            this.Controls.Add(this.MenuIdText);
            this.Controls.Add(this.DeleteMenuButton);
            this.Controls.Add(this.UpdateMenuButton);
            this.Controls.Add(this.InsertMenuButton);
            this.Controls.Add(this.PictureBox);
            this.Controls.Add(this.PictureLabel);
            this.Controls.Add(this.MenuHargaLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MenuNamaLabel);
            this.Controls.Add(this.DGMenu);
            this.Controls.Add(this.ManageEmployeeTitleLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "ManageMenuForm";
            this.Text = "ManageMenuForm";
            this.Load += new System.EventHandler(this.ManageMenuForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuInformationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ManageEmployeeTitleLabel;
        private System.Windows.Forms.DataGridView DGMenu;
        private System.Windows.Forms.Label MenuNamaLabel;
        private System.Windows.Forms.Label MenuHargaLabel;
        private System.Windows.Forms.Label PictureLabel;
        private System.Windows.Forms.Button InsertMenuButton;
        private System.Windows.Forms.Button UpdateMenuButton;
        private System.Windows.Forms.Button DeleteMenuButton;
        private System.Windows.Forms.TextBox MenuIdText;
        private System.Windows.Forms.TextBox NamaText;
        private System.Windows.Forms.TextBox HargaText;
        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn menuIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn photoDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn photoPathDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource menuInformationBindingSource;
        private System.Windows.Forms.TextBox PathText;
        private System.Windows.Forms.Button BrowsePicButton;
        private System.Windows.Forms.Button SearchButton;
    }
}