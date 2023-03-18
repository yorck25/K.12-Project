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
    public partial class Funktion : Form
    {

        cFunktion f;

        public Funktion(cFunktion f)
        {
            this.f = f; 
            InitializeComponent();
        }

        private void herfFNeue_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lBoxF.ClearSelected();
            Refresh();
            tBoxFBez.Clear();
            FDetail.Visible = true;
            FMitProAbt.Visible = false;
        }

        private void lBoxF_SelectedIndexChanged(object sender, EventArgs e)
        {
            FDetail.Visible = true;
            FMitProAbt.Visible = true;
            f = (cFunktion)lBoxF.SelectedItem;
            if (f != null)
            {
                tBoxFBez.Text = f.F_Bez;
            }
            else
            {
                return;
            }
        }

        private void Funktion_Load(object sender, EventArgs e)
        {
            cFunktion.FunktionLaden();
            FunktionListeLaden(true);
        }

        public void FunktionListeLaden(bool FNeuLaden)
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
            lBoxF.Items.Clear();
            foreach(cFunktion f in cFunktion.FListe)
            {
                lBoxF.Items.Add(f);
            }
        }

        private void butFSpeichern_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(tBoxFBez.Text))
            {
                Console.WriteLine("Keine Eingabe");
            }
            else
            {
                f.F_Bez = tBoxFBez.Text;
                f.FunktionSpeichern();
                Console.WriteLine("Kst wird gespeichert");
                tBoxFBez.Clear();
                FDetail.Visible = false;
                FMitProAbt.Visible = false;

                lBoxF.Items.Clear();
                foreach (cFunktion f in cFunktion.FListe)
                {
                    lBoxF.Items.Add(f);
                }
            }
        }

        private void herfFLöschen_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fBestätigungLöschen.Visible = true;
        }

        private void butRbestätigen_Click(object sender, EventArgs e)
        {
            fBestätigungLöschen.Visible = false;
            f = (cFunktion)lBoxF.SelectedItem;
            if (f != null)
            {
                f.FunktionLöschen();
                fBestätigungLöschen.Visible = false;
                FunktionListeLaden(true);
            }
            else
            {
                return;
            }
        }
    }
}
