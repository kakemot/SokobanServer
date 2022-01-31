using System.ComponentModel.DataAnnotations;

namespace SokobanServer
{
    public class Level
    {
        [Key]
        public int Id { get; set; }

        public string? LevelName { get; set; }

        public string? LevelContent { get; set; }
    }
}
