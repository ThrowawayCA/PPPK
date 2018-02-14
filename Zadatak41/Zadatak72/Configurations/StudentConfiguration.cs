using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zadatak72.MOdels;

namespace Zadatak72.Configurations
{
    class StudentConfiguration : EntityTypeConfiguration<Student>
    {
        public StudentConfiguration()
        {
            ToTable("Studenti");
            HasKey(s => s.IDStudent);
            Property(s => s.Ime).IsRequired().HasMaxLength(30);
            Property(s => s.Prezime).IsRequired().HasMaxLength(30);

            HasMany(s => s.UpisaniKolegiji).WithRequired(up => up.Student).HasForeignKey(up => up.StudentID);
        }
    }
}
