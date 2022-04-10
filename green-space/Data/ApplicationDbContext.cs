using green_space.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace green_space.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<Color> Colors { get; set; }
        public DbSet<Family> Families { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Maintenance> Maintenances { get; set; }
        public DbSet <Produce> Produces { get; set; }
        public DbSet<Soil> Soils { get; set; }
        public DbSet<Sun> Suns { get; set; }
        public DbSet<Models.Type> Types { get; set; }
        public DbSet<Water> Water { get; set; }
        public DbSet<Plant> Plants { get; set; }

        public DbSet<PlantColor> PlantColors { get; set; }
        public DbSet<PlantProduce> PlantProduces { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // plant - color
            builder.Entity<PlantColor>()
                .HasKey(pc => new { pc.PlantId, pc.ColorId });
            builder.Entity<PlantColor>()
                .HasOne(pc => pc.Plant)
                .WithMany(p => p.PlantColors)
                .HasForeignKey(pc => pc.PlantId);
            builder.Entity<PlantColor>()
                .HasOne(pc => pc.Color)
                .WithMany(c => c.PlantColors)
                .HasForeignKey(pc => pc.ColorId);

            // plant - produce
            builder.Entity<PlantProduce>()
                .HasKey(pp => new { pp.PlantId, pp.ProduceId });
            builder.Entity<PlantProduce>()
                .HasOne(pp => pp.Plant)
                .WithMany(p => p.PlantProduces)
                .HasForeignKey(pp => pp.PlantId);
            builder.Entity<PlantProduce>()
                .HasOne(pp => pp.Produce)
                .WithMany(p => p.PlantProduces)
                .HasForeignKey(pp => pp.ProduceId);
        }

    }
}