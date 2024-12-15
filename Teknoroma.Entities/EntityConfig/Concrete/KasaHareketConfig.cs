using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Teknoroma.Entities.Entities.Concrete;
using Teknoroma.Entities.EntityConfig.Abstract;

namespace Teknoroma.Entities.EntityConfig.Concrete
{
    public class KasaHareketConfig : BaseConfig<KasaHareket>
    {
        public override void Configure(EntityTypeBuilder<KasaHareket> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.HareketTipi)
                .HasMaxLength(50);

            builder.Property(x => x.Giris)
                .HasColumnType("double");

            builder.Property(x => x.Cikis)
                .HasColumnType("double");

            builder.Property(x => x.Tutar)
                .HasColumnType("double");

            builder.HasOne(x => x.Kasa)
                .WithMany(x => x.KasaHareketleri)
                .HasForeignKey(x => x.KasaId)
                .OnDelete(DeleteBehavior.Cascade); // Restrict silme davranışı

            builder.HasOne(x => x.Doviz)
                .WithMany(x => x.KasaHareketleri)
                .HasForeignKey(x => x.DovizId)
                .OnDelete(DeleteBehavior.Cascade); // Restrict silme davranışı
        }
    }
}
