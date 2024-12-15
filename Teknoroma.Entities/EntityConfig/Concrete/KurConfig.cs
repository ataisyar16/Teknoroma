using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Teknoroma.Entities.Entities.Concrete;

namespace Teknoroma.Entities.EntityConfig.Concrete
{
    public class KurConfig : IEntityTypeConfiguration<Kur>
    {
        public void Configure(EntityTypeBuilder<Kur> builder)
        {
            builder.Property(x => x.DovizId).IsRequired();
            builder.Property(x => x.KurTarihi).IsRequired();
            builder.Property(x => x.AlisKuru).HasColumnType("decimal(18,2)");
            builder.Property(x => x.SatisKuru).HasColumnType("decimal(18,2)");

            builder.HasOne(x => x.Doviz)
                   .WithMany()
                   .HasForeignKey(x => x.DovizId);
        }
    }
}
