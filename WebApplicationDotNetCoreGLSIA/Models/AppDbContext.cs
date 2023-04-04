using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using Microsoft.EntityFrameworkCore;

namespace WebApplicationDotNetCoreGLSIA.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options )
            : base( options ) { }
        public DbSet<Categorie> Categories { get; set; }
        public DbSet<ssCategorie> SousCategories { get; set; }
        public DbSet<Produit> produits { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categorie>().ToTable("Categs");
            modelBuilder.Entity<Categorie>()
                .Property(e => e.Name)
                .HasColumnType("varchar(20)")
                .HasDefaultValue("A");
            modelBuilder.Entity<ssCategorie>()
                .Property(n => n.Name)
                .HasColumnName("SubCatName")
                .HasMaxLength(255);
            modelBuilder.Entity<Categorie>()
                .HasData(
                new Categorie
                {
                    Id = new Guid("ca72b856-c29b-4df4-89e3-14b6586d512a"),
                    Name = "test"
                }

            );
          //  modelBuilder.Entity<ProduitssCategorie>()
          //.HasKey(t => new { t.ProduitId, t.ssCategorieId });
          //  modelBuilder.Entity<ProduitssCategorie>()
          //     .HasOne(p => p.produit)
          //     .WithMany(s => s.produitsscateg)
          //     .HasForeignKey(t => t.ProduitId);
          //  modelBuilder.Entity<ProduitssCategorie>()
          //     .HasOne(p => p.sscateg)
          //     .WithMany(s => s.prodsscateg)
          //     .HasForeignKey(t => t.ssCategorieId);




            //Vérifier API Fluent pour relation many to many entre 
            //sscategorie et Produit

            //modelBuilder.Entity<ssCategorie>()
            //     .HasMany(p => p.produits)
            //     .WithMany(s => s.sscategs)
            //     .UsingEntity<ProduitssCategorie>(j =>
            //     j.HasOne(p => p.produit)
            //     .WithMany(t => t.produitsscateg)
            //     .HasForeignKey(t => t.ProduitId),
            //     j => j.
            //     HasOne(p => p.sscateg)
            //     .WithMany(t => t.prodsscateg)
            //     .HasForeignKey(p => p.ssCategorieId),
            //     j =>
            //     {
            //         j.Property(pt => pt.DateAjout);
            //         j.HasKey(t => new { t.ProduitId, t.ssCategorieId });
            //     });


        }
    }
}
