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
            bmrBestätigungEinfügen.Visible = true;
        }

        public void Cboxaufbauen(bool NeuLaden)
        {
            if (NeuLaden)
            {
                try
                {
                    cArtikel.ArtikelLaden();
                    cEntnahmeschein.NurUnbearbeiteteEntScheineLaden();
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
            ListBoxMengeLaden(true);
        }

        public void ListBoxMengeLaden(bool ListeLaden)
        {
            if (ListeLaden)
            {
                try
                {
                    em.AusgewählteEntnahmemengeLaden();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Fehler bei Laden der ListBox BstMenge" + ex);
                }

                lBoxEmArt.Items.Clear();
                foreach (cEntnahmemenge em in cEntnahmemenge.EmListe)
                {
                    lBoxEmArt.Items.Add(em);
                }
            }

        }

        private void butEmbestätigen_Click(object sender, EventArgs e)
        {
            try
            {
                em.EM_ART_ID = Convert.ToInt32(((cArtikel)cBoxEmArt.SelectedItem).Art_ID);
                em.EM_Menge = Convert.ToInt16(tBoxEmMenge.Text);
                em.EM_ES_ID = Convert.ToInt32(((cEntnahmeschein)cBoxEmEschein.SelectedItem).ES_ID);
                em.ArtikelEinFürLieferschein();
                ListBoxMengeLaden(true);
                bmrBestätigungEinfügen.Visible = false;
                Console.WriteLine("Liefermenge wird hinzugefügt");
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Fehler beim erstellen" + ex);
                EmFehler.Visible = true;
            }
        }

        private void cBoxEmEschein_SelectedIndexChanged(object sender, EventArgs e)
        {
            em.EM_ES_ID = Convert.ToInt32(((cEntnahmeschein)cBoxEmEschein.SelectedItem).ES_ID);
            ListBoxMengeLaden(true);
        }

        private void butEmBestellt_Click(object sender, EventArgs e)
        {
            try
            {
                em.EM_ES_ID = Convert.ToInt32(((cEntnahmeschein)cBoxEmEschein.SelectedItem).ES_ID);
                em.EntnahmescheinStatusnNeu();
                Console.WriteLine("Entnahmeschein eingefügt");
            }
            catch { EmFehler.Visible = true; }
        }

        private void butEmFehler_Click(object sender, EventArgs e)
        {
            EmFehler.Visible = false;
        }
    }
}   