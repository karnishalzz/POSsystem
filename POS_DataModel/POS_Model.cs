namespace POS_DataModel
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using POS_DataModel.Entities;

    public partial class POS_Model : DbContext
    {
        public POS_Model()
            : base("name=POS_Model")
        {
        }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Brand> Brands { get; set; }
        public virtual DbSet<StockIn> StockIns { get; set; }
        public virtual DbSet<Cart> Carts { get; set; }
        public virtual DbSet<Vat> Vats { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<CancelSale> CancelSales { get; set; }
        public virtual DbSet<Store> Stores { get; set; }
        public virtual DbSet<Vendor> Vendors { get; set; }
        public virtual DbSet<AdjustStock> AdjustStocks { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Category>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.Price)
                .HasPrecision(18, 0);
        }
    }
}
