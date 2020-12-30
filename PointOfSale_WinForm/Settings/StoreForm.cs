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

namespace PointOfSale_WinForm.Settings
{
    public partial class StoreForm : Form
    {
        private readonly StoreService storeService = new StoreService();
        public StoreForm()
        {
            InitializeComponent();
            
            LoadStore();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
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
                var store = storeService.GetById(int.Parse(idlabel.Text));
                if ( store!=null)
                {
                    store.Name = nameTextBox.Text.ToString();
                    store.Address = addressTextBox.Text.ToString();
                    storeService.Update(store);
                    MessageBox.Show("Successfully Updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadStore();
                }
                else
                {
                    var store1 = new Store
                    {
                        Name = nameTextBox.Text.ToString(),
                        Address = addressTextBox.Text.ToString()
                    };
                    storeService.Insert(store1);
                    MessageBox.Show("Successfully Saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadStore();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            nameTextBox.Clear();
            addressTextBox.Clear();
            nameTextBox.Focus();
        }

       public void LoadStore()
       {
            var store = storeService.GetStore();
            if (store != null)
            {
                idlabel.Text = store.Id.ToString();
                nameTextBox.Text = store.Name;
                addressTextBox.Text=store.Address;
            }

            else
            {
                idlabel.Text = "0";
            }
            
        }
    }
}
