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
        public Abteilung()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lBoxAbt_SelectedIndexChanged(object sender, EventArgs e)
        {
            AbtDetail.Visible= true;
        }

        private void herfAbtMitarebiter_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Mitarbeiterverwaltung mitarbeiterverwaltung = new Mitarbeiterverwaltung();
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
    }
}
