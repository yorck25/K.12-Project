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
        cEntnahmeschein Em;
        public Entnahmeschein(cEntnahmeschein em)
        {
            InitializeComponent();
            this.Em = em;
        }

        private void Entnahmeschein_Load(object sender, EventArgs e)
        {
            ListenMitNeuladen(true);
            cBoxEsVonMit.DisplayMember= "MitarbeiterListe";
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
    }
}
