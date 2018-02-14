using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak73.MOdels
{
    class Context : DbContext
    {
        public Context() :base("name=cs")
        {

        }

        public DbSet<Kolegij> Kolegiji { get; set; }
        public DbSet<Student> Studenti { get; set; }
        public DbSet<UpisaniKolegiji> UpisaniKolegiji { get; set; }
    }
}
