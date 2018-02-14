using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Zadatak71
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        static AdventureWorksOBPEntities2 ds;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                InitlaiseDs();
                LoadDDLComercialist();
            }
        }

        private void LoadDDLComercialist()
        {
            foreach (Komercijalist item in ds.Komercijalist)
            {

                ddlKomercialist.Items.Add(new ListItem()
                {
                    Text = item.Ime + " " + item.Prezime,
                    Value = item.IDKomercijalist.ToString()

                });
            }

        }

        private void InitlaiseDs()
        {
            ds = new AdventureWorksOBPEntities2();
        }

        protected void btnDeleteRacun_Click(object sender, EventArgs e)
        {
            int IDkomercialist = int.Parse(ddlKomercialist.SelectedValue);
            int racunID = int.Parse(ddlRacun.SelectedValue);

            Racun r = ds.Racun.ToList().Find(i => i.IDRacun == racunID);

            ds.Stavka.RemoveRange(r.Stavka);
            ds.Racun.Remove(r);
            ds.SaveChanges();
            FillDDLRacuni(IDkomercialist);

        }

        protected void btnUpdateKupac_Click(object sender, EventArgs e)
        {
            int KupacID = int.Parse(hideKupacID.Value);

            Kupac k = ds.Kupac.ToList().Find(ka => ka.IDKupac == KupacID);

            k.Ime = txtIme.Text.Trim();
            k.Prezime = txtPrezime.Text.Trim();
            k.Email = txtEmail.Text.Trim();
            k.Telefon = txtTelefon.Text.Trim();
            ds.SaveChanges();
        }

        protected void ddlKomercialist_SelectedIndexChanged(object sender, EventArgs e)
        {
            int IDkomercialist = int.Parse(ddlKomercialist.SelectedValue);

            FillDDLRacuni(IDkomercialist);
        }

        private void FillDDLRacuni(int IDKomercialist)
        {
            IEnumerable<Racun> racuni = ds.Racun.ToList().FindAll(r => r.KomercijalistID == IDKomercialist).Take(10);

            foreach (Racun item in racuni)
            {

                ddlRacun.Items.Add(new ListItem()
                {
                    Text = item.BrojRacuna,
                    Value = item.IDRacun.ToString()
                });
            }
        }

        protected void ddlRacun_SelectedIndexChanged(object sender, EventArgs e)
        {
            int SelectedRacunID = int.Parse(ddlRacun.SelectedValue);

            loadKupac(SelectedRacunID);
            txtKartica.Text = ds.Racun.ToList().Find(r => r.IDRacun == SelectedRacunID).KreditnaKartica.ToString();
        }

        private void loadKupac(int SelectedRacunID)
        {
            Racun r = ds.Racun.ToList().Find(rac => rac.IDRacun == SelectedRacunID);

            Kupac k = r.Kupac;
            hideKupacID.Value = k.IDKupac.ToString();
            txtIme.Text = k.Ime;
            txtPrezime.Text = k.Prezime;
            txtEmail.Text = k.Email;
            txtTelefon.Text = k.Telefon;


        }
    }
}