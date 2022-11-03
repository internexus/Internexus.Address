using Internexus.Address.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Internexus.Address.Infra.Data.Configurations.Entities
{
    public class CityEntityConfiguration : IEntityTypeConfiguration<CityEntity>
    {
        public void Configure(EntityTypeBuilder<CityEntity> builder)
        {
            builder.Property<string>("Name")
                   .IsRequired()
                   .HasColumnType("varchar(40)");
        }
    }
}
