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
    public partial class CreateBrand : Form
    {
        private readonly BrandService brandService = new BrandService();
        private BrandForm brandFormList;

        public CreateBrand(BrandForm brandForm)
        {
            InitializeComponent();
            brandFormList = brandForm;
        }
        private void cancelButton_Click(object sender, EventArgs e)
        {
            clear();
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
                var brand = brandService.GetById(int.Parse(idLabel.Text));
                brand.Name = nameTextBox.Text;
                brand.Description = descriptionRichTextBox.Text;
                brandService.Update(brand);
                MessageBox.Show("Successfully Done!");
                clear();
                brandFormList.LoadRecords();
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
                if (String.IsNullOrEmpty(nameTextBox.Text))
                {
                    MessageBox.Show("Please Give a Name to Add");
                    return;
                }
                var brand = new b.Brand
                {

                    Name = nameTextBox.Text,
                    Description = descriptionRichTextBox.Text,
                    Status = true
                };
                brandService.Insert(brand);
                MessageBox.Show("Successfully Done!");
                clear();

                brandFormList.LoadRecords();
            }
            catch
            {
                MessageBox.Show("Something Went Wrong!Please Contact the Administration");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void clear()
        {
            idLabel.Text = null;
            descriptionRichTextBox.Text = null;
            nameTextBox.Text = null;

        }

        private void CreateBrand_Load(object sender, EventArgs e)
        {

        }
    }
}
