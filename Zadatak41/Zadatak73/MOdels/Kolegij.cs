using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak73.MOdels
{
    [Table("Kolegiji")]
    class Kolegij
    {
        [Key]
        public int IDKolegij { get; set; }
        [Required]
        [MaxLength(120)]
        public string Naziv { get; set; }
        [MaxLength(10)]
        public string SkraceniNaziv { get; set; }
        
        public int ECTSBodovi { get; set; }
    }
}
