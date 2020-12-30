namespace PointOfSale_WinForm.Other
{
    partial class LicesnseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LicesnseForm));
            this.panel3 = new System.Windows.Forms.Panel();
            this.expandButton = new FontAwesome.Sharp.IconPictureBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.loginButton = new System.Windows.Forms.Button();
            this.pcIdTextBox = new MetroFramework.Controls.MetroTextBox();
            this.productCodeTextBox = new MetroFramework.Controls.MetroTextBox();
            this.licenseTextBox = new MetroFramework.Controls.MetroTextBox();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.expandButton)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(195)))), ((int)(((byte)(239)))));
            this.panel3.Controls.Add(this.expandButton);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(375, 15);
            this.panel3.TabIndex = 26;
            // 
            // expandButton
            // 
            this.expandButton.BackColor = System.Drawing.Color.Transparent;
            this.expandButton.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.expandButton.IconColor = System.Drawing.Color.White;
            this.expandButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.expandButton.Location = new System.Drawing.Point(1203, 0);
            this.expandButton.Name = "expandButton";
            this.expandButton.Size = new System.Drawing.Size(32, 34);
            this.expandButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.expandButton.TabIndex = 15;
            this.expandButton.TabStop = false;
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.DimGray;
            this.cancelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cancelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelButton.FlatAppearance.BorderSize = 0;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.ForeColor = System.Drawing.Color.White;
            this.cancelButton.Location = new System.Drawing.Point(11, 181);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(352, 36);
            this.cancelButton.TabIndex = 35;
            this.cancelButton.Text = "Exit";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.loginButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.loginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginButton.FlatAppearance.BorderSize = 0;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.ForeColor = System.Drawing.Color.White;
            this.loginButton.Location = new System.Drawing.Point(11, 133);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(352, 42);
            this.loginButton.TabIndex = 34;
            this.loginButton.Text = "Submit";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // pcIdTextBox
            // 
            this.pcIdTextBox.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.pcIdTextBox.CustomButton.Image = null;
            this.pcIdTextBox.CustomButton.Location = new System.Drawing.Point(324, 2);
            this.pcIdTextBox.CustomButton.Name = "";
            this.pcIdTextBox.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.pcIdTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.pcIdTextBox.CustomButton.TabIndex = 1;
            this.pcIdTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.pcIdTextBox.CustomButton.UseSelectable = true;
            this.pcIdTextBox.CustomButton.Visible = false;
            this.pcIdTextBox.DisplayIcon = true;
            this.pcIdTextBox.Icon = ((System.Drawing.Image)(resources.GetObject("pcIdTextBox.Icon")));
            this.pcIdTextBox.Lines = new string[0];
            this.pcIdTextBox.Location = new System.Drawing.Point(11, 61);
            this.pcIdTextBox.MaxLength = 32767;
            this.pcIdTextBox.Name = "pcIdTextBox";
            this.pcIdTextBox.PasswordChar = '\0';
            this.pcIdTextBox.PromptText = "PC Id";
            this.pcIdTextBox.ReadOnly = true;
            this.pcIdTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.pcIdTextBox.SelectedText = "";
            this.pcIdTextBox.SelectionLength = 0;
            this.pcIdTextBox.SelectionStart = 0;
            this.pcIdTextBox.ShortcutsEnabled = true;
            this.pcIdTextBox.Size = new System.Drawing.Size(352, 30);
            this.pcIdTextBox.TabIndex = 33;
            this.pcIdTextBox.UseSelectable = true;
            this.pcIdTextBox.WaterMark = "PC Id";
            this.pcIdTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.pcIdTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // productCodeTextBox
            // 
            this.productCodeTextBox.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.productCodeTextBox.CustomButton.Image = null;
            this.productCodeTextBox.CustomButton.Location = new System.Drawing.Point(324, 2);
            this.productCodeTextBox.CustomButton.Name = "";
            this.productCodeTextBox.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.productCodeTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.productCodeTextBox.CustomButton.TabIndex = 1;
            this.productCodeTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.productCodeTextBox.CustomButton.UseSelectable = true;
            this.productCodeTextBox.CustomButton.Visible = false;
            this.productCodeTextBox.DisplayIcon = true;
            this.productCodeTextBox.Icon = ((System.Drawing.Image)(resources.GetObject("productCodeTextBox.Icon")));
            this.productCodeTextBox.Lines = new string[0];
            this.productCodeTextBox.Location = new System.Drawing.Point(11, 25);
            this.productCodeTextBox.MaxLength = 32767;
            this.productCodeTextBox.Name = "productCodeTextBox";
            this.productCodeTextBox.PasswordChar = '\0';
            this.productCodeTextBox.PromptText = "Product Code";
            this.productCodeTextBox.ReadOnly = true;
            this.productCodeTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.productCodeTextBox.SelectedText = "";
            this.productCodeTextBox.SelectionLength = 0;
            this.productCodeTextBox.SelectionStart = 0;
            this.productCodeTextBox.ShortcutsEnabled = true;
            this.productCodeTextBox.Size = new System.Drawing.Size(352, 30);
            this.productCodeTextBox.TabIndex = 32;
            this.productCodeTextBox.UseSelectable = true;
            this.productCodeTextBox.WaterMark = "Product Code";
            this.productCodeTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.productCodeTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // licenseTextBox
            // 
            this.licenseTextBox.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.licenseTextBox.CustomButton.Image = null;
            this.licenseTextBox.CustomButton.Location = new System.Drawing.Point(324, 2);
            this.licenseTextBox.CustomButton.Name = "";
            this.licenseTextBox.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.licenseTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.licenseTextBox.CustomButton.TabIndex = 1;
            this.licenseTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.licenseTextBox.CustomButton.UseSelectable = true;
            this.licenseTextBox.CustomButton.Visible = false;
            this.licenseTextBox.DisplayIcon = true;
            this.licenseTextBox.Icon = ((System.Drawing.Image)(resources.GetObject("licenseTextBox.Icon")));
            this.licenseTextBox.Lines = new string[0];
            this.licenseTextBox.Location = new System.Drawing.Point(11, 97);
            this.licenseTextBox.MaxLength = 32767;
            this.licenseTextBox.Name = "licenseTextBox";
            this.licenseTextBox.PasswordChar = '\0';
            this.licenseTextBox.PromptText = "License Key";
            this.licenseTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.licenseTextBox.SelectedText = "";
            this.licenseTextBox.SelectionLength = 0;
            this.licenseTextBox.SelectionStart = 0;
            this.licenseTextBox.ShortcutsEnabled = true;
            this.licenseTextBox.Size = new System.Drawing.Size(352, 30);
            this.licenseTextBox.TabIndex = 36;
            this.licenseTextBox.UseSelectable = true;
            this.licenseTextBox.WaterMark = "License Key";
            this.licenseTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.licenseTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // LicesnseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 230);
            this.ControlBox = false;
            this.Controls.Add(this.licenseTextBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.pcIdTextBox);
            this.Controls.Add(this.productCodeTextBox);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "LicesnseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Licesnse";
            this.Load += new System.EventHandler(this.LicesnseForm_Load);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.expandButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconPictureBox expandButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button loginButton;
        private MetroFramework.Controls.MetroTextBox pcIdTextBox;
        private MetroFramework.Controls.MetroTextBox productCodeTextBox;
        private MetroFramework.Controls.MetroTextBox licenseTextBox;
    }
}