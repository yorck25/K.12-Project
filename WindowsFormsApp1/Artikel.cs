﻿using MySql.Data.MySqlClient;
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
    public partial class Artikel : Form
    {
        public Artikel()
        {
            InitializeComponent();
        }

        public void ArtComEinNeuLaden(bool EinNeuLaden)
        {
            if (EinNeuLaden)
            {
                try
                {
                    cEinheit.EinheitLaden();
                }
                catch (MySqlException ex)
                {

                    Console.WriteLine("Fehler beim Laden: " + ex.Message);
                }
            }
            cBoxAbtEinheit.Items.Clear();
            foreach (cEinheit ein in cEinheit.EinListe)
            {
                cBoxAbtEinheit.Items.Add(ein);
            }
        }

        private void Artikel_Load(object sender, EventArgs e)
        {
            ArtComEinNeuLaden(true);
        }

        private void lBoxArt_SelectedIndexChanged(object sender, EventArgs e)
        {
            AbtneueAbteilung.Visible = true;
            butArtSpeichern.Visible= true;
            butArtErstellen.Visible = false;
        }

        private void herfArtNeu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbtneueAbteilung.Visible = true;
            butArtErstellen.Visible= true;
            butArtSpeichern.Visible = false;
        }

        private void butArtErstellen_Click(object sender, EventArgs e)
        {
            AbtneueAbteilung.Visible= false;
        }

        private void butArtSpeichern_Click(object sender, EventArgs e)
        {
            AbtneueAbteilung.Visible = false;
        }

        private void herfArtneueEinheit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Einheit einheit = new Einheit(new cEinheit());
            einheit.Show();
        }
    }
}
