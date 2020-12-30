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
using v=POS_DataModel.Entities;

namespace PointOfSale_WinForm.Vendor
{
    public partial class VendorListForm : Form
    {
        private readonly VendorService vendorService = new VendorService();
        public VendorListForm()
        {
            InitializeComponent();
            LoadRecords();
        }
        public void LoadRecords()
        {
           
                vendorListDataGridView.Rows.Clear();
                int i = 0;
                List<v.Vendor> vendors = vendorService.GetAll();
                foreach (var vendor in vendors)
                {
                    i += 1;
                vendorListDataGridView.Rows.Add(i, vendor.Id.ToString(), vendor.Name, vendor.Address, vendor.ContactPerson, vendor.Phone, vendor.Email, vendor.Fax);
                }

           
        }
        private void vendorListDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow = e.RowIndex;
            if (indexRow < 0)
            {
                return;
            }
            int id = Convert.ToInt32(vendorListDataGridView.Rows[e.RowIndex].Cells[1].Value);
            string colName = vendorListDataGridView.Columns[e.ColumnIndex].Name;
            var item = vendorService.GetById(id);
            if (colName == "Edit")
            {
                VendorForm vendor = new VendorForm(this);
                vendor.idLabel.Text = vendorListDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                vendor.nameTextBox.Text = vendorListDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                vendor.addresstextBox.Text = vendorListDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                vendor.contactPersonTextBox.Text = vendorListDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
                vendor.phoneTextBox.Text = vendorListDataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
                vendor.emailTextBox.Text = vendorListDataGridView.Rows[e.RowIndex].Cells[6].Value.ToString();
                vendor.faxTextBox.Text = vendorListDataGridView.Rows[e.RowIndex].Cells[7].Value.ToString();
                vendor.saveButton.Enabled = false;
                vendor.cancelButton.Enabled = false;
                vendor.ShowDialog();
            }
            if (colName == "Delete")
            {
                try
                {
                    var response = MessageBox.Show("Are You Sure?", "Confirm", MessageBoxButtons.YesNo);
                    if (response == DialogResult.Yes)
                    {

                        vendorService.Delete(item);
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
            VendorForm vendorForm = new VendorForm(this);
            vendorForm.updateButton.Enabled = false;
            vendorForm.ShowDialog();
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            vendorListDataGridView.Rows.Clear();
            int i = 0;
            List<v.Vendor> vendors = vendorService.GetVendorBySearch(searchTextBox.Text);
            foreach (var vendor in vendors)
            {
                i += 1;
                vendorListDataGridView.Rows.Add(i, vendor.Id.ToString(), vendor.Name, vendor.Address, vendor.ContactPerson, vendor.Phone, vendor.Email, vendor.Fax);
            }
        }
    }
}
