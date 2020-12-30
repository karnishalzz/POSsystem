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

namespace PointOfSale_WinForm.Other
{
    public partial class DashboardForm : Form
    {
        private readonly CartService cartService = new CartService();
        private readonly ProductService productService = new ProductService();
        private double _dailySales=0;
        private int _productLine = 0;
        private int _stockOnHand = 0;
        private int _criticalItems = 0;
        public DashboardForm()
        {
            InitializeComponent();
            dailySalesLabel.Text = DailySales().ToString("#,##0.00");
            productLineLabel.Text = ProductLine().ToString("#,##0");
            stockLabel.Text = StockOnHand().ToString("#,##0");
            criticalLabel.Text = CriticalItems().ToString("#,##0");
            LoadChart();
        }

        private void DashboardForm_Resize(object sender, EventArgs e)
        {
            panel1.Left=(this.Width - panel1.Width) / 2;
        }
        public double DailySales()
        {
            var carts = cartService.GetAllWithRefProduct();
            var from = DateTime.Now.AddDays(-1);
            var to = DateTime.Now.AddDays(1);
            var sortcart = carts.Where(c => c.Date > from && c.Date < to);

            _dailySales = sortcart.Count();
            return _dailySales;
        }
        public double ProductLine()
        {
            var products = productService.GetAll();
            foreach (var product in products)
            {
                _productLine++;
            }
            return _productLine;
        }
        public double StockOnHand()
        {
            int qty = productService.GetAll().Where(x=>x.Quantity>0).Count();
            _stockOnHand = qty;
            return _stockOnHand;
        }
        public double CriticalItems()
        {
            var products = productService.GetAll().Where(p=>p.Quantity<p.Reorder);
            foreach (var product in products)
            {
                _criticalItems++;
            }
            return _criticalItems;
        }

        public void LoadChart()
        {
            var items =cartService.GetYearSaleTotal();
            chart1.DataSource = items;
            Series series = chart1.Series["Series1"];
            series.ChartType = SeriesChartType.Doughnut;
            series.Name = "SALES";
            var chart = chart1;
            chart.Series[series.Name].XValueMember = "Year";
            chart.Series[series.Name].YValueMembers = "Total";
            chart.Series[0].IsValueShownAsLabel = true;
            //chart.Series[0].LegendText="#";

        }
    }
}
