using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_DataModel.ViewModel
{
    public class SoldItemsViewModel
    {
        public string Code { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public double Discount { get; set; }
        public double Total { get; set; }
        public double Vat { get; set; }
    }
}
