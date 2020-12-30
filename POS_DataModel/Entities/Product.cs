namespace POS_DataModel.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Code { get; set; }

        [Required]
        [StringLength(200)]
        public string Name { get; set; }

        public string Barcode { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public int Reorder { get; set; }
        public decimal Price { get; set; }

        public bool Status { get; set; }

        public int CategoryId { get; set; }
        public int BrandId { get; set; }

        public virtual Category category { get; set; }
        public virtual Brand brand { get; set; }
    }
}
