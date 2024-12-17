using Microsoft.EntityFrameworkCore;
using Teknoroma.Entities.Entities.Concrete;

namespace Teknoroma.Entities.EntityConfig
{
    public class DovizConfig : BaseConfig<Doviz>
    {
        public override void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Doviz> builder)
        {
            base.Configure(builder);

            builder.ToTable("Dovizler");

            builder.Property(d => d.DovizKodu)
                   .HasMaxLength(10)
                   .IsRequired();

            builder.Property(d => d.DovizAdi)
                   .HasMaxLength(50)
                   .IsRequired();

            builder.Property(d => d.Kur)
                   .HasColumnType("decimal(18,4)")
                   .IsRequired();

            builder.HasMany(d => d.KasaHareketleri)
                   .WithOne(kh => kh.Doviz)
                   .HasForeignKey(kh => kh.DovizId)
                   .OnDelete(DeleteBehavior.NoAction);

            builder.HasMany(d => d.Kasalar)
                   .WithOne(k => k.Doviz)
                   .HasForeignKey(k => k.DovizId)
                   .OnDelete(DeleteBehavior.NoAction);

            builder.HasMany(d => d.Kurlar)
                   .WithOne(k => k.Doviz)
                   .HasForeignKey(k => k.DovizId)
                   .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
