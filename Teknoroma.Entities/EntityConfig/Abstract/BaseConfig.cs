using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Teknoroma.Entities.Entities.Abstract;

namespace Teknoroma.Entities.EntityConfig
{
    public abstract class BaseConfig<TEntity> : IEntityTypeConfiguration<TEntity> where TEntity : BaseEntity
    {
        public virtual void Configure(EntityTypeBuilder<TEntity> builder)
        {
            // Primary Key
            builder.HasKey(e => e.Id);

            // Common Properties
            builder.Property(e => e.CreatedAt)
                   .HasColumnType("datetime2")
                   .IsRequired();

            builder.Property(e => e.UpdateAt)
                   .HasColumnType("datetime2")
                   .IsRequired();

            // Additional configuration to be overridden by derived classes
        }
    }
}
