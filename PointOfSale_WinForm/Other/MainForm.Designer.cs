namespace PointOfSale_WinForm
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.userlabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.exitButton = new FontAwesome.Sharp.IconPictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.logoutbutton = new System.Windows.Forms.Button();
            this.restorebutton = new System.Windows.Forms.Button();
            this.backupbutton = new System.Windows.Forms.Button();
            this.vatbutton = new System.Windows.Forms.Button();
            this.adjustStockButton = new System.Windows.Forms.Button();
            this.vendorButton = new System.Windows.Forms.Button();
            this.userButton = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.salesHistoryButton = new System.Windows.Forms.Button();
            this.brandButton = new System.Windows.Forms.Button();
            this.categoryButton = new System.Windows.Forms.Button();
            this.stockButton = new System.Windows.Forms.Button();
            this.productButton = new System.Windows.Forms.Button();
            this.recordButton = new System.Windows.Forms.Button();
            this.dashboardButton = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.namelabel = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.rolelabel = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            this.containerPanel = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // userlabel
            // 
            resources.ApplyResources(this.userlabel, "userlabel");
            this.userlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(195)))), ((int)(((byte)(239)))));
            this.userlabel.Name = "userlabel";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(195)))), ((int)(((byte)(239)))));
            this.panel3.Controls.Add(this.iconPictureBox1);
            this.panel3.Controls.Add(this.iconPictureBox2);
            this.panel3.Controls.Add(this.exitButton);
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            this.panel3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseMove);
            this.panel3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseUp);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.iconPictureBox1, "iconPictureBox1");
            this.iconPictureBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.iconPictureBox1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.iconPictureBox1.IconSize = 22;
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.TabStop = false;
            this.iconPictureBox1.Click += new System.EventHandler(this.iconPictureBox1_Click);
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.iconPictureBox2, "iconPictureBox2");
            this.iconPictureBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.iconPictureBox2.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.iconPictureBox2.IconSize = 22;
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.TabStop = false;
            this.iconPictureBox2.Click += new System.EventHandler(this.iconPictureBox2_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Transparent;
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.exitButton, "exitButton");
            this.exitButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.exitButton.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.exitButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.exitButton.IconSize = 22;
            this.exitButton.Name = "exitButton";
            this.exitButton.TabStop = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.panel1.Controls.Add(this.logoutbutton);
            this.panel1.Controls.Add(this.restorebutton);
            this.panel1.Controls.Add(this.backupbutton);
            this.panel1.Controls.Add(this.vatbutton);
            this.panel1.Controls.Add(this.adjustStockButton);
            this.panel1.Controls.Add(this.vendorButton);
            this.panel1.Controls.Add(this.userButton);
            this.panel1.Controls.Add(this.settingsButton);
            this.panel1.Controls.Add(this.salesHistoryButton);
            this.panel1.Controls.Add(this.brandButton);
            this.panel1.Controls.Add(this.categoryButton);
            this.panel1.Controls.Add(this.stockButton);
            this.panel1.Controls.Add(this.productButton);
            this.panel1.Controls.Add(this.recordButton);
            this.panel1.Controls.Add(this.dashboardButton);
            this.panel1.Controls.Add(this.panel4);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // logoutbutton
            // 
            this.logoutbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            resources.ApplyResources(this.logoutbutton, "logoutbutton");
            this.logoutbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoutbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.logoutbutton.ForeColor = System.Drawing.Color.White;
            this.logoutbutton.Name = "logoutbutton";
            this.logoutbutton.UseVisualStyleBackColor = false;
            this.logoutbutton.Click += new System.EventHandler(this.logoutbutton_Click_1);
            // 
            // restorebutton
            // 
            this.restorebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            resources.ApplyResources(this.restorebutton, "restorebutton");
            this.restorebutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.restorebutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.restorebutton.ForeColor = System.Drawing.Color.White;
            this.restorebutton.Name = "restorebutton";
            this.restorebutton.UseVisualStyleBackColor = false;
            this.restorebutton.Click += new System.EventHandler(this.restorebutton_Click);
            // 
            // backupbutton
            // 
            this.backupbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            resources.ApplyResources(this.backupbutton, "backupbutton");
            this.backupbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backupbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.backupbutton.ForeColor = System.Drawing.Color.White;
            this.backupbutton.Name = "backupbutton";
            this.backupbutton.UseVisualStyleBackColor = false;
            this.backupbutton.Click += new System.EventHandler(this.backupbutton_Click);
            // 
            // vatbutton
            // 
            this.vatbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            resources.ApplyResources(this.vatbutton, "vatbutton");
            this.vatbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vatbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.vatbutton.ForeColor = System.Drawing.Color.White;
            this.vatbutton.Name = "vatbutton";
            this.vatbutton.UseVisualStyleBackColor = false;
            this.vatbutton.Click += new System.EventHandler(this.vatbutton_Click);
            // 
            // adjustStockButton
            // 
            this.adjustStockButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            resources.ApplyResources(this.adjustStockButton, "adjustStockButton");
            this.adjustStockButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adjustStockButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.adjustStockButton.ForeColor = System.Drawing.Color.White;
            this.adjustStockButton.Name = "adjustStockButton";
            this.adjustStockButton.UseVisualStyleBackColor = false;
            this.adjustStockButton.Click += new System.EventHandler(this.adjustStockButton_Click);
            // 
            // vendorButton
            // 
            this.vendorButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            resources.ApplyResources(this.vendorButton, "vendorButton");
            this.vendorButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vendorButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.vendorButton.ForeColor = System.Drawing.Color.White;
            this.vendorButton.Name = "vendorButton";
            this.vendorButton.UseVisualStyleBackColor = false;
            this.vendorButton.Click += new System.EventHandler(this.vendorButton_Click);
            // 
            // userButton
            // 
            this.userButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            resources.ApplyResources(this.userButton, "userButton");
            this.userButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.userButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.userButton.ForeColor = System.Drawing.Color.White;
            this.userButton.Name = "userButton";
            this.userButton.UseVisualStyleBackColor = false;
            this.userButton.Click += new System.EventHandler(this.userButton_Click);
            // 
            // settingsButton
            // 
            this.settingsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            resources.ApplyResources(this.settingsButton, "settingsButton");
            this.settingsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settingsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.settingsButton.ForeColor = System.Drawing.Color.White;
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.UseVisualStyleBackColor = false;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // salesHistoryButton
            // 
            this.salesHistoryButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            resources.ApplyResources(this.salesHistoryButton, "salesHistoryButton");
            this.salesHistoryButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.salesHistoryButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.salesHistoryButton.ForeColor = System.Drawing.Color.White;
            this.salesHistoryButton.Name = "salesHistoryButton";
            this.salesHistoryButton.UseVisualStyleBackColor = false;
            this.salesHistoryButton.Click += new System.EventHandler(this.salesHistoryButton_Click);
            // 
            // brandButton
            // 
            this.brandButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            resources.ApplyResources(this.brandButton, "brandButton");
            this.brandButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.brandButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.brandButton.ForeColor = System.Drawing.Color.White;
            this.brandButton.Name = "brandButton";
            this.brandButton.UseVisualStyleBackColor = false;
            this.brandButton.Click += new System.EventHandler(this.brandButton_Click);
            // 
            // categoryButton
            // 
            this.categoryButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            resources.ApplyResources(this.categoryButton, "categoryButton");
            this.categoryButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.categoryButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.categoryButton.ForeColor = System.Drawing.Color.White;
            this.categoryButton.Name = "categoryButton";
            this.categoryButton.UseVisualStyleBackColor = false;
            this.categoryButton.Click += new System.EventHandler(this.categoryButton_Click_1);
            // 
            // stockButton
            // 
            this.stockButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            resources.ApplyResources(this.stockButton, "stockButton");
            this.stockButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stockButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.stockButton.ForeColor = System.Drawing.Color.White;
            this.stockButton.Name = "stockButton";
            this.stockButton.UseVisualStyleBackColor = false;
            this.stockButton.Click += new System.EventHandler(this.stockButton_Click);
            // 
            // productButton
            // 
            this.productButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            resources.ApplyResources(this.productButton, "productButton");
            this.productButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.productButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.productButton.ForeColor = System.Drawing.Color.White;
            this.productButton.Name = "productButton";
            this.productButton.UseVisualStyleBackColor = false;
            this.productButton.Click += new System.EventHandler(this.productButton_Click_1);
            // 
            // recordButton
            // 
            this.recordButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            resources.ApplyResources(this.recordButton, "recordButton");
            this.recordButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.recordButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.recordButton.ForeColor = System.Drawing.Color.White;
            this.recordButton.Name = "recordButton";
            this.recordButton.UseVisualStyleBackColor = false;
            this.recordButton.Click += new System.EventHandler(this.posButton_Click);
            // 
            // dashboardButton
            // 
            this.dashboardButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            resources.ApplyResources(this.dashboardButton, "dashboardButton");
            this.dashboardButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dashboardButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.dashboardButton.ForeColor = System.Drawing.Color.White;
            this.dashboardButton.Name = "dashboardButton";
            this.dashboardButton.UseVisualStyleBackColor = false;
            this.dashboardButton.Click += new System.EventHandler(this.dashboardButton_Click);
            // 
            // panel4
            // 
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.Controls.Add(this.namelabel);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.rolelabel);
            this.panel4.Controls.Add(this.userlabel);
            this.panel4.Name = "panel4";
            // 
            // namelabel
            // 
            resources.ApplyResources(this.namelabel, "namelabel");
            this.namelabel.Name = "namelabel";
            // 
            // panel6
            // 
            resources.ApplyResources(this.panel6, "panel6");
            this.panel6.Name = "panel6";
            // 
            // rolelabel
            // 
            resources.ApplyResources(this.rolelabel, "rolelabel");
            this.rolelabel.ForeColor = System.Drawing.Color.White;
            this.rolelabel.Name = "rolelabel";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.panel5.Controls.Add(this.iconButton2);
            this.panel5.Controls.Add(this.iconPictureBox3);
            resources.ApplyResources(this.panel5, "panel5");
            this.panel5.Name = "panel5";
            // 
            // iconButton2
            // 
            resources.ApplyResources(this.iconButton2, "iconButton2");
            this.iconButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton2.ForeColor = System.Drawing.Color.White;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Copyright;
            this.iconButton2.IconColor = System.Drawing.Color.White;
            this.iconButton2.IconSize = 15;
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Rotation = 0D;
            this.iconButton2.UseVisualStyleBackColor = false;
            // 
            // iconPictureBox3
            // 
            this.iconPictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.iconPictureBox3.IconColor = System.Drawing.Color.White;
            this.iconPictureBox3.IconSize = 26;
            resources.ApplyResources(this.iconPictureBox3, "iconPictureBox3");
            this.iconPictureBox3.Name = "iconPictureBox3";
            this.iconPictureBox3.TabStop = false;
            // 
            // containerPanel
            // 
            resources.ApplyResources(this.containerPanel, "containerPanel");
            this.containerPanel.Name = "containerPanel";
            this.containerPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.containerPanel_Paint);
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.containerPanel);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button userButton;
        public System.Windows.Forms.Button salesHistoryButton;
        public System.Windows.Forms.Button brandButton;
        public System.Windows.Forms.Button categoryButton;
        public System.Windows.Forms.Button stockButton;
        public System.Windows.Forms.Button productButton;
        public System.Windows.Forms.Button dashboardButton;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private System.Windows.Forms.Panel containerPanel;
        private System.Windows.Forms.Panel panel6;
        public System.Windows.Forms.Button settingsButton;
        public System.Windows.Forms.Button recordButton;
        public System.Windows.Forms.Button vendorButton;
        public System.Windows.Forms.Button adjustStockButton;
        public System.Windows.Forms.Label userlabel;
        public System.Windows.Forms.Label rolelabel;
        private System.Windows.Forms.Label namelabel;
        public System.Windows.Forms.Button vatbutton;
        public System.Windows.Forms.Button restorebutton;
        public System.Windows.Forms.Button backupbutton;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private FontAwesome.Sharp.IconPictureBox exitButton;
        public System.Windows.Forms.Button logoutbutton;
    }
}