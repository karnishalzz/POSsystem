using BusinessLayer_POS.Services;
using System;
using p = POS_DataModel.Entities;
using System.Windows.Forms;
using POS_DataModel.Entities;
using System.Collections.Generic;

namespace PointOfSale_WinForm.Product
{
    public partial class CreateProduct : Form
    {
        private readonly ProductService productService = new ProductService();
        private readonly CategoryService categoryService = new CategoryService();
        private readonly BrandService brandService = new BrandService();
        private FormProductList _productList;
        public CreateProduct(FormProductList productList)
        {
            InitializeComponent();
            LoadCategory();
            LoadBrand();
            _productList = productList;
        }
        public void LoadCategory()
        {
            categoryComboBox.Items.Clear();

            var categories = categoryService.GetAll();
            foreach(var category in categories)
            {
                categoryComboBox.Items.Add(category.Name);
            }
            
        }
        public void LoadBrand()
        {
            brandComboBox.Items.Clear();

            var brands = brandService.GetAll();
            foreach (var brand in brands)
            {
                brandComboBox.Items.Add(brand.Name);
            }

        }
        private void cancelButton_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(codeTextBox.Text))
                {
                    MessageBox.Show("Please Give a Code to the Product");
                    return;
                }
                if (!decimal.TryParse(priceTextBox.Text, out var x))
                {
                    MessageBox.Show("Please Give A valid Number Value");
                    return;
                }
                if (!decimal.TryParse(reorderTextBox.Text, out var y))
                {
                    MessageBox.Show("Please Give A valid Number Value");
                    return;
                }
                var category = categoryService.GetByName(categoryComboBox.Text);
                if (category == null)
                {
                    MessageBox.Show("Please SELECT a Category ");
                    return;
                }
                var brand = brandService.GetByName(brandComboBox.Text);
                if (brand == null)
                {
                    MessageBox.Show("Please SELECT a Brand ");
                    return;
                }
                var product = productService.GetById(int.Parse(idLabel.Text));
                product.Name = nameTextBox.Text;
                product.Code = codeTextBox.Text;
                product.Price = decimal.Parse(priceTextBox.Text);
                product.Barcode = barcodeTextBox.Text;
                product.Reorder = int.Parse(reorderTextBox.Text);
                product.Description = descriptionTextBox.Text;
                product.CategoryId = category.Id;
                product.BrandId = brand.Id;
                productService.Update(product);
                MessageBox.Show("Successfully Done!");
                _productList.LoadRecords();
                this.Close();
            }
            catch
            {
                MessageBox.Show("Something Went Wrong!Please Contact the Administration");
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(codeTextBox.Text))
                {
                    MessageBox.Show("Please Give a Code to the product");
                    return;
                }
                if (!decimal.TryParse(priceTextBox.Text, out var x))
                {
                    MessageBox.Show("Please Give A valid Number Value");
                    return;
                }
                if (!decimal.TryParse(reorderTextBox.Text, out var y))
                {
                    MessageBox.Show("Please Give A valid Number Value");
                    return;
                }
                if (productService.IsExist(codeTextBox.Text) == false)
                {
                    var category = categoryService.GetByName(categoryComboBox.Text);
                    if (category == null)
                    {
                        MessageBox.Show("Please SELECT a Category ");
                        return;
                    }
                    var brand = brandService.GetByName(brandComboBox.Text);
                    if (brand == null)
                    {
                        MessageBox.Show("Please SELECT a Brand ");
                        return;
                    }
                    var product = new p.Product
                    {
                        Code = codeTextBox.Text,
                        Name = nameTextBox.Text,
                        Price = decimal.Parse(priceTextBox.Text),
                        Barcode = barcodeTextBox.Text,
                        Description = descriptionTextBox.Text,
                        CategoryId = category.Id,
                        BrandId = brand.Id,
                        Status = true,
                        Quantity = 0,
                        Reorder = int.Parse(reorderTextBox.Text),

                    };
                    productService.Insert(product);
                    MessageBox.Show("Successfully Done!");
                    _productList.LoadRecords();
                    clear();
                }
                else
                {
                    MessageBox.Show("This Product Code Already Exists.Please Try Another One.");
                }
               
            }
            catch
            {
                MessageBox.Show("Something Went Wrong!Please Contact the Administration");
            }
        }
        private void clear()
        {
            codeTextBox.Text = null;
            nameTextBox.Text = null;
            priceTextBox.Text = null;
            barcodeTextBox.Text = null;
            descriptionTextBox.Text = null;
            categoryComboBox.SelectedIndex = -1;
            categoryComboBox.Text = "--Select Category--";
            brandComboBox.SelectedIndex = -1;
            brandComboBox.Text = "--Select Brand--";
            reorderTextBox.Text = null;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void categoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (categoryComboBox.SelectedIndex < 0)
            {
                categoryComboBox.Text = "--Select Category--";
            }
          
        }
        private void brandComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (brandComboBox.SelectedIndex < 0)
            {
                brandComboBox.Text = "--Select Brand--";
            }

        }

        private void priceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 46)
            {

            }
            else if (e.KeyChar==8)
            {

            }
            else if ((e.KeyChar < 48) || (e.KeyChar > 57))
            {
                e.Handled = true;
            }
        }

        private void reorderTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
