namespace PointOfSale_WinForm.POS
{
    partial class PasswordChangeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswordChangeForm));
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.exitButton = new FontAwesome.Sharp.IconPictureBox();
            this.expandButton = new FontAwesome.Sharp.IconPictureBox();
            this.confirmButton = new System.Windows.Forms.Button();
            this.oldpassTextBox = new MetroFramework.Controls.MetroTextBox();
            this.retypepassTextBox = new MetroFramework.Controls.MetroTextBox();
            this.newpassTextBox = new MetroFramework.Controls.MetroTextBox();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expandButton)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(195)))), ((int)(((byte)(239)))));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.exitButton);
            this.panel3.Controls.Add(this.expandButton);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(425, 29);
            this.panel3.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "Change Password";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Transparent;
            this.exitButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.exitButton.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.exitButton.IconColor = System.Drawing.Color.White;
            this.exitButton.IconSize = 29;
            this.exitButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.exitButton.Location = new System.Drawing.Point(394, 0);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(31, 29);
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
            this.expandButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.expandButton.Location = new System.Drawing.Point(1203, 0);
            this.expandButton.Name = "expandButton";
            this.expandButton.Size = new System.Drawing.Size(32, 34);
            this.expandButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.expandButton.TabIndex = 15;
            this.expandButton.TabStop = false;
            // 
            // confirmButton
            // 
            this.confirmButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.confirmButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.confirmButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.confirmButton.FlatAppearance.BorderSize = 0;
            this.confirmButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmButton.ForeColor = System.Drawing.Color.White;
            this.confirmButton.Location = new System.Drawing.Point(22, 154);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(380, 42);
            this.confirmButton.TabIndex = 30;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.UseVisualStyleBackColor = false;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // oldpassTextBox
            // 
            this.oldpassTextBox.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.oldpassTextBox.CustomButton.Image = null;
            this.oldpassTextBox.CustomButton.Location = new System.Drawing.Point(352, 2);
            this.oldpassTextBox.CustomButton.Name = "";
            this.oldpassTextBox.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.oldpassTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.oldpassTextBox.CustomButton.TabIndex = 1;
            this.oldpassTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.oldpassTextBox.CustomButton.UseSelectable = true;
            this.oldpassTextBox.CustomButton.Visible = false;
            this.oldpassTextBox.DisplayIcon = true;
            this.oldpassTextBox.Icon = ((System.Drawing.Image)(resources.GetObject("oldpassTextBox.Icon")));
            this.oldpassTextBox.Lines = new string[0];
            this.oldpassTextBox.Location = new System.Drawing.Point(22, 36);
            this.oldpassTextBox.MaxLength = 32767;
            this.oldpassTextBox.Name = "oldpassTextBox";
            this.oldpassTextBox.PasswordChar = '*';
            this.oldpassTextBox.PromptText = "Old Password";
            this.oldpassTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.oldpassTextBox.SelectedText = "";
            this.oldpassTextBox.SelectionLength = 0;
            this.oldpassTextBox.SelectionStart = 0;
            this.oldpassTextBox.ShortcutsEnabled = true;
            this.oldpassTextBox.Size = new System.Drawing.Size(380, 30);
            this.oldpassTextBox.TabIndex = 29;
            this.oldpassTextBox.UseSelectable = true;
            this.oldpassTextBox.WaterMark = "Old Password";
            this.oldpassTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.oldpassTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // retypepassTextBox
            // 
            this.retypepassTextBox.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.retypepassTextBox.CustomButton.Image = null;
            this.retypepassTextBox.CustomButton.Location = new System.Drawing.Point(352, 2);
            this.retypepassTextBox.CustomButton.Name = "";
            this.retypepassTextBox.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.retypepassTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.retypepassTextBox.CustomButton.TabIndex = 1;
            this.retypepassTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.retypepassTextBox.CustomButton.UseSelectable = true;
            this.retypepassTextBox.CustomButton.Visible = false;
            this.retypepassTextBox.DisplayIcon = true;
            this.retypepassTextBox.Icon = ((System.Drawing.Image)(resources.GetObject("retypepassTextBox.Icon")));
            this.retypepassTextBox.Lines = new string[0];
            this.retypepassTextBox.Location = new System.Drawing.Point(22, 109);
            this.retypepassTextBox.MaxLength = 32767;
            this.retypepassTextBox.Name = "retypepassTextBox";
            this.retypepassTextBox.PasswordChar = '*';
            this.retypepassTextBox.PromptText = "Confirm Password";
            this.retypepassTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.retypepassTextBox.SelectedText = "";
            this.retypepassTextBox.SelectionLength = 0;
            this.retypepassTextBox.SelectionStart = 0;
            this.retypepassTextBox.ShortcutsEnabled = true;
            this.retypepassTextBox.Size = new System.Drawing.Size(380, 30);
            this.retypepassTextBox.TabIndex = 31;
            this.retypepassTextBox.UseSelectable = true;
            this.retypepassTextBox.WaterMark = "Confirm Password";
            this.retypepassTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.retypepassTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // newpassTextBox
            // 
            this.newpassTextBox.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.newpassTextBox.CustomButton.Image = null;
            this.newpassTextBox.CustomButton.Location = new System.Drawing.Point(352, 2);
            this.newpassTextBox.CustomButton.Name = "";
            this.newpassTextBox.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.newpassTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.newpassTextBox.CustomButton.TabIndex = 1;
            this.newpassTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.newpassTextBox.CustomButton.UseSelectable = true;
            this.newpassTextBox.CustomButton.Visible = false;
            this.newpassTextBox.DisplayIcon = true;
            this.newpassTextBox.Icon = ((System.Drawing.Image)(resources.GetObject("newpassTextBox.Icon")));
            this.newpassTextBox.Lines = new string[0];
            this.newpassTextBox.Location = new System.Drawing.Point(22, 73);
            this.newpassTextBox.MaxLength = 32767;
            this.newpassTextBox.Name = "newpassTextBox";
            this.newpassTextBox.PasswordChar = '*';
            this.newpassTextBox.PromptText = "New Password";
            this.newpassTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.newpassTextBox.SelectedText = "";
            this.newpassTextBox.SelectionLength = 0;
            this.newpassTextBox.SelectionStart = 0;
            this.newpassTextBox.ShortcutsEnabled = true;
            this.newpassTextBox.Size = new System.Drawing.Size(380, 30);
            this.newpassTextBox.TabIndex = 32;
            this.newpassTextBox.UseSelectable = true;
            this.newpassTextBox.WaterMark = "New Password";
            this.newpassTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.newpassTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // PasswordChangeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 220);
            this.ControlBox = false;
            this.Controls.Add(this.newpassTextBox);
            this.Controls.Add(this.retypepassTextBox);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.oldpassTextBox);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PasswordChangeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PasswordChangeForm";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expandButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconPictureBox exitButton;
        private FontAwesome.Sharp.IconPictureBox expandButton;
        private System.Windows.Forms.Button confirmButton;
        private MetroFramework.Controls.MetroTextBox oldpassTextBox;
        private MetroFramework.Controls.MetroTextBox retypepassTextBox;
        private MetroFramework.Controls.MetroTextBox newpassTextBox;
        private System.Windows.Forms.Label label1;
    }
}