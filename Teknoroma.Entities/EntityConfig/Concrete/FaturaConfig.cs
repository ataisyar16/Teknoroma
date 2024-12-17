using Microsoft.EntityFrameworkCore;
using Teknoroma.Entities.Entities.Concrete;

namespace Teknoroma.Entities.EntityConfig
{
    public class FaturaConfig : BaseConfig<Fatura>
    {
        public override void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Fatura> builder)
        {
            base.Configure(builder);

            builder.ToTable("Faturalar");

            builder.Property(f => f.FaturaTarihi)
                   .HasColumnType("datetime2")
                   .IsRequired();

            builder.Property(f => f.ToplamTutar)
                   .HasColumnType("decimal(18,2)");

            builder.Property(f => f.KDV)
                   .HasColumnType("decimal(18,2)");

            builder.HasOne(f => f.Cari)
                   .WithMany(c => c.Faturalar)
                   .HasForeignKey(f => f.CariId)
                   .OnDelete(DeleteBehavior.NoAction);

            builder.HasMany(f => f.FaturaDetaylari)
                   .WithOne(fd => fd.Fatura)
                   .HasForeignKey(fd => fd.FaturaId)
                   .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
