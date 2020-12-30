using BusinessLayer_POS.Services;
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

namespace PointOfSale_WinForm.POS
{
    public partial class QuantityForm : Form
    {
        private int qty;
        private readonly CartService cartService = new CartService();
        private readonly VatService vatService = new VatService();
        POSForm _posForm;
        private int pid;
        private decimal price;
        private string transno;
        


        public QuantityForm(POSForm pOSForm)
        {
            InitializeComponent();
            _posForm = pOSForm;
        }

        private void QuantityForm_Load(object sender, EventArgs e)
        {

        }
        public void ProductDetails(string id,string price,string transno,int qty)
        {
            this.pid = int.Parse(id);
            this.price = decimal.Parse(price);
            this.transno = transno;
            this.qty = qty;
        }

        private void quantityTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == 13) && (quantityTextBox.Text != String.Empty))
            {
                if (!int.TryParse(quantityTextBox.Text, out var x))
                {
                    MessageBox.Show("Please Give A valid Number Value");
                    return;
                }
                if (int.Parse(quantityTextBox.Text)>0 )
                {
                   
                    bool found = false;
                    var cart_qty = 0;

                    var inCart = cartService.GetAllByRefAndProduct(_posForm.transactionLabel.Text, pid.ToString());
                    if (inCart != null) { found = true; cart_qty = inCart.Quantity; }
                    else found = false;
                    if (found == true)
                    {
                        if (this.qty < int.Parse(quantityTextBox.Text) + cart_qty)
                        {
                            MessageBox.Show("Unable to proceed.Remaining Quantity On Hand is " + this.qty, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        var q = inCart.Quantity + int.Parse(quantityTextBox.Text);
                        inCart.Quantity = q;
                        cartService.Update(inCart);
                    }
                    else
                    {
                        if (qty < int.Parse(quantityTextBox.Text) + cart_qty)
                        {
                            MessageBox.Show("Unable to proceed.Remaining Quantity On Hand is " + qty, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        var date = DateTime.Now.ToString("yyyyMMdd");
                        var avat = (vatService.GetVat().VatValue);
                        var cart = new Cart
                        {
                            TransactionNo = transno,
                            Price = price,
                            Quantity = int.Parse(quantityTextBox.Text),
                            StartDate = date,
                            ProductId = pid,
                            Total = price * int.Parse(quantityTextBox.Text),
                            Date = DateTime.Now,
                            Cashier = _posForm.usernameLabel.Text.ToString(),
                            Status = "Pending",
                            Vatvalue = avat,

                        };
                        cartService.Insert(cart);
                        _posForm.searchBarcodeTextBox.Clear();
                        _posForm.searchBarcodeTextBox.Focus();
                    }

                    _posForm.LoadCart();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Input");
                }
               
            }
        }
        
    }
}
