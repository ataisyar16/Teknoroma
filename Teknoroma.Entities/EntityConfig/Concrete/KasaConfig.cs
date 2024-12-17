using Microsoft.EntityFrameworkCore;
using Teknoroma.Entities.Entities.Concrete;

namespace Teknoroma.Entities.EntityConfig
{
    public class KasaConfig : BaseConfig<Kasa>
    {
        public override void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Kasa> builder)
        {
            base.Configure(builder);

            builder.ToTable("Kasalar");

            builder.Property(k => k.KasaKodu)
                   .HasMaxLength(10)
                   .IsRequired(false);

            builder.Property(k => k.SubeKodu)
                   .HasMaxLength(10)
                   .IsRequired(false);

            builder.Property(k => k.Bakiye)
                   .HasColumnType("decimal(18,2)");

            builder.HasOne(k => k.Doviz)
                   .WithMany(d => d.Kasalar)
                   .HasForeignKey(k => k.DovizId)
                   .OnDelete(DeleteBehavior.NoAction);

            builder.HasMany(k => k.KasaHareketleri)
                   .WithOne(kh => kh.Kasa)
                   .HasForeignKey(kh => kh.KasaId)
                   .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
