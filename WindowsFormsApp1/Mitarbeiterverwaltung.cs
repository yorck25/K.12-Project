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

        public void lBoxMverMitarbeiter_SelectedIndexChanged(object sender, EventArgs e)
        {
            MverDetailMitarbeiter.Visible= true;

            Mit = (cMitarbeiter)lBoxMverMitarbeiter.SelectedItem;
            if(Mit != null)
            {
                tBoxMitVName.Text = Mit.Mit_VName;
                tBoxMitName.Text = Mit.Mit_Name;
                tBoxMitStraße.Text = Mit.Mit_Straße;
                tBoxMitHausNr.Text = Convert.ToString(Mit.Mit_HausNr);
                tBoxMitPLZ.Text = Convert.ToString(Mit.Mit_PLZ);
                tBoxMitOrt.Text = Mit.Mit_Ort;
                //DateMit.Value = mit.Mit_GDat;
                tBoxMitEmail.Text = Mit.Mit_Mail;
                tBoxMitBenutzer.Text = Mit.Mit_Benutzer;
                tBoxMitPw.Text = Mit.Mit_Pw;
                cBoxMitAbt.SelectedItem = Mit.Mit_Abt_ID;
            }
            else
            {
                return;
            }
        }

        private void butMverDetailSchließen_Click(object sender, EventArgs e)
        {
            MverDetailMitarbeiter.Visible = false;
            Mit.Mit_Name = tBoxMitName.Text;
            Mit.Mit_VName = tBoxMitVName.Text;
            Mit.Mit_Mail = tBoxMitEmail.Text;
            Mit.Mit_Ort = tBoxMitOrt.Text;
            //Mit.Mit_GDat = DatteMit.
            Mit.Mit_HausNr = Convert.ToInt16(tBoxMitHausNr.Text);


            try
            {
                Mit.MitarbeiterSpeichern();
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
            MitListeLaden(true);
;            
        }

        public void MitListeLaden(bool MitNeuLaden)
        {
            if (MitNeuLaden)
            {
                try
                {
                    cMitarbeiter.MitarbeiterLaden();
                }
                catch (MySqlException ex)
                {

                    Console.WriteLine("Fehler beim Laden: " + ex.Message);
                }
            }
            lBoxMverMitarbeiter.Items.Clear();
            foreach (cMitarbeiter mit in cMitarbeiter.MitListe)
            {
                lBoxMverMitarbeiter.Items.Add(mit);
            }
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

        private void MverDetailMitarbeiter_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
