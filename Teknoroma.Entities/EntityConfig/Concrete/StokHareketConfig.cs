using Microsoft.EntityFrameworkCore;
using Teknoroma.Entities.Entities.Concrete;

namespace Teknoroma.Entities.EntityConfig
{
    public class StokHareketConfig : BaseConfig<StokHareket>
    {
        public override void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<StokHareket> builder)
        {
            base.Configure(builder);

            builder.ToTable("StokHareketleri");

            builder.Property(sh => sh.Adet)
                   .IsRequired();

            builder.Property(sh => sh.Tarih)
                   .HasColumnType("datetime2")
                   .IsRequired();

            builder.HasOne(sh => sh.Stok)
                   .WithMany(s => s.StokHareketleri)
                   .HasForeignKey(sh => sh.StokId)
                   .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(sh => sh.Depo)
                   .WithMany(d => d.StokHareketleri)
                   .HasForeignKey(sh => sh.DepoId)
                   .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
