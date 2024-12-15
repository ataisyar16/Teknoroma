using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Teknoroma.Entities.Entities.Concrete;

namespace Teknoroma.Entities.EntityConfig.Concrete
{
    public class StokBarkodConfig : IEntityTypeConfiguration<StokBarkod>
    {
        public void Configure(EntityTypeBuilder<StokBarkod> builder)
        {
            builder.Property(x => x.Barkod).IsRequired().HasMaxLength(50);

            builder.HasOne(x => x.Stok)
                   .WithMany(x => x.StokBarkodlari)
                   .HasForeignKey(x => x.StokId);
        }
    }
}
