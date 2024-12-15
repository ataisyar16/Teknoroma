using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Teknoroma.Entities.Entities.Concrete;
using Teknoroma.Entities.EntityConfig.Abstract;

namespace Teknoroma.Entities.EntityConfig.Concrete
{
    public class DepoConfig : BaseConfig<Depo>
    {
        public override void Configure(EntityTypeBuilder<Depo> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.DepoAdi)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(x => x.Adres)
                .HasMaxLength(250);

            builder.HasOne(x => x.Sube)
                .WithMany(x => x.Depolar)
                .HasForeignKey(x => x.SubeId);

            builder.HasMany(x => x.Stoklar)
                .WithOne(x => x.Depo)
                .HasForeignKey(x => x.DepoId);
        }
    }
}
