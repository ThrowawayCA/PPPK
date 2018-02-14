using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak72.MOdels
{
    class UpisaniKolegiji
    {
        public int IDUpisaniKolegij { get; set; }
        public int StudentID { get; set; }
        public virtual Student Student { get; set; }
        public int KolegijID { get; set; }
        public virtual  Kolegij Kolegij { get; set; }
    }
}
