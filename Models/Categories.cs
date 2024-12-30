using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace worldcup.Models
{
    public class Categories
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; }

        public string Url { get; set; }
        public string Image { get; set; }
    }
}