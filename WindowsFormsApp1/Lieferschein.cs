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
    public partial class Lieferschein : Form
    {
        cLieferschein Ls;
        public Lieferschein(cLieferschein ls)   
        {
            InitializeComponent();
            this.Ls = ls;
        }

        private void butLsNeu_Click(object sender, EventArgs e)
        {
            Ls.LS_B_ID = Convert.ToInt16(tBoxLsBId.Text);
            Ls.LS_BearbeitetVon_ID = Convert.ToInt32(cBoxLsBearbeitetVon.SelectedIndex);
            DateTime LsDate;
            LsDate = DateTime.Now;
            Ls.LS_Datum = Convert.ToString(LsDate);
            Ls.LS_Bearbeitet = false;
            Ls.LieferscheinSpeichern();
            Console.WriteLine("Lieferschein wird gespeichert");

            Liefermenge liefermenge = new Liefermenge(new cLiefermenge());
            liefermenge.ShowDialog();
        }

        private void Lieferschein_Load(object sender, EventArgs e)
        {
            lBoxladenLaden(true);
        }
            
        public void lBoxladenLaden(bool ListNeuLaden)
        {
            if (ListNeuLaden)
            {
                try
                {
                    cBestellung.BestellungLaden();
                    cMitarbeiter.MitarbeiterLaden();
                }
                catch (MySqlException ex)
                {

                    Console.WriteLine("Fehler beim Laden: " + ex.Message);
                }
            }
            //Alle Boxen leeren

            lBoxLsBgeliefert.Items.Clear();
            cBoxLsBearbeitetVon.Items.Clear();

            //ComoBox für Lager neu Aufbauen
            foreach (cBestellung bst in cBestellung.BstListe)
            {
                lBoxLsBgeliefert.Items.Add(bst);
            };
            foreach (cMitarbeiter mit in cMitarbeiter.MitListe)
            {
                cBoxLsBearbeitetVon.Items.Add(mit);
            }
            
        }

        private void lBoxLsBgeliefert_SelectedIndexChanged(object sender, EventArgs e)
        {
            cBestellung bst = (cBestellung)lBoxLsBgeliefert.SelectedItem;
            if (bst != null)
            {
                tBoxLsBId.Text = Convert.ToString(bst.B_ID);
                tBoxLsbDatum.Text = Convert.ToString(bst.B_Datum);
            }
            else
            {
                return;
            }
        }

        //public void lBoxLsBgeliefert_SelectedIndexChanged(object sender, EventArgs e)
        //{

        //    bst = (cBestellung)lBoxLsBgeliefert.SelectedItem;
        //    if (bst != null)
        //    {
        //        tBoxMitVName.Text = Mit.Mit_VName;
        //        tBoxMitName.Text = Mit.Mit_Name;
        //        tBoxMitStraße.Text = Mit.Mit_Straße;
        //        tBoxMitHausNr.Text = Convert.ToString(Mit.Mit_HausNr);
        //        tBoxMitPLZ.Text = Convert.ToString(Mit.Mit_PLZ);
        //        tBoxMitOrt.Text = Mit.Mit_Ort;
        //        //DateMit.Value = mit.Mit_GDat;
        //        tBoxMitEmail.Text = Mit.Mit_Mail;
        //        tBoxMitBenutzer.Text = Mit.Mit_Benutzer;
        //        tBoxMitPw.Text = Mit.Mit_Pw;
        //        cBoxMitAbt.SelectedItem = Mit.Mit_Abt_ID;
        //    }
        //    else
        //    {
        //        return;
        //    }
        //}
    }
}
