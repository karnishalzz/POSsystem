namespace PointOfSale_WinForm.POS
{
    partial class DiscountForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.discountPercentTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.discountAmuntTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.confirmButton = new System.Windows.Forms.Button();
            this.idLabel = new System.Windows.Forms.Label();
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
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(626, 32);
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
            this.label1.Size = new System.Drawing.Size(114, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Discount Module";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Transparent;
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.exitButton.IconColor = System.Drawing.Color.White;
            this.exitButton.IconSize = 29;
            this.exitButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.exitButton.Location = new System.Drawing.Point(594, 0);
            this.exitButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(29, 34);
            this.exitButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exitButton.TabIndex = 15;
            this.exitButton.TabStop = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Total Price";
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(138, 45);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.ReadOnly = true;
            this.priceTextBox.Size = new System.Drawing.Size(462, 25);
            this.priceTextBox.TabIndex = 8;
            // 
            // discountPercentTextBox
            // 
            this.discountPercentTextBox.Location = new System.Drawing.Point(138, 81);
            this.discountPercentTextBox.Name = "discountPercentTextBox";
            this.discountPercentTextBox.Size = new System.Drawing.Size(462, 25);
            this.discountPercentTextBox.TabIndex = 10;
            this.discountPercentTextBox.TextChanged += new System.EventHandler(this.discountPercentTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Discount(%)";
            // 
            // discountAmuntTextBox
            // 
            this.discountAmuntTextBox.Location = new System.Drawing.Point(138, 121);
            this.discountAmuntTextBox.Name = "discountAmuntTextBox";
            this.discountAmuntTextBox.ReadOnly = true;
            this.discountAmuntTextBox.Size = new System.Drawing.Size(462, 25);
            this.discountAmuntTextBox.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Discount Amount";
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
            this.confirmButton.Location = new System.Drawing.Point(138, 173);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(462, 33);
            this.confirmButton.TabIndex = 13;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.UseVisualStyleBackColor = false;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(59, 182);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(0, 17);
            this.idLabel.TabIndex = 14;
            this.idLabel.Visible = false;
            // 
            // DiscountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(626, 224);
            this.ControlBox = false;
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.discountAmuntTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.discountPercentTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DiscountForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DiscountForm";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DiscountForm_KeyDown);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Button confirmButton;
        public System.Windows.Forms.TextBox priceTextBox;
        public System.Windows.Forms.TextBox discountPercentTextBox;
        public System.Windows.Forms.TextBox discountAmuntTextBox;
        public System.Windows.Forms.Label idLabel;
    }
}