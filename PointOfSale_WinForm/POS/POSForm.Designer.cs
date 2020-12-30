namespace PointOfSale_WinForm.POS
{
    partial class POSForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(POSForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.Button();
            this.changePasswordButton = new System.Windows.Forms.Button();
            this.dailySalesButton = new System.Windows.Forms.Button();
            this.clearCartButton = new System.Windows.Forms.Button();
            this.settlePaymentButton = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.vatLabel = new System.Windows.Forms.Label();
            this.discountLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.addDiscountButton = new System.Windows.Forms.Button();
            this.searchProductButton = new System.Windows.Forms.Button();
            this.newTransactionButton = new System.Windows.Forms.Button();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.nameLabel = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.quantityTextBox = new MetroFramework.Controls.MetroTextBox();
            this.searchBarcodeTextBox = new MetroFramework.Controls.MetroTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.transactionLabel = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.rolelabel = new System.Windows.Forms.Label();
            this.displayTotalLabel = new System.Windows.Forms.Label();
            this.cartDataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remove = new System.Windows.Forms.DataGridViewImageColumn();
            this.Add = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.datenowLabel = new System.Windows.Forms.Label();
            this.timerLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cartDataGridView)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.panel1.Controls.Add(this.closeButton);
            this.panel1.Controls.Add(this.changePasswordButton);
            this.panel1.Controls.Add(this.dailySalesButton);
            this.panel1.Controls.Add(this.clearCartButton);
            this.panel1.Controls.Add(this.settlePaymentButton);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.addDiscountButton);
            this.panel1.Controls.Add(this.searchProductButton);
            this.panel1.Controls.Add(this.newTransactionButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(938, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 545);
            this.panel1.TabIndex = 0;
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.CadetBlue;
            this.closeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.ForeColor = System.Drawing.Color.White;
            this.closeButton.Image = ((System.Drawing.Image)(resources.GetObject("closeButton.Image")));
            this.closeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.closeButton.Location = new System.Drawing.Point(0, 357);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(260, 51);
            this.closeButton.TabIndex = 21;
            this.closeButton.Text = "   [ F7 ] Logout";
            this.closeButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.closeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // changePasswordButton
            // 
            this.changePasswordButton.BackColor = System.Drawing.Color.CadetBlue;
            this.changePasswordButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.changePasswordButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.changePasswordButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.changePasswordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changePasswordButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changePasswordButton.ForeColor = System.Drawing.Color.White;
            this.changePasswordButton.Image = ((System.Drawing.Image)(resources.GetObject("changePasswordButton.Image")));
            this.changePasswordButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.changePasswordButton.Location = new System.Drawing.Point(0, 306);
            this.changePasswordButton.Name = "changePasswordButton";
            this.changePasswordButton.Size = new System.Drawing.Size(260, 51);
            this.changePasswordButton.TabIndex = 19;
            this.changePasswordButton.Text = "   [ F7 ] Change Password";
            this.changePasswordButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.changePasswordButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.changePasswordButton.UseVisualStyleBackColor = false;
            this.changePasswordButton.Click += new System.EventHandler(this.changePasswordButton_Click);
            // 
            // dailySalesButton
            // 
            this.dailySalesButton.BackColor = System.Drawing.Color.CadetBlue;
            this.dailySalesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.dailySalesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dailySalesButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.dailySalesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dailySalesButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dailySalesButton.ForeColor = System.Drawing.Color.White;
            this.dailySalesButton.Image = ((System.Drawing.Image)(resources.GetObject("dailySalesButton.Image")));
            this.dailySalesButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dailySalesButton.Location = new System.Drawing.Point(0, 255);
            this.dailySalesButton.Name = "dailySalesButton";
            this.dailySalesButton.Size = new System.Drawing.Size(260, 51);
            this.dailySalesButton.TabIndex = 18;
            this.dailySalesButton.Text = "   [ F6 ] Daily Sales";
            this.dailySalesButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dailySalesButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.dailySalesButton.UseVisualStyleBackColor = false;
            this.dailySalesButton.Click += new System.EventHandler(this.dailySalesButton_Click);
            // 
            // clearCartButton
            // 
            this.clearCartButton.BackColor = System.Drawing.Color.CadetBlue;
            this.clearCartButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.clearCartButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearCartButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.clearCartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearCartButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearCartButton.ForeColor = System.Drawing.Color.White;
            this.clearCartButton.Image = ((System.Drawing.Image)(resources.GetObject("clearCartButton.Image")));
            this.clearCartButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clearCartButton.Location = new System.Drawing.Point(0, 204);
            this.clearCartButton.Name = "clearCartButton";
            this.clearCartButton.Size = new System.Drawing.Size(260, 51);
            this.clearCartButton.TabIndex = 17;
            this.clearCartButton.Text = "   [ F5 ] Clear Cart";
            this.clearCartButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clearCartButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.clearCartButton.UseVisualStyleBackColor = false;
            this.clearCartButton.Click += new System.EventHandler(this.canncelSalesButton_Click);
            // 
            // settlePaymentButton
            // 
            this.settlePaymentButton.BackColor = System.Drawing.Color.CadetBlue;
            this.settlePaymentButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.settlePaymentButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settlePaymentButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.settlePaymentButton.Enabled = false;
            this.settlePaymentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settlePaymentButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settlePaymentButton.ForeColor = System.Drawing.Color.White;
            this.settlePaymentButton.Image = ((System.Drawing.Image)(resources.GetObject("settlePaymentButton.Image")));
            this.settlePaymentButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settlePaymentButton.Location = new System.Drawing.Point(0, 153);
            this.settlePaymentButton.Name = "settlePaymentButton";
            this.settlePaymentButton.Size = new System.Drawing.Size(260, 51);
            this.settlePaymentButton.TabIndex = 16;
            this.settlePaymentButton.Text = "   [ F4 ] Settle Payment";
            this.settlePaymentButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settlePaymentButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.settlePaymentButton.UseVisualStyleBackColor = false;
            this.settlePaymentButton.Click += new System.EventHandler(this.settlePaymentButton_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel7.Controls.Add(this.label14);
            this.panel7.Controls.Add(this.vatLabel);
            this.panel7.Controls.Add(this.discountLabel);
            this.panel7.Controls.Add(this.label10);
            this.panel7.Controls.Add(this.totalLabel);
            this.panel7.Controls.Add(this.label7);
            this.panel7.Location = new System.Drawing.Point(0, 408);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(260, 137);
            this.panel7.TabIndex = 0;
            this.panel7.Paint += new System.Windows.Forms.PaintEventHandler(this.panel7_Paint);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label14.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label14.Location = new System.Drawing.Point(3, 73);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(68, 21);
            this.label14.TabIndex = 6;
            this.label14.Text = "Vat ( % )";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // vatLabel
            // 
            this.vatLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vatLabel.ForeColor = System.Drawing.Color.Red;
            this.vatLabel.Location = new System.Drawing.Point(150, 75);
            this.vatLabel.Name = "vatLabel";
            this.vatLabel.Size = new System.Drawing.Size(105, 23);
            this.vatLabel.TabIndex = 5;
            this.vatLabel.Text = "0.00";
            this.vatLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // discountLabel
            // 
            this.discountLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discountLabel.ForeColor = System.Drawing.Color.Red;
            this.discountLabel.Location = new System.Drawing.Point(150, 47);
            this.discountLabel.Name = "discountLabel";
            this.discountLabel.Size = new System.Drawing.Size(105, 23);
            this.discountLabel.TabIndex = 3;
            this.discountLabel.Text = "0.00";
            this.discountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label10.Location = new System.Drawing.Point(3, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 21);
            this.label10.TabIndex = 2;
            this.label10.Text = "Discount";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // totalLabel
            // 
            this.totalLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.ForeColor = System.Drawing.Color.Red;
            this.totalLabel.Location = new System.Drawing.Point(150, 20);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(105, 23);
            this.totalLabel.TabIndex = 1;
            this.totalLabel.Text = "0.00";
            this.totalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label7.Location = new System.Drawing.Point(3, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 21);
            this.label7.TabIndex = 0;
            this.label7.Text = "Sales Total";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // addDiscountButton
            // 
            this.addDiscountButton.BackColor = System.Drawing.Color.CadetBlue;
            this.addDiscountButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.addDiscountButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addDiscountButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.addDiscountButton.Enabled = false;
            this.addDiscountButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addDiscountButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addDiscountButton.ForeColor = System.Drawing.Color.White;
            this.addDiscountButton.Image = ((System.Drawing.Image)(resources.GetObject("addDiscountButton.Image")));
            this.addDiscountButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addDiscountButton.Location = new System.Drawing.Point(0, 102);
            this.addDiscountButton.Name = "addDiscountButton";
            this.addDiscountButton.Size = new System.Drawing.Size(260, 51);
            this.addDiscountButton.TabIndex = 15;
            this.addDiscountButton.Text = "   [ F3 ] Add Discount";
            this.addDiscountButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addDiscountButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addDiscountButton.UseVisualStyleBackColor = false;
            this.addDiscountButton.Click += new System.EventHandler(this.addDiscountButton_Click);
            // 
            // searchProductButton
            // 
            this.searchProductButton.BackColor = System.Drawing.Color.CadetBlue;
            this.searchProductButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.searchProductButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchProductButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchProductButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchProductButton.ForeColor = System.Drawing.Color.White;
            this.searchProductButton.Image = ((System.Drawing.Image)(resources.GetObject("searchProductButton.Image")));
            this.searchProductButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchProductButton.Location = new System.Drawing.Point(0, 51);
            this.searchProductButton.Name = "searchProductButton";
            this.searchProductButton.Size = new System.Drawing.Size(260, 51);
            this.searchProductButton.TabIndex = 14;
            this.searchProductButton.Text = "   [ F2 ] Search Product";
            this.searchProductButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchProductButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.searchProductButton.UseVisualStyleBackColor = false;
            this.searchProductButton.Click += new System.EventHandler(this.searchProductButton_Click);
            // 
            // newTransactionButton
            // 
            this.newTransactionButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.newTransactionButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.newTransactionButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newTransactionButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.newTransactionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newTransactionButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newTransactionButton.ForeColor = System.Drawing.Color.White;
            this.newTransactionButton.Image = ((System.Drawing.Image)(resources.GetObject("newTransactionButton.Image")));
            this.newTransactionButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.newTransactionButton.Location = new System.Drawing.Point(0, 0);
            this.newTransactionButton.Name = "newTransactionButton";
            this.newTransactionButton.Size = new System.Drawing.Size(260, 51);
            this.newTransactionButton.TabIndex = 13;
            this.newTransactionButton.Text = "   [ F1 ] New Transaction";
            this.newTransactionButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.newTransactionButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.newTransactionButton.UseVisualStyleBackColor = false;
            this.newTransactionButton.Click += new System.EventHandler(this.newTransactionButton_Click);
            // 
            // usernameLabel
            // 
            this.usernameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.ForeColor = System.Drawing.Color.White;
            this.usernameLabel.Location = new System.Drawing.Point(74, 28);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(148, 27);
            this.usernameLabel.TabIndex = 3;
            this.usernameLabel.Text = "Cashier Name Here";
            this.usernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(195)))), ((int)(((byte)(239)))));
            this.label1.Location = new System.Drawing.Point(73, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "POS Software";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Location = new System.Drawing.Point(4, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(63, 52);
            this.panel3.TabIndex = 0;
            // 
            // nameLabel
            // 
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.Color.Black;
            this.nameLabel.Location = new System.Drawing.Point(28, 3);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(129, 27);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "Transaction No";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.quantityTextBox);
            this.panel4.Controls.Add(this.searchBarcodeTextBox);
            this.panel4.Controls.Add(this.label15);
            this.panel4.Controls.Add(this.dateLabel);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.transactionLabel);
            this.panel4.Controls.Add(this.nameLabel);
            this.panel4.Location = new System.Drawing.Point(4, 55);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(932, 97);
            this.panel4.TabIndex = 1;
            // 
            // quantityTextBox
            // 
            // 
            // 
            // 
            this.quantityTextBox.CustomButton.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityTextBox.CustomButton.Image = null;
            this.quantityTextBox.CustomButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.quantityTextBox.CustomButton.Location = new System.Drawing.Point(32, 1);
            this.quantityTextBox.CustomButton.Name = "";
            this.quantityTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.quantityTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.quantityTextBox.CustomButton.TabIndex = 1;
            this.quantityTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.quantityTextBox.CustomButton.UseSelectable = true;
            this.quantityTextBox.CustomButton.Visible = false;
            this.quantityTextBox.Icon = ((System.Drawing.Image)(resources.GetObject("quantityTextBox.Icon")));
            this.quantityTextBox.Lines = new string[] {
        "1"};
            this.quantityTextBox.Location = new System.Drawing.Point(657, 52);
            this.quantityTextBox.MaxLength = 32767;
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.PasswordChar = '\0';
            this.quantityTextBox.PromptText = "1";
            this.quantityTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.quantityTextBox.SelectedText = "";
            this.quantityTextBox.SelectionLength = 0;
            this.quantityTextBox.SelectionStart = 0;
            this.quantityTextBox.ShortcutsEnabled = true;
            this.quantityTextBox.Size = new System.Drawing.Size(54, 23);
            this.quantityTextBox.TabIndex = 19;
            this.quantityTextBox.Text = "1";
            this.quantityTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.quantityTextBox.UseSelectable = true;
            this.quantityTextBox.WaterMark = "1";
            this.quantityTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.quantityTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // searchBarcodeTextBox
            // 
            // 
            // 
            // 
            this.searchBarcodeTextBox.CustomButton.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBarcodeTextBox.CustomButton.Image = null;
            this.searchBarcodeTextBox.CustomButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchBarcodeTextBox.CustomButton.Location = new System.Drawing.Point(468, 1);
            this.searchBarcodeTextBox.CustomButton.Name = "";
            this.searchBarcodeTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.searchBarcodeTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.searchBarcodeTextBox.CustomButton.TabIndex = 1;
            this.searchBarcodeTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.searchBarcodeTextBox.CustomButton.UseSelectable = true;
            this.searchBarcodeTextBox.CustomButton.Visible = false;
            this.searchBarcodeTextBox.DisplayIcon = true;
            this.searchBarcodeTextBox.Enabled = false;
            this.searchBarcodeTextBox.Icon = ((System.Drawing.Image)(resources.GetObject("searchBarcodeTextBox.Icon")));
            this.searchBarcodeTextBox.Lines = new string[0];
            this.searchBarcodeTextBox.Location = new System.Drawing.Point(161, 52);
            this.searchBarcodeTextBox.MaxLength = 32767;
            this.searchBarcodeTextBox.Name = "searchBarcodeTextBox";
            this.searchBarcodeTextBox.PasswordChar = '\0';
            this.searchBarcodeTextBox.PromptText = "Search barcode Here";
            this.searchBarcodeTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.searchBarcodeTextBox.SelectedText = "";
            this.searchBarcodeTextBox.SelectionLength = 0;
            this.searchBarcodeTextBox.SelectionStart = 0;
            this.searchBarcodeTextBox.ShortcutsEnabled = true;
            this.searchBarcodeTextBox.Size = new System.Drawing.Size(490, 23);
            this.searchBarcodeTextBox.TabIndex = 17;
            this.searchBarcodeTextBox.UseSelectable = true;
            this.searchBarcodeTextBox.WaterMark = "Search barcode Here";
            this.searchBarcodeTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.searchBarcodeTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBarcodeTextBox.TextChanged += new System.EventHandler(this.searchBarcodeTextBox_TextChanged);
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(26, 48);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(129, 27);
            this.label15.TabIndex = 18;
            this.label15.Text = "[ F8 ] Barcode";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dateLabel
            // 
            this.dateLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.ForeColor = System.Drawing.Color.Black;
            this.dateLabel.Location = new System.Drawing.Point(158, 25);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(381, 27);
            this.dateLabel.TabIndex = 5;
            this.dateLabel.Text = "000000000000";
            this.dateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(28, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 27);
            this.label4.TabIndex = 4;
            this.label4.Text = "Date";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // transactionLabel
            // 
            this.transactionLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactionLabel.ForeColor = System.Drawing.Color.Red;
            this.transactionLabel.Location = new System.Drawing.Point(158, 3);
            this.transactionLabel.Name = "transactionLabel";
            this.transactionLabel.Size = new System.Drawing.Size(390, 27);
            this.transactionLabel.TabIndex = 3;
            this.transactionLabel.Text = "000000000000";
            this.transactionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.panel6.Controls.Add(this.rolelabel);
            this.panel6.Controls.Add(this.usernameLabel);
            this.panel6.Controls.Add(this.displayTotalLabel);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Controls.Add(this.panel3);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1198, 55);
            this.panel6.TabIndex = 0;
            // 
            // rolelabel
            // 
            this.rolelabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rolelabel.ForeColor = System.Drawing.Color.White;
            this.rolelabel.Location = new System.Drawing.Point(228, 28);
            this.rolelabel.Name = "rolelabel";
            this.rolelabel.Size = new System.Drawing.Size(148, 27);
            this.rolelabel.TabIndex = 4;
            this.rolelabel.Text = "Cashier Name Here";
            this.rolelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // displayTotalLabel
            // 
            this.displayTotalLabel.AutoSize = true;
            this.displayTotalLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.displayTotalLabel.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayTotalLabel.ForeColor = System.Drawing.Color.White;
            this.displayTotalLabel.Location = new System.Drawing.Point(1119, 0);
            this.displayTotalLabel.Name = "displayTotalLabel";
            this.displayTotalLabel.Size = new System.Drawing.Size(79, 34);
            this.displayTotalLabel.TabIndex = 1;
            this.displayTotalLabel.Text = "0.00";
            // 
            // cartDataGridView
            // 
            this.cartDataGridView.AllowUserToAddRows = false;
            this.cartDataGridView.AllowUserToDeleteRows = false;
            this.cartDataGridView.AllowUserToResizeColumns = false;
            this.cartDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cartDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.cartDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.cartDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.cartDataGridView.CausesValidation = false;
            this.cartDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.cartDataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(195)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cartDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.cartDataGridView.ColumnHeadersHeight = 30;
            this.cartDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.cartDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column8,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column3,
            this.Column9,
            this.Remove,
            this.Add,
            this.Delete});
            this.cartDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.cartDataGridView.EnableHeadersVisualStyles = false;
            this.cartDataGridView.GridColor = System.Drawing.Color.White;
            this.cartDataGridView.Location = new System.Drawing.Point(4, 157);
            this.cartDataGridView.MultiSelect = false;
            this.cartDataGridView.Name = "cartDataGridView";
            this.cartDataGridView.ReadOnly = true;
            this.cartDataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cartDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.cartDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.cartDataGridView.Size = new System.Drawing.Size(932, 306);
            this.cartDataGridView.TabIndex = 6;
            this.cartDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cartDataGridView_CellContentClick);
            this.cartDataGridView.SelectionChanged += new System.EventHandler(this.cartDataGridView_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "#";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 39;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "ID";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Visible = false;
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column8.HeaderText = "PCODE";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 70;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "Description";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Column5.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column5.HeaderText = "Price";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 58;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column6.HeaderText = "Quantity";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 78;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Column7.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column7.HeaderText = "Discount";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 79;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column3.HeaderText = "Total";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 57;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "PID";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Visible = false;
            // 
            // Remove
            // 
            this.Remove.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Remove.HeaderText = "";
            this.Remove.Image = ((System.Drawing.Image)(resources.GetObject("Remove.Image")));
            this.Remove.Name = "Remove";
            this.Remove.ReadOnly = true;
            this.Remove.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Remove.Width = 5;
            // 
            // Add
            // 
            this.Add.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Add.HeaderText = "";
            this.Add.Image = ((System.Drawing.Image)(resources.GetObject("Add.Image")));
            this.Add.Name = "Add";
            this.Add.ReadOnly = true;
            this.Add.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Add.Width = 5;
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Delete.HeaderText = "";
            this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Width = 5;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel5.Controls.Add(this.datenowLabel);
            this.panel5.Controls.Add(this.timerLabel);
            this.panel5.Location = new System.Drawing.Point(4, 466);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(932, 137);
            this.panel5.TabIndex = 7;
            // 
            // datenowLabel
            // 
            this.datenowLabel.AutoSize = true;
            this.datenowLabel.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datenowLabel.Location = new System.Drawing.Point(21, 88);
            this.datenowLabel.Name = "datenowLabel";
            this.datenowLabel.Size = new System.Drawing.Size(0, 30);
            this.datenowLabel.TabIndex = 1;
            // 
            // timerLabel
            // 
            this.timerLabel.AutoSize = true;
            this.timerLabel.Font = new System.Drawing.Font("Consolas", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerLabel.ForeColor = System.Drawing.Color.White;
            this.timerLabel.Location = new System.Drawing.Point(3, 4);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(312, 75);
            this.timerLabel.TabIndex = 0;
            this.timerLabel.Text = "00:00:00";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // POSForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1198, 600);
            this.ControlBox = false;
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.cartDataGridView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel6);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "POSForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.POSForm_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cartDataGridView)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button searchProductButton;
        public System.Windows.Forms.Button newTransactionButton;
        public System.Windows.Forms.Button dailySalesButton;
        public System.Windows.Forms.Button clearCartButton;
        public System.Windows.Forms.Button settlePaymentButton;
        public System.Windows.Forms.Button addDiscountButton;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label15;
        public MetroFramework.Controls.MetroTextBox searchBarcodeTextBox;
        public System.Windows.Forms.Button closeButton;
        public System.Windows.Forms.Button changePasswordButton;
        private System.Windows.Forms.Label displayTotalLabel;
        public System.Windows.Forms.Label transactionLabel;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label datenowLabel;
        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.DataGridView cartDataGridView;
        public System.Windows.Forms.Label vatLabel;
        public System.Windows.Forms.Label discountLabel;
        public System.Windows.Forms.Label totalLabel;
        public System.Windows.Forms.Label usernameLabel;
        public System.Windows.Forms.Label rolelabel;
        public MetroFramework.Controls.MetroTextBox quantityTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewImageColumn Remove;
        private System.Windows.Forms.DataGridViewImageColumn Add;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
    }
}