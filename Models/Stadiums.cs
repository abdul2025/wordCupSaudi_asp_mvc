
namespace worldcup.Models
{
    public class Stadiums
    {
        
        public int Id { get; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }
        public string City { get; set; }
        public string Type { get; set; }
        public DateTime ConstractionDate { get; set; }
        public string Owner {get;set;}
        public double Length { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        public string Images { get; set; }
        public List<string> Facility { get; set; } = new List<string>();

        
    }
}