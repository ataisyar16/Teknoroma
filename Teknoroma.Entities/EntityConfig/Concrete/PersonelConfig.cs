using Microsoft.EntityFrameworkCore;
using Teknoroma.Entities.Entities.Concrete;

namespace Teknoroma.Entities.EntityConfig
{
    public class PersonelConfig : BaseConfig<Personel>
    {
        public override void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Personel> builder)
        {
            base.Configure(builder);

            builder.ToTable("Personeller");

            builder.Property(p => p.Ad)
                   .HasMaxLength(50)
                   .IsRequired(false);

            builder.Property(p => p.Soyad)
                   .HasMaxLength(50)
                   .IsRequired(false);

            builder.Property(p => p.TcNo)
                   .HasMaxLength(11)
                   .IsRequired(false);

            builder.Property(p => p.Gorev)
                   .HasMaxLength(50)
                   .IsRequired(false);

            builder.Property(p => p.Cinsiyet)
                   .IsRequired(false);

            builder.HasOne(p => p.Sube)
                   .WithMany(s => s.Personeller)
                   .HasForeignKey(p => p.SubeId)
                   .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(p => p.Departman)
                   .WithMany(d => d.Personeller)
                   .HasForeignKey(p => p.DepartmanId)
                   .OnDelete(DeleteBehavior.NoAction);

            builder.HasMany(p => p.Satislar)
                   .WithOne(s => s.Personel)
                   .HasForeignKey(s => s.PersonelId)
                   .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
