
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MOVIEInfoCURD.Models
{
    public class Movies
    {
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Year { get; set; }
        [Required]
        public string Plot { get; set; }
        [Required]
        public string Image { get; set; }
        [Required]
        public string Actors { get; set; }
        [Required]
        public string Producer { get; set; }
    }
}
