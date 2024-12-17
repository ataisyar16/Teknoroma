using Microsoft.EntityFrameworkCore;
using Teknoroma.Entities.Entities.Concrete;

namespace Teknoroma.Entities.EntityConfig
{
    public class BirimConfig : BaseConfig<Birim>
    {
        public override void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Birim> builder)
        {
            base.Configure(builder);

            builder.ToTable("Birimler");

            builder.Property(b => b.BirimKodu)
                   .HasMaxLength(10)
                   .IsRequired();

            builder.Property(b => b.Aciklama)
                   .HasMaxLength(100);

            builder.HasMany(b => b.Stoklar)
                   .WithOne(s => s.Birim)
                   .HasForeignKey(s => s.BirimId)
                   .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
