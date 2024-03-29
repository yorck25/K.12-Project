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
using System.Xml.Linq;

namespace WindowsFormsApp1
{
    public partial class Lieferant : Form
    {
        cLieferant l;
        public Lieferant(cLieferant l)
        {
            InitializeComponent();
            this.l = l;
        }

        private void herfLLöschen_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lBestätigungLöschen.Visible = true;
        }

        private void herfLNeu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tBoxLAnrede.Clear();
            tBoxLName.Clear();
            tBoxLMail.Clear();
            tBoxLHausNr.Clear();
            tBoxLFax.Clear();
            tBoxLDurch.Clear();
            tBoxLOrt.Clear();
            tBoxLStrasse.Clear();
            tBoxLPartner.Clear();
            tBoxLTel.Clear();
            tBoxLPost.Clear();
            tBoxLPLZ.Clear();
            tBoxLNotiz.Clear();
            tBoxLBlz.Clear();
            lDetail.Visible = true;
        }

        private void lBoxLieferant_SelectedIndexChanged(object sender, EventArgs e)
        {
            lDetail.Visible = true;

            l = (cLieferant)lBoxLieferant.SelectedItem;
            if (l != null)
            {
                tBoxLAnrede.Text = l.L_Anrede;
                tBoxLName.Text = l.L_Name;
                tBoxLStrasse.Text = l.L_Strasse;
                tBoxLHausNr.Text = Convert.ToString(l.L_HausNr);
                tBoxLPLZ.Text = Convert.ToString(l.L_PLZ);
                tBoxLOrt.Text = l.L_Ort;
                tBoxLPost.Text = l.L_Postfach;
                tBoxLTel.Text = Convert.ToString(l.L_Tel);
                tBoxLFax.Text = Convert.ToString(l.L_Fax);
                tBoxLBlz.Text = Convert.ToString(l.L_BLZ);
                tBoxLPartner.Text = l.L_Anspr;
                tBoxLMail.Text = l.L_Mail;
                tBoxLDurch.Text = Convert.ToString(l.L_Durchwahl);
                tBoxLNotiz.Text = l.L_Ntz;
            }
            else
            {
                return;
            }
        }

        public void butLErstellen_Click(object sender, EventArgs e)
        {
            try
            {
                l.L_Anrede = tBoxLAnrede.Text;
                l.L_Name = tBoxLName.Text;
                l.L_Strasse = tBoxLStrasse.Text;
                l.L_HausNr = Convert.ToInt32(tBoxLHausNr.Text);
                l.L_PLZ = Convert.ToInt32(tBoxLPLZ.Text);
                l.L_Ort = tBoxLOrt.Text;
                l.L_Postfach = tBoxLPost.Text;
                l.L_Tel = Convert.ToInt32(tBoxLTel.Text);
                l.L_Fax = Convert.ToInt32(tBoxLFax.Text);
                l.L_BLZ = Convert.ToInt32(tBoxLBlz.Text);
                l.L_Anspr = tBoxLPartner.Text;
                l.L_Mail = tBoxLMail.Text;
                l.L_Durchwahl = Convert.ToInt32(tBoxLDurch.Text);
                l.L_Ntz = tBoxLNotiz.Text;
                l.L_IBAN = tBoxLiban.Text;
                l.L_Geloescht = false;
                l.LieferantSpeichern();
                Console.WriteLine("Lager wird gespeichert");
                tBoxLAnrede.Clear();
                tBoxLName.Clear();
                tBoxLMail.Clear();
                tBoxLHausNr.Clear();
                tBoxLFax.Clear();
                tBoxLDurch.Clear();
                tBoxLOrt.Clear();
                tBoxLStrasse.Clear();
                tBoxLPartner.Clear();
                tBoxLTel.Clear();
                tBoxLPost.Clear();
                tBoxLPLZ.Clear();
                tBoxLNotiz.Clear();
                tBoxLBlz.Clear();
                tBoxLiban.Clear();

                lBoxLieferant.Items.Clear();
                foreach (cLieferant l in cLieferant.LListe)
                {
                    lBoxLieferant.Items.Add(l);
                }
            }
            catch { lvwFehler.Visible = true; }
        }   

    public void LieferantenListeLaden(bool LiefNeuLaden)
    {
        if (LiefNeuLaden)
        {
            try
            {
                cLieferant.LieferantLaden();
            }
            catch (MySqlException ex)
            {

                Console.WriteLine("Fehler beim Laden: " + ex.Message);
            }
        }
        lBoxLieferant.Items.Clear();
        foreach (cLieferant l in cLieferant.LListe)
        {
            lBoxLieferant.Items.Add(l);
        }
    }

    private void Lieferant_Load(object sender, EventArgs e)
    {
        LieferantenListeLaden(true);
    }

    private void butLbestätigen_Click(object sender, EventArgs e)
    {
        l = (cLieferant)lBoxLieferant.SelectedItem;
        if (l != null)
        {
            l.LieferantLöschen();
            lBestätigungLöschen.Visible = false;
            LieferantenListeLaden(true);
        }
        else
        {
            lvwFehler.Visible = true;
            return;
        }
    }

        private void butLvwFehler_Click(object sender, EventArgs e)
        {
            lvwFehler.Visible = false;
        }
    }
}
