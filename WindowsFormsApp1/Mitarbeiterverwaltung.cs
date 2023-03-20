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
            MverDetailMitarbeiter.Visible = true;

            Mit = (cMitarbeiter)lBoxMverMitarbeiter.SelectedItem;
            if (Mit != null)
            {
                tBoxMitVName.Text = Mit.Mit_VName;
                tBoxMitName.Text = Mit.Mit_Name;
                tBoxMitStraße.Text = Mit.Mit_Straße;
                tBoxMitHausNr.Text = Convert.ToString(Mit.Mit_HausNr);
                tBoxMitPLZ.Text = Convert.ToString(Mit.Mit_PLZ);
                tBoxMitOrt.Text = Mit.Mit_Ort;
                //DateMit.Value = mit.Mit_GDat;
                cBoxMitAbt.Text = Convert.ToString(Mit.Mit_Abt_ID +1);
                cBoxMitFunk.Text = Convert.ToString(Mit.Mit_F_ID +1);
                cBoxMitRolle.Text = Convert.ToString(Mit.Mit_R_ID + 1);
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


            try
            {
                MverDetailMitarbeiter.Visible = false;
                Mit.Mit_Name = tBoxMitName.Text;
                Mit.Mit_VName = tBoxMitVName.Text;
                Mit.Mit_Mail = tBoxMitEmail.Text;
                Mit.Mit_Ort = tBoxMitOrt.Text;
                Mit.Mit_GDat = DateMit.Value;
                Mit.Mit_HausNr = Convert.ToInt16(tBoxMitHausNr.Text);
                Mit.Mit_PLZ = Convert.ToInt16(tBoxMitPLZ.Text);
                Mit.Mit_Straße = tBoxMitStraße.Text;
                Mit.Mit_Benutzer = tBoxMitBenutzer.Text;
                Mit.Mit_Mail = tBoxMitEmail.Text;
                Mit.Mit_Pw = tBoxMitPw.Text;
                Mit.Mit_Abt_ID = Convert.ToInt32(cBoxMitAbt.SelectedIndex + 1);
                Mit.Mit_R_ID = Convert.ToInt32(cBoxMitRolle.SelectedIndex + 1);
                Mit.Mit_F_ID = Convert.ToInt32(cBoxMitFunk.SelectedIndex + 1);
                Mit.MitarbeiterSpeichern();
            }
            catch
            {
                return;
            }
        }

        private void butMitAbt_Click(object sender, EventArgs e)
        {
            Abteilung abteilung = new Abteilung(new cAbteilung());
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
            ListenMitNeuladen(true);
            tBoxMitPw.PasswordChar = '*';
            tBoxMitPw.ReadOnly= true;

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
            cBoxMitAbt.Items.Clear();
            cBoxMitRolle.Items.Clear();
            cBoxMitFunk.Items.Clear();
            lBoxMverMitarbeiter.Items.Clear();
            //Abteilung Neu Aufbauen
            foreach (cAbteilung abt in cAbteilung.Abtliste)
            {
                cBoxMitAbt.Items.Add(abt);
            }
            //Rolle Neu Aufbauen
            foreach (cRolle r in cRolle.RListe)
            {
                cBoxMitRolle.Items.Add(r);
            }
            //Funktion Neu Aufbauen
            foreach (cFunktion f in cFunktion.FListe)
            {
                cBoxMitFunk.Items.Add(f);
            }
            foreach (cMitarbeiter mit in cMitarbeiter.MitListe)
            {
                lBoxMverMitarbeiter.Items.Add(mit);
            }
        }

        private void MverDetailMitarbeiter_Paint(object sender, PaintEventArgs e)
        {

        }

        private void butMitPwAnzeigen_Click(object sender, EventArgs e)
        {
            if (tBoxMitPw.PasswordChar == '*')
            {
                tBoxMitPw.PasswordChar = '\0';
            }
            else
            {
                tBoxMitPw.PasswordChar = '*';
            }
        }

        private void herfMitPwÄndern_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tBoxMitPw.ReadOnly= false;
        }

        private void herfMitLöschen_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            mitBestätigungLöschen.Visible = true;
        }

        private void butMitbestätigen_Click(object sender, EventArgs e)
        {
            mitBestätigungLöschen.Visible = false;
            Mit = (cMitarbeiter)lBoxMverMitarbeiter.SelectedItem;
            if (Mit != null)
            {
                Mit.MItarbeiterLöschen();
                mitBestätigungLöschen.Visible = false;
                ListenMitNeuladen(true);
            }
            else
            {
                return;
            }
        }
    }
}
