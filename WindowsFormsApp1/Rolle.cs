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
            r.RolleLaden();
            RolleListeLaden(true);
        }

        public void RolleListeLaden(bool RNeuLaden)
        {
            if (RNeuLaden)
            {
                try
                {
                    cKostenstelle.AlleLaden();
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

            if (string.IsNullOrEmpty(tBoxRBez.Text))
            {
                Console.WriteLine("Keine Eingabe");
            }
            else
            {
                r.RolleSpeichern();
                Console.WriteLine("Kst wird gespeichert");
                tBoxRBez.Clear();
                RDetail.Visible = false;
                RMitProAbt.Visible = false;

                lBoxR.Items.Clear();
                foreach (cRolle r in cRolle.RListe)
                {
                    lBoxR.Items.Add(r);
                }
            }
        }

        private void herfRNeue_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RDetail.Visible = true;
            RMitProAbt.Visible = false;
        }

        private void lBoxR_SelectedIndexChanged(object sender, EventArgs e)
        {
            RDetail.Visible = true;
            RMitProAbt.Visible = true;
        }
    }
}
