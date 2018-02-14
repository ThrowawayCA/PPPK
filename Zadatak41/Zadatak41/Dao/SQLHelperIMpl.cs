using Microsoft.ApplicationBlocks.Data;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zadatak41.models;

namespace Zadatak41.Dao
{
    public   class SQLHelperIMpl
    {
        private static string cs = ConfigurationManager.ConnectionStrings["cs"].ConnectionString;


        public static List<Drzava> GetDrzave()
        {
            List<Drzava> drzave = new List<Drzava>();
            DataSet ds = SqlHelper.ExecuteDataset(cs, nameof(GetDrzave));

            foreach (DataRow item in ds.Tables[0].Rows)
            {
                drzave.Add(new Drzava()
                {
                    IDDrzava = (int)item[nameof(Drzava.IDDrzava)],
                    Naziv = item[nameof(Drzava.Naziv)].ToString()
                    });
            }

            return drzave;

        }


        public static List<Grad> GetGradovi(int IDDrzava)
        {
            List<Grad> gradovi = new List<Grad>();
            DataSet ds = SqlHelper.ExecuteDataset(cs,nameof(GetGradovi),IDDrzava);

            foreach (DataRow item in ds.Tables[0].Rows)
            {
                gradovi.Add(new Grad()
                {
                    IDGrad = (int)item[nameof(Grad.IDGrad)],
                    DrzavaID = (int)item[nameof(Grad.DrzavaID)],
                    Naziv = item[nameof(Grad.Naziv)].ToString()
                });
            }

            return gradovi;

        }


        public static void InsertGrad(Grad g)
        {
            SqlHelper.ExecuteNonQuery(cs, nameof(InsertGrad), g.Naziv, g.DrzavaID);
            
        }
        public static void UpdateGrad(Grad g)
        {
            SqlHelper.ExecuteNonQuery(cs, nameof(UpdateGrad),g.IDGrad, g.Naziv, g.DrzavaID);
            
        }
        public static void DeleteGrad(int IDGrad )
        {
            SqlHelper.ExecuteNonQuery(cs, nameof(DeleteGrad),IDGrad);
        }

    }
}
