
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zadatak42.models;

namespace Zadatak42.Dao
{
    public class SQLHelperIMpl
    {
        private static string cs = ConfigurationManager.ConnectionStrings["cs"].ConnectionString;
        private static SqlDatabase sql = new SqlDatabase(cs);

        public static List<Drzava> GetDrzave()
        {
            List<Drzava> drzave = new List<Drzava>();
            DataSet ds = sql.ExecuteDataSet(nameof(GetDrzave));

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
            DataSet ds = sql.ExecuteDataSet(nameof(GetGradovi),IDDrzava);

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
            sql.ExecuteNonQuery( nameof(InsertGrad), g.Naziv, g.DrzavaID);
        }
        public static void UpdateGrad(Grad g)
        {
            sql.ExecuteNonQuery( nameof(UpdateGrad),g.IDGrad, g.Naziv, g.DrzavaID);
            
        }
        public static void DeleteGrad(int IDGrad )
        {
            sql.ExecuteNonQuery(nameof(DeleteGrad),IDGrad);
        }

    }
}
