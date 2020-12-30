using BusinessLayer_POS.Services;
using Microsoft.Reporting.WinForms;
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

namespace PointOfSale_WinForm.Records
{
    public partial class InventoryReportForm : Form
    {
        private readonly ProductService productService = new ProductService();
        private readonly CartService cartService = new CartService();
        private readonly CancelSaleService cancelSaleService = new CancelSaleService();
        private readonly StockInService stockInService = new StockInService();
      
        public InventoryReportForm()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        public void LoadInventoryReport()
        {
            try
            {
                ReportDataSource reportDataSource;
                this.reportViewer1.LocalReport.ReportPath = Application.StartupPath + @"\Reports\InventoryReport.rdlc";
                this.reportViewer1.LocalReport.DataSources.Clear();
                DataSet dataSet = new DataSet();

                var products = productService.GetAll().Where(p => p.Quantity > 0);
                List<InventoryViewModel> inventoryViewModels = new List<InventoryViewModel>();
                foreach (var x in products)
                {
                    var inventoryViewModel = new InventoryViewModel()
                    {
                       Code=x.Code,
                       Barcode=x.Barcode,
                       Description=x.Description,
                       Brand=x.brand.Name,
                       Category=x.category.Name,
                       Price=double.Parse(x.Price.ToString()),
                       Quantity=x.Quantity,
                       Reorder=x.Reorder
                    };
                    inventoryViewModels.Add(inventoryViewModel);
                }

                reportDataSource = new ReportDataSource("DataSet1", inventoryViewModels);
                reportViewer1.LocalReport.DataSources.Add(reportDataSource);
                reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
                reportViewer1.ZoomMode = ZoomMode.Percent;
                reportViewer1.ZoomPercent = 100;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void LoadTopSell(DateTime from,DateTime to,string sort)
        {
            try
            {
                ReportDataSource reportDataSource;
                this.reportViewer1.LocalReport.ReportPath = Application.StartupPath + @"\Reports\TopSellingReport.rdlc";
                this.reportViewer1.LocalReport.DataSources.Clear();
                DataSet dataSet = new DataSet();
                ReportParameter pHeader= new ReportParameter("pHeader", "Top 10 Selling Items");
                var carts = cartService.GetAllSoldItemsForRecord(from,to);

                var sortcarts = carts.GroupBy(l => new { l.ProductId, l.Product.Code, l.Product.Description })
                   .Select(g => new { g.Key.ProductId, g.Key.Code, g.Key.Description, Quantity = g.Sum(c => c.Quantity), Total = g.Sum(c => c.Total) })
                   .Take(10);
                List<TopSellingViewModel> topSellingViewModels = new List<TopSellingViewModel>();
                foreach (var x in sortcarts)
                {
                    var topSellingViewModel = new TopSellingViewModel()
                    {
                        Description=x.Description,
                        Code=x.Code,
                        Total=double.Parse(x.Total.ToString()),
                        Quantity=x.Quantity
                    };
                    topSellingViewModels.Add(topSellingViewModel);
                }
                

                if (sort== "qty")
                {
                    sortcarts = sortcarts.OrderByDescending(c => c.Quantity).Take(10);
                    pHeader = new ReportParameter("pHeader", "Top 10 Selling Items By Quantity.");
                }
                else if (sort == "total")
                {
                    sortcarts = sortcarts.OrderByDescending(c => c.Quantity).Take(10);
                    pHeader = new ReportParameter("pHeader", "Top 10 Selling Items By Total Amount.");
                }
                ReportParameter pDate = new ReportParameter("pDate", "Date From: " + from.AddDays(1).ToShortDateString() + " To Date: " + to.AddDays(-1).ToShortDateString());
                reportViewer1.LocalReport.SetParameters(pDate);
                reportViewer1.LocalReport.SetParameters(pHeader);
                reportDataSource = new ReportDataSource("DataSet1", topSellingViewModels);
                reportViewer1.LocalReport.DataSources.Add(reportDataSource);
                reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
                reportViewer1.ZoomMode = ZoomMode.Percent;
                reportViewer1.ZoomPercent = 100;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void LoadSoldItems(DateTime from,DateTime to)
        {
            try
            {
                ReportDataSource reportDataSource;
                this.reportViewer1.LocalReport.ReportPath = Application.StartupPath + @"\Reports\SoldItemsReport.rdlc";
                this.reportViewer1.LocalReport.DataSources.Clear();
                DataSet dataSet = new DataSet();

                var carts = cartService.GetAllSoldItemsForRecordDetail(from, to);
                List<SoldItemsViewModel> soldItemsViewModels = new List<SoldItemsViewModel>();

                foreach (var x in carts)
                {
                    var soldItemsViewModel = new SoldItemsViewModel()
                    {
                        Code = x.Product.Code,
                        Description = x.Product.Description,
                        Price = double.Parse(x.Price.ToString()),
                        Quantity = x.Quantity,
                        Discount = double.Parse(x.Discount.ToString()),
                        Total = double.Parse(x.Total.ToString()),
                        Vat = (double)(x.Vatvalue*100)
                    };
                    soldItemsViewModels.Add(soldItemsViewModel);
                }

                ReportParameter pDate = new ReportParameter("pDate", "Date From: " + from.AddDays(1).ToShortDateString() + " To Date: " + to.AddDays(-1).ToShortDateString());
                reportViewer1.LocalReport.SetParameters(pDate);
                reportDataSource = new ReportDataSource("DataSet1", soldItemsViewModels);
                reportViewer1.LocalReport.DataSources.Add(reportDataSource);
                reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
                reportViewer1.ZoomMode = ZoomMode.Percent;
                reportViewer1.ZoomPercent = 100;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        public void LoadCancelledItems(DateTime from,DateTime to)
        {
            try
            {
                ReportDataSource reportDataSource;
                this.reportViewer1.LocalReport.ReportPath = Application.StartupPath + @"\Reports\CancelledOrderReport.rdlc";
                this.reportViewer1.LocalReport.DataSources.Clear();
                DataSet dataSet = new DataSet();

                var cancelledsale = cancelSaleService.GetCancelledSaleByDate(from,to);
                List<CancelledOrderViewModel> cancelledOrderViewModels = new List<CancelledOrderViewModel>();
                foreach (var x in cancelledsale)
                {
                    var cancelledOrderViewModel = new CancelledOrderViewModel()
                    {
                        TransactionNo=x.TransactionNo,
                        Code=x.Product.Code,
                        Description=x.Product.Description,
                        Price=double.Parse(x.Price.ToString()),
                        Quantity=x.Quantity,
                        Total=double.Parse(x.Total.ToString()),
                        StartDate=x.StartDate.ToShortDateString(),
                        VoidBy=x.VoidBy,
                        CancelledBy=x.CancelledBy,
                        Reason=x.Reason,
                        Action=x.Action

                    };
                    cancelledOrderViewModels.Add(cancelledOrderViewModel);
                }
                ReportParameter pDate = new ReportParameter("pDate", "Date From: " + from.AddDays(1).ToShortDateString() + " To Date: " + to.AddDays(-1).ToShortDateString());
                reportViewer1.LocalReport.SetParameters(pDate);
                reportDataSource = new ReportDataSource("DataSet1", cancelledOrderViewModels);
                reportViewer1.LocalReport.DataSources.Add(reportDataSource);
                reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
                reportViewer1.ZoomMode = ZoomMode.Percent;
                reportViewer1.ZoomPercent = 100;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void LoadStockInHistory(DateTime from,DateTime to)
        {
            try
            {
                ReportDataSource reportDataSource;
                this.reportViewer1.LocalReport.ReportPath = Application.StartupPath + @"\Reports\StockInReport.rdlc";
                this.reportViewer1.LocalReport.DataSources.Clear();
                DataSet dataSet = new DataSet();

                List<StockIn> stocks = stockInService.GetAllStockBetweenDates(from, to);
                List<StockinViewModel> stockinViewModels = new List<StockinViewModel>();
                foreach (var x in stocks)
                {
                    var stockinViewModel = new StockinViewModel()
                    {
                        Code=x.product.Code,
                        RefNo=x.RefNo,
                        Description=x.product.Description,
                        StartDate=x.StartDate.ToShortDateString(),
                        Quantity=x.Quantity,
                        StockInBy=x.StockInBy,
                        Vendor=x.vendor.Name

                    };
                    stockinViewModels.Add(stockinViewModel);
                }
                ReportParameter pDate = new ReportParameter("pDate", "Date From: " + from.AddDays(1).ToShortDateString() + " To Date: " + to.AddDays(-1).ToShortDateString());
                reportViewer1.LocalReport.SetParameters(pDate);
                reportDataSource = new ReportDataSource("DataSet1", stockinViewModels);
                reportViewer1.LocalReport.DataSources.Add(reportDataSource);
                reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
                reportViewer1.ZoomMode = ZoomMode.Percent;
                reportViewer1.ZoomPercent = 100;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
