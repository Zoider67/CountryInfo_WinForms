namespace CountryInfo_WinForms
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class CountriesDBContext : DbContext
    {
        public CountriesDBContext()
            : base("name=CountryDBConnection")
        {
        }

        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Region> Regions { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<City>()
                .Property(e => e.Name)
                .IsFixedLength();

            modelBuilder.Entity<City>()
                .HasMany(e => e.Countries)
                .WithRequired(e => e.CapitalNavigation)
                .HasForeignKey(e => e.Capital)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Country>()
                .Property(e => e.Name)
                .IsFixedLength();

            modelBuilder.Entity<Region>()
                .Property(e => e.Name)
                .IsFixedLength();

            modelBuilder.Entity<Region>()
                .HasMany(e => e.Countries)
                .WithRequired(e => e.RegionNavigation)
                .HasForeignKey(e => e.Region)
                .WillCascadeOnDelete(false);
        }
    }
}
