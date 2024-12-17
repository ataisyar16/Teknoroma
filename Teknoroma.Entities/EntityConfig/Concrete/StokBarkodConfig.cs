using Microsoft.EntityFrameworkCore;
using Teknoroma.Entities.Entities.Concrete;

namespace Teknoroma.Entities.EntityConfig
{
    public class StokBarkodConfig : BaseConfig<StokBarkod>
    {
        public override void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<StokBarkod> builder)
        {
            base.Configure(builder);

            builder.ToTable("StokBarkodlari");

            builder.Property(sb => sb.Barkod)
                   .HasMaxLength(50)
                   .IsRequired(false);

            builder.HasOne(sb => sb.Stok)
                   .WithMany(s => s.StokBarkodlari)
                   .HasForeignKey(sb => sb.StokId)
                   .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
