using Microsoft.EntityFrameworkCore;
using Teknoroma.Entities.Entities.Concrete;

namespace Teknoroma.Entities.EntityConfig
{
    public class KullaniciYorumConfig : BaseConfig<KullaniciYorum>
    {
        public override void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<KullaniciYorum> builder)
        {
            base.Configure(builder);

            builder.ToTable("KullaniciYorumlari");

            builder.Property(ky => ky.YorumMetni)
                   .HasMaxLength(500)
                   .IsRequired(false);

            builder.Property(ky => ky.YorumTarihi)
                   .HasColumnType("datetime2");

            builder.HasOne(ky => ky.Kullanici)
                   .WithMany(a => a.Yorumlar)
                   .HasForeignKey(ky => ky.KullaniciId)
                   .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(ky => ky.Stok)
                   .WithMany(s => s.KullaniciYorumlari)
                   .HasForeignKey(ky => ky.StokId)
                   .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
