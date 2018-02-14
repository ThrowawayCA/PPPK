using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak73.MOdels
{
    [Table("UpisaniKolegiji")]
    class UpisaniKolegiji
    {
        [Key]
        public int IDUpisaniKolegiji { get; set; }
        [ForeignKey("Student")]
        public int StudentID { get; set; }
        public virtual Student Student { get; set; }
        [ForeignKey("Kolegij")]
        public int KolegijID { get; set; }
        public virtual Kolegij Kolegij { get; set; }

    }
}
