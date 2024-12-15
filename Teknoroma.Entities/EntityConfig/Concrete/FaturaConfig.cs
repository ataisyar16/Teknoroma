using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Teknoroma.Entities.Entities.Concrete;
using Teknoroma.Entities.EntityConfig.Abstract;

namespace Teknoroma.Entities.EntityConfig.Concrete
{
    public class FaturaConfig : BaseConfig<Fatura>
    {
        public override void Configure(EntityTypeBuilder<Fatura> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.FaturaTarihi)
                .IsRequired();

            builder.Property(x => x.ToplamTutar)
                .HasColumnType("decimal(18,2)");

            builder.Property(x => x.KDV)
                .HasColumnType("decimal(18,2)");

            builder.HasOne(x => x.Cari)
                .WithMany(x => x.Faturalar)
                .HasForeignKey(x => x.CariId);
        }
    }
}
