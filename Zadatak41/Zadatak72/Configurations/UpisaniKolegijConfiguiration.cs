using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zadatak72.MOdels;

namespace Zadatak72.Configurations
{
    class UpisaniKolegijConfiguiration: EntityTypeConfiguration<UpisaniKolegiji>
    {

        public UpisaniKolegijConfiguiration()
        {
            ToTable("UpisaniKolegiji");
            HasKey(uk => uk.IDUpisaniKolegij);
        }
    }
}
