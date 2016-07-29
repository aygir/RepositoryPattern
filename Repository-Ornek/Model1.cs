namespace Repository_Ornek
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<tablo1> tablo1 { get; set; }
        public virtual DbSet<tablo2> tablo2 { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tablo1>()
                .Property(e => e.var4)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tablo2>()
                .Property(e => e.var4)
                .HasPrecision(19, 4);
        }
    }
}
