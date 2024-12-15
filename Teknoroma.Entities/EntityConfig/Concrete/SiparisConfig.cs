using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Teknoroma.Entities.Entities.Concrete;

namespace Teknoroma.Entities.EntityConfig.Concrete
{
    public class SiparisConfig : IEntityTypeConfiguration<Siparis>
    {
        public void Configure(EntityTypeBuilder<Siparis> builder)
        {
            builder.Property(x => x.SiparisTarihi).IsRequired();
            builder.Property(x => x.Durum).HasMaxLength(50);

            builder.HasOne(x => x.Cari)
                   .WithMany()
                   .HasForeignKey(x => x.CariId);
        }
    }
}
