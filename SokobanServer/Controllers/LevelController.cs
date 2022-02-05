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
        public async Task<ActionResult<int>> PostNewLevel(Level level)
        {
            DbService db = new DbService();
            int id = await db.AddLevel(level);
            return id;
        }
    }
}