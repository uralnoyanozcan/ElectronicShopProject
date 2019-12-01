namespace WebApplication1.App_Code
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class UserModel1 : DbContext
    {
        public UserModel1()
            : base("name=UserModel1")
        {
        }

        public virtual DbSet<UserTable> UserTable { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserTable>()
                .Property(e => e.password)
                .IsFixedLength();
        }
    }
}
