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
    public partial class Entnahmemenge : Form
    {
        cEntnahmemenge em;
        public Entnahmemenge(cEntnahmemenge em)
        {
            InitializeComponent();
            this.em = em;
        }

        private void butEmHinzu_Click(object sender, EventArgs e)
        {
            em.EM_ART_ID = Convert.ToInt16(cBoxEmArt.SelectedIndex + 1);
            em.EM_Menge = Convert.ToInt16(tBoxEmMenge.Text);
            em.EM_ES_ID = Convert.ToInt16(cBoxEmEschein.SelectedIndex + 1);
            em.ArtikelEinFürLieferschein();
            Console.WriteLine("Liefermenge wird hinzugefügt");

            try
            {

            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Fehler beim erstellen" + ex);
            }
        }

        public void Cboxaufbauen(bool NeuLaden)
        {
            if (NeuLaden)
            {
                try
                {
                    cEntnahmeschein.AlleEntnahmescheinLaden();
                    cArtikel.ArtikelLaden();
                }
                catch (MySqlException ex)
                {

                    Console.WriteLine("Fehler beim Laden: " + ex.Message);
                }
            }
            cBoxEmArt.Items.Clear();
            foreach (cArtikel art in cArtikel.ArtListe)
            {
                cBoxEmArt.Items.Add(art);
            }

            cBoxEmEschein.Items.Clear();
            foreach (cEntnahmeschein es in cEntnahmeschein.Emliste)
            {
                cBoxEmEschein.Items.Add(es);
            }
        }

        private void Entnahmemenge_Load(object sender, EventArgs e)
        {
            Cboxaufbauen(true);
        }
    }
}
