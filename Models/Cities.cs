using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace worldcup.Models
{
    public class Cities
    {
        [Key]
        public int Id { get; set; }
        public required string Name { get; set; }

        [ForeignKey("ProvinceId")]
        public required Provinces Province { get; set; } // Navigation Property
    }
}