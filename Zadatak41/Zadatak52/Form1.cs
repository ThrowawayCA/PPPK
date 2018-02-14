using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Zadatak52.PPPKI51ADataSet;

namespace Zadatak52
{
    public partial class Form1 : Form
    {
        PPPKI51ADataSet ds;
        PPPKI51ADataSetTableAdapters.AlbumTableAdapter taAlbum;
        PPPKI51ADataSetTableAdapters.IzvodjacTableAdapter taIzvodjac;
        PPPKI51ADataSetTableAdapters.PjesmaTableAdapter taPjesma;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ds = new PPPKI51ADataSet();
            taAlbum = new PPPKI51ADataSetTableAdapters.AlbumTableAdapter();
            taIzvodjac = new PPPKI51ADataSetTableAdapters.IzvodjacTableAdapter();
            taPjesma = new PPPKI51ADataSetTableAdapters.PjesmaTableAdapter();
            taAlbum.Fill(ds.Album);
            taIzvodjac.Fill(ds.Izvodjac);
            taPjesma.Fill(ds.Pjesma);
            LoadCBAlbum();
        }

        private void LoadCBAlbum()
        {
            ds.Album.ToList().ForEach(a => cbAlbumi.Items.Add(a));
        }

        private void cbAlbumi_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadSongs();
            
        }

        private void LoadSongs()
        {
            AlbumRow row = cbAlbumi.SelectedItem as AlbumRow;
            lstPjesme.Items.Clear();
            row.GetChildRows(ds.Relations["AlbumPjesmaRelation"]).ToList().ForEach(p => lstPjesme.Items.Add(p));
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            AlbumRow rowAlbum = cbAlbumi.SelectedItem as AlbumRow;
            PjesmaRow row = ds.Pjesma.NewPjesmaRow();

            row.NaslovPjesme = txtPjesma.Text.Trim();
            row.AlbumRow = rowAlbum;
            row.AlbumID = rowAlbum.IDAlbum;
            ds.Pjesma.AddPjesmaRow(row);
          

            taPjesma.Update(ds.Pjesma);
            LoadSongs();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            PjesmaRow row = lstPjesme.SelectedItem as PjesmaRow;

            row.NaslovPjesme = txtPjesma.Text.Trim();

            taPjesma.Update(ds.Pjesma);
            LoadSongs();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            PjesmaRow row = lstPjesme.SelectedItem as PjesmaRow;

            row.Delete();

            taPjesma.Update(ds.Pjesma);
            LoadSongs();
        }

        private void lstPjesme_SelectedIndexChanged(object sender, EventArgs e)
        {
            PjesmaRow row = lstPjesme.SelectedItem as PjesmaRow;

            txtPjesma.Text = row.NaslovPjesme;


        }
    }
}
