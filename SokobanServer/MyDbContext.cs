using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace SokobanServer
{
    public class MyDbContext : DbContext
    {
        public DbSet<Level> Levels { get; set; }

        public string DbPath { get; }

        public MyDbContext()
        {
            DbPath = System.IO.Path.Join("", "levels.db");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlite($"Data Source={DbPath}");
    }
}
