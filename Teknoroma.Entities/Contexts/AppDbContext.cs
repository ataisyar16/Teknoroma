using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using Teknoroma.Entities.Entities.Concrete;

namespace Teknoroma.Entities.Contexts
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {
        public DbSet<Birim> Birimler { get; set; }
        public DbSet<Cari> Cariler { get; set; }
        public DbSet<Departman> Departmanlar { get; set; }
        public DbSet<Depo> Depolar { get; set; }
        public DbSet<Doviz> Dovizler { get; set; }
        public DbSet<Fatura> Faturalar { get; set; }

        public DbSet<FaturaDetay> FaturaDetaylar { get; set; }
        public DbSet<Kasa> Kasalar { get; set; }

        public DbSet<KasaHareket> KasaHareketler { get; set; }
        public DbSet<Kategori> Kategoriler { get; set; }

        public DbSet<KullaniciYorum> KullaniciYorumlari { get; set; }
        public DbSet<Kur> Kurlar { get; set; }

        public DbSet<Personel> Personeller { get; set; }
        public DbSet<Satis> Satislar { get; set; }

        public DbSet<SatisDetay> SatisDetaylari { get; set; }
        public DbSet<Siparis> Siparisler { get; set; }

        public DbSet<Stok> Stoklar { get; set; }
        public DbSet<StokBarkod> StokBarkodlar { get; set; }

        public DbSet<StokFotograf> StokFotograflar { get; set; }
        public DbSet<StokHareket> StokHareketler { get; set; }

        public DbSet<Sube> Subeler { get; set; }
        public DbSet<Tedarikci> Tedarikciler { get; set; }

        public AppDbContext()
        {

        }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.;Database=Teknoroma;Trusted_Connection=true;TrustServerCertificate=true");
        }

    }
}



