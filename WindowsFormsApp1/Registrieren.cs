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

        public void Registrieren_Load(object sender, EventArgs e)
        {
            cBoxenRegLaden(true);
        }

        public void cBoxenRegLaden(bool NeuLaden)
        {
            if(NeuLaden)
            {
                cAbteilung.AbteilungLaden();
                cRolle.RolleLaden();
                cFunktion.FunktionLaden();
            }

            cBoxRegAbt.Items.Clear();
            cBoxRegAbr.Items.Clear();
            cBoxRegFunk.Items.Clear();
            cBoxRegRolle.Items.Clear();

            foreach(cAbteilung abt in cAbteilung.Abtliste)
            {
                cBoxRegAbt.Items.Add(abt);
            }

            foreach(cFunktion f in cFunktion.FListe)
            {
                cBoxRegFunk.Items.Add(f);
            }

            foreach(cRolle r in cRolle.RListe)
            {
                cBoxRegRolle.Items.Add(r);
            }
        }

        private void herfRegVorhanden_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = new Login(new cLogin());
            login.Show();
        }

        private void butRegErstellen_Click(object sender, EventArgs e)
        {
            //cMitarbeiter.MitarbeiterSpeichern();

            Mit.Mit_VName = tBoxRegVname.Text;
            Mit.Mit_Name = tBoxRegName.Text;
            Mit.Mit_Straße = tBoxRegStraße.Text;
            Mit.Mit_HausNr = Convert.ToInt16(tBoxRegHausNr.Text);
            Mit.Mit_PLZ = Convert.ToInt16(tBoxRegPLZ.Text);
            Mit.Mit_Ort = tBoxRegOrt.Text;
            Mit.Mit_GDat = DateReg.Value;
            Mit.Mit_Mail = tBoxRegEmail.Text;
            Mit.Mit_Benutzer = tBoxRegUname.Text;
            Mit.Mit_Pw = tBoxRegPw.Text;
            Mit.Mit_Abt_ID = Convert.ToInt32(cBoxRegAbt.SelectedIndex + 1);
            Mit.Mit_R_ID = Convert.ToInt32(cBoxRegRolle.SelectedIndex + 1);
            Mit.Mit_F_ID = Convert.ToInt32(cBoxRegFunk.SelectedIndex + 1);
            Mit.Mit_Abr_ID = Convert.ToInt32(cBoxRegAbr.SelectedIndex + 1);

            if (string.IsNullOrEmpty(tBoxRegName.Text))
            {
                Console.WriteLine("Keine Eingabe");
            }
            else
            {
                Mit.MitarbeiterSpeichern();
                Console.WriteLine("Mitarbeiter wird gespeichert");
                tBoxRegName.Clear();

            }
        }
    }
}
