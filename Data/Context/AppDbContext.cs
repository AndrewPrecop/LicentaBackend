using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Component> Components { get; set; }
        public DbSet<ConfigurationPC> ConfigurationPCs { get; set; }
        public DbSet<ConfigurationComponent> ConfigurationComponents { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ConfigurationComponent>()
                .HasKey(cc => new { cc.ConfigurationPcId, cc.ComponentId });
            modelBuilder.Entity<ConfigurationComponent>()
                .HasOne(cc => cc.Component)
                .WithMany(c => c.Configurations)
                .HasForeignKey(cc => cc.ComponentId);
            modelBuilder.Entity<ConfigurationComponent>()
                .HasOne(cc => cc.ConfigurationPC)
                .WithMany(c => c.Components)
                .HasForeignKey(cc => cc.ConfigurationPcId);
        }
    }
}
