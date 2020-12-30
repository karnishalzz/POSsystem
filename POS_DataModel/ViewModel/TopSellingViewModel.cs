using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_DataModel.ViewModel
{
    public class TopSellingViewModel
    {
        public string Code { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public double Total { get; set; }
    }
}
