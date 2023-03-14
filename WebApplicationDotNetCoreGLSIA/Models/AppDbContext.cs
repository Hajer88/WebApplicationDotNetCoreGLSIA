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

         protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categorie>().ToTable("Categs");
        }
    }
}
