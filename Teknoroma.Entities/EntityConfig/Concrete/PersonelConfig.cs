using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Teknoroma.Entities.Entities.Concrete;

namespace Teknoroma.Entities.EntityConfig.Concrete
{
    public class PersonelConfig : IEntityTypeConfiguration<Personel>
    {
        public void Configure(EntityTypeBuilder<Personel> builder)
        {
            builder.Property(x => x.Ad).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Soyad).IsRequired().HasMaxLength(100);
            builder.Property(x => x.TcNo).IsRequired().HasMaxLength(11);
            builder.Property(x => x.Gorev).HasMaxLength(100);

            builder.HasOne(x => x.Sube)
                   .WithMany(x => x.Personeller)
                   .HasForeignKey(x => x.SubeId);

            builder.HasOne(x => x.Departman)
                   .WithMany()
                   .HasForeignKey(x => x.DepartmanId);
        }
    }
}
