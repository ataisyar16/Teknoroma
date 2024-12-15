using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Teknoroma.Entities.Entities.Concrete;
using Teknoroma.Entities.EntityConfig.Abstract;

namespace Teknoroma.Entities.EntityConfig.Concrete
{
    public class CariConfig : BaseConfig<Cari>
    {
        public override void Configure(EntityTypeBuilder<Cari> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.SubeNo)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(x => x.CariHesapNo)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(x => x.Sehir)
                .HasMaxLength(100);

            builder.Property(x => x.Ilce)
                .HasMaxLength(100);

            builder.Property(x => x.Adres)
                .HasMaxLength(250);

            builder.Property(x => x.Bakiye)
                .HasColumnType("decimal(18,2)");

            builder.HasMany(x => x.Faturalar)
                .WithOne(x => x.Cari)
                .HasForeignKey(x => x.CariId);
        }
    }
}
