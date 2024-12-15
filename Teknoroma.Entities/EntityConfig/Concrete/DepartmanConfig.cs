using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Teknoroma.Entities.Entities.Concrete;
using Teknoroma.Entities.EntityConfig.Abstract;

namespace Teknoroma.Entities.EntityConfig.Concrete
{
    public class DepartmanConfig : BaseConfig<Departman>
    {
        public override void Configure(EntityTypeBuilder<Departman> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.DepartmanAdi)
                .IsRequired()
                .HasMaxLength(100);

            builder.HasOne(x => x.UstDepartman)
                .WithMany()
                .HasForeignKey(x => x.UstId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(x => x.Personeller)
                .WithOne(x => x.Departman)
                .HasForeignKey(x => x.DepartmanId);
        }
    }
}
