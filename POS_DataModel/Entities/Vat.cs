namespace POS_DataModel.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

   [Table("Vat")]
    public partial class Vat
    {
        public int Id { get; set; }
        public decimal  VatValue { get; set; }

    }
}
