using Microsoft.EntityFrameworkCore;
using Teknoroma.Entities.Entities.Concrete;

namespace Teknoroma.Entities.EntityConfig
{
    public class StokConfig : BaseConfig<Stok>
    {
        public override void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Stok> builder)
        {
            base.Configure(builder);

            builder.ToTable("Stoklar");

            builder.Property(s => s.StokAdi)
                   .HasMaxLength(100)
                   .IsRequired(false);

            builder.Property(s => s.StokKodu)
                   .HasMaxLength(50)
                   .IsRequired(false);

            builder.Property(s => s.Fiyat)
                   .HasColumnType("decimal(18,2)")
                   .IsRequired(false);

            builder.HasOne(s => s.Depo)
                   .WithMany(d => d.Stoklar)
                   .HasForeignKey(s => s.DepoId)
                   .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(s => s.Birim)
                   .WithMany(b => b.Stoklar)
                   .HasForeignKey(s => s.BirimId)
                   .OnDelete(DeleteBehavior.NoAction);

            builder.HasMany(s => s.SatisDetaylari)
                   .WithOne(sd => sd.Stok)
                   .HasForeignKey(sd => sd.StokId)
                   .OnDelete(DeleteBehavior.NoAction);

            builder.HasMany(s => s.FaturaDetaylari)
                   .WithOne(fd => fd.Stok)
                   .HasForeignKey(fd => fd.StokId)
                   .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
