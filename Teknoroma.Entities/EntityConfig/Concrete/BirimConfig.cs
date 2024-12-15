using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Teknoroma.Entities.Entities.Concrete;
using Teknoroma.Entities.EntityConfig.Abstract;

namespace Teknoroma.Entities.EntityConfig.Concrete
{
    public class BirimConfig : BaseConfig<Birim>
    {
        public override void Configure(EntityTypeBuilder<Birim> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.BirimKodu)
                .HasMaxLength(50);

            builder.Property(x => x.Aciklama)
                .HasMaxLength(250);

            builder.HasMany(x => x.Stoklar)
                .WithOne(x => x.Birim)
                .HasForeignKey(x => x.BirimId);
        }
    }
}
