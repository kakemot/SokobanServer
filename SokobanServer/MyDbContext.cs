using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace SokobanServer
{
    public class MyDbContext : DbContext
    {
        public DbSet<Level> Levels { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=Database.db", options =>
            {
                options.MigrationsAssembly(Assembly.GetExecutingAssembly().FullName);
            });
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Map table names
            modelBuilder.Entity<Level>().ToTable("Levels", "test");
            modelBuilder.Entity<Level>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.HasIndex(e => e.LevelName).IsUnique();
            });
            base.OnModelCreating(modelBuilder);
        }
    }
}
