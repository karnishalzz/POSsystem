namespace PointOfSale_WinForm.POS
{
    partial class SoldItemsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SoldItemsForm));
            this.panel3 = new System.Windows.Forms.Panel();
            this.exitButton = new FontAwesome.Sharp.IconPictureBox();
            this.expandButton = new FontAwesome.Sharp.IconPictureBox();
            this.soldDataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cancel = new System.Windows.Forms.DataGridViewImageColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.fromDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.toDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.totalLabel = new System.Windows.Forms.Label();
            this.printButton = new System.Windows.Forms.Button();
            this.cashierComboBox = new System.Windows.Forms.ComboBox();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expandButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soldDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.exitButton);
            this.panel3.Controls.Add(this.expandButton);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1005, 41);
            this.panel3.TabIndex = 25;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Transparent;
            this.exitButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.exitButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.exitButton.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.exitButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.exitButton.IconSize = 36;
            this.exitButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.exitButton.Location = new System.Drawing.Point(969, 0);
            this.exitButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(36, 41);
            this.exitButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exitButton.TabIndex = 14;
            this.exitButton.TabStop = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // expandButton
            // 
            this.expandButton.BackColor = System.Drawing.Color.Transparent;
            this.expandButton.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.expandButton.IconColor = System.Drawing.Color.White;
            this.expandButton.IconSize = 37;
            this.expandButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.expandButton.Location = new System.Drawing.Point(1387, 0);
            this.expandButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.expandButton.Name = "expandButton";
            this.expandButton.Size = new System.Drawing.Size(37, 44);
            this.expandButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.expandButton.TabIndex = 15;
            this.expandButton.TabStop = false;
            // 
            // soldDataGridView
            // 
            this.soldDataGridView.AllowUserToAddRows = false;
            this.soldDataGridView.AllowUserToDeleteRows = false;
            this.soldDataGridView.AllowUserToResizeColumns = false;
            this.soldDataGridView.AllowUserToResizeRows = false;
            this.soldDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.soldDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.soldDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.soldDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.soldDataGridView.CausesValidation = false;
            this.soldDataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.soldDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.soldDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.soldDataGridView.ColumnHeadersHeight = 30;
            this.soldDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.soldDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column9,
            this.Column10,
            this.Column7,
            this.Column8,
            this.Cancel});
            this.soldDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.soldDataGridView.EnableHeadersVisualStyles = false;
            this.soldDataGridView.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.soldDataGridView.Location = new System.Drawing.Point(0, 82);
            this.soldDataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.soldDataGridView.MultiSelect = false;
            this.soldDataGridView.Name = "soldDataGridView";
            this.soldDataGridView.ReadOnly = true;
            this.soldDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.soldDataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soldDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.soldDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.soldDataGridView.Size = new System.Drawing.Size(1005, 467);
            this.soldDataGridView.TabIndex = 16;
            this.soldDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.soldDataGridView_CellContentClick);
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
            this.Column3.HeaderText = "INVOICE #";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 93;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column4.HeaderText = "PCODE";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 73;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.HeaderText = "DESCRIPTION";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Column9.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column9.HeaderText = "PRICE";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 65;
            // 
            // Column10
            // 
            this.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column10.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column10.HeaderText = "QUANTITY";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Width = 93;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Column7.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column7.HeaderText = "DISCOUNT";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 95;
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Column8.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column8.HeaderText = "TOTAL";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 67;
            // 
            // Cancel
            // 
            this.Cancel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Cancel.HeaderText = "";
            this.Cancel.Image = ((System.Drawing.Image)(resources.GetObject("Cancel.Image")));
            this.Cancel.Name = "Cancel";
            this.Cancel.ReadOnly = true;
            this.Cancel.Width = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-3, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 16);
            this.label1.TabIndex = 26;
            this.label1.Text = "Filter By Date( From - To )";
            // 
            // fromDateTimePicker
            // 
            this.fromDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fromDateTimePicker.Location = new System.Drawing.Point(163, 47);
            this.fromDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fromDateTimePicker.Name = "fromDateTimePicker";
            this.fromDateTimePicker.Size = new System.Drawing.Size(201, 22);
            this.fromDateTimePicker.TabIndex = 27;
            this.fromDateTimePicker.ValueChanged += new System.EventHandler(this.fromDateTimePicker_ValueChanged);
            // 
            // toDateTimePicker
            // 
            this.toDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.toDateTimePicker.Location = new System.Drawing.Point(370, 47);
            this.toDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.toDateTimePicker.Name = "toDateTimePicker";
            this.toDateTimePicker.Size = new System.Drawing.Size(192, 22);
            this.toDateTimePicker.TabIndex = 28;
            this.toDateTimePicker.ValueChanged += new System.EventHandler(this.toDateTimePicker_ValueChanged);
            // 
            // totalLabel
            // 
            this.totalLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.totalLabel.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.ForeColor = System.Drawing.Color.Crimson;
            this.totalLabel.Location = new System.Drawing.Point(890, 47);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(115, 31);
            this.totalLabel.TabIndex = 29;
            this.totalLabel.Text = "0.00";
            this.totalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // printButton
            // 
            this.printButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.printButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.printButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.printButton.FlatAppearance.BorderSize = 0;
            this.printButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printButton.ForeColor = System.Drawing.Color.White;
            this.printButton.Image = ((System.Drawing.Image)(resources.GetObject("printButton.Image")));
            this.printButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.printButton.Location = new System.Drawing.Point(729, 48);
            this.printButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(155, 27);
            this.printButton.TabIndex = 30;
            this.printButton.Text = "Print Preview";
            this.printButton.UseVisualStyleBackColor = false;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // cashierComboBox
            // 
            this.cashierComboBox.FormattingEnabled = true;
            this.cashierComboBox.Location = new System.Drawing.Point(568, 47);
            this.cashierComboBox.Name = "cashierComboBox";
            this.cashierComboBox.Size = new System.Drawing.Size(155, 25);
            this.cashierComboBox.TabIndex = 31;
            this.cashierComboBox.SelectedIndexChanged += new System.EventHandler(this.cashierComboBox_SelectedIndexChanged);
            this.cashierComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cashierComboBox_KeyPress);
            // 
            // SoldItemsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1005, 549);
            this.ControlBox = false;
            this.Controls.Add(this.cashierComboBox);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.toDateTimePicker);
            this.Controls.Add(this.fromDateTimePicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.soldDataGridView);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SoldItemsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SoldItemsForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expandButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soldDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconPictureBox exitButton;
        private FontAwesome.Sharp.IconPictureBox expandButton;
        private System.Windows.Forms.DataGridView soldDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label totalLabel;
        public System.Windows.Forms.Button printButton;
        public System.Windows.Forms.DateTimePicker fromDateTimePicker;
        public System.Windows.Forms.DateTimePicker toDateTimePicker;
        public System.Windows.Forms.ComboBox cashierComboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewImageColumn Cancel;
    }
}