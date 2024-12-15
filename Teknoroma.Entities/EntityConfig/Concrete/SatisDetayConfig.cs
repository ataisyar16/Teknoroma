using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Teknoroma.Entities.Entities.Concrete;

namespace Teknoroma.Entities.EntityConfig.Concrete
{
    public class SatisDetayConfig : IEntityTypeConfiguration<SatisDetay>
    {
        public void Configure(EntityTypeBuilder<SatisDetay> builder)
        {
            builder.Property(x => x.Miktar).IsRequired();
            builder.Property(x => x.BirimFiyat).HasColumnType("decimal(18,2)");

            builder.HasOne(x => x.Satis)
                   .WithMany(x => x.SatisDetaylari)
                   .HasForeignKey(x => x.SatisId);

            builder.HasOne(x => x.Stok)
                   .WithMany(x => x.SatisDetaylari)
                   .HasForeignKey(x => x.StokId);
        }
    }
}
