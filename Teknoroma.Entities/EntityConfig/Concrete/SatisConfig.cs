using Microsoft.EntityFrameworkCore;
using Teknoroma.Entities.Entities.Concrete;

namespace Teknoroma.Entities.EntityConfig
{
    public class SatisConfig : BaseConfig<Satis>
    {
        public override void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Satis> builder)
        {
            base.Configure(builder);

            builder.ToTable("Satislar");

            builder.Property(s => s.SatisTarihi)
                   .HasColumnType("datetime2");

            builder.Property(s => s.ToplamTutar)
                   .HasColumnType("decimal(18,2)")
                   .IsRequired();

            builder.HasOne(s => s.Cari)
                   .WithMany(c => c.Satislar)
                   .HasForeignKey(s => s.CariId)
                   .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(s => s.Personel)
                   .WithMany(p => p.Satislar)
                   .HasForeignKey(s => s.PersonelId)
                   .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(s => s.Sube)
                   .WithMany(sb => sb.Satislar)
                   .HasForeignKey(s => s.SubeId)
                   .OnDelete(DeleteBehavior.NoAction);

            builder.HasMany(s => s.SatisDetaylari)
                   .WithOne(sd => sd.Satis)
                   .HasForeignKey(sd => sd.SatisId)
                   .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
