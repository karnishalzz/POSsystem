using BusinessLayer_POS.Services;
using POS_DataModel.Entities;
using POS_DataModel.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace PointOfSale_WinForm.Records
{
    public partial class RecordForm : Form
    {
        private readonly CartService cartService = new CartService();
        private readonly ProductService productService = new ProductService();
        private readonly CancelSaleService cancelSaleService = new CancelSaleService();
        private readonly StockInService stockInService = new StockInService();
        private readonly AdjustStockService adjustStockService = new AdjustStockService();
        private readonly UserService userService = new UserService();
        public RecordForm()
        {
            InitializeComponent();
            
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            if (sortComboBox.Text == String.Empty)
            {
                MessageBox.Show("Please select an option from the dropdown list.","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            LoadData();
           LoadChartTopSelling();
        }
        public void LoadData()
        {
            recordDataGridView.Rows.Clear();
            int i = 0;
            var carts = cartService.GetAllSoldItemsForRecord(fromDateTimePicker.Value.AddDays(-1),toDateTimePicker.Value.AddDays(1));
            
            var sortcarts = carts.GroupBy(l => new { l.ProductId, l.Product.Code, l.Product.Description })
               .Select(g => new { g.Key.ProductId, g.Key.Code,g.Key.Description, Quantity = g.Sum(c => c.Quantity), Total = g.Sum(c => c.Total) })
               .Take(10);

            
            if (sortComboBox.Text=="SORT BY QUANTITY")
            {
                sortcarts = sortcarts.OrderByDescending(c => c.Quantity).Take(10);
            }
            else if(sortComboBox.Text=="SORT BY TOTAL AMOUNT")
            {
                sortcarts = sortcarts.OrderByDescending(c => c.Total).Take(10);
            }
            foreach(var cart in sortcarts)
            {
                i++;
                recordDataGridView.Rows.Add(i, cart.Code, cart.Description, cart.Quantity,cart.Total);
            }
        }
        public void LoadChartTopSelling()
        {

            var carts = cartService.GetAllSoldItemsForRecord(fromDateTimePicker.Value.AddDays(-1), toDateTimePicker.Value.AddDays(1));

            var sortcarts = carts.GroupBy(l => new { l.ProductId, l.Product.Code, l.Product.Description })
               .Select(g => new { g.Key.ProductId, g.Key.Code, g.Key.Description, Quantity = g.Sum(c => c.Quantity), Total = g.Sum(c => c.Total) })
               .Take(10);


            if (sortComboBox.Text == "SORT BY QUANTITY")
            {
                sortcarts = sortcarts.OrderByDescending(c => c.Quantity).Take(10);
            }
            else if (sortComboBox.Text == "SORT BY TOTAL AMOUNT")
            {
                sortcarts = sortcarts.OrderByDescending(c => c.Total).Take(10);
            }


            chart1.DataSource = sortcarts;
            Series series = chart1.Series[0];
            series.ChartType = SeriesChartType.Doughnut;
            series.Name = "TOP SELLING.";
            var chart = chart1;
            chart.Series[0].XValueMember = "Code";
            chart.Series[0].IsValueShownAsLabel = true;
            if (sortComboBox.Text == "SORT BY QUANTITY")
            {
                chart.Series[0].YValueMembers = "Quantity";
                chart.Series[0].LabelFormat = "{#,##0}";

            }
            else if (sortComboBox.Text == "SORT BY TOTAL AMOUNT")
            {
                chart.Series[0].YValueMembers = "Total";
                chart.Series[0].LabelFormat = "{#,##0.00}";
            }

        }

        private void soldloadButton_Click(object sender, EventArgs e)
        {
            try
            {
                soldDGridView.Rows.Clear();
                int i = 0;
                var carts = cartService.GetAllSoldItemsForRecord(soldfromTimePicker.Value.AddDays(-1), soldTodateTimePicker.Value.AddDays(1));
                var sortcarts = carts.GroupBy(l => new { l.ProductId, l.Product.Code, l.Product.Description,l.Price })
              .Select(g => new { g.Key.ProductId, g.Key.Code, g.Key.Description, g.Key.Price,Discount = g.Sum(c=>c.Discount), Quantity = g.Sum(c => c.Quantity), Total = g.Sum(c => c.Total) })
              .OrderByDescending(x => x.Quantity);
             
                foreach (var cart in carts)
                {
                    i++;
                    soldDGridView.Rows.Add(i, cart.Product.Code, cart.Product.Description,cart.Price, cart.Quantity,cart.Discount,cart.Total);
                }
                totalLabel.Text = carts.Sum(c => c.Total).ToString("#,##0.00");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void LoadCriticalStock()
        {
            productListDataGridView.Rows.Clear();
            int i = 0;
            var products = productService.GetAll().Where(p=>p.Quantity<=p.Reorder);
            if (products != null)
            {
                foreach (var product in products)
                {
                    i += 1;
                    productListDataGridView.Rows.Add(i, product.Id.ToString(), product.Code, product.Name, product.Barcode, product.Description, product.Price, product.category.Name, product.brand.Name, product.Reorder, product.Quantity);
                }
            }
           
        }
        public void LoadInventoryList()
        {
            inventorydataGridView.Rows.Clear();
            int i = 0;
            var products = productService.GetAll().Where(p=>p.Quantity>0);
            foreach (var product in products)
            {
                i += 1;
                inventorydataGridView.Rows.Add(i, product.Id.ToString(), product.Code, product.Name, product.Barcode, product.Description, product.Price, product.category.Name, product.brand.Name, product.Reorder, product.Quantity);
            }
        }

        private void loadCancelOrderbutton_Click(object sender, EventArgs e)
        {
            CancelledOrders();
        }
        public void CancelledOrders()
        {
            int i = 0;
            canceldataGridView.Rows.Clear();
            var cancelledsale = cancelSaleService.GetCancelledSaleByDate(fromcanceldateTimePicker.Value.AddDays(-1), canceltodateTimePicker.Value.AddDays(1));
            if (cancelledsale != null)
            {
                foreach(var cancel in cancelledsale)
                {
                    i++;
                    canceldataGridView.Rows.Add(i, cancel.TransactionNo,cancel.Product.Code, cancel.Product.Description, cancel.Quantity, cancel.Price, cancel.Total, cancel.StartDate, cancel.VoidBy, cancel.CancelledBy, cancel.Reason, cancel.Action);

                }
            }

        }

        private void historyButton_Click(object sender, EventArgs e)
        {
            LoadStockHistory();
        }
        private void LoadStockHistory()
        {
            stockHistoryDataGridView.Rows.Clear();
            int i = 0;
            decimal total = 0;

            List<StockIn> stocks = stockInService.GetAllStockBetweenDates(fromHistorydateTimePicker.Value.AddDays(-1), toHistorydateTimePicker.Value.AddDays(1));
            foreach (var stock in stocks)
            {
                i += 1;
                int qty = stock.product.Quantity;
                decimal price =stock.product.Price;
                total += qty * price;
                stockHistoryDataGridView.Rows.Add(i, stock.Id.ToString(), stock.RefNo, stock.product.Code, stock.product.Description, stock.Quantity,(stock.product.Quantity*stock.product.Price) ,stock.StartDate.ToShortDateString(), stock.StockInBy);
            }

            totalstockinLabel.Text = total.ToString("#,##0.00");
        }

        private void topSellLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            InventoryReportForm form = new InventoryReportForm();
            if (sortComboBox.Text == "SORT BY QUANTITY")
            {
                form.LoadTopSell(fromDateTimePicker.Value.AddDays(-1), toDateTimePicker.Value.AddDays(1), "qty");
            }
            else if (sortComboBox.Text == "SORT BY TOTAL AMOUNT")
            {
                form.LoadTopSell(fromDateTimePicker.Value.AddDays(-1), toDateTimePicker.Value.AddDays(1),"total");
            }
            
            form.ShowDialog();
        }

        private void soldItemLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            InventoryReportForm form = new InventoryReportForm();
            form.LoadSoldItems(soldfromTimePicker.Value.AddDays(-1), soldTodateTimePicker.Value.AddDays(1)); ;
            form.ShowDialog();
        }

       
        private void inventoryLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            InventoryReportForm form = new InventoryReportForm();
            form.LoadInventoryReport();
            form.ShowDialog();
        }

        private void cancelOrdeLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            InventoryReportForm form = new InventoryReportForm();
            form.LoadCancelledItems(fromcanceldateTimePicker.Value.AddDays(-1),canceltodateTimePicker.Value.AddDays(1));
            form.ShowDialog();
        }

        private void stockIninkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            InventoryReportForm form = new InventoryReportForm();
            form.LoadStockInHistory(fromHistorydateTimePicker.Value.AddDays(-1), toHistorydateTimePicker.Value.AddDays(1));
            form.ShowDialog();
        }

     
        private void sortComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
       

        private void chartLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ChartForm chart = new ChartForm();
            chart.titleLabel.Text = "SOLD ITEMS [" + soldfromTimePicker.Value.ToShortDateString() + " - " + toDateTimePicker.Value + "]";
            chart.LoadChartSold(soldfromTimePicker.Value.AddDays(-1), soldTodateTimePicker.Value.AddDays(1));
            chart.ShowDialog();
        }

      

        private void stockadjustButton_Click_1(object sender, EventArgs e)
        {
            stockadjustDataGridView.Rows.Clear();
            int i = 0;

            List<AdjustStock> stocks = adjustStockService.GetAdjustmentsByDate(adjustFromDateTimePicker.Value.AddDays(-1), adjustToDateTimePicker.Value.AddDays(1));
            foreach (var stock in stocks)
            {
                i += 1;
                stockadjustDataGridView.Rows.Add(i, stock.Id, stock.ReferenceNo, stock.Product.Code, stock.Product.Description, stock.Quantity, stock.Action, stock.Remarks, stock.Date, stock.Username);
            }
        }

        private void loadAllAdjustButton_Click_1(object sender, EventArgs e)
        {
            stockadjustDataGridView.Rows.Clear();
            int i = 0;

            List<AdjustStock> stocks = adjustStockService.GetAllAdjustments();
            foreach (var stock in stocks)
            {
                i += 1;
                stockadjustDataGridView.Rows.Add(i, stock.Id, stock.ReferenceNo, stock.Product.Code, stock.Product.Description, stock.Quantity, stock.Action, stock.Remarks, stock.Date, stock.Username);
            }
        }

        private void loadUserbutton_Click(object sender, EventArgs e)
        {
            userdataGridView.Rows.Clear();
            int i = 0;
            var users = userService.GetAll();
            if (users != null)
            {
                foreach (var user in users)
                {
                    i += 1;
                  
                    userdataGridView.Rows.Add(i, user.Id,user.Name,user.Username,user.Role,user.IsActive);
                }
            }
        }

        private void sortComboBox_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void recordDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow = e.RowIndex;
            if (indexRow < 0)
            {
                return;
            }
        }

        private void soldDGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow = e.RowIndex;
            if (indexRow < 0)
            {
                return;
            }
        }

        private void productListDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow = e.RowIndex;
            if (indexRow < 0)
            {
                return;
            }
        }

        private void inventorydataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow = e.RowIndex;
            if (indexRow < 0)
            {
                return;
            }
        }

        private void canceldataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow = e.RowIndex;
            if (indexRow < 0)
            {
                return;
            }
        }

        private void stockHistoryDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow = e.RowIndex;
            if (indexRow < 0)
            {
                return;
            }
        }

        private void stockadjustDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow = e.RowIndex;
            if (indexRow < 0)
            {
                return;
            }
        }

        private void userdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow = e.RowIndex;
            if (indexRow < 0)
            {
                return;
            }
        }
    }
}
