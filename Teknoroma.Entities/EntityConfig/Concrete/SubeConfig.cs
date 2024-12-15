using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Teknoroma.Entities.Entities.Concrete;

namespace Teknoroma.Entities.EntityConfig.Concrete
{
    public class SubeConfig : IEntityTypeConfiguration<Sube>
    {
        public void Configure(EntityTypeBuilder<Sube> builder)
        {
            builder.Property(x => x.SubeAdi).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Sehir).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Ilce).HasMaxLength(50);
            builder.Property(x => x.Address).HasMaxLength(200);
        }
    }
}
