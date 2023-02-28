using MetroFramework.Controls;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WindowsFormsApp1
{
    public partial class Login : Form
    {

        cLogin l;

        public Login(cLogin l)
        {
            this.l = l;
            InitializeComponent();
        }

        private void butLoginPasAnzeigen_Click(object sender, EventArgs e)
        {
            if (tBoxLoginPas.PasswordChar == '*')
            {
                tBoxLoginPas.PasswordChar = '\0';
            }
            else
            {
                tBoxLoginPas.PasswordChar = '*';
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            tBoxLoginEmail.Clear();
            tBoxLoginPas.Clear();
            tBoxLoginPas.PasswordChar = '*';
        }

        private void butLoginReg_Click(object sender, EventArgs e)
        {
            Registrieren registrieren = new Registrieren(new cMitarbeiter());
            this.Hide();
            registrieren.Show();

        }

        public void butLoginAnmelden_Click(object sender, EventArgs e)
        {
            cLogin l = new cLogin();
            // l.Login_Email = tBoxLoginEmail.Text;
            // l.Login_Passwort = tBoxLoginPas.Text;
            l.Anmelden(tBoxLoginEmail.Text, tBoxLoginPas.Text);
           /* if (string.IsNullOrEmpty(tBoxLoginEmail.Text))
                {
                Console.WriteLine("Keine vollsätndige Eingabe");
            }
            else
            {
                l.Anmelden();
                Console.WriteLine("Login");
            }*/


        }
    }
}
