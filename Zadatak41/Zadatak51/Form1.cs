using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Zadatak51.PPPKI51ADataSet;

namespace Zadatak51
{
    public partial class Form1 : Form
    {
        PPPKI51ADataSet1 ds;
        PPPKI51ADataSet1TableAdapters.AlbumTableAdapter taAlbum;
        PPPKI51ADataSet1TableAdapters.IzvodjacTableAdapter taIzvodjac;
        PPPKI51ADataSet1TableAdapters.PjesmaTableAdapter taPjesma;
       
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ds = new PPPKI51ADataSet1();
            taAlbum = new PPPKI51ADataSet1TableAdapters.AlbumTableAdapter();
            taIzvodjac = new PPPKI51ADataSet1TableAdapters.IzvodjacTableAdapter();
            taPjesma = new PPPKI51ADataSet1TableAdapters.PjesmaTableAdapter();
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
            AlbumRow row = cbAlbumi.SelectedItem as AlbumRow;

            row.GetChildRows(ds.Relations["AlbumPjesmaRelation"]).ToList().ForEach(p => lstPjesme.Items.Add(p));
        }
    }
}
