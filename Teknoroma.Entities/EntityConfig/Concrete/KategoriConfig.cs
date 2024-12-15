using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Teknoroma.Entities.Entities.Concrete;
using Teknoroma.Entities.EntityConfig.Abstract;

namespace Teknoroma.Entities.EntityConfig.Concrete
{
    public class KategoriConfig : BaseConfig<Kategori>
    {
        public override void Configure(EntityTypeBuilder<Kategori> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.KategoriAdi)
                .IsRequired()
                .HasMaxLength(100);

            builder.HasIndex(x => x.KategoriAdi)
                .IsUnique();
        }
    }
}
