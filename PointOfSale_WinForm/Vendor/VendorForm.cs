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
using v = POS_DataModel.Entities;

namespace PointOfSale_WinForm.Vendor
{
    public partial class VendorForm : Form
    {
        private readonly VendorService vendorService = new VendorService();
        VendorListForm _vendorListForm;
        public VendorForm(VendorListForm vendorListForm)
        {
            InitializeComponent();
            _vendorListForm = vendorListForm;
        }


        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(nameTextBox.Text))
                {
                    MessageBox.Show("Please Give a Name to Add");
                    return;
                }
                if (string.IsNullOrEmpty(phoneTextBox.Text))
                {
                    MessageBox.Show("Please Input A Phone Number");
                    return;
                }

                var vendor = new v.Vendor
                {
                    Name = nameTextBox.Text,
                    Address=addresstextBox.Text,
                    ContactPerson=contactPersonTextBox.Text,
                    Phone=phoneTextBox.Text,
                    Email=emailTextBox.Text,
                    Fax=faxTextBox.Text

                };
                vendorService.Insert(vendor);
                MessageBox.Show("Successfully Done!");
                _vendorListForm.LoadRecords();
                clear();
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
                if (string.IsNullOrEmpty(nameTextBox.Text))
                {
                    MessageBox.Show("Please Give a Name to Add");
                    return;
                }
                if (string.IsNullOrEmpty(phoneTextBox.Text))
                {
                    MessageBox.Show("Please Input A Phone Number");
                    return;
                }
                var vendor = vendorService.GetById(int.Parse(idLabel.Text));
                vendor.Name = nameTextBox.Text;
                vendor.Address = addresstextBox.Text;
                vendor.ContactPerson = contactPersonTextBox.Text;
                vendor.Phone = phoneTextBox.Text;
                vendor.Email = emailTextBox.Text;
                vendor.Fax = faxTextBox.Text;
                vendorService.Update(vendor);
                MessageBox.Show("Successfully Done!");
                _vendorListForm.LoadRecords();
                this.Close();
            }
            catch
            {
                MessageBox.Show("Something Went Wrong!Please Contact the Administration");
            }
        }
        private void clear()
        {

            nameTextBox.Text = null;
            addresstextBox.Text = null;
            contactPersonTextBox.Text = null;
            phoneTextBox.Text = null;
            emailTextBox.Text = null;
            faxTextBox.Text = null;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void VendorForm_Load(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
