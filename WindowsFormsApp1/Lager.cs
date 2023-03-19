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
    public partial class Lager : Form
    {
        cLager lvw;

        public Lager(cLager lvw)
        {
            InitializeComponent();
            this.lvw = lvw;
        }

        private void Lager_Load(object sender, EventArgs e)
        {
            LagerListeLaden(true);
        }

        public void LagerListeLaden(bool LagerNeuLaden)
        {
            if (LagerNeuLaden)
            {
                try
                {
                    cLager.LagerLaden();
                }
                catch (MySqlException ex)
                {

                    Console.WriteLine("Fehler beim Laden: " + ex.Message);
                }
            }
            lBoxLagerort.Items.Clear();
            foreach (cLager lvw in cLager.LVWListe)
            {
                lBoxLagerort.Items.Add(lvw);
            }
        }

        public void butLVWErstellen_Click(object sender, EventArgs e)
        {
            lvw.LVW_Bez = tBoxLVWBez.Text;
            lvw.LVW_Ort = tBoxLVWOrt.Text;
            lvw.LVW_PLZ = tBoxLVWPLZ.Text;
            lvw.LVW_Str = tBoxLVWStr.Text;

            if (string.IsNullOrEmpty(tBoxLVWBez.Text))
            {
                Console.WriteLine("Keine Eingabe");
            }
            else
            {
                lvw.LagerSpeichern();
                Console.WriteLine("Lager wird gespeichert");
                tBoxLVWBez.Clear();
                tBoxLVWOrt.Clear();
                tBoxLVWStr.Clear();
                tBoxLVWPLZ.Clear();
                LVWDetail.Visible = false;

                lBoxLagerort.Items.Clear();
                foreach (cLager lvw in cLager.LVWListe)
                {
                    lBoxLagerort.Items.Add(lvw);
                }
            }
        }

        private void herfLVWNeu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lBoxLagerort.ClearSelected();
            Refresh();
            tBoxLVWBez.Clear();
            tBoxLVWOrt.Clear();
            tBoxLVWPLZ.Clear();
            tBoxLVWStr.Clear();

            LVWDetail.Visible = true;
        }

        private void lBoxLagerort_SelectedIndexChanged(object sender, EventArgs e)
        {
            LVWDetail.Visible = true;

            lvw = (cLager)lBoxLagerort.SelectedItem;
            if (lvw != null)
            {
                tBoxLVWBez.Text = lvw.LVW_Bez;
                tBoxLVWOrt.Text = lvw.LVW_Ort;
                tBoxLVWPLZ.Text = lvw.LVW_PLZ;
                tBoxLVWStr.Text = lvw.LVW_Str;
            }
            else
            {
                return;
            }
        }

        private void herfLvwLöschen_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lvwBestätigungLöschen.Visible = true;
        }

        private void butLvwbestätigen_Click(object sender, EventArgs e)
        {
            lvw = (cLager)lBoxLagerort.SelectedItem;
            if (lvw != null)
            {

                lvw.LagerLöschen();
                lvwBestätigungLöschen.Visible = false;
                LagerListeLaden(true);
            }
            else
            {
                return;
            }
        }
    }
}
