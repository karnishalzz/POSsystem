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
    public partial class DiscountForm : Form
    {
        private readonly CartService cartService = new CartService();
        POSForm _posForm;
        public DiscountForm(POSForm pOSForm)
        {
            InitializeComponent();
            _posForm = pOSForm;
            this.KeyPreview = true;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void discountPercentTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double discount = Double.Parse(priceTextBox.Text) * (Double.Parse(discountPercentTextBox.Text)/100);
                discountAmuntTextBox.Text = discount.ToString("#.##0.00");
            }
            catch(Exception ex)
            {
                discountAmuntTextBox.Text = "0.00";
            }
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(discountAmuntTextBox.Text, out var x))
                {
                    MessageBox.Show("Please Give A valid Number Value");
                    return;
                }
                if (MessageBox.Show("Add Discount? click yes to confirm.", "POS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var dis= decimal.Parse(discountAmuntTextBox.Text);
                    var cart = cartService.GetById(int.Parse(idLabel.Text));
                    cart.Discount = dis;
                    cart.Total -= dis;
                    cart.DiscountPercent = Decimal.Parse(discountPercentTextBox.Text)/100;
                    cartService.Update(cart);
                    _posForm.LoadCart();
                    this.Dispose();
                    
                  

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DiscountForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Dispose();
            }
        }
    
    }
}
