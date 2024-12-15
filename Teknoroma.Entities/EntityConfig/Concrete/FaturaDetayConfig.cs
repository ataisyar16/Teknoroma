using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Teknoroma.Entities.Entities.Concrete;
using Teknoroma.Entities.EntityConfig.Abstract;

namespace Teknoroma.Entities.EntityConfig.Concrete
{
    public class FaturaDetayConfig : BaseConfig<FaturaDetay>
    {
        public override void Configure(EntityTypeBuilder<FaturaDetay> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Miktar)
                .IsRequired();

            builder.Property(x => x.Fiyat)
                .HasColumnType("decimal(18,2)");

            builder.HasOne(x => x.Fatura)
                .WithMany(x => x.FaturaDetaylari)
                .HasForeignKey(x => x.FaturaId);

            builder.HasOne(x => x.Stok)
                .WithMany(x => x.FaturaDetaylari)
                .HasForeignKey(x => x.StokId);
        }
    }
}
