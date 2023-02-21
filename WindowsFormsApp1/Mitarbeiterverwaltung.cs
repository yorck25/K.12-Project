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
    public partial class Mitarbeiterverwaltung : Form
    {
        public Mitarbeiterverwaltung()
        {
            InitializeComponent();
        }

        private void lBoxMverMitarbeiter_SelectedIndexChanged(object sender, EventArgs e)
        {
            MverDetailMitarbeiter.Visible= true;
        }

        private void butMverDetailSchließen_Click(object sender, EventArgs e)
        {
            MverDetailMitarbeiter.Visible = false;
        }

        private void butMitAbt_Click(object sender, EventArgs e)
        {
            Abteilung abteilung= new Abteilung(new cAbteilung());
            abteilung.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Funktion funktion = new Funktion(new cFunktion());
            funktion.Show();
        }

        private void butMitRolle_Click(object sender, EventArgs e)
        {
            Rolle rolle = new Rolle(new cRolle());
            rolle.Show();
        }
    }
}
