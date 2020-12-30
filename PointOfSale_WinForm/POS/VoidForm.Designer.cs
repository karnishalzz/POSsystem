namespace PointOfSale_WinForm.POS
{
    partial class VoidForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VoidForm));
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.exitButton = new FontAwesome.Sharp.IconPictureBox();
            this.expandButton = new FontAwesome.Sharp.IconPictureBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.passTextBox = new MetroFramework.Controls.MetroTextBox();
            this.usernameTextBox = new MetroFramework.Controls.MetroTextBox();
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
            this.panel3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(399, 39);
            this.panel3.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 21);
            this.label1.TabIndex = 16;
            this.label1.Text = "Void Cancel Order";
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Transparent;
            this.exitButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.exitButton.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.exitButton.IconColor = System.Drawing.Color.White;
            this.exitButton.IconSize = 36;
            this.exitButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.exitButton.Location = new System.Drawing.Point(363, 0);
            this.exitButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(36, 39);
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
            this.expandButton.Location = new System.Drawing.Point(1403, 0);
            this.expandButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.expandButton.Name = "expandButton";
            this.expandButton.Size = new System.Drawing.Size(37, 44);
            this.expandButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.expandButton.TabIndex = 15;
            this.expandButton.TabStop = false;
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
            this.loginButton.Location = new System.Drawing.Point(21, 119);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(352, 42);
            this.loginButton.TabIndex = 30;
            this.loginButton.Text = "VOID";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // passTextBox
            // 
            this.passTextBox.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.passTextBox.CustomButton.Image = null;
            this.passTextBox.CustomButton.Location = new System.Drawing.Point(324, 2);
            this.passTextBox.CustomButton.Name = "";
            this.passTextBox.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.passTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.passTextBox.CustomButton.TabIndex = 1;
            this.passTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.passTextBox.CustomButton.UseSelectable = true;
            this.passTextBox.CustomButton.Visible = false;
            this.passTextBox.DisplayIcon = true;
            this.passTextBox.Icon = ((System.Drawing.Image)(resources.GetObject("passTextBox.Icon")));
            this.passTextBox.Lines = new string[0];
            this.passTextBox.Location = new System.Drawing.Point(21, 83);
            this.passTextBox.MaxLength = 32767;
            this.passTextBox.Name = "passTextBox";
            this.passTextBox.PasswordChar = '*';
            this.passTextBox.PromptText = "Password";
            this.passTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.passTextBox.SelectedText = "";
            this.passTextBox.SelectionLength = 0;
            this.passTextBox.SelectionStart = 0;
            this.passTextBox.ShortcutsEnabled = true;
            this.passTextBox.Size = new System.Drawing.Size(352, 30);
            this.passTextBox.TabIndex = 29;
            this.passTextBox.UseSelectable = true;
            this.passTextBox.WaterMark = "Password";
            this.passTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.passTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.usernameTextBox.CustomButton.Image = null;
            this.usernameTextBox.CustomButton.Location = new System.Drawing.Point(324, 2);
            this.usernameTextBox.CustomButton.Name = "";
            this.usernameTextBox.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.usernameTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.usernameTextBox.CustomButton.TabIndex = 1;
            this.usernameTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.usernameTextBox.CustomButton.UseSelectable = true;
            this.usernameTextBox.CustomButton.Visible = false;
            this.usernameTextBox.DisplayIcon = true;
            this.usernameTextBox.Icon = ((System.Drawing.Image)(resources.GetObject("usernameTextBox.Icon")));
            this.usernameTextBox.Lines = new string[0];
            this.usernameTextBox.Location = new System.Drawing.Point(21, 47);
            this.usernameTextBox.MaxLength = 32767;
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.PasswordChar = '\0';
            this.usernameTextBox.PromptText = "Username";
            this.usernameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.usernameTextBox.SelectedText = "";
            this.usernameTextBox.SelectionLength = 0;
            this.usernameTextBox.SelectionStart = 0;
            this.usernameTextBox.ShortcutsEnabled = true;
            this.usernameTextBox.Size = new System.Drawing.Size(352, 30);
            this.usernameTextBox.TabIndex = 31;
            this.usernameTextBox.UseSelectable = true;
            this.usernameTextBox.WaterMark = "Username";
            this.usernameTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.usernameTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // VoidForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 180);
            this.ControlBox = false;
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passTextBox);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "VoidForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VoidForm";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expandButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconPictureBox exitButton;
        private FontAwesome.Sharp.IconPictureBox expandButton;
        private System.Windows.Forms.Button loginButton;
        private MetroFramework.Controls.MetroTextBox passTextBox;
        private MetroFramework.Controls.MetroTextBox usernameTextBox;
    }
}