using Microsoft.EntityFrameworkCore;
using Teknoroma.Entities.Entities.Concrete;

namespace Teknoroma.Entities.EntityConfig
{
    public class KurConfig : BaseConfig<Kur>
    {
        public override void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Kur> builder)
        {
            base.Configure(builder);

            builder.ToTable("Kurlar");

            builder.Property(k => k.KurTarihi)
                   .HasColumnType("datetime2");

            builder.Property(k => k.AlisKuru)
                   .HasColumnType("decimal(18,4)")
                   .IsRequired(false);

            builder.Property(k => k.SatisKuru)
                   .HasColumnType("decimal(18,4)")
                   .IsRequired(false);

            builder.HasOne(k => k.Doviz)
                   .WithMany(d => d.Kurlar)
                   .HasForeignKey(k => k.DovizId)
                   .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
