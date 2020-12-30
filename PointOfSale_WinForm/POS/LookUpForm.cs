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
using p=POS_DataModel.Entities;

namespace PointOfSale_WinForm.POS
{
    public partial class LookUpForm : Form
    {
        private readonly ProductService productService = new ProductService();
        POSForm pOSForm;
        public LookUpForm(POSForm form)
        {
            InitializeComponent();
            pOSForm = form;
            this.KeyPreview = true;
        }

        public void LoadRecords(string text)
        {
            productListDataGridView.Rows.Clear();
            int i = 0;
            if (text == null) {
                var products = productService.GetAll();
                foreach (var product in products)
                {
                    i += 1;
                    productListDataGridView.Rows.Add(i, product.Id.ToString(), product.Code, product.Name, product.Barcode, product.Description, product.Price, product.Quantity, product.category.Name, product.brand.Name);
                }
            } 
            else
            {
                i++;
                var product = productService.GetProductsByCode(text);
                if (product != null)
                {
                    productListDataGridView.Rows.Add(i, product.Id.ToString(), product.Code, product.Name, product.Barcode, product.Description, product.Price, product.Quantity, product.category.Name, product.brand.Name);
                }
               
            }
            

        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            string txt = searchTextBox.Text;
            LoadRecords(txt);
        }

        private void productListDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow = e.RowIndex;
            if (indexRow < 0)
            {
                return;
            }
            string col = productListDataGridView.Columns[e.ColumnIndex].Name;
            if (col == "Select")
            {
                QuantityForm quantityForm = new QuantityForm(pOSForm);
   
                var id = productListDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                var price = productListDataGridView.Rows[e.RowIndex].Cells[6].Value.ToString();
                var qty =int.Parse(productListDataGridView.Rows[e.RowIndex].Cells[7].Value.ToString());
                quantityForm.ProductDetails(id,price,pOSForm.transactionLabel.Text,qty);
                quantityForm.ShowDialog();

            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void LookUpForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Dispose();
            }
        }
    }
}
