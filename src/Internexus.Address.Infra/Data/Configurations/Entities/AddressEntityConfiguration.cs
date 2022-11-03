using Internexus.Address.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Internexus.Address.Infra.Data.Configurations.Entities
{
    public class AddressEntityConfiguration : IEntityTypeConfiguration<AddressEntity>
    {
        public void Configure(EntityTypeBuilder<AddressEntity> builder)
        {
            builder.Property<int>("Zipcode")
                   .IsRequired()
                   .HasColumnType("int(8)");

            builder.Property<string>("Street")
                   .HasColumnType("varchar(60)");

            builder.Property<string>("Number")
                   .HasColumnType("varchar(10)");

            builder.Property<string>("Complement")
                   .HasColumnType("varchar(24)");

            builder.Property<string>("Neighborhood")
                   .HasColumnType("varchar(30)");

            builder.HasIndex(c => c.Zipcode).IsUnique();
        }
    }
}
