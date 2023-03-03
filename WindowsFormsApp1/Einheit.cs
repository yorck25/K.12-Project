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
    public partial class Einheit : Form
    {
        cEinheit ein;

        public Einheit(cEinheit ein)
        {
            InitializeComponent();
            this.ein = ein;
        }

        private void herfEinNeu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EinDetail.Visible = true;
            butEinErstellen.Visible = true;
            butEinSpeichern.Visible = false;
        }

        private void Einheit_Load(object sender, EventArgs e)
        {
            EinheitListeLaden(true);
        }

        private void lBoxEinheit_SelectedIndexChanged(object sender, EventArgs e)
        {
            EinDetail.Visible = true;
            butEinSpeichern.Visible = true;
            butEinErstellen.Visible = false;

            cEinheit ein = (cEinheit)lBoxEinheit.SelectedItem;
            if (ein != null)
            {
                tBoxEinBez.Text = ein.Ein_Bez;
            }
            else
            {
                return;
            }
        }

        public void EinheitListeLaden(bool FNeuLaden)
        {
            if (FNeuLaden)
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
            lBoxEinheit.Items.Clear();
            foreach (cEinheit ein in cEinheit.EinListe)
            {
                lBoxEinheit.Items.Add(ein);
            }
        }

        private void butEinSpeichern_Click(object sender, EventArgs e)
        {
            ein.Ein_Bez = tBoxEinBez.Text;

            if (string.IsNullOrEmpty(tBoxEinBez.Text))
            {
                Console.WriteLine("Keine Eingabe");
            }
            else
            {
                ein.EinheitAktuell();
                Console.WriteLine("Kst wird gespeichert");
                tBoxEinBez.Clear();
                EinDetail.Visible = false;

                lBoxEinheit.Items.Clear();
                foreach (cEinheit ein in cEinheit.EinListe)
                {
                    lBoxEinheit.Items.Add(ein);
                }
            }
        }
    }
}
