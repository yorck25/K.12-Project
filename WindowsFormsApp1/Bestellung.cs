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
            ListBoxNeuLAden(true);
        }

        public void cBoxenBLaden(bool LVWNeuLaden)
        {
            if (LVWNeuLaden)
            {
                try
                {
                    cLager.LagerLaden();
                    cBestellung.BestellungLaden();
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

        public void ListBoxNeuLAden(bool lBoxLaden)
        {
            if(lBoxLaden)
            {
                try
                {
                    cBestellung.BestellungLaden();
                }
                catch
                {
                    Console.WriteLine("Fehler");
                }
            }
            lBoxBestellung.Items.Clear();
            //ListBox für Bestellung neu Aufbauen
            foreach (cBestellung bst in cBestellung.BstListe)
            {
                lBoxBestellung.Items.Insert(0, bst);
            }
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
                DateTime CurrentDate;
                CurrentDate = DateTime.Now;
                b.B_Datum = Convert.ToString(CurrentDate);
                Console.WriteLine(b.B_Datum);
                b.BestellungSpeichern();

                cBoxBLager.SelectedIndex = 0;
                cBoxBMit.SelectedIndex = 0;
                BestellungDetail.Visible = false;
                BestellMenge bestellMenge = new BestellMenge(new cBestellMenge());
                bestellMenge.ShowDialog();
                ListBoxNeuLAden(true);
            }
        }

        private void lBoxBestellung_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void herfBNeu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            BestellungDetail.Show();
        }
    }
}
