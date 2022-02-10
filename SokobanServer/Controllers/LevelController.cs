using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;

namespace SokobanServer.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class LevelsController : ControllerBase
    {
        [HttpGet("{id}")]
        public async Task<Level> Get(int id)
        {
            DbService db = new DbService();
            Level level = await db.GetLevel(id);
            return level;
        }

        [HttpGet]
        public async Task<List<Level>> Get()
        {
            DbService db = new DbService();
            List<Level> level = await db.GetLevels();
            return level;
        }

        [HttpPost]
        public async Task<ActionResult<Level>> PostNewLevel(Level level)
        {
            DbService db = new DbService();
            int newId = await db.AddLevel(level);
            Level newLevel = level;
            newLevel.Id = newId;
            return newLevel;
        }

        [HttpPost]
        public async Task<ActionResult<Level>> SetLevelAsSolvable(int id)
        {
            DbService db = new DbService();
            Level level = await db.SetLevelAsSolvable(id);
            return level;
        }
    }
}