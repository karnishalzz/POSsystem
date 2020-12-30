using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_DataModel.ViewModel
{
     public class RecieptViewModel
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public double Total { get; set; }
        public double Price { get; set; }
    }
}
