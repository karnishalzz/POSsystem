using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_DataModel.ViewModel
{
    public class StockinViewModel
    {
        public string RefNo { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public string StartDate { get; set; }
        public string StockInBy { get; set; }
        public string Vendor { get; set; }

    }
}
