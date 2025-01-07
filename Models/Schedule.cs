
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace worldcup.Models
{
    public class Schedule
    {
        [Key]
        public int Id { get; set; }

        public required DateTime MatchDateTime { get; set; }


        [ForeignKey("StadiumId")]
        public required Stadiums Stadium { get; set; } // Navigation Property


        public required ICollection<Teams> Teams { get; set; } // Navigation Property

    }


    
}


