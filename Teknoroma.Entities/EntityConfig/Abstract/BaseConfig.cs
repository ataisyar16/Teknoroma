using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Teknoroma.Entities.Entities.Abstract;

namespace Teknoroma.Entities.EntityConfig.Abstract
{
    public abstract class BaseConfig<T> : IEntityTypeConfiguration<T> where T : BaseEntity
    {
        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            // Primary Key
            builder.HasKey(x => x.Id);

            // Common Properties
            builder.Property(x => x.CreatedAt)
                .IsRequired();

            builder.Property(x => x.UpdateAt)
                .IsRequired();

            // Index for Id
            builder.HasIndex(x => x.Id).IsUnique();
        }
    }
}
