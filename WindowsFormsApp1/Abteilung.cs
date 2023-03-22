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
    public partial class Abteilung : Form 
    { 
    
        cAbteilung abt;
        public Abteilung(cAbteilung abt)
        {
            this.abt = abt;
            InitializeComponent();
        }

        private void lBoxAbt_SelectedIndexChanged(object sender, EventArgs e)
        {
           
                AbtDetail.Visible= true;
                AbtMitProAbt.Visible = true;
                abt = (cAbteilung)lBoxAbt.SelectedItem;
                if (abt != null)
                {
                    tBoxAbtBez.Text = abt.Abt_Bez;
                    cBoxAbtKst.Text = Convert.ToString(abt.Abt_Kst_ID);
                }
                else
                {
                    return;
                }
        }

        private void herfAbtMitarebiter_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Mitarbeiterverwaltung mitarbeiterverwaltung = new Mitarbeiterverwaltung(new cMitarbeiter());
            mitarbeiterverwaltung.Show();
        }

        private void lBoxAbtMit_SelectedIndexChanged(object sender, EventArgs e)
        {
            herfAbtMitarebiter.Visible= true;
        }

        private void herfAbtKst_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Kostenstelle kostenstelle= new Kostenstelle(new cKostenstelle());
            kostenstelle.Show();
        }

        public void AbtComKstNeuLaden(bool AbtNeuLaden)
        {
            if (AbtNeuLaden)
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
            cBoxAbtKst.Items.Clear();
            foreach (cKostenstelle kst in cKostenstelle.liste)
            {
                cBoxAbtKst.Items.Add(kst);
            }
        }

        public void Abteilung_Load(object sender, EventArgs e)
        {
            AbtComKstNeuLaden(true);
            lBoxAbtNeuLaden(true);
        }

        public void lBoxAbtNeuLaden(bool lBoxAbtNeuladen)
        {
            if (lBoxAbtNeuladen)
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
            lBoxAbt.Items.Clear();
            foreach (cAbteilung abt in cAbteilung.Abtliste)
            {
                lBoxAbt.Items.Add(abt);
            }
        }

        public void butAbtBearbeiten_Click(object sender, EventArgs e)
        {
            try
            {
                abt.Abt_Geloescht = false;
                abt.Abt_Bez = tBoxAbtBez.Text;
                abt.Abt_Kst_ID = Convert.ToInt32(cBoxAbtKst.SelectedIndex + 1);
                Console.WriteLine(abt.Abt_Kst_ID);
                abt.Spiechern();
                Console.WriteLine("Abteilung wird gespeichert");
                lBoxAbtNeuLaden(true);
                tBoxAbtBez.Clear();
                cBoxAbtKst.SelectedIndex = 0 -1;
            }
            catch 
            {
                AbtFehler.Visible = true;
            }
                
        }
        

        private void cBoxAbtKst_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void herfAbtNeu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbtDetail.Visible = true;
            AbtMitProAbt.Visible = false;
            tBoxAbtBez.Clear() ;
            cBoxAbtKst.Text = "0";
            lBoxAbt.ClearSelected();
        }

        private void herfAbtLöschen_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            abtBestätigungLöschen.Visible = true;
        }

        private void butAbtbestätigen_Click(object sender, EventArgs e)
        {
            try 
            { 
                abtBestätigungLöschen.Visible = false;
                abt = (cAbteilung)lBoxAbt.SelectedItem;
                if (abt != null)
                {
                    abt.AbteilungLöschen();
                    abtBestätigungLöschen.Visible = false;
                    lBoxAbtNeuLaden(true);
                }
            }
            catch { AbtFehler.Visible = true; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbtFehler.Visible = false;
        }
    }
}
