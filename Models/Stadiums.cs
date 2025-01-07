
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace worldcup.Models
{
    public class Stadiums
    {
        [Key]
        public int Id { get; set; }
        public required string Name { get; set; }
        public int Capacity { get; set; }
        
        [ForeignKey("CityId")]
        public required Cities City { get; set; } // Navigation Property
        public required string Type { get; set; }
        public DateTime ContractionDate { get; set; }
        public required string Owner {get;set;}
        public double Length { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        public required string Images { get; set; }
        public List<string> Facility { get; set; } = new List<string>();

        
    }
}