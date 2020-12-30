namespace PointOfSale_WinForm.User
{
    partial class UserForm
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.userTabControl = new MetroFramework.Controls.MetroTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.availLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.checkAvailButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.roleComboBox = new System.Windows.Forms.ComboBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.retypPassTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.passTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cancelPassChangeButton = new System.Windows.Forms.Button();
            this.savePassChhangebutton = new System.Windows.Forms.Button();
            this.retypetextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.newtextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.oldtextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.usertextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.userIdlabel = new System.Windows.Forms.Label();
            this.usersTextBox = new System.Windows.Forms.TextBox();
            this.activateButton = new System.Windows.Forms.Button();
            this.activeCheckBox = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.userTabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.metroLabel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1005, 32);
            this.panel3.TabIndex = 7;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(3, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(148, 25);
            this.metroLabel1.TabIndex = 7;
            this.metroLabel1.Text = "User Managment";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // userTabControl
            // 
            this.userTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userTabControl.Controls.Add(this.tabPage1);
            this.userTabControl.Controls.Add(this.tabPage2);
            this.userTabControl.Controls.Add(this.tabPage3);
            this.userTabControl.Location = new System.Drawing.Point(126, 115);
            this.userTabControl.Name = "userTabControl";
            this.userTabControl.SelectedIndex = 0;
            this.userTabControl.Size = new System.Drawing.Size(719, 395);
            this.userTabControl.TabIndex = 8;
            this.userTabControl.UseSelectable = true;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.availLabel);
            this.tabPage1.Controls.Add(this.cancelButton);
            this.tabPage1.Controls.Add(this.checkAvailButton);
            this.tabPage1.Controls.Add(this.saveButton);
            this.tabPage1.Controls.Add(this.roleComboBox);
            this.tabPage1.Controls.Add(this.nameTextBox);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.retypPassTextBox);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.passTextBox);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.usernameTextBox);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 38);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(711, 353);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Create User";
            // 
            // availLabel
            // 
            this.availLabel.BackColor = System.Drawing.Color.Gold;
            this.availLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availLabel.ForeColor = System.Drawing.Color.DarkGreen;
            this.availLabel.Location = new System.Drawing.Point(189, 297);
            this.availLabel.Name = "availLabel";
            this.availLabel.Size = new System.Drawing.Size(216, 25);
            this.availLabel.TabIndex = 34;
            this.availLabel.Text = "Username Available";
            this.availLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.availLabel.Visible = false;
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
            this.cancelButton.Location = new System.Drawing.Point(537, 257);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(115, 33);
            this.cancelButton.TabIndex = 33;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // checkAvailButton
            // 
            this.checkAvailButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.checkAvailButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.checkAvailButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkAvailButton.FlatAppearance.BorderSize = 0;
            this.checkAvailButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkAvailButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkAvailButton.ForeColor = System.Drawing.Color.White;
            this.checkAvailButton.Location = new System.Drawing.Point(189, 257);
            this.checkAvailButton.Name = "checkAvailButton";
            this.checkAvailButton.Size = new System.Drawing.Size(216, 33);
            this.checkAvailButton.TabIndex = 32;
            this.checkAvailButton.Text = "Check Availabliity";
            this.checkAvailButton.UseVisualStyleBackColor = false;
            this.checkAvailButton.Click += new System.EventHandler(this.checkAvailButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.saveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.saveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveButton.FlatAppearance.BorderSize = 0;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.ForeColor = System.Drawing.Color.White;
            this.saveButton.Location = new System.Drawing.Point(411, 257);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(120, 33);
            this.saveButton.TabIndex = 31;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // roleComboBox
            // 
            this.roleComboBox.FormattingEnabled = true;
            this.roleComboBox.Items.AddRange(new object[] {
            "Administrative",
            "Cashier"});
            this.roleComboBox.Location = new System.Drawing.Point(189, 164);
            this.roleComboBox.Name = "roleComboBox";
            this.roleComboBox.Size = new System.Drawing.Size(463, 25);
            this.roleComboBox.TabIndex = 30;
            this.roleComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.roleComboBox_KeyPress);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(189, 211);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(463, 25);
            this.nameTextBox.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(130, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 17);
            this.label5.TabIndex = 28;
            this.label5.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(139, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 17);
            this.label4.TabIndex = 27;
            this.label4.Text = "Role";
            // 
            // retypPassTextBox
            // 
            this.retypPassTextBox.Location = new System.Drawing.Point(189, 116);
            this.retypPassTextBox.Name = "retypPassTextBox";
            this.retypPassTextBox.PasswordChar = '*';
            this.retypPassTextBox.Size = new System.Drawing.Size(463, 25);
            this.retypPassTextBox.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 17);
            this.label3.TabIndex = 25;
            this.label3.Text = "Re-Type Password";
            // 
            // passTextBox
            // 
            this.passTextBox.Location = new System.Drawing.Point(189, 75);
            this.passTextBox.Name = "passTextBox";
            this.passTextBox.PasswordChar = '*';
            this.passTextBox.Size = new System.Drawing.Size(463, 25);
            this.passTextBox.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "Password";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(189, 31);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(463, 25);
            this.usernameTextBox.TabIndex = 22;
            this.usernameTextBox.TextChanged += new System.EventHandler(this.usernameTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "Username";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.cancelPassChangeButton);
            this.tabPage2.Controls.Add(this.savePassChhangebutton);
            this.tabPage2.Controls.Add(this.retypetextBox);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.newtextBox);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.oldtextBox);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.usertextBox);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 38);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(711, 353);
            this.tabPage2.TabIndex = 4;
            this.tabPage2.Text = "Change Password";
            // 
            // cancelPassChangeButton
            // 
            this.cancelPassChangeButton.BackColor = System.Drawing.Color.DimGray;
            this.cancelPassChangeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cancelPassChangeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelPassChangeButton.FlatAppearance.BorderSize = 0;
            this.cancelPassChangeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelPassChangeButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelPassChangeButton.ForeColor = System.Drawing.Color.White;
            this.cancelPassChangeButton.Location = new System.Drawing.Point(533, 247);
            this.cancelPassChangeButton.Name = "cancelPassChangeButton";
            this.cancelPassChangeButton.Size = new System.Drawing.Size(115, 33);
            this.cancelPassChangeButton.TabIndex = 31;
            this.cancelPassChangeButton.Text = "Cancel";
            this.cancelPassChangeButton.UseVisualStyleBackColor = false;
            this.cancelPassChangeButton.Click += new System.EventHandler(this.cancelPassChangeButton_Click);
            // 
            // savePassChhangebutton
            // 
            this.savePassChhangebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.savePassChhangebutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.savePassChhangebutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.savePassChhangebutton.FlatAppearance.BorderSize = 0;
            this.savePassChhangebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savePassChhangebutton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savePassChhangebutton.ForeColor = System.Drawing.Color.White;
            this.savePassChhangebutton.Location = new System.Drawing.Point(407, 247);
            this.savePassChhangebutton.Name = "savePassChhangebutton";
            this.savePassChhangebutton.Size = new System.Drawing.Size(120, 33);
            this.savePassChhangebutton.TabIndex = 30;
            this.savePassChhangebutton.Text = "Save";
            this.savePassChhangebutton.UseVisualStyleBackColor = false;
            this.savePassChhangebutton.Click += new System.EventHandler(this.savePassChhangebutton_Click);
            // 
            // retypetextBox
            // 
            this.retypetextBox.Location = new System.Drawing.Point(184, 199);
            this.retypetextBox.Name = "retypetextBox";
            this.retypetextBox.PasswordChar = '*';
            this.retypetextBox.Size = new System.Drawing.Size(463, 25);
            this.retypetextBox.TabIndex = 29;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(63, 202);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 17);
            this.label9.TabIndex = 28;
            this.label9.Text = "Re-Type Password";
            // 
            // newtextBox
            // 
            this.newtextBox.Location = new System.Drawing.Point(184, 158);
            this.newtextBox.Name = "newtextBox";
            this.newtextBox.PasswordChar = '*';
            this.newtextBox.Size = new System.Drawing.Size(463, 25);
            this.newtextBox.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(63, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 17);
            this.label6.TabIndex = 26;
            this.label6.Text = "New Password";
            // 
            // oldtextBox
            // 
            this.oldtextBox.Location = new System.Drawing.Point(184, 117);
            this.oldtextBox.Name = "oldtextBox";
            this.oldtextBox.PasswordChar = '*';
            this.oldtextBox.Size = new System.Drawing.Size(463, 25);
            this.oldtextBox.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(63, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 17);
            this.label7.TabIndex = 24;
            this.label7.Text = "Old Password";
            // 
            // usertextBox
            // 
            this.usertextBox.Location = new System.Drawing.Point(184, 73);
            this.usertextBox.Name = "usertextBox";
            this.usertextBox.ReadOnly = true;
            this.usertextBox.Size = new System.Drawing.Size(463, 25);
            this.usertextBox.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(63, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 17);
            this.label8.TabIndex = 22;
            this.label8.Text = "Username";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.White;
            this.tabPage3.Controls.Add(this.userIdlabel);
            this.tabPage3.Controls.Add(this.usersTextBox);
            this.tabPage3.Controls.Add(this.activateButton);
            this.tabPage3.Controls.Add(this.activeCheckBox);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage3.Location = new System.Drawing.Point(4, 38);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(711, 353);
            this.tabPage3.TabIndex = 5;
            this.tabPage3.Text = "Activate/Deactivate User";
            // 
            // userIdlabel
            // 
            this.userIdlabel.AutoSize = true;
            this.userIdlabel.Location = new System.Drawing.Point(260, 161);
            this.userIdlabel.Name = "userIdlabel";
            this.userIdlabel.Size = new System.Drawing.Size(0, 17);
            this.userIdlabel.TabIndex = 25;
            this.userIdlabel.Visible = false;
            // 
            // usersTextBox
            // 
            this.usersTextBox.Location = new System.Drawing.Point(182, 121);
            this.usersTextBox.Name = "usersTextBox";
            this.usersTextBox.Size = new System.Drawing.Size(427, 25);
            this.usersTextBox.TabIndex = 24;
            this.usersTextBox.TextChanged += new System.EventHandler(this.usersTextBox_TextChanged_1);
            // 
            // activateButton
            // 
            this.activateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.activateButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.activateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.activateButton.FlatAppearance.BorderSize = 0;
            this.activateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.activateButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activateButton.ForeColor = System.Drawing.Color.White;
            this.activateButton.Location = new System.Drawing.Point(182, 199);
            this.activateButton.Name = "activateButton";
            this.activateButton.Size = new System.Drawing.Size(120, 33);
            this.activateButton.TabIndex = 23;
            this.activateButton.Text = "Save";
            this.activateButton.UseVisualStyleBackColor = false;
            this.activateButton.Click += new System.EventHandler(this.activateButton_Click);
            // 
            // activeCheckBox
            // 
            this.activeCheckBox.AutoSize = true;
            this.activeCheckBox.Location = new System.Drawing.Point(182, 161);
            this.activeCheckBox.Name = "activeCheckBox";
            this.activeCheckBox.Size = new System.Drawing.Size(70, 21);
            this.activeCheckBox.TabIndex = 22;
            this.activeCheckBox.Text = "IsActive";
            this.activeCheckBox.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(102, 121);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 17);
            this.label10.TabIndex = 21;
            this.label10.Text = "Username";
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1005, 587);
            this.ControlBox = false;
            this.Controls.Add(this.userTabControl);
            this.Controls.Add(this.panel3);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "UserForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Resize += new System.EventHandler(this.UserForm_Resize);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.userTabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTabControl userTabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label availLabel;
        public System.Windows.Forms.Button cancelButton;
        public System.Windows.Forms.Button checkAvailButton;
        public System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.ComboBox roleComboBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox retypPassTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox passTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        public System.Windows.Forms.Button cancelPassChangeButton;
        public System.Windows.Forms.Button savePassChhangebutton;
        private System.Windows.Forms.TextBox retypetextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox newtextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox oldtextBox;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox usertextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label userIdlabel;
        private System.Windows.Forms.TextBox usersTextBox;
        public System.Windows.Forms.Button activateButton;
        private System.Windows.Forms.CheckBox activeCheckBox;
        private System.Windows.Forms.Label label10;
    }
}