using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Teknoroma.Entities.Entities.Concrete;

namespace Teknoroma.Entities.EntityConfig.Concrete
{
    public class StokConfig : IEntityTypeConfiguration<Stok>
    {
        public void Configure(EntityTypeBuilder<Stok> builder)
        {
            builder.Property(x => x.StokAdi).IsRequired().HasMaxLength(100);
            builder.Property(x => x.StokKodu).IsRequired().HasMaxLength(50);
            builder.Property(x => x.StokAdet).IsRequired();
            builder.Property(x => x.Fiyat).HasColumnType("decimal(18,2)");

            builder.HasOne(x => x.Depo)
                   .WithMany()
                   .HasForeignKey(x => x.DepoId);

            builder.HasOne(x => x.Birim)
                   .WithMany()
                   .HasForeignKey(x => x.BirimId);
        }
    }
}
