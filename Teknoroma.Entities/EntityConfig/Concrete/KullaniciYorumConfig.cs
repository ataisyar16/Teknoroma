using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Teknoroma.Entities.Entities.Concrete;
using Teknoroma.Entities.EntityConfig.Abstract;

namespace Teknoroma.Entities.EntityConfig.Concrete
{
    public class KullaniciYorumConfig : BaseConfig<KullaniciYorum>
    {
        public override void Configure(EntityTypeBuilder<KullaniciYorum> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.YorumMetni)
                .IsRequired()
                .HasMaxLength(500);

            builder.Property(x => x.YorumTarihi)
                .IsRequired();

            builder.HasOne(x => x.Kullanici)
                .WithMany(x => x.Yorumlar)
                .HasForeignKey(x => x.KullaniciId);

            builder.HasOne(x => x.Stok)
                .WithMany(x => x.KullaniciYorumlari)
                .HasForeignKey(x => x.StokId);
        }
    }
}
