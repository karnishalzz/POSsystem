using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_DataModel.Entities
{
    [Table("AdjustStock")]
    public partial class AdjustStock
    {
        public int Id { get; set; }
        public string ReferenceNo { get; set; }
        public int Quantity { get; set; }
        public string Action { get; set; }
        public string Remarks { get; set; }
        public DateTime Date { get; set; }
        public string Username { get; set; }
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }

    }
}
