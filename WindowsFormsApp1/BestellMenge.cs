﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class BestellMenge : Form
    {
        cBestellMenge BM;
        public BestellMenge(cBestellMenge bM)
        {
            InitializeComponent();
            BM = bM;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void BestellMenge_Load(object sender, EventArgs e)
        {
            Cboxaufbauen(true);
        }

        public void Cboxaufbauen(bool NeuLaden)
        {
            if (NeuLaden)
            {
                try
                {
                    cBestellung.NurUngeliefertBestellungLaden();
                    cArtikel.ArtikelLaden();
                }
                catch (MySqlException ex)
                {

                    Console.WriteLine("Fehler beim Laden: " + ex.Message);
                }
            }
            cBoxBMArt.Items.Clear();
            foreach (cArtikel art in cArtikel.ArtListe)
            {
                cBoxBMArt.Items.Add(art);
            }

            lBoxBestellungen.Items.Clear();
            foreach (cBestellung b in cBestellung.BstListe)
            {
                lBoxBestellungen.Items.Add(b);
            }
        }

        private void BMDetail_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cBoxBMArt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void butBMHinzu_Click(object sender, EventArgs e)
        {

            bmrBestätigungEinfügen.Visible = true;
        }

        public void ListBoxMengeLaden(bool ListeLaden)
        {
            if(ListeLaden)
            {
                try
                {
                    BM.AusgewählteBestellmengeLaden();
                }
                catch (Exception ex) 
                {
                    Console.WriteLine("Fehler bei Laden der ListBox BstMenge" + ex);
                }

                lBoxBMliste.Items.Clear();
                foreach(cBestellMenge bm in cBestellMenge.BMListe)
                {
                    lBoxBMliste.Items.Add(bm);
                }
            }

        }

        private void lBoxBMliste_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lBoxBestellungen_SelectedIndexChanged(object sender, EventArgs e)
        {
            BM.BM_BST_ID = Convert.ToInt32(((cBestellung)lBoxBestellungen.SelectedItem).B_ID);
            BMDetail.Visible = true;
            ListBoxMengeLaden(true);
        }

        private void butEmBestellt_Click(object sender, EventArgs e)
        {
            try
            {
                BM.BestellungStatusNeu();
                Console.WriteLine("Bestellung auf dem Weg");
            }
            catch { BmFehler.Visible = true; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BM.BM_BST_ID = Convert.ToInt16(((cBestellung)lBoxBestellungen.SelectedItem).B_ID);
            BM.AusgewählteBestellmengeLaden();
        }

        private void butBmbestätigen_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Convert.ToString(cBoxBMArt.SelectedIndex == -1)) || string.IsNullOrEmpty(tBoxBMmenge.Text))
            {
                Console.WriteLine("Error");
                BmFehler.Visible = true;
            }
            else
            {
                BM.BM_ART_ID = Convert.ToInt16(((cArtikel)cBoxBMArt.SelectedItem).Art_ID);
                BM.BM_Menge = Convert.ToInt32(tBoxBMmenge.Text);
                BM.BM_BST_ID = Convert.ToInt16(((cBestellung)lBoxBestellungen.SelectedItem).B_ID);
                Console.WriteLine("Bestellmenge wird gespeichert");
                BM.BestellmengeSpeichern();
                ListBoxMengeLaden(true);
                bmrBestätigungEinfügen.Visible = false;
                tBoxBMmenge.Clear();
            }
        }

        private void butBmFehler_Click(object sender, EventArgs e)
        {
            BmFehler.Visible = false;
        }
    }
}
