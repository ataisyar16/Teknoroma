using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Teknoroma.Entities.Entities.Concrete;
using Teknoroma.Entities.EntityConfig.Abstract;

namespace Teknoroma.Entities.EntityConfig.Concrete
{
    public class KasaConfig : BaseConfig<Kasa>
    {
        public override void Configure(EntityTypeBuilder<Kasa> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.KasaKodu)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(x => x.SubeKodu)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(x => x.Bakiye)
                .HasColumnType("decimal(18,2)");

            builder.HasOne(x => x.Doviz)
                .WithMany(x => x.Kasalar)
                .HasForeignKey(x => x.DovizId);
        }
    }
}
