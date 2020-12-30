using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointOfSale_WinForm.POS
{
    public partial class CancelDetailsForm : Form
    {
        SoldItemsForm _soldItemsForm;
        public CancelDetailsForm(SoldItemsForm soldItemsForm)
        {
            InitializeComponent();
            _soldItemsForm = soldItemsForm;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            try
            {
                if ((actionComboBox.Text!=String.Empty)||(cancelQtyTextBox.Text!=String.Empty)||(reasonTextBox.Text!=string.Empty))
                {
                    if (!int.TryParse(cancelQtyTextBox.Text, out var x))
                    {
                        MessageBox.Show("Please Give A valid Number Value");
                        return;
                    }
                    if (int.Parse(quantityTextBox.Text) >= int.Parse(cancelQtyTextBox.Text))
                    {
                        VoidForm voidForm = new VoidForm(this);
                        voidForm.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Sold quantity is lesser than the given quantity", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please fill up all the information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void RefeshList()
        {
            _soldItemsForm.LoadSoldRecords();
        }

        private void actionComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
