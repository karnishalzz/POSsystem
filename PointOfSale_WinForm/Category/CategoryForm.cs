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


namespace PointOfSale_WinForm
{
    public partial class CategoryForm : Form
    {
        private readonly CategoryService categoryService = new CategoryService();

        public CategoryForm()
        {
            InitializeComponent();
        }
        private void CategoryForm_Load(object sender, EventArgs e)
        {
            LoadRecords();
        }
        public void LoadRecords()
        {
            categoryListDataGridView.Rows.Clear();
            int i = 0;
            List<Category> categories = categoryService.GetAll();
            foreach (var category in categories)
            {
                i += 1;
                categoryListDataGridView.Rows.Add(i, category.Id.ToString(), category.Name, category.Description);
            }

        }

        private void categoryListDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow = e.RowIndex;
            if (indexRow < 0)
            {
                return;
            }
            int id = Convert.ToInt32(categoryListDataGridView.Rows[e.RowIndex].Cells[1].Value);
            string colName = categoryListDataGridView.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                CreateCategory createCategory = new CreateCategory(this);
                createCategory.idLabel.Text = categoryListDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                createCategory.nameTextBox.Text = categoryListDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                createCategory.descriptionRichTextBox.Text = categoryListDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
              
                createCategory.saveButton.Enabled = false;
                createCategory.cancelButton.Enabled = false;
                createCategory.ShowDialog();
            }
            if (colName == "Delete")
            {
                try
                {
                    var response = MessageBox.Show("Are You Sure?", "Confirm", MessageBoxButtons.YesNo);
                    if (response == DialogResult.Yes)
                    {
                        var product = categoryService.GetById(id);
                        categoryService.Delete(product);
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
            CreateCategory createCategoryForm = new CreateCategory(this);
            createCategoryForm.updateButton.Enabled = false;
            createCategoryForm.ShowDialog();
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            categoryListDataGridView.Rows.Clear();
            int i = 0;
            List<Category> categories = categoryService.GetCategoryBySearch(searchTextBox.Text);
            foreach (var category in categories)
            {
                i += 1;
                categoryListDataGridView.Rows.Add(i, category.Id.ToString(), category.Name, category.Description);
            }
        }
    }
}
