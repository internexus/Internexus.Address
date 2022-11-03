using Internexus.Address.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Internexus.Address.Infra.Data.Configurations.Entities
{
    public class StateEntityConfiguration : IEntityTypeConfiguration<StateEntity>
    {
        public void Configure(EntityTypeBuilder<StateEntity> builder)
        {
            builder.Property<string>("Name")
                   .IsRequired()
                   .HasColumnType("varchar(20)");

            builder.Property<string>("Acronym")
                   .IsRequired()
                   .HasColumnType("char(2)");

            builder.HasIndex(c => c.Name).IsUnique();
            builder.HasIndex(c => c.Acronym).IsUnique();
        }
    }
}
