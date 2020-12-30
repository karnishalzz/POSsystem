namespace PointOfSale_WinForm.POS
{
    partial class CancelDetailsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.exitButton = new FontAwesome.Sharp.IconPictureBox();
            this.expandButton = new FontAwesome.Sharp.IconPictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.codeTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.transTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.discountTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cancelByTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.voidByTextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.actionComboBox = new System.Windows.Forms.ComboBox();
            this.reasonTextBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cancelQtyTextBox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
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
            this.panel3.Size = new System.Drawing.Size(814, 34);
            this.panel3.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 21);
            this.label1.TabIndex = 16;
            this.label1.Text = "Cancel Order Details";
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Transparent;
            this.exitButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.exitButton.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.exitButton.IconColor = System.Drawing.Color.White;
            this.exitButton.IconSize = 34;
            this.exitButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.exitButton.Location = new System.Drawing.Point(778, 0);
            this.exitButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(36, 34);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 17);
            this.label2.TabIndex = 27;
            this.label2.Text = "ID";
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(112, 74);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(278, 25);
            this.idTextBox.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(195)))), ((int)(((byte)(239)))));
            this.label3.Location = new System.Drawing.Point(12, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 21);
            this.label3.TabIndex = 29;
            this.label3.Text = "SOLD ITEM";
            // 
            // codeTextBox
            // 
            this.codeTextBox.Location = new System.Drawing.Point(112, 105);
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.ReadOnly = true;
            this.codeTextBox.Size = new System.Drawing.Size(278, 25);
            this.codeTextBox.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 17);
            this.label4.TabIndex = 30;
            this.label4.Text = "Product Code";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(112, 136);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.ReadOnly = true;
            this.descriptionTextBox.Size = new System.Drawing.Size(278, 57);
            this.descriptionTextBox.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 17);
            this.label5.TabIndex = 32;
            this.label5.Text = "Description";
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(509, 105);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.ReadOnly = true;
            this.priceTextBox.Size = new System.Drawing.Size(278, 25);
            this.priceTextBox.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(410, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 17);
            this.label6.TabIndex = 36;
            this.label6.Text = "Price";
            // 
            // transTextBox
            // 
            this.transTextBox.Location = new System.Drawing.Point(509, 74);
            this.transTextBox.Name = "transTextBox";
            this.transTextBox.ReadOnly = true;
            this.transTextBox.Size = new System.Drawing.Size(278, 25);
            this.transTextBox.TabIndex = 35;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(410, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 17);
            this.label7.TabIndex = 34;
            this.label7.Text = "Transaction No";
            // 
            // totalTextBox
            // 
            this.totalTextBox.Location = new System.Drawing.Point(509, 168);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.ReadOnly = true;
            this.totalTextBox.Size = new System.Drawing.Size(278, 25);
            this.totalTextBox.TabIndex = 41;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(410, 171);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 17);
            this.label8.TabIndex = 40;
            this.label8.Text = "Total";
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(509, 137);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.ReadOnly = true;
            this.quantityTextBox.Size = new System.Drawing.Size(138, 25);
            this.quantityTextBox.TabIndex = 39;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(410, 140);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 17);
            this.label9.TabIndex = 38;
            this.label9.Text = "Qty/Discount";
            // 
            // discountTextBox
            // 
            this.discountTextBox.Location = new System.Drawing.Point(649, 137);
            this.discountTextBox.Name = "discountTextBox";
            this.discountTextBox.ReadOnly = true;
            this.discountTextBox.Size = new System.Drawing.Size(138, 25);
            this.discountTextBox.TabIndex = 42;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(158)))), ((int)(((byte)(132)))));
            this.label10.Location = new System.Drawing.Point(12, 248);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(129, 21);
            this.label10.TabIndex = 43;
            this.label10.Text = "CANCEL ITEM(S)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 348);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 17);
            this.label11.TabIndex = 48;
            this.label11.Text = "Add to Inventory?";
            // 
            // cancelByTextBox
            // 
            this.cancelByTextBox.Location = new System.Drawing.Point(130, 309);
            this.cancelByTextBox.Name = "cancelByTextBox";
            this.cancelByTextBox.ReadOnly = true;
            this.cancelByTextBox.Size = new System.Drawing.Size(278, 25);
            this.cancelByTextBox.TabIndex = 47;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 317);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 17);
            this.label12.TabIndex = 46;
            this.label12.Text = "Cancelled By";
            // 
            // voidByTextBox
            // 
            this.voidByTextBox.Location = new System.Drawing.Point(130, 278);
            this.voidByTextBox.Name = "voidByTextBox";
            this.voidByTextBox.ReadOnly = true;
            this.voidByTextBox.Size = new System.Drawing.Size(278, 25);
            this.voidByTextBox.TabIndex = 45;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(13, 286);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 17);
            this.label13.TabIndex = 44;
            this.label13.Text = "Void By";
            // 
            // actionComboBox
            // 
            this.actionComboBox.FormattingEnabled = true;
            this.actionComboBox.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.actionComboBox.Location = new System.Drawing.Point(130, 348);
            this.actionComboBox.Name = "actionComboBox";
            this.actionComboBox.Size = new System.Drawing.Size(278, 25);
            this.actionComboBox.TabIndex = 49;
            this.actionComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.actionComboBox_KeyPress);
            // 
            // reasonTextBox
            // 
            this.reasonTextBox.Location = new System.Drawing.Point(523, 309);
            this.reasonTextBox.Multiline = true;
            this.reasonTextBox.Name = "reasonTextBox";
            this.reasonTextBox.Size = new System.Drawing.Size(278, 57);
            this.reasonTextBox.TabIndex = 53;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(424, 312);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 17);
            this.label14.TabIndex = 52;
            this.label14.Text = "Reason(s)";
            // 
            // cancelQtyTextBox
            // 
            this.cancelQtyTextBox.Location = new System.Drawing.Point(523, 278);
            this.cancelQtyTextBox.Name = "cancelQtyTextBox";
            this.cancelQtyTextBox.Size = new System.Drawing.Size(278, 25);
            this.cancelQtyTextBox.TabIndex = 51;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(424, 281);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(98, 17);
            this.label15.TabIndex = 50;
            this.label15.Text = "Cancel Quantity";
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.cancelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cancelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelButton.FlatAppearance.BorderSize = 0;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.ForeColor = System.Drawing.Color.White;
            this.cancelButton.Location = new System.Drawing.Point(603, 395);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(198, 33);
            this.cancelButton.TabIndex = 54;
            this.cancelButton.Text = "Cancel Order";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // CancelDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 445);
            this.ControlBox = false;
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.reasonTextBox);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.cancelQtyTextBox);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.actionComboBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cancelByTextBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.voidByTextBox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.discountTextBox);
            this.Controls.Add(this.totalTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.transTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.codeTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CancelDetailsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CancelDetailsForm";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expandButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconPictureBox exitButton;
        private FontAwesome.Sharp.IconPictureBox expandButton;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox codeTextBox;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox transTextBox;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox discountTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox cancelByTextBox;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.TextBox voidByTextBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        public System.Windows.Forms.Button cancelButton;
        public System.Windows.Forms.TextBox reasonTextBox;
        public System.Windows.Forms.TextBox cancelQtyTextBox;
        public System.Windows.Forms.ComboBox actionComboBox;
    }
}