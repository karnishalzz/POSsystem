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

namespace PointOfSale_WinForm.POS
{
    public partial class SoldReportForm : Form
    {
        SoldItemsForm itemsForm;
        string _store = "Marinoft";
        string _address = "10th floor karnafuli tower,Kazir dewri,Chittagong";
        private readonly CartService cartService = new CartService();
        private readonly StoreService storeService = new StoreService();
        public SoldReportForm(SoldItemsForm soldItemsForm)
        {
            InitializeComponent();
            itemsForm = soldItemsForm;
            LoadStore();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        public void LoadStore()
        {
            var store = storeService.GetStore();
            if (store != null)
            {
                _store = store.Name;
                _address = store.Address;
            }
        }

       
        public void LoadReport()
        {
            try
            {
                ReportDataSource reportDataSource;
                this.reportViewer1.LocalReport.ReportPath = Application.StartupPath + @"\Reports\SoldItemListReport.rdlc";
                this.reportViewer1.LocalReport.DataSources.Clear();
                DataSet dataSet = new DataSet();
                List<Cart> items;
                if (itemsForm.cashierComboBox.Text=="All Cashier" || itemsForm.cashierComboBox.Text == "") {
                    items = cartService.GetAllSoldItemsOnCart(itemsForm.fromDateTimePicker.Value.AddDays(-1), itemsForm.toDateTimePicker.Value.AddDays(1),"");
                }
                else
                {
                   items = cartService.GetAllSoldItemsOnCart(itemsForm.fromDateTimePicker.Value.AddDays(-1), itemsForm.toDateTimePicker.Value.AddDays(1),itemsForm.cashierComboBox.Text);
                }
                List<SoldItemsListViewModel> soldItemsListViewModels = new List<SoldItemsListViewModel>();
                foreach (var x in items)
                {
                    var soldItemsListViewModel = new SoldItemsListViewModel()
                    {
                        TransactionNo = x.TransactionNo,
                        Code = x.Product.Code,
                        Description = x.Product.Description,
                        Price = double.Parse(x.Price.ToString()),
                        Quantity = x.Quantity,
                        Total = double.Parse(x.Total.ToString()),
                        Discount = (double)(x.Discount)

                    };
                    soldItemsListViewModels.Add(soldItemsListViewModel);
                }
                ReportParameter pDate = new ReportParameter("pDate", "Date From: " + itemsForm.fromDateTimePicker.Value.ToShortDateString() + " To Date: " + itemsForm.toDateTimePicker.Value.ToShortDateString());
                ReportParameter pCashier = new ReportParameter("pCashier", "Cashier: " + itemsForm.cashierComboBox.Text);
                ReportParameter pHeader = new ReportParameter("pHeader", "SALES REPORT");
                ReportParameter pStore = new ReportParameter("pStore", _store);
                ReportParameter pAddress = new ReportParameter("pAddress", _address);

                reportViewer1.LocalReport.SetParameters(pDate);
                reportViewer1.LocalReport.SetParameters(pCashier);
                reportViewer1.LocalReport.SetParameters(pHeader);
                reportViewer1.LocalReport.SetParameters(pStore);
                reportViewer1.LocalReport.SetParameters(pAddress);

                reportDataSource = new ReportDataSource("DataSet1", soldItemsListViewModels);
                reportViewer1.LocalReport.DataSources.Add(reportDataSource);
                reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
                reportViewer1.ZoomMode = ZoomMode.Percent;
                reportViewer1.ZoomPercent = 100;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

      
    }
}
