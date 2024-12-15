using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Teknoroma.Entities.Entities.Concrete;
using Teknoroma.Entities.EntityConfig.Abstract;

namespace Teknoroma.Entities.EntityConfig.Concrete
{
    public class StokHareketConfig : BaseConfig<StokHareket>
    {
        public override void Configure(EntityTypeBuilder<StokHareket> builder)
        {
            base.Configure(builder);



            builder.HasOne(x => x.Stok)
                .WithMany(x => x.StokHareketleri)
                .HasForeignKey(x => x.StokId);

            builder.HasOne(x => x.Depo)
                .WithMany(x => x.StokHareketleri)
                .HasForeignKey(x => x.DepoId)
                .OnDelete(DeleteBehavior.Cascade);


        }
    }
}
