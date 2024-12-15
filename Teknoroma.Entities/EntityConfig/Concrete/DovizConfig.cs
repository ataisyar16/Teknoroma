using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Teknoroma.Entities.Entities.Concrete;
using Teknoroma.Entities.EntityConfig.Abstract;

namespace Teknoroma.Entities.EntityConfig.Concrete
{
    public class DovizConfig : BaseConfig<Doviz>
    {
        public override void Configure(EntityTypeBuilder<Doviz> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.DovizKodu)
                .IsRequired()
                .HasMaxLength(10);

            builder.Property(x => x.DovizAdi)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(x => x.Kur)
                .HasColumnType("decimal(18,4)");

            builder.HasMany(x => x.KasaHareketleri)
                .WithOne(x => x.Doviz)
                .HasForeignKey(x => x.DovizId);
        }
    }
}
