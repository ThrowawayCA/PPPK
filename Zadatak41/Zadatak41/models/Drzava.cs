using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak41.models
{
    public class Drzava
    {
        public int IDDrzava { get; set; }
        public string Naziv { get; set; }


        public override string ToString()
        {
            return Naziv;
        }
    }
}
