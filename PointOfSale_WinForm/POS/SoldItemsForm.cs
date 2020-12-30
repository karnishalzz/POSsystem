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

namespace PointOfSale_WinForm.POS
{
    public partial class SoldItemsForm : Form
    {
        private readonly CartService cartService = new CartService();
        private readonly UserService userService = new UserService();
        public string user;
        
        public SoldItemsForm()
        {
            InitializeComponent();
            LoadSoldRecords();
            LoadCashier();
        }
       
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        public void LoadSoldRecords()
        {
            List<Cart> items;
            if(cashierComboBox.Text=="All Cashier")
            {
                items = cartService.GetAllSoldItemsOnCart(fromDateTimePicker.Value.AddDays(-1), toDateTimePicker.Value.AddDays(1), "All Cashier");
            }
            else
            {
                items = cartService.GetAllSoldItemsOnCart(fromDateTimePicker.Value.AddDays(-1), toDateTimePicker.Value.AddDays(1), cashierComboBox.Text);
            }
            soldDataGridView.Rows.Clear();
            int i = 0;
            decimal _total = 0;
         
            foreach(var item in items)
            {
                i += 1;
                _total += item.Total;
                soldDataGridView.Rows.Add(i, item.Id, item.TransactionNo, item.Product.Code, item.Product.Description, item.Price, item.Quantity, item.Discount, item.Total);
            }
            totalLabel.Text = _total.ToString("#,##0.00");
        }
        
        private void fromDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            LoadSoldRecords();
        }

        private void toDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            LoadSoldRecords();
        }



        private void printButton_Click(object sender, EventArgs e)
        {
            SoldReportForm soldReportForm = new SoldReportForm(this);
            soldReportForm.LoadReport();
            soldReportForm.ShowDialog();
        }

        private void cashierComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        public void LoadCashier()
        {
            cashierComboBox.Items.Clear();
            cashierComboBox.Items.Add("All Cashier");
            var cashiers=userService.GetUserByRole("Cashier");
            foreach(var cashier in cashiers)
            {
                cashierComboBox.Items.Add(cashier.Username.ToString());

            }
        }

        private void cashierComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadSoldRecords();
        }

        private void soldDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow = e.RowIndex;
            if (indexRow < 0)
            {
                return;
            }
            string colname = soldDataGridView.Columns[e.ColumnIndex].Name;
            if (colname == "Cancel")
            {
                CancelDetailsForm cancelDetailsForm = new CancelDetailsForm(this);
                cancelDetailsForm.idTextBox.Text = soldDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                cancelDetailsForm.transTextBox.Text = soldDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                cancelDetailsForm.codeTextBox.Text = soldDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                cancelDetailsForm.descriptionTextBox.Text = soldDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
                cancelDetailsForm.priceTextBox.Text = soldDataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
                cancelDetailsForm.quantityTextBox.Text = soldDataGridView.Rows[e.RowIndex].Cells[6].Value.ToString();
                cancelDetailsForm.discountTextBox.Text = soldDataGridView.Rows[e.RowIndex].Cells[7].Value.ToString();
                cancelDetailsForm.totalTextBox.Text = soldDataGridView.Rows[e.RowIndex].Cells[8].Value.ToString();
                

                cancelDetailsForm.cancelByTextBox.Text = user;
                cancelDetailsForm.ShowDialog();
            }
        }
    }
}
