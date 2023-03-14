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
                cBoxLsmScheine.Items.Insert(0, ls);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void butLsmHinzu_Click(object sender, EventArgs e)
        {
            Lms.ArtikelEinFürLieferschein();
        }

        private void butLsmBestandAktuell_Click(object sender, EventArgs e)
        {

        }
    }
}
