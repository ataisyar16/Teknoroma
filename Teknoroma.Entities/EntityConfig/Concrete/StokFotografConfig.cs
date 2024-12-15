using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Teknoroma.Entities.Entities.Concrete;

namespace Teknoroma.Entities.EntityConfig.Concrete
{
    public class StokFotografConfig : IEntityTypeConfiguration<StokFotograf>
    {
        public void Configure(EntityTypeBuilder<StokFotograf> builder)
        {
            builder.Property(x => x.FotografYolu).IsRequired();

            builder.HasOne(x => x.Stok)
                   .WithMany(x => x.StokFotograflari)
                   .HasForeignKey(x => x.StokId);
        }
    }
}
