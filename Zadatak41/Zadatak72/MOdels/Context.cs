using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zadatak72.Configurations;

namespace Zadatak72.MOdels
{
    class Context :DbContext
    {

        public Context() :base("name=cs")
        {

        }

        public DbSet<Student> Studenti { get; set; }
        public DbSet<Kolegij> Kolegiji { get; set; }
        public DbSet<UpisaniKolegiji> UpisaniKolegiji { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new KolegijConfiguration());
            modelBuilder.Configurations.Add(new StudentConfiguration());
            modelBuilder.Configurations.Add(new UpisaniKolegijConfiguiration());
        }
    }
}
