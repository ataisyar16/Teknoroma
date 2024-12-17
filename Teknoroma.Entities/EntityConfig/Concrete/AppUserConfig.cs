using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Teknoroma.Entities.Entities.Concrete;

namespace Teknoroma.Entities.EntityConfig
{
    public class AppUserConfig : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            // Identity tabloları varsayılan olarak AspNetUsers olarak adlandırılır
            builder.ToTable("AspNetUsers");

            // AppUser'da ek alanlar için yapılandırmalar
            builder.Property(a => a.FirstName)
                   .HasMaxLength(50)
                   .IsRequired();

            builder.Property(a => a.LastName)
                   .HasMaxLength(50)
                   .IsRequired();

            builder.Property(a => a.PersonelId)
                   .IsRequired(false);

            // AppUser ile Personel ilişkisi (Bire Bir)
            builder.HasOne(a => a.Personel)
                   .WithOne() // Personel’in bire bir ilişkisi
                   .HasForeignKey<AppUser>(a => a.PersonelId)
                   .OnDelete(DeleteBehavior.SetNull);
        }
    }
}
