using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Teknoroma.Entities.Entities.Concrete;

namespace Teknoroma.Entities.EntityConfig.Concrete
{
    public class TedarikciConfig : IEntityTypeConfiguration<Tedarikci>
    {
        public void Configure(EntityTypeBuilder<Tedarikci> builder)
        {
            builder.Property(x => x.Ad).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Telefon).HasMaxLength(15);
            builder.Property(x => x.Email).HasMaxLength(100);
            builder.Property(x => x.Adres).HasMaxLength(200);
        }
    }
}
