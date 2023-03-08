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
    public partial class Bestellung : Form
    {
        cBestellung b;
        public Bestellung(cBestellung b)
        {
            InitializeComponent();
            this.b = b;
        }

        private void Bestellung_Load(object sender, EventArgs e)
        {
            cBoxenBLaden(true);
        }

        public void cBoxenBLaden(bool LVWNeuLaden)
        {
            if (LVWNeuLaden)
            {
                try
                {
                    cLager.LagerLaden();
                    cMitarbeiter.MitarbeiterLaden();
                }
                catch (MySqlException ex)
                {

                    Console.WriteLine("Fehler beim Laden: " + ex.Message);
                }
            }
            //Alle Boxen leeren

            cBoxBMit.Items.Clear();
            cBoxBLager.Items.Clear();

            //ComoBox für Lager neu Aufbauen
            foreach (cLager lager in cLager.LVWListe)
            {
                cBoxBLager.Items.Add(lager);
            };
            //ComoBox für Mitarbeiter neu Aufbauen
            foreach (cMitarbeiter mit in cMitarbeiter.MitListe)
            {
                cBoxBMit.Items.Add(mit);
            };
        }

        public void butBArtikel_Click(object sender, EventArgs e)
        {

            if(cBoxBLager.SelectedItem == null && cBoxBMit.SelectedItem == null){
                Console.WriteLine("Error");
            }
            else
            {
            b.B_Mitarbeiter = Convert.ToInt32(cBoxBMit.SelectedIndex + 1);
            b.B_Lager = Convert.ToInt32(cBoxBLager.SelectedIndex + 1);
            b.BestellungSpeichern();

            BestellMenge bestellMenge = new BestellMenge(new cBestellMenge());
            bestellMenge.ShowDialog();
            }
        }
    }
}
