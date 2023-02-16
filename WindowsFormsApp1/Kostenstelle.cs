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
        }

        private void herfKstAbt_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Abteilung abteilung = new Abteilung();
            abteilung.Show();
        }

        private void lBoxKstAbt_SelectedIndexChanged(object sender, EventArgs e)
        {
            herfKstAbt.Visible= true;
        }

        private void butKstSpeichern_Click(object sender, EventArgs e)
        {
            kst.Kst_Bez = tBoxKstBez.Text;

            try
            {

                if(string.IsNullOrEmpty(tBoxKstBez.Text))
                {
                    Console.WriteLine("Keine Eingabe");
                    return;
                }
                else
                {
                kst.Spiechern();
                Console.WriteLine("Kst wird gespeichert");
                tBoxKstBez.Clear();
                KstDetail.Visible= false;
                AbtMitProAbt.Visible= false;

                
                return;
                }
            }
            catch(MySqlException ex)
            {
                Console.WriteLine("KSt Speichern Fehler: " + ex);
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
    }
}
