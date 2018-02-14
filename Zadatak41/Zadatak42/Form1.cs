using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zadatak42.Dao;
using Zadatak42.models;

namespace Zadatak42
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lbGrad_SelectedIndexChanged(object sender, EventArgs e)
        {
            Grad g = lbGrad.SelectedItem as Grad;
            txtGrad.Text = g.Naziv;
        }

        private void lbDrzava_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillDDLGRad();

        }

        private void FillDDLGRad()
        {
            Drzava d = lbDrzava.SelectedItem as Drzava;
            lbGrad.Items.Clear();
            SQLHelperIMpl.GetGradovi(d.IDDrzava).ForEach(g => lbGrad.Items.Add(g));

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Drzava selected = lbDrzava.SelectedItem as Drzava;
            Grad g = new Grad()
            {
                Naziv = txtGrad.Text,
                DrzavaID = selected.IDDrzava
            };

            SQLHelperIMpl.InsertGrad(g);
            FillDDLGRad();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Grad g = lbGrad.SelectedItem as Grad;
            g.Naziv = txtGrad.Text;
            SQLHelperIMpl.UpdateGrad(g);
            FillDDLGRad();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Grad g = lbGrad.SelectedItem as Grad;

            SQLHelperIMpl.DeleteGrad(g.IDGrad);
            FillDDLGRad();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FillDDLDrzave();
        }

        private void FillDDLDrzave()
        {
            lbDrzava.Items.Clear();
            SQLHelperIMpl.GetDrzave().ForEach(d => lbDrzava.Items.Add(d));

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            FillDDLDrzave();
        }
    }
}
