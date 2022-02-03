using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace SokobanServer
{
    public class MyDbContext : DbContext
    {
        public DbSet<Level> Levels { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql("Port=25060;Host=app-fef0c111-3e52-4d9a-9020-97de5b1e737b-do-user-10768448-0.b.db.ondigitalocean.com;Database=db;Username=db;Password=9nw7Tnqn66pHiug0");
    }
}
