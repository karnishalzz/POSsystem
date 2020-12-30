namespace POS_DataModel.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CancelSale")]
    public partial class CancelSale
    {
        public int Id { get; set; }
        public string TransactionNo { get; set; }
        public int ProductId { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public decimal Total { get; set; }
        public DateTime StartDate { get; set; }
        public string VoidBy { get; set; }
        public string CancelledBy { get; set; }
        public string Reason { get; set; }
        public string Action { get; set; }
        public virtual Product Product { get; set; }

    }
}