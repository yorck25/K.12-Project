using ComponentFactory.Krypton.Toolkit;
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
    public partial class Mitarbeiterverwaltung : Form
    {
        cMitarbeiter Mit;
        public Mitarbeiterverwaltung(cMitarbeiter mit)
        {
            InitializeComponent();
            this.Mit = mit;
        }

        private void lBoxMverMitarbeiter_SelectedIndexChanged(object sender, EventArgs e)
        {
            MverDetailMitarbeiter.Visible= true;
        }

        private void butMverDetailSchließen_Click(object sender, EventArgs e)
        {
            MverDetailMitarbeiter.Visible = false;
            Mit.Mit_Name = tBoxMitName.Text;

            if (string.IsNullOrEmpty(tBoxMitName.Text))
            {
                Console.WriteLine("Keine Eingabe");
            }
            else
            {
                Mit.MitarbeiterSpeichern();
                Console.WriteLine("Kst wird gespeichert");
                tBoxMitName.Clear();

            }
        }

        private void butMitAbt_Click(object sender, EventArgs e)
        {
            Abteilung abteilung= new Abteilung(new cAbteilung());
            abteilung.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Funktion funktion = new Funktion(new cFunktion());
            funktion.Show();
        }

        private void butMitRolle_Click(object sender, EventArgs e)
        {
            Rolle rolle = new Rolle(new cRolle());
            rolle.Show();
        }

        public void Mitarbeiterverwaltung_Load(object sender, EventArgs e)
        {
            CBoxMitAbtNeuLaden(true);
            CBoxMitRNeuLaden(true);
            CBoxMitFNeuLaden(true);
            
        }

        public void CBoxMitFNeuLaden(bool FNeuLaden)
        {
            if (FNeuLaden)
            {
                try
                {
                   cFunktion.FunktionLaden();
                }
                catch (MySqlException ex)
                {

                    Console.WriteLine("Fehler beim Laden: " + ex.Message);
                }
            }
            cBoxMitFunk.Items.Clear();
            foreach (cFunktion f in cFunktion.FListe)
            {
                cBoxMitFunk.Items.Add(f);
            }
        }

        public void CBoxMitAbtNeuLaden(bool AbtNeuLaden)
        {
            if (AbtNeuLaden)
            {
                try
                {
                   cAbteilung.AbteilungLaden();
                }
                catch (MySqlException ex)
                {

                    Console.WriteLine("Fehler beim Laden: " + ex.Message);
                }
            }
            cBoxMitAbt.Items.Clear();
            foreach (cAbteilung abt in cAbteilung.Abtliste)
            {
                cBoxMitAbt.Items.Add(abt);
            }
        }

        public void CBoxMitRNeuLaden(bool RNeuLaden)
        {
            if (RNeuLaden)
            {
                try
                {
                    cRolle.RolleLaden();
                }
                catch (MySqlException ex)
                {

                    Console.WriteLine("Fehler beim Laden: " + ex.Message);
                }
            }
            cBoxMitRolle.Items.Clear();
            foreach (cRolle r in cRolle.RListe)
            {
                cBoxMitRolle.Items.Add(r);
            }
        }
    }
}
