using System.ComponentModel.DataAnnotations;

namespace lab2.Models
{
    public class Gamelevel
    {
        [Key]
        public int LevelId { get; set; }
        public string title { get; set; }
        public string? description { get; set; }
    }
}
