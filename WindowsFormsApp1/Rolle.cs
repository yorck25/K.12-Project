using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WindowsFormsApp1
{
    public partial class Rolle : Form
    {
        cRolle r;
        public Rolle(cRolle r)
        {
            this.r = r;
            InitializeComponent();
        }

        private void Rolle_Load(object sender, EventArgs e)
        {
            cRolle.RolleLaden();
            RolleListeLaden(true);
        }

        public void RolleListeLaden(bool RNeuLaden)
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
            lBoxR.Items.Clear();
            foreach (cRolle r in cRolle.RListe)
            {
                lBoxR.Items.Add(r);
            }
        }

        private void butRSpeichern_Click(object sender, EventArgs e)
        {
            r.R_Bez = tBoxRBez.Text;
            r.R_Geloescht = false;

                if (string.IsNullOrEmpty(tBoxRBez.Text))
                {
                    rFehler.Visible = true;
                    Console.WriteLine("Keine Eingabe");

                }
                else
                {
                    r.RolleSpeichern();
                    Console.WriteLine("Rolle wird gespeichert");
                    tBoxRBez.Clear();
                    RDetail.Visible = false;
                    RMitProAbt.Visible = false;
                    RolleListeLaden(true);
                }
            //this.Close();
        }

        private void herfRNeue_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lBoxR.ClearSelected();
            Refresh();
            tBoxRBez.Clear();
            RDetail.Visible = true;
            RMitProAbt.Visible = false;
        }

        private void lBoxR_SelectedIndexChanged(object sender, EventArgs e)
        {
            RDetail.Visible = true;
            RMitProAbt.Visible = true;
            r = (cRolle)lBoxR.SelectedItem;
            if (r != null)
            {
                tBoxRBez.Text = r.R_Bez;
            }
            else
            {
                return;
            }
        }

        private void herfRMit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Mitarbeiterverwaltung mitarbeiterverwaltung = new Mitarbeiterverwaltung(new cMitarbeiter());
            mitarbeiterverwaltung.Show();
        }

        private void herfRLöschen_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            rBestätigungLöschen.Visible = true;
        }

        private void butRbestätigen_Click(object sender, EventArgs e)
        {
            r = (cRolle)lBoxR.SelectedItem;
            if (r != null)
            {
                r.R_Geloescht = true;
                r.RolleLöschen();
                rBestätigungLöschen.Visible = false;
                RolleListeLaden(true);
            }
            else
            {
                rFehler.Visible = true;
                return;
            }
        }

        private void butRFehler_Click(object sender, EventArgs e)
        {
            rFehler.Visible = false;
        }
    }
}
