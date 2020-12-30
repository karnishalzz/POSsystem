using BusinessLayer_POS.Services;
using Microsoft.Reporting.WinForms;
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
    public partial class ReceiptForm : Form
    {
        private readonly CartService cartService = new CartService();
        private readonly StoreService storeService = new StoreService();
        POSForm _pOSForm;
        string _store = "Marinoft Software Solution";
        string _address = "10th floor,Karnafuli Tower,Chittagong";
        public ReceiptForm(POSForm pOSForm)
        {
            InitializeComponent();
            _pOSForm = pOSForm;
            GetStoreInfo();
            this.KeyPreview = true;
        }
        public void GetStoreInfo()
        {
            var store = storeService.GetStore();
            if (store != null)
            {
                _store = store.Name;
                _address = store.Address;
            }
        }

        private void ReceiptForm_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
        }
        public void LoadReprt(string pcash,string pchange)
        {
            ReportDataSource reportDataSource;
            try
            {
                this.reportViewer1.LocalReport.ReportPath = Application.StartupPath + @"\Reports\ReceiptReport.rdlc";
                this.reportViewer1.LocalReport.DataSources.Clear();
                DataSet dataSet = new DataSet();
                var cart =cartService.GetAllSoldByRefNo(_pOSForm.transactionLabel.Text);
                List<RecieptViewModel> recieptViewModels = new List<RecieptViewModel>();
                foreach (var x in cart)
                {
                    var recieptViewModel = new RecieptViewModel()
                    {
                   Name=x.Product.Name,
                   Price=(double)(x.Price),
                   Quantity=x.Quantity,
                   Total=(double)(x.Total)
                   
                    };
                    recieptViewModels.Add(recieptViewModel);
                }
                ReportParameter pVat = new ReportParameter("pVat", _pOSForm.vatLabel.Text);
                ReportParameter pDiscount = new ReportParameter("pDiscount", _pOSForm.discountLabel.Text);
                ReportParameter pTotal = new ReportParameter("pTotal", _pOSForm.totalLabel.Text);
                ReportParameter pCash = new ReportParameter("pCash", pcash);
                ReportParameter pChange = new ReportParameter("pChange", pchange);
                ReportParameter pStore = new ReportParameter("pStore", _store);
                ReportParameter pAddress = new ReportParameter("pAddress", _address);
                ReportParameter pTrasaction = new ReportParameter("pTrasaction", "Invoice #: "+ _pOSForm.transactionLabel.Text);
                ReportParameter pCashier = new ReportParameter("pCashier", _pOSForm.usernameLabel.Text);

              
                reportViewer1.LocalReport.SetParameters(pVat);
                reportViewer1.LocalReport.SetParameters(pDiscount);
                reportViewer1.LocalReport.SetParameters(pTotal);
                reportViewer1.LocalReport.SetParameters(pCash);
                reportViewer1.LocalReport.SetParameters(pChange);
                reportViewer1.LocalReport.SetParameters(pStore);
                reportViewer1.LocalReport.SetParameters(pAddress);
                reportViewer1.LocalReport.SetParameters(pTrasaction);
                reportViewer1.LocalReport.SetParameters(pCashier);

                reportDataSource = new ReportDataSource("soldDataSet", recieptViewModels);
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

        private void ReceiptForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Dispose();
            }
        }
    }
}
