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
    public partial class Kostenstelle : Form
    {
        cKostenstelle kst;

        public Kostenstelle(cKostenstelle kst)
        {
            this.kst = kst;
            InitializeComponent();
        }

        private void lBoxKst_SelectedIndexChanged(object sender, EventArgs e)
        {
                KstDetail.Visible= true;
                AbtMitProAbt.Visible= true;
                herfKstLöschen.Visible= true;

            kst = (cKostenstelle)lBoxKst.SelectedItem;
            if (kst != null)
            {
                tBoxKstBez.Text = kst.Kst_Bez;
            }
            else
            {
                return;
            }
        }

        public void herfKstAbt_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Abteilung abteilung = new Abteilung(new cAbteilung());
            abteilung.Show();
        }

        private void lBoxKstAbt_SelectedIndexChanged(object sender, EventArgs e)
        {
            herfKstAbt.Visible= true;
        }

        public void Listaufbauen(bool NeuLaden)
        {
            if(NeuLaden)
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
            lBoxKst.Items.Clear();
            foreach (cKostenstelle kst in cKostenstelle.liste)
            {
                lBoxKst.Items.Add(kst);
            }
        }

        private void butKstSpeichern_Click(object sender, EventArgs e)
        {
            kst.Kst_Bez = tBoxKstBez.Text;

            try
            {
                kst.Spiechern();
                Console.WriteLine("Kst wird gespeichert");
                tBoxKstBez.Clear();
                KstDetail.Visible = false;
                AbtMitProAbt.Visible = false;
                KstFehlereingabe.Visible = false;
            }
            catch(MySqlException ex)
            {
                Console.WriteLine("fehler" + ex);
            }
              
        }

        private void tBoxKstBez_TextChanged(object sender, EventArgs e)
        {

        }

        private void KstDetail_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AbtMitProAbt_Paint(object sender, PaintEventArgs e)
        {

        }

        private void herfKstNew_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            KstDetail.Visible= true;
        }

        private void Kostenstelle_Load(object sender, EventArgs e)
        {
            Listaufbauen(true);
        }
    }
}
