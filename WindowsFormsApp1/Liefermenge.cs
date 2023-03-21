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
                    cLieferschein.NurUnbearbeiteteScheineLaden();
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

        private void butLsmHinzu_Click(object sender, EventArgs e)
        {
            lmBestätigungEinfügen.Visible = true;
        }

        private void butLmLsFertig_Click(object sender, EventArgs e)
        {
            Lms.LieferscheinStatusnNeu();
            this.Close();
        }

        private void cBoxLsmScheine_SelectedIndexChanged(object sender, EventArgs e)
        {
            Lms.LM_LS_ID = Convert.ToInt32(((cLieferschein)cBoxLsmScheine.SelectedItem).LS_ID);
            ListBoxMengeLaden(true);
        }

        public void ListBoxMengeLaden(bool ListeLaden)
        {
            if (ListeLaden)
            {
                try
                {
                    Lms.AusgewählteLiefermengeLaden();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Fehler bei Laden der ListBox BstMenge" + ex);
                }

                lBoxLsmArt.Items.Clear();
                foreach (cLiefermenge lm in cLiefermenge.LmListe)
                {
                    lBoxLsmArt.Items.Add(lm);
                }
            }

        }

        private void butLmbestätigen_Click(object sender, EventArgs e)
        {
            try
            {
                Lms.LM_ART_ID = Convert.ToInt16(((cArtikel)cBoxLsmArt.SelectedItem).Art_ID);
                Lms.LM_Menge = Convert.ToInt16(tBoxLsmMenge.Text);
                Lms.LM_LS_ID = Convert.ToInt16(((cLieferschein)cBoxLsmScheine.SelectedItem).LS_ID);
                Console.WriteLine("Liefermenge wird hinzugefügt");
                Lms.ArtikelEinFürLieferschein();
                ListBoxMengeLaden(true);
                lmBestätigungEinfügen.Visible = false;
                tBoxLsmMenge.Clear();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Fehler beim erstellen" + ex);
            }
        }
    }
}
