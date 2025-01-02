using System.ComponentModel.DataAnnotations;

namespace worldcup.Models
{
    public class Teams
    {
        [Key]
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Country { get; set; }
        public required DateTime founded { get; set; }

        public required ICollection<Schedule> Schedule { get; set; } // Navigation Property
    }
}