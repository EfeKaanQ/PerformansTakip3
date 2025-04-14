
using Microsoft.EntityFrameworkCore;
using PerformansTakip.Models;

namespace PerformansTakip.Data
{
    public class ApplicationDbContext : DbContext
    {
        
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
    public DbSet<Sinif> Siniflar { get; set; }
        public DbSet<Ogrenci> Ogrenciler { get; set; }

           public DbSet<Ogretmen> Ogretmenler { get; set; }
         protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Sinif ve Ogretmen arasındaki ilişkiyi tanımla
        modelBuilder.Entity<Sinif>()
            .HasOne(s => s.Ogretmen)
            .WithMany(o => o.Siniflar)
            .HasForeignKey(s => s.OgretmenId);  // Sinif'ta OgretmenId'yi kullanıyoruz
    }

       
           
    }
}
