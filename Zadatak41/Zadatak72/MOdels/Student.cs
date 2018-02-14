using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak72.MOdels
{
    class Student
    {
        public int IDStudent { get; set; }
        public string  Ime { get; set; }
        public string Prezime { get; set; }
        public virtual IList<UpisaniKolegiji> UpisaniKolegiji { get; set; }
    }
}
