namespace PointOfSale_WinForm.POS
{
    partial class SettlePaymentForm
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
            this.saleTextBox = new System.Windows.Forms.TextBox();
            this.changeTextBox = new System.Windows.Forms.TextBox();
            this.cashTextBox = new System.Windows.Forms.TextBox();
            this.enterButton = new System.Windows.Forms.Button();
            this.button00 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonC = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(195)))), ((int)(((byte)(239)))));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.exitButton);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(285, 44);
            this.panel3.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(4, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Settle Payment Module";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Transparent;
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.exitButton.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.exitButton.IconColor = System.Drawing.Color.White;
            this.exitButton.IconSize = 39;
            this.exitButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.exitButton.Location = new System.Drawing.Point(246, 0);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(39, 44);
            this.exitButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exitButton.TabIndex = 15;
            this.exitButton.TabStop = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // saleTextBox
            // 
            this.saleTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.saleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saleTextBox.Location = new System.Drawing.Point(15, 52);
            this.saleTextBox.Name = "saleTextBox";
            this.saleTextBox.ReadOnly = true;
            this.saleTextBox.Size = new System.Drawing.Size(257, 31);
            this.saleTextBox.TabIndex = 8;
            // 
            // changeTextBox
            // 
            this.changeTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.changeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeTextBox.Location = new System.Drawing.Point(15, 126);
            this.changeTextBox.Name = "changeTextBox";
            this.changeTextBox.Size = new System.Drawing.Size(257, 31);
            this.changeTextBox.TabIndex = 9;
            // 
            // cashTextBox
            // 
            this.cashTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.cashTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashTextBox.Location = new System.Drawing.Point(15, 89);
            this.cashTextBox.Name = "cashTextBox";
            this.cashTextBox.Size = new System.Drawing.Size(257, 31);
            this.cashTextBox.TabIndex = 10;
            this.cashTextBox.TextChanged += new System.EventHandler(this.cashTextBox_TextChanged);
            // 
            // enterButton
            // 
            this.enterButton.BackColor = System.Drawing.Color.Gray;
            this.enterButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.enterButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.enterButton.FlatAppearance.BorderSize = 0;
            this.enterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enterButton.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterButton.ForeColor = System.Drawing.Color.White;
            this.enterButton.Location = new System.Drawing.Point(15, 362);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(257, 45);
            this.enterButton.TabIndex = 42;
            this.enterButton.Text = "Enter";
            this.enterButton.UseVisualStyleBackColor = false;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // button00
            // 
            this.button00.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(195)))), ((int)(((byte)(239)))));
            this.button00.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button00.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button00.FlatAppearance.BorderSize = 0;
            this.button00.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button00.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button00.ForeColor = System.Drawing.Color.White;
            this.button00.Location = new System.Drawing.Point(213, 296);
            this.button00.Name = "button00";
            this.button00.Size = new System.Drawing.Size(60, 60);
            this.button00.TabIndex = 41;
            this.button00.Text = "00";
            this.button00.UseVisualStyleBackColor = false;
            this.button00.Click += new System.EventHandler(this.button00_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(195)))), ((int)(((byte)(239)))));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(147, 296);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(60, 60);
            this.button3.TabIndex = 40;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(195)))), ((int)(((byte)(239)))));
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(15, 164);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(60, 60);
            this.button7.TabIndex = 30;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(195)))), ((int)(((byte)(239)))));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(81, 230);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(60, 60);
            this.button5.TabIndex = 35;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(195)))), ((int)(((byte)(239)))));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(15, 230);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(60, 60);
            this.button4.TabIndex = 34;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button0
            // 
            this.button0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(195)))), ((int)(((byte)(239)))));
            this.button0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button0.FlatAppearance.BorderSize = 0;
            this.button0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button0.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button0.ForeColor = System.Drawing.Color.White;
            this.button0.Location = new System.Drawing.Point(213, 230);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(60, 60);
            this.button0.TabIndex = 37;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = false;
            this.button0.Click += new System.EventHandler(this.button0_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(195)))), ((int)(((byte)(239)))));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(81, 296);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(60, 60);
            this.button2.TabIndex = 39;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(195)))), ((int)(((byte)(239)))));
            this.button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Location = new System.Drawing.Point(147, 164);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(60, 60);
            this.button9.TabIndex = 32;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(195)))), ((int)(((byte)(239)))));
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(147, 230);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(60, 60);
            this.button6.TabIndex = 36;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(195)))), ((int)(((byte)(239)))));
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Location = new System.Drawing.Point(81, 164);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(60, 60);
            this.button8.TabIndex = 31;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(195)))), ((int)(((byte)(239)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(15, 296);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 60);
            this.button1.TabIndex = 38;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonC
            // 
            this.buttonC.BackColor = System.Drawing.Color.Gold;
            this.buttonC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonC.FlatAppearance.BorderSize = 0;
            this.buttonC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonC.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonC.ForeColor = System.Drawing.Color.White;
            this.buttonC.Location = new System.Drawing.Point(213, 164);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(60, 60);
            this.buttonC.TabIndex = 33;
            this.buttonC.Text = "C";
            this.buttonC.UseVisualStyleBackColor = false;
            this.buttonC.Click += new System.EventHandler(this.buttonC_Click);
            // 
            // SettlePaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 418);
            this.ControlBox = false;
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.button00);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonC);
            this.Controls.Add(this.cashTextBox);
            this.Controls.Add(this.changeTextBox);
            this.Controls.Add(this.saleTextBox);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SettlePaymentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SettlePaymentForm";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SettlePaymentForm_KeyDown);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconPictureBox exitButton;
        public System.Windows.Forms.Button enterButton;
        public System.Windows.Forms.Button button00;
        public System.Windows.Forms.Button button3;
        public System.Windows.Forms.Button button7;
        public System.Windows.Forms.Button button5;
        public System.Windows.Forms.Button button4;
        public System.Windows.Forms.Button button0;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button button9;
        public System.Windows.Forms.Button button6;
        public System.Windows.Forms.Button button8;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button buttonC;
        public System.Windows.Forms.TextBox saleTextBox;
        public System.Windows.Forms.TextBox changeTextBox;
        public System.Windows.Forms.TextBox cashTextBox;
    }
}