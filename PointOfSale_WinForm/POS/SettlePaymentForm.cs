using BusinessLayer_POS.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointOfSale_WinForm.POS
{
    public partial class SettlePaymentForm : Form
    {
        POSForm _pOSForm;
        private readonly CartService cartService = new CartService();
        private readonly ProductService productService = new ProductService();
        private readonly StockInService stockInService = new StockInService();
        public SettlePaymentForm(POSForm pOSForm)
        {
            InitializeComponent();
            _pOSForm = pOSForm;
            this.KeyPreview = true;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void cashTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double sale = Double.Parse(saleTextBox.Text);
                double cash = Double.Parse(cashTextBox.Text);
                double change = cash - sale;
                changeTextBox.Text = change.ToString("#,##0.00");
            }
            catch(Exception )
            {
                changeTextBox.Text = "0.00";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            cashTextBox.Text += button7.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            cashTextBox.Text += button8.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            cashTextBox.Text += button9.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cashTextBox.Text += button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            cashTextBox.Text += button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            cashTextBox.Text += button6.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cashTextBox.Text += button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cashTextBox.Text += button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cashTextBox.Text += button3.Text;
        }

        private void button00_Click(object sender, EventArgs e)
        {
            cashTextBox.Text += button00.Text;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            cashTextBox.Text += button0.Text;
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            cashTextBox.Clear();
            cashTextBox.Focus();
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            try
            {
                if ((Double.Parse(changeTextBox.Text) < 0) || (cashTextBox.Text==String.Empty))
                {
                    MessageBox.Show("Insufficient Number.Please enter a valid number", "POS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                   
                    for(int i = 0; i < _pOSForm.cartDataGridView.Rows.Count; i++)
                    {
                        var q = int.Parse(_pOSForm.cartDataGridView.Rows[i].Cells[5].Value.ToString());
                        var product = productService.GetById(int.Parse(_pOSForm.cartDataGridView.Rows[i].Cells[8].Value.ToString()));
                        product.Quantity -= q;
                        productService.Update(product);
                        int _cartId = int.Parse(_pOSForm.cartDataGridView.Rows[i].Cells[1].Value.ToString());
                        var cart = cartService.GetById(_cartId);
                        cart.Status = "Sold";
                        cartService.Update(cart);
                        
                    }
                    ReceiptForm receiptForm = new ReceiptForm(_pOSForm);
                    receiptForm.LoadReprt(cashTextBox.Text,changeTextBox.Text);
                    receiptForm.ShowDialog();
                    MessageBox.Show("Payment Successful", "POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _pOSForm.GetTransactionNo();
                    _pOSForm.LoadCart();
                    _pOSForm.searchBarcodeTextBox.Clear();
                    _pOSForm.quantityTextBox.Clear();
                    this.Dispose();
                    
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void SettlePaymentForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Dispose();
            }
            else if (e.KeyCode==Keys.Enter)
            {
                enterButton_Click(sender, e);
            }
        }
    }
    
}
