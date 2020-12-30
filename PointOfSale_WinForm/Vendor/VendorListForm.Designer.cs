namespace PointOfSale_WinForm.Vendor
{
    partial class VendorListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VendorListForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.searchTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.addButton = new FontAwesome.Sharp.IconPictureBox();
            this.vendorListDataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorListDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.metroLabel1);
            this.panel3.Controls.Add(this.addButton);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1011, 36);
            this.panel3.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.searchTextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(580, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(398, 36);
            this.panel1.TabIndex = 17;
            // 
            // searchTextBox
            // 
            // 
            // 
            // 
            this.searchTextBox.CustomButton.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTextBox.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.searchTextBox.CustomButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchTextBox.CustomButton.Location = new System.Drawing.Point(364, 2);
            this.searchTextBox.CustomButton.Name = "";
            this.searchTextBox.CustomButton.Size = new System.Drawing.Size(31, 31);
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
            this.searchTextBox.PromptText = "Search Vendor Name Here";
            this.searchTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.searchTextBox.SelectedText = "";
            this.searchTextBox.SelectionLength = 0;
            this.searchTextBox.SelectionStart = 0;
            this.searchTextBox.ShortcutsEnabled = true;
            this.searchTextBox.Size = new System.Drawing.Size(398, 36);
            this.searchTextBox.TabIndex = 16;
            this.searchTextBox.UseSelectable = true;
            this.searchTextBox.WaterMark = "Search Vendor Name Here";
            this.searchTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.searchTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(3, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(100, 25);
            this.metroLabel1.TabIndex = 7;
            this.metroLabel1.Text = "Vendor List";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.Transparent;
            this.addButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.addButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.addButton.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.addButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.addButton.IconSize = 33;
            this.addButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.addButton.Location = new System.Drawing.Point(978, 0);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(33, 36);
            this.addButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.addButton.TabIndex = 15;
            this.addButton.TabStop = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // vendorListDataGridView
            // 
            this.vendorListDataGridView.AllowUserToAddRows = false;
            this.vendorListDataGridView.AllowUserToDeleteRows = false;
            this.vendorListDataGridView.AllowUserToResizeColumns = false;
            this.vendorListDataGridView.AllowUserToResizeRows = false;
            this.vendorListDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vendorListDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.vendorListDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.vendorListDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.vendorListDataGridView.CausesValidation = false;
            this.vendorListDataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.vendorListDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.vendorListDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.vendorListDataGridView.ColumnHeadersHeight = 30;
            this.vendorListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.vendorListDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column3,
            this.Column5,
            this.Column9,
            this.Column6,
            this.Column10,
            this.Edit,
            this.Delete});
            this.vendorListDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.vendorListDataGridView.EnableHeadersVisualStyles = false;
            this.vendorListDataGridView.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.vendorListDataGridView.Location = new System.Drawing.Point(0, 36);
            this.vendorListDataGridView.MultiSelect = false;
            this.vendorListDataGridView.Name = "vendorListDataGridView";
            this.vendorListDataGridView.ReadOnly = true;
            this.vendorListDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.vendorListDataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vendorListDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.vendorListDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.vendorListDataGridView.Size = new System.Drawing.Size(1011, 542);
            this.vendorListDataGridView.TabIndex = 18;
            this.vendorListDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.vendorListDataGridView_CellContentClick);
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
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column4.HeaderText = "NAME";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 69;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "ADDRESS";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column5.HeaderText = "CONTACT PERSON";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 142;
            // 
            // Column9
            // 
            this.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column9.HeaderText = "PHONE";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column6.HeaderText = "EMAIL";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 68;
            // 
            // Column10
            // 
            this.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column10.HeaderText = "FAX";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Width = 53;
            // 
            // Edit
            // 
            this.Edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Edit.FillWeight = 50F;
            this.Edit.HeaderText = "";
            this.Edit.Image = ((System.Drawing.Image)(resources.GetObject("Edit.Image")));
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Delete.FillWeight = 50F;
            this.Delete.HeaderText = "";
            this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            // 
            // VendorListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 578);
            this.ControlBox = false;
            this.Controls.Add(this.vendorListDataGridView);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "VendorListForm";
            this.Text = "VendorListForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.addButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorListDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroTextBox searchTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private FontAwesome.Sharp.IconPictureBox addButton;
        private System.Windows.Forms.DataGridView vendorListDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
    }
}