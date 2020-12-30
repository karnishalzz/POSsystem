using BusinessLayer_POS.Services;
using PointOfSale_WinForm.User;
using POS_DataModel.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tulpep.NotificationWindow;

namespace PointOfSale_WinForm.POS
{
    public partial class POSForm : Form
    {
        string _id;
        string _price;
        //double price_withoutvat = 0.00;
        private readonly CartService cartService = new CartService();
        private readonly ProductService productService = new ProductService();
        private readonly VatService vatService = new VatService();

        LoginForm _loginForm;
        public POSForm(LoginForm loginForm)
        {
            InitializeComponent();
            dateLabel.Text = DateTime.Now.ToLongDateString();
            this.KeyPreview = true;
            _loginForm = loginForm;
            NotifyCriticalItems();
        }
        public void NotifyCriticalItems()
        {
            string critical = "";
            int i = 0;
            var products = productService.GetAll().Where(p => p.Quantity <= p.Reorder);
            if (products != null)
            {
                foreach (var p in products)
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
        public void GetTransactionNo()
        {
            try
            {
                string transNo;
                int count = 0;
                string sdate = DateTime.Now.ToString("yyyyMMdd");
                var cart = cartService.GetCartByDate(sdate).LastOrDefault();
                if (cart != null)
                {
                    transNo = cart.TransactionNo;
                    count =int.Parse(transNo.Substring(8,4));
                    transactionLabel.Text = sdate + (count + 1);
                }
                else
                {
                    transNo = sdate + "1001";
                    transactionLabel.Text = transNo;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "POS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void newTransactionButton_Click(object sender, EventArgs e)
        {
            if (cartDataGridView.Rows.Count > 0)
            {
                return;
            }
            GetTransactionNo();
            searchBarcodeTextBox.Enabled = true;
            searchBarcodeTextBox.Focus();
        }

       

        private void searchBarcodeTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(quantityTextBox.Text, out var x))
                {
                    MessageBox.Show("Please Give A valid Number Value");
                    return;
                }
                if (searchBarcodeTextBox.Text == String.Empty) { return; }
                
                else
                {
                    string _pid;
                    decimal _price;
                    int _qty;
                    var product = productService.GetProductByBarcode(searchBarcodeTextBox.Text);
                    if (product!= null)
                    {
                        //QuantityForm quantityForm = new QuantityForm(this);
                        //quantityForm.ProductDetails(product.Id.ToString(), product.Price.ToString(), transactionLabel.Text,product.Quantity);
                        //quantityForm.ShowDialog();
                        _pid = product.Id.ToString();
                        _price = product.Price;
                        _qty =product.Quantity;
                        AddToCart(_pid, _price, _qty);
                        
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "POS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void AddToCart(string pid,decimal price,int qty)
        {

            bool found = false;
            var cart_qty = 0;
            var inCart = cartService.GetAllByRefAndProduct(transactionLabel.Text, pid);
            if (inCart != null) { found = true; cart_qty = inCart.Quantity; }
            else found = false;
            if (found == true)
            {
                if (qty < int.Parse(quantityTextBox.Text) + cart_qty)
                {
                    MessageBox.Show("Unable to proceed.Remaining Quantity On Hand is " + qty, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                var cart = cartService.GetById(inCart.Id);
                var q = cart_qty+ int.Parse(quantityTextBox.Text);
                cart.Quantity = q;
                cartService.Update(cart);
                searchBarcodeTextBox.SelectionStart = 0;
                searchBarcodeTextBox.SelectionLength = searchBarcodeTextBox.Text.Length;
                searchBarcodeTextBox.Focus();
            }
            else
            {
                if (qty < int.Parse(quantityTextBox.Text) + cart_qty)
                {
                    MessageBox.Show("Unable to proceed.Remaining Quantity On Hand is " + qty, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                var avat = vatService.GetVat().VatValue;
                var date = DateTime.Now.ToString("yyyyMMdd");
                var cart = new Cart
                {
                    TransactionNo = transactionLabel.Text,
                    Price = price,
                    Quantity = int.Parse(quantityTextBox.Text),
                    StartDate = date,
                    ProductId = int.Parse(pid),
                    Date = DateTime.Now,
                    Cashier = usernameLabel.Text.ToString(),
                    Status = "Pending",
                    Vatvalue = avat
            };
                cartService.Insert(cart);
                searchBarcodeTextBox.SelectionStart=0;
                searchBarcodeTextBox.SelectionLength = searchBarcodeTextBox.Text.Length;
                searchBarcodeTextBox.Focus();
            }

            LoadCart();
            
        }
        public void LoadCart()
        {
            try
            {
                cartDataGridView.Rows.Clear();
                int i = 0;
                decimal total = 0;
                double discount = 0;
                string transNo = transactionLabel.Text;
                List<Cart> carts = cartService.GetAllByRefNo(transNo);
                if (carts.Count() >0)
                {
                    foreach (var cart in carts)
                    {
                        i += 1;
                        total += Decimal.Parse(cart.Total.ToString());
                        //price_withoutvat+= (Double.Parse(cart.Price.ToString())*cart.Quantity);
                        discount += Double.Parse(cart.Discount.ToString());
                        cartDataGridView.Rows.Add(i, cart.Id.ToString(), cart.Product.Code, cart.Product.Description, cart.Price, cart.Quantity, cart.Discount, cart.Total, cart.ProductId);
                        settlePaymentButton.Enabled = true;
                        addDiscountButton.Enabled = true;
                    }
                }
                else
                {
                    settlePaymentButton.Enabled = false;
                    addDiscountButton.Enabled = false;
                }
                
                totalLabel.Text = total.ToString("#,##0.00");
                discountLabel.Text = discount.ToString("#,##0.00");
                GetCartTotal();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "POS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

       

       

        private void searchProductButton_Click(object sender, EventArgs e)
        {
            if (transactionLabel.Text == "000000000000") { return; }
            LookUpForm lookUpForm = new LookUpForm(this);
            lookUpForm.LoadRecords(null);
            lookUpForm.Show();
        }

        private void cartDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow = e.RowIndex;
            if (indexRow < 0)
            {
                return;
            }
            string col = cartDataGridView.Columns[e.ColumnIndex].Name;
            if (col == "Delete")
            {
                if (MessageBox.Show("Remove this item?","",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    var cart = cartService.GetById(Convert.ToInt32(cartDataGridView.Rows[e.RowIndex].Cells[1].Value));
                    cartService.Delete(cart);
                    MessageBox.Show("Successfully removed", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadCart();
                }
            }
            else if (col == "Add")
            {
                var product = productService.GetProductsByCode(cartDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString());
                if(int.Parse(cartDataGridView.Rows[e.RowIndex].Cells[5].Value.ToString()) < product.Quantity)
                {
                    var cart = cartService.GetById(Convert.ToInt32(cartDataGridView.Rows[e.RowIndex].Cells[1].Value));
                    cart.Quantity += 1;
                    cartService.Update(cart);
                    LoadCart();
                }
                else
                {
                    MessageBox.Show("Remaining quantity on hand is " + product.Quantity + " !", "Out Of Stock", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else if (col == "Remove")
            {
                var cart = cartService.GetById(Convert.ToInt32(cartDataGridView.Rows[e.RowIndex].Cells[1].Value));
                if (cart.Quantity>1)
                {
                    cart.Quantity -= 1;
                    cartService.Update(cart);
                    LoadCart();
                }
                else
                {
                    MessageBox.Show("Remaining quantity on cart is " + cart.Quantity + " !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }
        public void GetCartTotal()
        {
      
            double discount = Double.Parse(discountLabel.Text);
            double sales = Double.Parse(totalLabel.Text);
            var vatval = 0.00;
            var vat = 0.00;
            //var vatable = 0.00;
            if (sales != 0)
            {
                vatval =Double.Parse(vatService.GetVat().VatValue.ToString());
                vat = vatval * 100;
                //vatable = price_withoutvat;
            }
           
            vatLabel.Text = vat.ToString("#,##0.00");
            //vatableLabel.Text = vatable.ToString("#,##0.00");
            displayTotalLabel.Text = sales.ToString("#,##0.00");
            
        }

        private void addDiscountButton_Click(object sender, EventArgs e)
        {
            DiscountForm discountForm = new DiscountForm(this);
            discountForm.idLabel.Text= _id;
            discountForm.priceTextBox.Text = _price;
            discountForm.ShowDialog();
            
        }

        private void cartDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            int i = cartDataGridView.CurrentRow.Index;
            _id = cartDataGridView[1, i].Value.ToString();
            _price = cartDataGridView[7, i].Value.ToString();
        }

        private void canncelSalesButton_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Remove All items frm cart?", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                for(int i = 0; i < cartDataGridView.Rows.Count; i++)
                {
                    var cart = cartService.GetById(Convert.ToInt32(cartDataGridView.Rows[i].Cells[1].Value));
                    cartService.Delete(cart);
                    settlePaymentButton.Enabled = false;
                    addDiscountButton.Enabled = false;

                }
                MessageBox.Show("All Items Successfully Removed From The Cart.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadCart();
            }
           
        }

        private void settlePaymentButton_Click(object sender, EventArgs e)
        {
            SettlePaymentForm form = new SettlePaymentForm(this);
            form.saleTextBox.Text = displayTotalLabel.Text;
            form.ShowDialog();
        }

        private void dailySalesButton_Click(object sender, EventArgs e)
        {
            SoldItemsForm soldItemsForm = new SoldItemsForm();
            soldItemsForm.fromDateTimePicker.Enabled = false;
            soldItemsForm.toDateTimePicker.Enabled = false;
            soldItemsForm.cashierComboBox.Enabled = false;
            soldItemsForm.cashierComboBox.Text = usernameLabel.Text;
            soldItemsForm.user = usernameLabel.Text;
            soldItemsForm.ShowDialog();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            if (cartDataGridView.Rows.Count > 0)
            {
                MessageBox.Show("Unable to logout.Please cancel the transaction.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(MessageBox.Show("Logout Application?","Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
                _loginForm.Show();

            }
        }

      

        private void POSForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                newTransactionButton_Click(sender, e);
            }
            else if (e.KeyCode == Keys.F2)
            {
                searchProductButton_Click(sender, e);
            }
            else if (e.KeyCode == Keys.F3)
            {
                addDiscountButton_Click(sender, e);
            }
            else if (e.KeyCode == Keys.F4)
            {
                settlePaymentButton_Click(sender, e);
            }
            else if (e.KeyCode == Keys.F5)
            {
                canncelSalesButton_Click(sender, e);
            }
            else if (e.KeyCode == Keys.F6)
            {
                dailySalesButton_Click(sender, e);
            }
            else if (e.KeyCode == Keys.F7)
            {
                changePasswordButton_Click(sender, e);
            }
            else if (e.KeyCode == Keys.F8)
            {
                searchBarcodeTextBox.SelectionStart = 0;
                searchBarcodeTextBox.SelectionLength = searchBarcodeTextBox.Text.Length;
            }
        }

        private void changePasswordButton_Click(object sender, EventArgs e)
        {
            PasswordChangeForm passwordChangeForm = new PasswordChangeForm(this);
            passwordChangeForm.ShowDialog();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timerLabel.Text = DateTime.Now.ToString("hh:mm:ss tt");
            datenowLabel.Text = DateTime.Now.ToLongDateString();
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
