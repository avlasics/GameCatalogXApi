namespace GameCatalogXApi
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using GameCatalogXApi.Entities;

    public partial class CatalogXDbContext : DbContext
    {
        public CatalogXDbContext()
            : base("name=GameCatalogX")
        {
            Database.SetInitializer<CatalogXDbContext>(new GameCatalogXDBInitializer());
        }

        public virtual DbSet<CustomerReview> CustomerReviews { get; set; }
        public virtual DbSet<Game> Games { get; set; }
        public virtual DbSet<Image> Images { get; set; }
        public virtual DbSet<SystemRequirement> SystemRequirements { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Game>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Game>()
                .Property(e => e.About)
                .IsUnicode(false);

            modelBuilder.Entity<Game>()
                .Property(e => e.Developer)
                .IsUnicode(false);

            modelBuilder.Entity<Game>()
                .Property(e => e.Publisher)
                .IsUnicode(false);

        }
    }
}
