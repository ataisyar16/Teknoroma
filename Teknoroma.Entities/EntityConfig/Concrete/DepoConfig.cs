using Microsoft.EntityFrameworkCore;
using Teknoroma.Entities.Entities.Concrete;

namespace Teknoroma.Entities.EntityConfig
{
    public class DepoConfig : BaseConfig<Depo>
    {
        public override void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Depo> builder)
        {
            base.Configure(builder);

            builder.ToTable("Depolar");

            builder.Property(d => d.DepoAdi)
                   .HasMaxLength(100)
                   .IsRequired();

            builder.Property(d => d.Adres)
                   .HasMaxLength(200);

            builder.HasOne(d => d.Sube)
                   .WithMany(s => s.Depolar)
                   .HasForeignKey(d => d.SubeId)
                   .OnDelete(DeleteBehavior.NoAction);

            builder.HasMany(d => d.Stoklar)
                   .WithOne(s => s.Depo)
                   .HasForeignKey(s => s.DepoId)
                   .OnDelete(DeleteBehavior.NoAction);

            builder.HasMany(d => d.StokHareketleri)
                   .WithOne(sh => sh.Depo)
                   .HasForeignKey(sh => sh.DepoId)
                   .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
