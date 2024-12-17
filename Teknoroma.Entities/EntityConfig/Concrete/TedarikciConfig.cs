using Microsoft.EntityFrameworkCore;
using Teknoroma.Entities.Entities.Concrete;

namespace Teknoroma.Entities.EntityConfig
{
    public class TedarikciConfig : BaseConfig<Tedarikci>
    {
        public override void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Tedarikci> builder)
        {
            base.Configure(builder);

            builder.ToTable("Tedarikciler");

            builder.Property(t => t.Ad)
                   .HasMaxLength(100)
                   .IsRequired(false);

            builder.Property(t => t.Telefon)
                   .HasMaxLength(15)
                   .IsRequired(false);

            builder.Property(t => t.Email)
                   .HasMaxLength(100)
                   .IsRequired(false);

            builder.Property(t => t.Adres)
                   .HasMaxLength(250)
                   .IsRequired(false);
        }
    }
}
