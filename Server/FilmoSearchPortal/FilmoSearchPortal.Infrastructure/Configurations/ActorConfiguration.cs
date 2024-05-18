using FilmoSearchPortal.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilmoSearchPortal.Infrastructure.Configurations
{
    internal sealed class ActorConfiguration : IEntityTypeConfiguration<Actor>
    {
        public void Configure(EntityTypeBuilder<Actor> builder)
        {
            builder.ToTable(nameof(Actor));

            builder.HasKey(ac => ac.Id);
            builder.Property(ac => ac.Id).HasColumnName("ActorId").IsRequired();
            builder.HasIndex(ac => ac.Id).IsUnique();

            builder.Property(ac => ac.Name).IsRequired();
        }
    }
}
