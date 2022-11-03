using Internexus.Address.Domain.Entities;
using Internexus.Address.Infra.Data.Seeders;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Internexus.Address.Infra.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<StateEntity> States { get; set; }
        public DbSet<CityEntity> Cities { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            modelBuilder.Entity<StateEntity>().HasData(StatesTableSeeder.Run());
            modelBuilder.Entity<CityEntity>().HasData(CitiesTableSeeder.Run());
        }
    }
}
