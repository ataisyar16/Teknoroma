using Microsoft.EntityFrameworkCore;
using Teknoroma.Entities.Entities.Concrete;

namespace Teknoroma.Entities.EntityConfig
{
    public class SubeConfig : BaseConfig<Sube>
    {
        public override void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Sube> builder)
        {
            base.Configure(builder);

            builder.ToTable("Subeler");

            builder.Property(sb => sb.SubeAdi)
                   .HasMaxLength(100)
                   .IsRequired(false);

            builder.Property(sb => sb.Sehir)
                   .HasMaxLength(50)
                   .IsRequired(false);

            builder.Property(sb => sb.Ilce)
                   .HasMaxLength(50)
                   .IsRequired(false);

            builder.Property(sb => sb.Address)
                   .HasMaxLength(250)
                   .IsRequired(false);

            builder.HasMany(sb => sb.Depolar)
                   .WithOne(d => d.Sube)
                   .HasForeignKey(d => d.SubeId)
                   .OnDelete(DeleteBehavior.NoAction);

            builder.HasMany(sb => sb.Personeller)
                   .WithOne(p => p.Sube)
                   .HasForeignKey(p => p.SubeId)
                   .OnDelete(DeleteBehavior.NoAction);

            builder.HasMany(sb => sb.Satislar)
                   .WithOne(s => s.Sube)
                   .HasForeignKey(s => s.SubeId)
                   .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
