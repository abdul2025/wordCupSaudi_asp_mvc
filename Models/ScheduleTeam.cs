using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace worldcup.Models
{
    public class ScheduleTeam
        {   
            [Key]
            public int Id { get; set; }
            public int ScheduleId { get; set; }
            public required Schedule Schedule { get; set; }

            public int StadiumId { get; set; }
            public required Stadiums Stadium { get; set; }
        }
}