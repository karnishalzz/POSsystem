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
    public partial class VoidForm : Form
    {
        CancelDetailsForm _cancelDetailsForm;
        private readonly UserService userService = new UserService();
        private readonly CancelSaleService cancelSaleService = new CancelSaleService();
        private readonly ProductService productService = new ProductService();
        private readonly CartService cartService = new CartService();

        public VoidForm(CancelDetailsForm cancelDetailsForm)
        {
            InitializeComponent();
            _cancelDetailsForm = cancelDetailsForm;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (passTextBox.Text != String.Empty)
                {
                    string user;
                    var voidUser = userService.GetByUsername(usernameTextBox.Text,passTextBox.Text);
                    if (voidUser.Role=="Administrative")
                    {
                        user = voidUser.Username;
                        SaveCancelSale(user);
                        if (_cancelDetailsForm.actionComboBox.Text == "Yes")
                        {
                            BackToInventory();
                        }
                        UpdateCart();
                        MessageBox.Show("sale Transaction Successfully cancelled!","Cancel Order", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Dispose();
                        _cancelDetailsForm.RefeshList();
                        _cancelDetailsForm.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("You are not authorized to perform this task.", "Unauthorized", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void SaveCancelSale(string user)
        {
            var product = productService.GetProductsByCode(_cancelDetailsForm.codeTextBox.Text);
            var cancelSale = new CancelSale
            {
                TransactionNo = _cancelDetailsForm.transTextBox.Text,
                ProductId=product.Id,
                Price=decimal.Parse(_cancelDetailsForm.priceTextBox.Text),
                Quantity=int.Parse(_cancelDetailsForm.cancelQtyTextBox.Text),
                StartDate=DateTime.Now,
                VoidBy=user,
                CancelledBy=_cancelDetailsForm.cancelByTextBox.Text,
                Reason=_cancelDetailsForm.reasonTextBox.Text,
                Action=_cancelDetailsForm.actionComboBox.Text



            };
            cancelSaleService.Insert(cancelSale);

        }
        public void BackToInventory()
        {
            var product = productService.GetProductsByCode(_cancelDetailsForm.codeTextBox.Text);
            product.Quantity += int.Parse(_cancelDetailsForm.cancelQtyTextBox.Text);
            productService.Update(product);
        }
        public void UpdateCart()
        {
            var cart = cartService.GetById(int.Parse(_cancelDetailsForm.idTextBox.Text));
            cart.Quantity -= int.Parse(_cancelDetailsForm.cancelQtyTextBox.Text);
            cartService.Update(cart);
        }
    }
}
