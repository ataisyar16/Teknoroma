using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Teknoroma.Entities.Entities.Concrete;

namespace Teknoroma.Entities.EntityConfig.Concrete
{
    public class SatisConfig : IEntityTypeConfiguration<Satis>
    {
        public void Configure(EntityTypeBuilder<Satis> builder)
        {
            builder.Property(x => x.SatisTarihi).IsRequired();
            builder.Property(x => x.ToplamTutar).HasColumnType("decimal(18,2)");

            builder.HasOne(x => x.Cari)
                   .WithMany()
                   .HasForeignKey(x => x.CariId);

            builder.HasOne(x => x.Personel)
                   .WithMany(x => x.Satislar)
                   .HasForeignKey(x => x.PersonelId);

            builder.HasOne(x => x.Sube)
                   .WithMany(x => x.Satislar)
                   .HasForeignKey(x => x.SubeId);
        }
    }
}
