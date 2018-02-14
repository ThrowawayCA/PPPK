using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak73.MOdels
{
    [Table("Studenti")]
    class Student
    {
        [Key]
        public int IDStudent { get; set; }
        [Required]
        [MaxLength(30)]
        public string Ime { get; set; }
        [Required]
        [MaxLength(50)]
        public string Prezime { get; set; }

        public virtual IList<UpisaniKolegiji> UpisaniKolegiji { get; set; }

    }
}
