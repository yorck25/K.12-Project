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
    public partial class Hauptmenu : Form
    {
        cArtikel art;
        public Hauptmenu()
        {
            InitializeComponent();
        }

        private void hauptmenuÖffnenSidebar_Click(object sender, EventArgs e)
        {
            hmenuNavElemente.Visible = !hmenuNavElemente.Visible;
        }

        private void button1hauptmenuÖffnenAcc_Click(object sender, EventArgs e)
        {
            hmenuAccElemente.Visible = !hmenuAccElemente.Visible;
        }

        private void butHauptmenuÖffnenNachrichten_Click(object sender, EventArgs e)
        {
            hmenuBenachrichtigungList.Visible = !hmenuBenachrichtigungList.Visible;
        }

        private void lBoxBenachrichtigung_SelectedIndexChanged(object sender, EventArgs e)
        {
            hmenuDetailBenachrichtigung.Visible = !hmenuDetailBenachrichtigung.Visible;
        }
        public void cBoxenLaden(bool HMenuArtNeuLaden)
        {
            if (HMenuArtNeuLaden)
            {
                try
                {
                    cArtikel.ArtikelLaden();
                }
                catch (MySqlException exc)
                {
                    Console.WriteLine("Fehler beim Laden: " + exc.Message);
                }
            }
            //Alle Boxen leeren
            lBoxHmenuBestand.Items.Clear();


            //ListBox Artikel neu Aufbauen
            foreach (cArtikel art in cArtikel.ArtListe)
            {
                lBoxHmenuBestand.Items.Add(art);
                Console.WriteLine(art);
            }
        }
        private void lBoxHmenuBestand_SelectedIndexChanged(object sender, EventArgs e)
        {
            hmenuDetailABestand.Visible = hmenuDetailABestand.Visible;
            art = (cArtikel)lBoxHmenuBestand.SelectedItem;
            if (art != null)
            {
                tBoxHmenuAName.Text = art.Art_Bez;
                tBoxHmenuABestand.Text = Convert.ToString(art.Art_Bst);
                tBoxHmenuAMAxBestand.Text = Convert.ToString(art.Art_MaxBst);
                tBoxHmenuAMinBestand.Text = Convert.ToString(art.Art_MinBst);

            }
            else
            {
                return;
            }
        }

        private void butHmenuBestätigen_Click(object sender, EventArgs e)
        {
            hmenuDetailABestand.Visible = false;
        }

        private void butHmenuAbmelden_Click(object sender, EventArgs e)
        {
            Login login = new Login(new cLogin());
            login.Show();
        }

        private void butHmenuMitarbeiter_Click(object sender, EventArgs e)
        {
            Mitarbeiterverwaltung mitarbeiterverwaltung = new Mitarbeiterverwaltung(new cMitarbeiter());
            mitarbeiterverwaltung.Show();
        }

        private void butHmenuÄndern_Click(object sender, EventArgs e)
        {
            Mitarbeiterverwaltung mitarbeiterverwaltung = new Mitarbeiterverwaltung(new cMitarbeiter());
            mitarbeiterverwaltung.Show();
        }

        private void butHmenuArtikel_Click(object sender, EventArgs e)
        {
            Artikel artikel = new Artikel(new cArtikel());
            artikel.Show();
        }

        private void butHmenuLieferant_Click(object sender, EventArgs e)
        {
            Lieferant lieferant = new Lieferant(new cLieferant());
            lieferant.Show();
        }

        private void butHmenuLager_Click(object sender, EventArgs e)
        {
            Lager lager = new Lager(new cLager());
            lager.Show();
        }

        private void butHmenuBestellung_Click(object sender, EventArgs e)
        {
            Bestellung bestellung = new Bestellung(new cBestellung());
            bestellung.Show();
        }

        private void butHmenuLieferschein_Click(object sender, EventArgs e)
        {
            Lieferschein lieferschein = new Lieferschein(new cLieferschein());
            lieferschein.Show();
        }

        private void Hauptmenu_Load(object sender, EventArgs e)
        {
            cBoxenLaden(true);
        }
    }
}