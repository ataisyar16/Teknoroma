using Microsoft.EntityFrameworkCore;
using Teknoroma.Entities.Entities.Concrete;

namespace Teknoroma.Entities.EntityConfig
{
    public class SiparisConfig : BaseConfig<Siparis>
    {
        public override void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Siparis> builder)
        {
            base.Configure(builder);

            builder.ToTable("Siparisler");

            builder.Property(s => s.SiparisTarihi)
                   .HasColumnType("datetime2")
                   .IsRequired(false);

            builder.Property(s => s.Durum)
                   .HasMaxLength(50)
                   .IsRequired(false);

            builder.HasOne(s => s.Cari)
                   .WithMany(c => c.Siparisler)
                   .HasForeignKey(s => s.CariId)
                   .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
