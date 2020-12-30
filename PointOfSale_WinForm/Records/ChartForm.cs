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
using System.Windows.Forms.DataVisualization.Charting;

namespace PointOfSale_WinForm.Records
{
    public partial class ChartForm : Form
    {
        private readonly CartService cartService = new CartService();
        public ChartForm()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        public void LoadChartSold(DateTime from,DateTime to)
        {
            var carts = cartService.GetAllSoldItemsForRecord(from,to);
            var sortcarts = carts.GroupBy(l => new { l.ProductId, l.Product.Code, l.Product.Description, l.Price })
          .Select(g => new { g.Key.ProductId, g.Key.Code, g.Key.Description, g.Key.Price, Discount = g.Sum(c => c.Discount), Quantity = g.Sum(c => c.Quantity), Total = g.Sum(c => c.Total) })
          .OrderByDescending(x => x.Quantity);
            chart1.DataSource = sortcarts;
            Series series = chart1.Series[0];
            series.ChartType = SeriesChartType.Doughnut;
            series.Name = "SOLD ITEMS";
            chart1.Series[0].XValueMember = "Description";
            chart1.Series[0].YValueMembers = "Total";
            chart1.Series[0].LabelFormat = "{#,##0.00}";
            chart1.Series[0].IsValueShownAsLabel = true;
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
