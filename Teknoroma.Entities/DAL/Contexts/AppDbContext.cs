using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Teknoroma.Entities.Entities.Concrete;
using Teknoroma.Entities.EntityConfig;

namespace Teknoroma.Entities.DAL.Contexts
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {
        // DbSets for Entities
        public DbSet<Birim> Birimler { get; set; }
        public DbSet<Cari> Cariler { get; set; }
        public DbSet<Departman> Departmanlar { get; set; }
        public DbSet<Depo> Depolar { get; set; }
        public DbSet<Doviz> Dovizler { get; set; }
        public DbSet<Fatura> Faturalar { get; set; }
        public DbSet<FaturaDetay> FaturaDetaylari { get; set; }
        public DbSet<Kasa> Kasalar { get; set; }
        public DbSet<KasaHareket> KasaHareketleri { get; set; }
        public DbSet<Kategori> Kategoriler { get; set; }
        public DbSet<KullaniciYorum> KullaniciYorumlari { get; set; }
        public DbSet<Kur> Kurlar { get; set; }
        public DbSet<Personel> Personeller { get; set; }
        public DbSet<Satis> Satislar { get; set; }
        public DbSet<SatisDetay> SatisDetaylari { get; set; }
        public DbSet<Siparis> Siparisler { get; set; }
        public DbSet<Stok> Stoklar { get; set; }
        public DbSet<StokBarkod> StokBarkodlari { get; set; }
        public DbSet<StokFotograf> StokFotograflari { get; set; }
        public DbSet<StokHareket> StokHareketleri { get; set; }
        public DbSet<Sube> Subeler { get; set; }
        public DbSet<Tedarikci> Tedarikciler { get; set; }

        public AppDbContext()
        {
        }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Apply configurations from the EntityConfig folder
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);

            // Manually configure AppUser
            modelBuilder.ApplyConfiguration(new AppUserConfig());
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(
                    @"Server=.;Database=Teknoroma;Trusted_Connection=true;TrustServerCertificate=true");
            }
        }
    }
}
