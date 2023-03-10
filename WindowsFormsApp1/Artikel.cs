using MySql.Data.MySqlClient;
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
    public partial class Artikel : Form
    {
        cArtikel art;
        public Artikel(cArtikel art)
        {
            InitializeComponent();
            this.art = art;
        }

        public void cBoxenLaden(bool LVWNeuLaden)
        {
            if (LVWNeuLaden)
            {
                try
                {
                    cEinheit.EinheitLaden();
                    cLager.LagerLaden();
                    cLieferant.LieferantLaden();
                    cArtikel.ArtikelLaden();
                }
                catch (MySqlException ex)
                {

                    Console.WriteLine("Fehler beim Laden: " + ex.Message);
                }
            }
            //Alle Boxen leeren
            lBoxArt.Items.Clear();
            cBoxArtLager.Items.Clear();
            cBoxArtL.Items.Clear();
            cBoxAbtEinheit.Items.Clear();

            //ListBox Artikel neu Aufbauen
            foreach (cArtikel art in cArtikel.ArtListe)
            {
                lBoxArt.Items.Add(art);
            };
            //ComoBox für Lager neu Aufbauen
            foreach (cLager lager in  cLager.LVWListe)
            {
                cBoxArtLager.Items.Add(lager);
            };
            //ComoBox für Lieferanten neu Aufbauen
            foreach (cLieferant l in cLieferant.LListe)
            {
                cBoxArtL.Items.Add(l);
            };
            //ComoBox für Einhaiten neu Aufbauen
            foreach (cEinheit ein in cEinheit.EinListe)
            {
                cBoxAbtEinheit.Items.Add(ein);
            }
        }

        private void Artikel_Load(object sender, EventArgs e)
        {
            cBoxenLaden(true);  
        }

        private void lBoxArt_SelectedIndexChanged(object sender, EventArgs e)
        {
            AbtneueAbteilung.Visible = true;
            art = (cArtikel)lBoxArt.SelectedItem;
            if (art != null)
            {
                tBoxAbtBez.Text = art.Art_Bez;
                tBoxArtPreis.Text = Convert.ToString(art.Art_Preis);
                tBoxArtBst.Text = Convert.ToString(art.Art_Bst);
                tBoxArtMaxBst.Text = Convert.ToString(art.Art_MaxBst);
                tBoxArtMinBst.Text = Convert.ToString(art.Art_MinBst);
                cBoxArtLager.Text = Convert.ToString(art.Art_Lager);
                cBoxAbtEinheit.Text = Convert.ToString(art.Art_Einheit);
                cBoxArtL.Text = Convert.ToString(art.Art_Lieferant);

            }
            else
            {
                return;
            }
        }

        private void herfArtNeu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbtneueAbteilung.Visible = true;

            tBoxAbtBez.Clear();
            tBoxArtPreis.Clear();
            tBoxArtBst.Clear();
            tBoxArtMaxBst.Clear();
            tBoxArtMinBst.Clear();
            cBoxArtLager.SelectedIndex = 0;
            cBoxAbtEinheit.SelectedIndex = 0;
            cBoxArtL.SelectedIndex = 0;
        }

        private void butArtErstellen_Click(object sender, EventArgs e)
        {
            AbtneueAbteilung.Visible= false;

            if (tBoxAbtBez.Text == null)
            {
                Console.WriteLine("Kein Wert");
            }
            else
            {
                art.Art_Bez = tBoxAbtBez.Text;
                art.Art_Preis = Convert.ToInt32(tBoxArtPreis.Text);
                art.Art_Bst = Convert.ToInt16(tBoxArtBst.Text);
                art.Art_MinBst = Convert.ToInt16(tBoxArtMinBst.Text);
                art.Art_MaxBst = Convert.ToInt16(tBoxArtMaxBst.Text);
                art.Art_Einheit = Convert.ToInt32(cBoxAbtEinheit.SelectedIndex + 1);
                art.Art_Lager = Convert.ToInt16(cBoxArtLager.SelectedIndex +1);
                art.Art_Lieferant = Convert.ToInt32(cBoxArtL.SelectedIndex +1);
                
                art.ArtikelSpeichern();
                cBoxenLaden(true);
                Console.WriteLine("Artikel wird gespeichert");
            }
        }

        private void butArtSpeichern_Click(object sender, EventArgs e)
        {
            AbtneueAbteilung.Visible = false;
        }

        private void herfArtneueEinheit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Einheit einheit = new Einheit(new cEinheit());
            einheit.Show();
        }

        private void herfArtLgv_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Lager lager = new Lager(new cLager());
            lager.Show();
        }

        private void herfArtLief_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Lieferant lieferant = new Lieferant(new cLieferant());
            lieferant.Show();
        }

        private void cBoxArtLager_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
