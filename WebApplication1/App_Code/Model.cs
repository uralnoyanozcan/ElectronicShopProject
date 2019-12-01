namespace WebApplication1.App_Code
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model : DbContext
    {
        public Model()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Cart> Cart { get; set; }
        public virtual DbSet<Products> Product { get; set; }
        public virtual DbSet<ProductType> ProductType { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Products>()
                .Property(e => e.Price)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Products>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<ProductType>()
                .HasMany(e => e.Product)
                .WithRequired(e => e.ProductType)
                .HasForeignKey(e => e.TypeID);
        }
    }
}
