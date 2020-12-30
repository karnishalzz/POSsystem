using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_DataModel.ViewModel
{
    public class InventoryViewModel
    {
        public string Code { get; set; }
        public string Barcode { get; set; }
        public string Description { get; set; }
        public string Brand { get; set; }
        public string Category { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public int Reorder { get; set; }
    }
}
