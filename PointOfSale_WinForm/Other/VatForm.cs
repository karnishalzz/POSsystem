using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer_POS.Services;
using POS_DataModel.Entities;

namespace PointOfSale_WinForm.Other
{
    public partial class VatForm : Form
    {
        private readonly VatService vatService = new VatService();
        public VatForm()
        {
            InitializeComponent();
            LoadVat();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!decimal.TryParse(nameTextBox.Text, out var x))
                {
                    MessageBox.Show("Please Give A valid Number Value");
                    return;
                }
                var vat = vatService.GetById(int.Parse(idLabel.Text));
                if (vat!=null)
                {
                    vat.VatValue =Decimal.Parse(nameTextBox.Text)/100;
                    vatService.Update(vat);
                    MessageBox.Show("Vat Updated successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadVat();
                }
                else
                {
                    var vat1 = new Vat
                    {
                        VatValue =Decimal.Parse(nameTextBox.Text)/100,
                        
                    };
                    vatService.Insert(vat1);
                    MessageBox.Show("New Vat Added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadVat();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LoadVat()
        {
            var vat = vatService.GetVat();
            if (vat != null)
            {
                nameTextBox.Text =(vat.VatValue*100).ToString();
                idLabel.Text = vat.Id.ToString();

            }
            else
            {
                idLabel.Text = "0";
            }

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
