namespace PointOfSale_WinForm.Stock
{
    partial class StockAdjustmentForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockAdjustmentForm));
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.exitButton = new FontAwesome.Sharp.IconPictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.reftextBox = new System.Windows.Forms.TextBox();
            this.codetextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.descriptiontextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.qtyTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.userTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.remarksTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.adjustmentButton = new System.Windows.Forms.Button();
            this.commandComboBox = new System.Windows.Forms.ComboBox();
            this.productListDataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Select = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.searchTextBox = new MetroFramework.Controls.MetroTextBox();
            this.productIdLabel = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productListDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(195)))), ((int)(((byte)(239)))));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.exitButton);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1024, 31);
            this.panel3.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Adjust Stock";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Transparent;
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.exitButton.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.exitButton.IconColor = System.Drawing.Color.White;
            this.exitButton.IconSize = 31;
            this.exitButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.exitButton.Location = new System.Drawing.Point(992, 0);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(32, 31);
            this.exitButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exitButton.TabIndex = 15;
            this.exitButton.TabStop = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 393);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "REFERENCE NO";
            // 
            // reftextBox
            // 
            this.reftextBox.Location = new System.Drawing.Point(115, 390);
            this.reftextBox.Name = "reftextBox";
            this.reftextBox.ReadOnly = true;
            this.reftextBox.Size = new System.Drawing.Size(384, 25);
            this.reftextBox.TabIndex = 8;
            // 
            // codetextBox
            // 
            this.codetextBox.Location = new System.Drawing.Point(115, 421);
            this.codetextBox.Name = "codetextBox";
            this.codetextBox.ReadOnly = true;
            this.codetextBox.Size = new System.Drawing.Size(384, 25);
            this.codetextBox.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 424);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "PRODUCT CODE";
            // 
            // descriptiontextBox
            // 
            this.descriptiontextBox.Location = new System.Drawing.Point(115, 452);
            this.descriptiontextBox.Name = "descriptiontextBox";
            this.descriptiontextBox.Size = new System.Drawing.Size(384, 25);
            this.descriptiontextBox.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 455);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "DESCRIPTION";
            // 
            // qtyTextBox
            // 
            this.qtyTextBox.Location = new System.Drawing.Point(115, 483);
            this.qtyTextBox.Name = "qtyTextBox";
            this.qtyTextBox.Size = new System.Drawing.Size(384, 25);
            this.qtyTextBox.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 486);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "QUANTITY";
            // 
            // userTextBox
            // 
            this.userTextBox.Location = new System.Drawing.Point(602, 452);
            this.userTextBox.Name = "userTextBox";
            this.userTextBox.ReadOnly = true;
            this.userTextBox.Size = new System.Drawing.Size(407, 25);
            this.userTextBox.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(519, 455);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "USER";
            // 
            // remarksTextBox
            // 
            this.remarksTextBox.Location = new System.Drawing.Point(602, 421);
            this.remarksTextBox.Name = "remarksTextBox";
            this.remarksTextBox.Size = new System.Drawing.Size(407, 25);
            this.remarksTextBox.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(519, 424);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "REMARKS";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(519, 393);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 17);
            this.label9.TabIndex = 15;
            this.label9.Text = "COMMAND";
            // 
            // adjustmentButton
            // 
            this.adjustmentButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.adjustmentButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.adjustmentButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adjustmentButton.FlatAppearance.BorderSize = 0;
            this.adjustmentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adjustmentButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adjustmentButton.ForeColor = System.Drawing.Color.White;
            this.adjustmentButton.Location = new System.Drawing.Point(870, 486);
            this.adjustmentButton.Name = "adjustmentButton";
            this.adjustmentButton.Size = new System.Drawing.Size(139, 33);
            this.adjustmentButton.TabIndex = 21;
            this.adjustmentButton.Text = "Save";
            this.adjustmentButton.UseVisualStyleBackColor = false;
            this.adjustmentButton.Click += new System.EventHandler(this.adjustmentButton_Click);
            // 
            // commandComboBox
            // 
            this.commandComboBox.FormattingEnabled = true;
            this.commandComboBox.Items.AddRange(new object[] {
            "REMOVE FROM INVENTORY",
            "ADD TO INVENTORY"});
            this.commandComboBox.Location = new System.Drawing.Point(602, 390);
            this.commandComboBox.Name = "commandComboBox";
            this.commandComboBox.Size = new System.Drawing.Size(407, 25);
            this.commandComboBox.TabIndex = 22;
            this.commandComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.commandComboBox_KeyPress);
            // 
            // productListDataGridView
            // 
            this.productListDataGridView.AllowUserToAddRows = false;
            this.productListDataGridView.AllowUserToDeleteRows = false;
            this.productListDataGridView.AllowUserToResizeColumns = false;
            this.productListDataGridView.AllowUserToResizeRows = false;
            this.productListDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productListDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.productListDataGridView.CausesValidation = false;
            this.productListDataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.productListDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.productListDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.productListDataGridView.ColumnHeadersHeight = 30;
            this.productListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.productListDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column5,
            this.Column4,
            this.Column9,
            this.Column8,
            this.Column7,
            this.Column6,
            this.Column10,
            this.Select});
            this.productListDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.productListDataGridView.EnableHeadersVisualStyles = false;
            this.productListDataGridView.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.productListDataGridView.Location = new System.Drawing.Point(0, 70);
            this.productListDataGridView.MultiSelect = false;
            this.productListDataGridView.Name = "productListDataGridView";
            this.productListDataGridView.ReadOnly = true;
            this.productListDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.productListDataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productListDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.productListDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productListDataGridView.Size = new System.Drawing.Size(1024, 314);
            this.productListDataGridView.TabIndex = 23;
            this.productListDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productListDataGridView_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "#";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 40;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "ID";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Visible = false;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column3.HeaderText = "CODE";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 66;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column5.HeaderText = "BARCODE";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 89;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column4.HeaderText = "NAME";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 69;
            // 
            // Column9
            // 
            this.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column9.HeaderText = "DESCRIPTION";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column8.HeaderText = "BRAND";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 74;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column7.HeaderText = "CATEGORY";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 95;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column6.HeaderText = "PRICE";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 65;
            // 
            // Column10
            // 
            this.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column10.HeaderText = "STOCK ON HAND";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Width = 135;
            // 
            // Select
            // 
            this.Select.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Select.FillWeight = 50F;
            this.Select.HeaderText = "";
            this.Select.Image = ((System.Drawing.Image)(resources.GetObject("Select.Image")));
            this.Select.Name = "Select";
            this.Select.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.searchTextBox);
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1024, 34);
            this.panel1.TabIndex = 24;
            // 
            // searchTextBox
            // 
            // 
            // 
            // 
            this.searchTextBox.CustomButton.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTextBox.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.searchTextBox.CustomButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchTextBox.CustomButton.Location = new System.Drawing.Point(992, 2);
            this.searchTextBox.CustomButton.Name = "";
            this.searchTextBox.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.searchTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.searchTextBox.CustomButton.TabIndex = 1;
            this.searchTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.searchTextBox.CustomButton.UseSelectable = true;
            this.searchTextBox.CustomButton.Visible = false;
            this.searchTextBox.DisplayIcon = true;
            this.searchTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchTextBox.Icon = ((System.Drawing.Image)(resources.GetObject("searchTextBox.Icon")));
            this.searchTextBox.Lines = new string[0];
            this.searchTextBox.Location = new System.Drawing.Point(0, 0);
            this.searchTextBox.MaxLength = 32767;
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.PasswordChar = '\0';
            this.searchTextBox.PromptText = "Search Product Name Here";
            this.searchTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.searchTextBox.SelectedText = "";
            this.searchTextBox.SelectionLength = 0;
            this.searchTextBox.SelectionStart = 0;
            this.searchTextBox.ShortcutsEnabled = true;
            this.searchTextBox.Size = new System.Drawing.Size(1024, 34);
            this.searchTextBox.TabIndex = 16;
            this.searchTextBox.UseSelectable = true;
            this.searchTextBox.WaterMark = "Search Product Name Here";
            this.searchTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.searchTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.searchTextBox_KeyPress);
            // 
            // productIdLabel
            // 
            this.productIdLabel.AutoSize = true;
            this.productIdLabel.Location = new System.Drawing.Point(602, 484);
            this.productIdLabel.Name = "productIdLabel";
            this.productIdLabel.Size = new System.Drawing.Size(0, 17);
            this.productIdLabel.TabIndex = 25;
            this.productIdLabel.Visible = false;
            // 
            // StockAdjustmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 531);
            this.ControlBox = false;
            this.Controls.Add(this.productIdLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.productListDataGridView);
            this.Controls.Add(this.commandComboBox);
            this.Controls.Add(this.adjustmentButton);
            this.Controls.Add(this.userTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.remarksTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.qtyTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.descriptiontextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.codetextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.reftextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "StockAdjustmentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StockAdjustmentForm";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productListDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconPictureBox exitButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox reftextBox;
        private System.Windows.Forms.TextBox codetextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox descriptiontextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox qtyTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox remarksTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.Button adjustmentButton;
        private System.Windows.Forms.ComboBox commandComboBox;
        private System.Windows.Forms.DataGridView productListDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewImageColumn Select;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroTextBox searchTextBox;
        public System.Windows.Forms.TextBox userTextBox;
        private System.Windows.Forms.Label productIdLabel;
    }
}