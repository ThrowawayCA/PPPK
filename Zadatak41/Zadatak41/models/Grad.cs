using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak41.models
{
   public class Grad
    {
        public int IDGrad { get; set; }
        public string Naziv { get; set; }
        public int DrzavaID { get; set; }


        public override string ToString()
        {
            return Naziv;
        }
    }
}
