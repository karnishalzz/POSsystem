using BusinessLayer_POS.Services;
using FontAwesome.Sharp;
using PointOfSale_WinForm.Brand;
using PointOfSale_WinForm.Other;
using PointOfSale_WinForm.POS;
using PointOfSale_WinForm.Product;
using PointOfSale_WinForm.Records;
using PointOfSale_WinForm.Settings;
using PointOfSale_WinForm.Stock;
using PointOfSale_WinForm.User;
using PointOfSale_WinForm.Vendor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tulpep.NotificationWindow;

namespace PointOfSale_WinForm
{
    public partial class MainForm : Form
    {
        private readonly ProductService productService = new ProductService();
        public string _password;
        LoginForm LoginForm;
        public MainForm(LoginForm loginForm)
        {
            InitializeComponent();
            this.LoginForm = loginForm;
            LoadDashboard();
            NotifyCriticalItems();
            
        }
        public void NotifyCriticalItems()
        {
            string critical = "";
            int i = 0;
            var products = productService.GetAll().Where(p => p.Quantity <= p.Reorder);
            if (products != null)
            {
                foreach(var p in products)
                {
                    i++;
                    critical += i + p.Name.ToString() + Environment.NewLine;
                }
            }
            PopupNotifier popup = new PopupNotifier();
            //popup.Image = Properties.Resources.error;
            popup.TitleText = "CRITICAL ITEM(S)";
            popup.ContentText = critical;
            popup.Popup();
        }
        public void LoadDashboard()
        {
            containerPanel.Controls.Clear();
            DashboardForm form = new DashboardForm();
            form.TopLevel = false;
            containerPanel.Controls.Add(form);
            form.BringToFront();
            form.Show();
        }
      
        private void exitButton_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void expandButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        
        private void dashboardButton_Click(object sender, EventArgs e)
        {
            LoadDashboard();
        }

        private void posButton_Click(object sender, EventArgs e)
        {
            containerPanel.Controls.Clear();
            RecordForm recordForm = new RecordForm();
            recordForm.TopLevel = false;
            containerPanel.Controls.Add(recordForm);
            recordForm.LoadCriticalStock();
            recordForm.CancelledOrders();
            recordForm.LoadInventoryList();
            recordForm.BringToFront();
            recordForm.Show();
        }

        private void stockButton_Click(object sender, EventArgs e)
        {
            containerPanel.Controls.Clear();
            StockInForm stockInForm = new StockInForm();
            stockInForm.TopLevel = false;
            stockInForm.stockInByTextBox.Text = userlabel.Text;
            containerPanel.Controls.Add(stockInForm);
            stockInForm.BringToFront();
            stockInForm.Show();
        }

        private void productButton_Click_1(object sender, EventArgs e)
        {
            containerPanel.Controls.Clear();
            FormProductList formProductList = new FormProductList();
            formProductList.TopLevel = false;
            containerPanel.Controls.Add(formProductList);
            formProductList.BringToFront();
            formProductList.Show();
        }

        private void categoryButton_Click_1(object sender, EventArgs e)
        {
            containerPanel.Controls.Clear();
            CategoryForm categoryForm = new CategoryForm();
            categoryForm.TopLevel = false;
            containerPanel.Controls.Add(categoryForm);
            categoryForm.BringToFront();
            categoryForm.Show();

        }

        private void brandButton_Click(object sender, EventArgs e)
        {
            containerPanel.Controls.Clear();
            BrandForm brandForm = new BrandForm();
            brandForm.TopLevel = false;
            containerPanel.Controls.Add(brandForm);
            brandForm.BringToFront();
            brandForm.Show();


        }

        private void userButton_Click(object sender, EventArgs e)
        {
            containerPanel.Controls.Clear();
            UserForm userForm = new UserForm(this);
            userForm.usertextBox.Text = userlabel.Text;
            userForm.TopLevel = false;
            containerPanel.Controls.Add(userForm);
            userForm.BringToFront();
            userForm.Show();
        }

        private void salesHistoryButton_Click(object sender, EventArgs e)
        {
            
            containerPanel.Controls.Clear();
            SoldItemsForm soldItemsForm = new SoldItemsForm();
            soldItemsForm.TopLevel = false;
            containerPanel.Controls.Add(soldItemsForm);
            soldItemsForm.BringToFront();
            soldItemsForm.Show();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("LOGOUT From Application?", "LOGOUT", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
                this.LoginForm.Show();
            }
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            StoreForm storeForm = new StoreForm();
            storeForm.ShowDialog();
        }

        private void vendorButton_Click(object sender, EventArgs e)
        {
            containerPanel.Controls.Clear();
            VendorListForm vendorForm = new VendorListForm();
            vendorForm.TopLevel = false;
            containerPanel.Controls.Add(vendorForm);
            vendorForm.BringToFront();
            vendorForm.Show();
        }

        private void adjustStockButton_Click(object sender, EventArgs e)
        {
            StockAdjustmentForm stockAdjustmentForm = new StockAdjustmentForm(this);
            stockAdjustmentForm.LoadRecords();
            stockAdjustmentForm.userTextBox.Text = userlabel.Text;
            stockAdjustmentForm.ReferenceNo();
            stockAdjustmentForm.BringToFront();
            stockAdjustmentForm.ShowDialog();
        }

        private void vatbutton_Click(object sender, EventArgs e)
        {
            VatForm vatForm = new VatForm();
            vatForm.BringToFront();
            vatForm.ShowDialog();

        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void backupbutton_Click(object sender, EventArgs e)
        {
            BackupForm backupForm = new BackupForm();
            backupForm.BringToFront();
            backupForm.ShowDialog();
        }

        private void restorebutton_Click(object sender, EventArgs e)
        {
            RestoreForm backupForm = new RestoreForm();
            backupForm.BringToFront();
            backupForm.ShowDialog();
        }


        private void iconPictureBox2_Click(object sender, EventArgs e)
        {
            if (this.WindowState== FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
 
                this.MinimumSize = new Size(1263, 650);
                this.MaximumSize = new Size(1263, 650);

                this.StartPosition = FormStartPosition.CenterScreen;
              
            }
            else {
                this.MaximumSize = new Size(0, 0);
                this.MinimumSize = new Size(0, 0);
                this.WindowState = FormWindowState.Maximized;
                this.MinimumSize = this.Size;
                this.MaximumSize = this.Size;
            }
            
           
        }

        private void containerPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("LOGOUT From Application?", "LOGOUT", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
                this.LoginForm.Show();
            }
        }
        int mouseX, mouseY;
        bool mouseM;

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            mouseX = e.X;
            mouseY = e.Y;
            mouseM = true;
        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseM)
            {
                SetDesktopLocation(MousePosition.X - mouseX, MousePosition.Y - mouseY);
            }
        }

        private void panel3_MouseUp(object sender, MouseEventArgs e)
        {
            mouseM = false;
        }

        private void logoutbutton_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("LOGOUT From Application?", "LOGOUT", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
                this.LoginForm.Show();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
