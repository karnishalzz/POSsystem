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
using p=POS_DataModel.Entities;

namespace PointOfSale_WinForm.Stock
{
    public partial class StockAdjustmentForm : Form
    {
        private readonly ProductService productService = new ProductService();
        private readonly AdjustStockService adjustStockService = new AdjustStockService();
        MainForm _mainForm;
        int _qty = 0;
        public StockAdjustmentForm(MainForm mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public void LoadRecords()
        {
            var text = searchTextBox.Text;
            productListDataGridView.Rows.Clear();
            int i = 0;
            List<p.Product> products;
            if (text != null)
            {
                products = productService.GetProductBySearch(text);
            }
            else
            {
                products = productService.GetAll();
            }

            foreach (var product in products)
            {
                i += 1;
                productListDataGridView.Rows.Add(i, product.Id.ToString(), product.Code, product.Barcode, product.Name,  product.Description, product.brand.Name, product.category.Name, product.Price, product.Quantity );
            }
        }

        private void searchTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            LoadRecords();
        }

        private void productListDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(productListDataGridView.Rows[e.RowIndex].Cells[1].Value);
            string colName = productListDataGridView.Columns[e.ColumnIndex].Name;
            var product = productService.GetById(id);
            if (colName == "Select")
            {
                codetextBox.Text = productListDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                descriptiontextBox.Text = productListDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString() + "," +productListDataGridView.Rows[e.RowIndex].Cells[5].Value.ToString() +","+ productListDataGridView.Rows[e.RowIndex].Cells[6].Value.ToString()+"," +productListDataGridView.Rows[e.RowIndex].Cells[7].Value.ToString();
                _qty = int.Parse(productListDataGridView.Rows[e.RowIndex].Cells[9].Value.ToString());
                productIdLabel.Text=productListDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
        }
        public void ReferenceNo()
        {
            Random random = new Random();
            reftextBox.Text = random.Next().ToString();
        }

        private void adjustmentButton_Click(object sender, EventArgs e)
        {
            try {

                
                var product = productService.GetById(int.Parse(productIdLabel.Text));
                if (product == null)
                {
                    MessageBox.Show("Please select a product");
                }
                if (!int.TryParse(qtyTextBox.Text, out var x))
                {
                    MessageBox.Show("Please Give A valid Quantity");
                    return;
                }
                if (commandComboBox.Text=="REMOVE FROM INVENTORY") {
                    if (int.Parse(qtyTextBox.Text) > _qty)
                    {
                        MessageBox.Show("STOCK ON HAND SHOULD BE GREATER THAN FROM GIVEN QUANTITY.", "PROCESS COMPLETED", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    product.Quantity -= int.Parse(qtyTextBox.Text);
                }
                else if (commandComboBox.Text == "ADD TO INVENTORY") {
                    product.Quantity += int.Parse(qtyTextBox.Text);
                }
                else
                {
                    commandComboBox.Focus();
                    MessageBox.Show("Please select a command to perform", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                
         
                var item = new AdjustStock
                {
                    ReferenceNo = reftextBox.Text,
                    ProductId = int.Parse(productIdLabel.Text),
                    Quantity = int.Parse(qtyTextBox.Text),
                    Action = commandComboBox.Text,
                    Remarks = remarksTextBox.Text,
                    Date = DateTime.Now,
                    Username = userTextBox.Text

                };
                adjustStockService.Insert(item);
                productService.Update(product);
                MessageBox.Show("STOCK HAS BEEN SUCCESSFULLY ADJUSTED!", "PROCESS COMPLETED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadRecords();
                clear();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void clear()
        {
            reftextBox.Clear();
            productIdLabel.Text = "";
            codetextBox.Clear();
            qtyTextBox.Clear();
            codetextBox.Clear();
            descriptiontextBox.Clear();
            remarksTextBox.Clear();
            commandComboBox.Text="";

            ReferenceNo();

        }

        private void commandComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
