namespace POS_DataModel.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Cart")]
    public partial class Cart
    {
        public int Id { get; set; }
        public string TransactionNo { get; set; }
        public decimal Price { get; set; }
        public decimal Total { get; set; }
        public decimal Vatvalue { get; set; }
        public decimal Discount { get; set; }
        public decimal DiscountPercent { get; set; }
        public int Quantity { get; set; }
        public int ProductId { get; set; }
        public string StartDate { get; set; }
        public DateTime Date { get; set; }
        public string Status { get; set; }
        public string Cashier { get; set; }
        public virtual Product Product { get; set; }

       
    }
}