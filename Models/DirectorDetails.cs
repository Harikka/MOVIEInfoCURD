using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MOVIEInfoCURD.Models
{
    public class DirectorDetails
    {
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string DOB { get; set; }
        [Required]
        public string Biodata { get; set; }
    }
}
