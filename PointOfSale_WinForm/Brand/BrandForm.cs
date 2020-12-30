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
using b=POS_DataModel.Entities;

namespace PointOfSale_WinForm.Brand
{
    public partial class BrandForm : Form
    {
        private readonly BrandService brandService = new BrandService();
     
        public BrandForm()
        {
            InitializeComponent();
        }
        public void LoadRecords()
        {
            brandListDataGridView.Rows.Clear();
            int i = 0;
            List<b.Brand> brands = brandService.GetAll();
            foreach (var brand in brands)
            {
                i += 1;
                brandListDataGridView.Rows.Add(i, brand.Id.ToString(), brand.Name, brand.Description);
            }

        }
        private void categoryListDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow = e.RowIndex;
            if (indexRow < 0)
            {
                return;
            }
            int id = Convert.ToInt32(brandListDataGridView.Rows[e.RowIndex].Cells[1].Value);
            string colName = brandListDataGridView.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                CreateBrand createBrand = new CreateBrand(this);
                createBrand.idLabel.Text = brandListDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                createBrand.nameTextBox.Text = brandListDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                createBrand.descriptionRichTextBox.Text = brandListDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();

                createBrand.saveButton.Enabled = false;
                createBrand.cancelButton.Enabled = false;
                createBrand.ShowDialog();
            }
            if (colName == "Delete")
            {
                try
                {
                    var response = MessageBox.Show("Are You Sure?", "Confirm", MessageBoxButtons.YesNo);
                    if (response == DialogResult.Yes)
                    {
                        var product = brandService.GetById(id);
                        brandService.Delete(product);
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
       
        private void addButton_Click(object sender, EventArgs e)
        {
            CreateBrand createBrand = new CreateBrand(this);
            createBrand.updateButton.Enabled = false;
            createBrand.ShowDialog();
        }
        private void BrandForm_Load(object sender, EventArgs e)
        {
            LoadRecords();
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            brandListDataGridView.Rows.Clear();
            int i = 0;
            List<b.Brand> brands = brandService.GetBrandBySearch(searchTextBox.Text);
            foreach (var brand in brands)
            {
                i += 1;
                brandListDataGridView.Rows.Add(i, brand.Id.ToString(), brand.Name, brand.Description);
            }
        }

        
    }
}
