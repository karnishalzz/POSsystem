using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_DataModel.ViewModel
{
     public class CancelledOrderViewModel
    {
        public string TransactionNo { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public double Total { get; set; }
        public string StartDate { get; set; }
        public string VoidBy { get; set; }
        public string CancelledBy { get; set; }
        public string Reason { get; set; }
        public string Action { get; set; }

    }
}
