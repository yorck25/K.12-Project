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
            ListenMitNeuladen(true);
            cBoxEsVonMit.DisplayMember = "MitarbeiterListe";
            cBoxEsFürMit.DisplayMember = "MitarbeiterListe";
        }

    public void ListenMitNeuladen(bool NeuLaden)
        {
            if (NeuLaden)
            {
                try
                {
                    cMitarbeiter.MitarbeiterLaden();
                    cAbteilung.AbteilungLaden();
                    cRolle.RolleLaden();
                    cFunktion.FunktionLaden();
                }
                catch (MySqlException ex)
                {

                    Console.WriteLine("Fehler beim Laden: " + ex.Message);
                }
            }
            cBoxEsFürMit.Items.Clear();
            cBoxEsVonMit.Items.Clear();
            //Abteilung Neu Aufbauen
            foreach (cMitarbeiter mit in cMitarbeiter.MitListe)
            {
                cBoxEsFürMit.Items.Add(mit);
                cBoxEsVonMit.Items.Add(mit);
            }
        }

        public void butEsErstellen_Click(object sender, EventArgs e)
        {
            Es.ES_VonMit = Convert.ToInt16(cBoxEsVonMit.SelectedIndex + 1);
            Es.ES_FuerMit = Convert.ToInt16(cBoxEsFürMit.SelectedIndex + 1);
            Es.ES_Ntz = tBoxEsNtz.Text;
            DateTime EsDate;
            EsDate = DateTime.Now;
            Es.ES_Datum = Convert.ToString(EsDate);
            //Es.Es_Bearbeitet = false;
            Es.EntnahmescheinSpiechern();
            Console.WriteLine("Entnahmeschein wird gespeichert");
            
        }
    }
}
