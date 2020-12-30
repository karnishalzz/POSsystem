using BusinessLayer_POS.Services;
using PointOfSale_WinForm.Stock;
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
using p=POS_DataModel.Entities;
namespace PointOfSale_WinForm
{
    public partial class StockInForm : Form
    {
        private readonly StockInService stockInService = new StockInService();
        private readonly ProductService productService = new ProductService();
        private readonly VendorService vendorService = new VendorService();
        
        public StockInForm()
        {
            InitializeComponent();
            LoadStockHistory();
            LoadVendor();
            
        }
        
        public void LoadStockIn()
        {
            stockInDataGridView.Rows.Clear();
            int i = 0;
            var refno = refTextBox.Text;
            List<StockIn> stocks = stockInService.GetStocksWithProductByRef(refno);
            var vendor = vendorService.GetById(int.Parse(idLabel.Text));
            foreach (var stock in stocks)
            {
                i += 1;
                stockInDataGridView.Rows.Add(i, stock.Id.ToString(), stock.RefNo, stock.product.Code,stock.product.Description, stock.Quantity, stock.StartDate,stock.StockInBy,stock.vendor.ContactPerson);
            }


        }
        public void LoadVendor()
        {
            vendorComboBox.Items.Clear();
            var vendors = vendorService.GetAll();
            foreach(var v in vendors)
            {
                vendorComboBox.Items.Add(v.Name);
            }

        }

        private void stockInDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow = e.RowIndex;
            if (indexRow < 0)
            {
                return;
            }
            string col = stockInDataGridView.Columns[e.ColumnIndex].Name;
            if (col == "colDelete")
            {
                if(MessageBox.Show("Remove this item?","Stock in", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var stock=stockInService.GetById(Convert.ToInt32(stockInDataGridView.Rows[e.RowIndex].Cells[1].Value));
                    stockInService.Delete(stock);
                    MessageBox.Show("Item has been sucessfully removed", "Stock in", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadStockIn();
                }
            }
        }

        private void productlinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SearchProduct_Stock searchProduct_Stock = new SearchProduct_Stock(this);
            searchProduct_Stock.LoadProduct();
            searchProduct_Stock.ShowDialog();
        }

        private void LoadStockHistory()
        {
            stockHistoryDataGridView.Rows.Clear();
            int i = 0;
            var from = dateTimePicker1.Value.AddDays(-1);
            var to = dateTimePicker2.Value.AddDays(1);
            List<StockIn> stocks = stockInService.GetAllStockBetweenDates(from,to);
            foreach (var stock in stocks)
            {
                i += 1;
                stockHistoryDataGridView.Rows.Add(i, stock.Id.ToString(), stock.RefNo, stock.product.Code, stock.product.Description, stock.Quantity,stock.StartDate.ToShortDateString(), stock.StockInBy);
            }


        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            LoadStockHistory();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (stockInDataGridView.Rows.Count > 0)
                {
                    if (idLabel.Text!=null)
                    {
                        for (int i = 0; i < stockInDataGridView.Rows.Count; i++)
                        {
                            if (!int.TryParse(stockInDataGridView.Rows[i].Cells[5].Value.ToString(), out var x))
                            {
                                MessageBox.Show("Please Give A valid Number Value");
                                return;
                            }
                            if (int.Parse(stockInDataGridView.Rows[i].Cells[5].Value.ToString())<=0)
                            {
                                MessageBox.Show("Please Check the given Quantities");
                                return;
                            }
                        }

                        if (MessageBox.Show("Are you sure you want to add these products?", "Stock Entry", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            for (int i = 0; i < stockInDataGridView.Rows.Count; i++)
                            {

                                var q = Convert.ToInt32(stockInDataGridView.Rows[i].Cells[5].Value);
                                var _vendor= int.Parse(idLabel.Text);
                                var stock = stockInService.GetById(Convert.ToInt32(stockInDataGridView.Rows[i].Cells[1].Value));
                                stock.Quantity += q;
                                stock.Status = true;
                                stock.VendorId = _vendor; 
                                stockInService.Update(stock);
                                var product = productService.GetById(stock.ProductId);
                                product.Quantity += q;
                                productService.Update(product);
                               

                            }
                            MessageBox.Show("Item has been sucessfully Added", "Stock in", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            clear();

                        }
                    }
                    else
                    {
                        MessageBox.Show("Please Enter Vendor Information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void clear()
        {
            refTextBox.Text = null;
            stockInByTextBox.Text = null;
            stockDateTimePicker.Value = DateTime.Now;
            stockInDataGridView.Rows.Clear();

        }

        private void vendorComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void vendorComboBox_TextChanged(object sender, EventArgs e)
        {
            var vendor = vendorService.GetVendorByName(vendorComboBox.Text);
            if (vendor != null)
            {
                idLabel.Text = vendor.Id.ToString();
                contactTextBox.Text = vendor.ContactPerson.ToString();
                addressTextBox.Text = vendor.Address.ToString();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            refTextBox.Clear();
            Random random = new Random();
            refTextBox.Text += random.Next();
        }

        private void stockHistoryDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow = e.RowIndex;
            if (indexRow < 0)
            {
                return;
            }
        }
    }
}
