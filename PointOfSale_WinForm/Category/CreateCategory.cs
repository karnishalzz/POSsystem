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
    public partial class CreateCategory : Form
    {
        private readonly CategoryService categoryService = new CategoryService();
        private CategoryForm categoryFormList;

        public CreateCategory(CategoryForm categoryList)
        {
            InitializeComponent();
            categoryFormList = categoryList;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(nameTextBox.Text))
                {
                    MessageBox.Show("Please Give a Name to Add");
                    return;
                }
                var category = new Category
                {

                    Name = nameTextBox.Text,
                    Description = descriptionRichTextBox.Text,
                    Status = true
                };
                categoryService.Insert(category);
                MessageBox.Show("Successfully Done!");
                clear();
                
                categoryFormList.LoadRecords();
            }
            catch
            {
                MessageBox.Show("Something Went Wrong!Please Contact the Administration");
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(nameTextBox.Text))
                {
                    MessageBox.Show("Please Give a Name to Add");
                    return;
                }
                var category = categoryService.GetById(int.Parse(idLabel.Text));
                category.Name = nameTextBox.Text;
                category.Description = descriptionRichTextBox.Text;
                categoryService.Update(category);
                MessageBox.Show("Successfully Done!");
                clear();
                categoryFormList.LoadRecords();
            }
            catch
            {
                MessageBox.Show("Something Went Wrong!Please Contact the Administration");
            }
        }

      
        private void clear()
        {
            idLabel.Text = null;
            descriptionRichTextBox.Text = null;
            nameTextBox.Text = null;
        
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
