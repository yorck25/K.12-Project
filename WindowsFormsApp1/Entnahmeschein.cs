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
    public partial class Entnahmeschein : Form
    {
        cEntnahmeschein Es;
        public Entnahmeschein(cEntnahmeschein es)
        {
            InitializeComponent();
            this.Es = es;
        }

        private void Entnahmeschein_Load(object sender, EventArgs e)
        {
            ListenNeuladen(true);
            cBoxEsVonMit.DisplayMember = "MitarbeiterListe";
            cBoxEsFürMit.DisplayMember = "MitarbeiterListe";
        }

    public void ListenNeuladen(bool NeuLaden)
        {
            if (NeuLaden)
            {
                try
                {
                    cMitarbeiter.MitarbeiterLaden();
                    cEntnahmeschein.AlleEntnahmescheinLaden();


                }
                catch (MySqlException ex)
                {

                    Console.WriteLine("Fehler beim Laden: " + ex.Message);
                }
            }
            cBoxEsFürMit.Items.Clear();
            cBoxEsVonMit.Items.Clear();
            lBoxEs.Items.Clear();
            //Mitarbeiter Neu Aufbauen
            foreach (cMitarbeiter mit in cMitarbeiter.MitListe)
            {
                cBoxEsFürMit.Items.Add(mit);
                cBoxEsVonMit.Items.Add(mit);
            }
            foreach(cEntnahmeschein es in cEntnahmeschein.Emliste)
            {
                lBoxEs.Items.Add(es);
            }

        }

        public void butEsErstellen_Click(object sender, EventArgs e)
        {
            Es.ES_VonMit = Convert.ToInt16(((cMitarbeiter)cBoxEsVonMit.SelectedItem).Mit_ID);
            Es.ES_FuerMit = Convert.ToInt16(((cMitarbeiter)cBoxEsFürMit.SelectedItem).Mit_ID);
            Es.ES_Ntz = tBoxEsNtz.Text;
            DateTime EsDate;
            EsDate = DateTime.Now;
            Es.ES_Datum = Convert.ToString(EsDate);
            Es.EntnahmescheinSpiechern();
            Entnahmemenge entnahmemenge = new Entnahmemenge(new cEntnahmemenge());
            entnahmemenge.Show();
            Console.WriteLine("Entnahmeschein wird gespeichert");
            
        }

        private void herfEsNeu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EsDetail.Visible = true;
            butEsErstellen.Enabled = true;
            tBoxEsNtz.Clear();
            lBoxEs.ClearSelected();
            cBoxEsFürMit.ResetText();
            cBoxEsVonMit.ResetText();
            EsDetail.Enabled = true;
        }

        private void lBoxEs_SelectedIndexChanged(object sender, EventArgs e)
        {
            butEsErstellen.Enabled = false;
            EsDetail.Visible = true;

            Es = (cEntnahmeschein)lBoxEs.SelectedItem;
            if (Es != null)
            {
                cBoxEsFürMit.Text = Convert.ToString(Es.ES_FuerMit);
                cBoxEsVonMit.Text = Convert.ToString(Es.ES_VonMit);
                tBoxEsNtz.Text = Convert.ToString(Es.ES_Ntz);
            }
            else
            {
                return;
            }
        }

        private void butEsMehrArt_Click(object sender, EventArgs e)
        {
            Entnahmemenge entnahmemenge = new Entnahmemenge(new cEntnahmemenge());
            entnahmemenge.ShowDialog();
        }
    }
}
