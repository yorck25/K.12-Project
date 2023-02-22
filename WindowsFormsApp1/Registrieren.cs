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
    public partial class Registrieren : Form
    {
        cMitarbeiter Mit;
        public Registrieren(cMitarbeiter Mit)
        {
            InitializeComponent();
            this.Mit = Mit;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void Registrieren_Load(object sender, EventArgs e)
        {

        }

        private void herfRegVorhanden_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = new Login();
            login.Show();
        }

        private void butRegErstellen_Click(object sender, EventArgs e)
        {
            //cMitarbeiter.MitarbeiterSpeichern();

            Mit.Mit_VName = tBoxRegVname.Text;
            Mit.Mit_Name = tBoxRegName.Text;
            Mit.Mit_Straße = tBoxRegStraße.Text;
            Mit.Mit_HausNr = tBoxRegHausNr.Text;
            Mit.Mit_PLZ = Convert.ToInt16(tBoxRegPLZ.Text);
            Mit.Mit_Ort = tBoxRegOrt.Text;
            Mit.Mit_GDat = DateReg.Value;


            Console.WriteLine(Mit.Mit_GDat);

            if (string.IsNullOrEmpty(tBoxRegName.Text))
            {
                Console.WriteLine("Keine Eingabe");
            }
            else
            {
                Mit.MitarbeiterSpeichern();
                Console.WriteLine("Kst wird gespeichert");
                tBoxRegName.Clear();

            }
        }
    }
}
