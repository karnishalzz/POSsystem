using BusinessLayer_POS.Services;
using p=POS_DataModel.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointOfSale_WinForm.Stock
{
    public partial class SearchProduct_Stock : Form
    {
        private StockInForm _stockInForm;
        private readonly StockInService stockInService = new StockInService();
        private readonly ProductService productService = new ProductService();
        private readonly VendorService vendorService = new VendorService();
        public SearchProduct_Stock(StockInForm stockInForm)
        {
            InitializeComponent();
            _stockInForm = stockInForm;
            LoadProduct();
        }
        public void LoadProduct()
        {
            var text = searchTextBox.Text;
            productListDataGridView.Rows.Clear();
            int i = 0;
            List<p.Product> products;
            if (text != null)
            {
                products = productService.GetProductBySearch(text);
            }
            else {
                products = productService.GetAll();
            }
            
            foreach (var product in products)
            {
                i += 1;
                productListDataGridView.Rows.Add(i, product.Id.ToString(), product.Code ,product.Name, product.Quantity);
            }


        }

        private void productListDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow = e.RowIndex;
            if (indexRow < 0)
            {
                return;
            }
            string colname = productListDataGridView.Columns[e.ColumnIndex].Name;

            if (colname == "Select")
            {
                if (_stockInForm.refTextBox.Text == string.Empty)
                {
                    MessageBox.Show("Please enter reference no", "Stock in", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    _stockInForm.refTextBox.Focus();
                    return;
                }
                if (_stockInForm.stockInByTextBox.Text == string.Empty)
                {
                    MessageBox.Show("Please enter stock in by", "Stock in", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    _stockInForm.stockInByTextBox.Focus();
                    return;
                }
                if (_stockInForm.vendorComboBox.Text == string.Empty)
                {
                    MessageBox.Show("Please select a vendor", "Stock in", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    _stockInForm.stockInByTextBox.Focus();
                    return;
                }

                if (MessageBox.Show("Add this item?", "stock in", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        var vrndorid =int.Parse( _stockInForm.idLabel.Text);

                        var stockin = new p.StockIn
                        {
                            ProductId = Convert.ToInt32(productListDataGridView.Rows[e.RowIndex].Cells[1].Value),
                            RefNo = _stockInForm.refTextBox.Text,
                            StockInBy = _stockInForm.stockInByTextBox.Text,
                            StartDate = _stockInForm.stockDateTimePicker.Value,
                            VendorId= vrndorid,
                            Status=false,
                        };
                        stockInService.Insert(stockin);
                        MessageBox.Show("Successfully Added", "Stock in", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _stockInForm.LoadStockIn();

                    }
                    catch (Exception ex)
                    {
                        var msg = ex.Message;
                        MessageBox.Show("Something Went Wrong!Please Contact the Administration");
                    }

                }

            }
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            LoadProduct();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void searchTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            LoadProduct();
        }
    }
}
