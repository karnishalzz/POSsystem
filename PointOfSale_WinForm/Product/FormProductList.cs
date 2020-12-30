using BusinessLayer_POS.Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using p=POS_DataModel.Entities ;

namespace PointOfSale_WinForm.Product
{
    public partial class FormProductList : Form
    {
        private readonly ProductService productService = new ProductService();

        public FormProductList()
        {

            InitializeComponent();

        }
        public void LoadRecords()
        {
            productListDataGridView.Rows.Clear();
            int i = 0;
            List<p.Product> products = productService.GetAll();
            foreach (var product in products)
            {
                i += 1;
                productListDataGridView.Rows.Add(i, product.Id.ToString(),product.Code, product.Name, product.Barcode,product.Description, product.Price,product.Reorder,product.category.Name, product.brand.Name);
            }

        }
        private void addButton_Click(object sender, EventArgs e)
        {
            CreateProduct createProductForm = new CreateProduct(this);
            createProductForm.updateButton.Enabled = false;
            createProductForm.LoadCategory();
            createProductForm.LoadBrand();
            createProductForm.ShowDialog();
        }

        private void FormProductList_Load(object sender, EventArgs e)
        {
            LoadRecords();
     
           
        }

     

        //private void codeTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        //{
        //    if (string.IsNullOrWhiteSpace(codeTextBox.Text))
        //    {
        //        e.Cancel = true;
        //        codeTextBox.Focus();
        //        errorProvider.SetError(codeTextBox, "This Field is Required");
        //    }
        //    else
        //    {
        //        e.Cancel = false;
        //        errorProvider.SetError(codeTextBox, "");
        //    }
        //}


        private void productListDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow = e.RowIndex;
            if (indexRow < 0)
            {
                return;
            }
            int id = Convert.ToInt32(productListDataGridView.Rows[e.RowIndex].Cells[1].Value);
            string colName = productListDataGridView.Columns[e.ColumnIndex].Name;
            var product = productService.GetById(id);
            if (colName == "Edit")
            {
                CreateProduct createProduct = new CreateProduct(this);
                createProduct.idLabel.Text = productListDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                createProduct.codeTextBox.Text = productListDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                createProduct.nameTextBox.Text = productListDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                createProduct.barcodeTextBox.Text = productListDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
                createProduct.descriptionTextBox.Text = productListDataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
                createProduct.priceTextBox.Text = productListDataGridView.Rows[e.RowIndex].Cells[6].Value.ToString();
                createProduct.categoryComboBox.Text = productListDataGridView.Rows[e.RowIndex].Cells[8].Value.ToString();
                createProduct.brandComboBox.Text = productListDataGridView.Rows[e.RowIndex].Cells[9].Value.ToString();
                createProduct.reorderTextBox.Text = productListDataGridView.Rows[e.RowIndex].Cells[7].Value.ToString();
                createProduct.saveButton.Enabled = false;
                createProduct.cancelButton.Enabled = false;
                createProduct.ShowDialog();
            }
            if (colName == "Delete")
            {
                try
                {
                    var response = MessageBox.Show("Are You Sure?", "Confirm", MessageBoxButtons.YesNo);
                    if (response == DialogResult.Yes)
                    {
                        
                        productService.Delete(product);
                        MessageBox.Show("Successfully Done!");
                        LoadRecords();
                    }
                }

                catch
                {
                    MessageBox.Show("Something Went Wrong!Please Contact the Administration");
                }
            }
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            productListDataGridView.Rows.Clear();
            int i = 0;
            List<p.Product> products = productService.GetProductBySearch(searchTextBox.Text);
            foreach (var product in products)
            {
                i += 1;
                productListDataGridView.Rows.Add(i, product.Id.ToString(), product.Code, product.Name, product.Barcode, product.Description, product.Price, product.Quantity, product.category.Name, product.brand.Name);
            }
        }
    }
}
