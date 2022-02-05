namespace SokobanServer
{
    public class DbService
    {
        public async Task<int> AddLevel(Level level)
        {
            await using var dbContext = new MyDbContext();
            dbContext.Database.EnsureCreated();
            var result = await dbContext.AddAsync(level);
            await dbContext.SaveChangesAsync();
            return result.Entity.Id;
        }

        public async Task<List<Level>> GetLevels()
        {
            await using var dbContext = new MyDbContext();
            dbContext.Database.EnsureCreated();
            List<Level> level = dbContext.Levels.ToList();
            return level;
        }

        public async Task<Level> GetLevel(int id)
        {
            await using var dbContext = new MyDbContext();
            dbContext.Database.EnsureCreated();
            Level level = dbContext.Levels.Where(x => x.Id == id).First();
            return level;
        }
    }
}
