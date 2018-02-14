using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zadatak72.MOdels;

namespace Zadatak72.Configurations
{
    class KolegijConfiguration : EntityTypeConfiguration<Kolegij>
    {
        public KolegijConfiguration()
        {
            ToTable("Kolegiji");

            HasKey(k => k.IDkolegij);
            Property(k => k.Naziv).IsRequired().HasMaxLength(120);
            Property(k => k.SkraceniNaziv).IsOptional().HasMaxLength(10);
            Property(k => k.ECTSbodova).HasColumnType("int");
    }

    }
}
