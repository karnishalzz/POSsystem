namespace POS_DataModel.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("StockIn")]
    public partial class StockIn
    {
        public int Id { get; set; }
        public string RefNo { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public DateTime StartDate { get; set; }
        public string StockInBy { get; set; }
        public bool Status { get; set; }
        public int VendorId { get; set; }
        public virtual Product product { get; set; }
        public virtual Vendor vendor { get; set; }


    }
}