using Microsoft.EntityFrameworkCore;
using Teknoroma.Entities.Entities.Concrete;

namespace Teknoroma.Entities.EntityConfig
{
    public class FaturaDetayConfig : BaseConfig<FaturaDetay>
    {
        public override void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<FaturaDetay> builder)
        {
            base.Configure(builder);

            builder.ToTable("FaturaDetaylari");

            builder.Property(fd => fd.Miktar)
                   .IsRequired(false);

            builder.Property(fd => fd.Fiyat)
                   .HasColumnType("decimal(18,2)")
                   .IsRequired(false);

            builder.HasOne(fd => fd.Fatura)
                   .WithMany(f => f.FaturaDetaylari)
                   .HasForeignKey(fd => fd.FaturaId)
                   .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(fd => fd.Stok)
                   .WithMany(s => s.FaturaDetaylari)
                   .HasForeignKey(fd => fd.StokId)
                   .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
