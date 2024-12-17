using Microsoft.EntityFrameworkCore;
using Teknoroma.Entities.Entities.Concrete;

namespace Teknoroma.Entities.EntityConfig
{
    public class CariConfig : BaseConfig<Cari>
    {
        public override void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Cari> builder)
        {
            base.Configure(builder);

            builder.ToTable("Cariler");

            builder.Property(c => c.SubeNo)
                   .HasMaxLength(10)
                   .IsRequired();

            builder.Property(c => c.CariHesapNo)
                   .HasMaxLength(20)
                   .IsRequired();

            builder.Property(c => c.Sehir)
                   .HasMaxLength(50);

            builder.Property(c => c.Ilce)
                   .HasMaxLength(50);

            builder.Property(c => c.Adres)
                   .HasMaxLength(200);

            builder.Property(c => c.Bakiye)
                   .HasColumnType("decimal(18,2)");

            builder.HasMany(c => c.Faturalar)
                   .WithOne(f => f.Cari)
                   .HasForeignKey(f => f.CariId)
                   .OnDelete(DeleteBehavior.NoAction);

            builder.HasMany(c => c.Siparisler)
                   .WithOne(s => s.Cari)
                   .HasForeignKey(s => s.CariId)
                   .OnDelete(DeleteBehavior.NoAction);

            builder.HasMany(c => c.Satislar)
                   .WithOne(s => s.Cari)
                   .HasForeignKey(s => s.CariId)
                   .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
