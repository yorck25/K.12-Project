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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            BMDetail.Visible = true;
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
                    cBestellung.BestellungLaden();
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
                cBoxBMArt.Items.Insert(0, art);
            }

            cBoxBMBestellung.Items.Clear();
            foreach (cBestellung b in cBestellung.BstListe)
            {
                cBoxBMBestellung.Items.Insert(0, b);
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
            if (cBoxBMArt.SelectedItem == null && tBoxBMmenge.Text == null)
            {
                Console.WriteLine("Error");
            }
            else
            {
                BM.BM_ART_ID = Convert.ToInt32(cBoxBMArt.SelectedIndex + 1);
                BM.BM_Menge = Convert.ToInt32(tBoxBMmenge.Text);
                BM.BM_BST_ID = Convert.ToInt32(cBoxBMBestellung.SelectedIndex +1);
                Console.WriteLine("Bestellmenge wird gespeichert");
                BM.BestellmengeSpeichern();
                ListBoxMengeLaden(true);

            }
        }

        public void ListBoxMengeLaden(bool ListeLaden)
        {
            if(ListeLaden)
            {
                try
                {
                    cBestellMenge.BestellmengeLaden();
                }
                catch (Exception ex) 
                {
                    Console.WriteLine("Fehler bei Laden der ListBox BstMenge" + ex);
                }

                lBoxBMliste.Items.Clear();
                foreach(cBestellMenge bm in cBestellMenge.BMListe)
                {
                    lBoxBMliste.Items.Insert(0, bm);
                }
            }

        }
    }
}
