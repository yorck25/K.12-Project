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
    public partial class Liefermenge : Form
    {
        cLiefermenge Lms;
        public Liefermenge(cLiefermenge lms)
        {
            InitializeComponent();
            Lms = lms;
        }

        private void Liefermenge_Load(object sender, EventArgs e)
        {
            Cboxaufbauen(true);
        }
        public void Cboxaufbauen(bool NeuLaden)
        {
            if (NeuLaden)
            {
                try
                {
                    cLieferschein.LieferscheinLaden();
                    cArtikel.ArtikelLaden();
                }
                catch (MySqlException ex)
                {

                    Console.WriteLine("Fehler beim Laden: " + ex.Message);
                }
            }
            cBoxLsmArt.Items.Clear();
            foreach (cArtikel art in cArtikel.ArtListe)
            {
                cBoxLsmArt.Items.Add(art);
            }

            cBoxLsmScheine.Items.Clear();
            foreach (cLieferschein ls in cLieferschein.LsListe)
            {
                cBoxLsmScheine.Items.Add(ls);
            }
        }

        public void ArtikelProLSchein(bool ArtLaden)
        {
            if (ArtLaden)
            {
                Lms.LiefermengeLaden();
            }
            lBoxLsmArt.Items.Clear();
            foreach(cLiefermenge lm in cLiefermenge.LmListe)
            {
                cBoxLsmArt.Items.Add(lm);
            }
        }

        private void butLsmHinzu_Click(object sender, EventArgs e)
        {
            Lms.LM_ART_ID = Convert.ToInt16(cBoxLsmArt.SelectedIndex +1);
            Lms.LM_Menge = Convert.ToInt16(tBoxLsmMenge.Text);
            Lms.LM_LS_ID = Convert.ToInt16(cBoxLsmScheine.SelectedIndex +1);
            Lms.ArtikelEinFürLieferschein();
            ArtikelProLSchein(true);
            Console.WriteLine("Liefermenge wird hinzugefügt");

            try
            {

            }
            catch(MySqlException ex)
            {
                Console.WriteLine("Fehler beim erstellen" + ex);
            }
        }

        private void butLsmBestandAktuell_Click(object sender, EventArgs e)
        {

        }
    }
}
