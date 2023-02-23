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
        SqlCommand cmd;
        SqlConnection conn;
        SqlDataReader dr;

        public Login()
        {
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
            this.Close();
            registrieren.Show();

        }

        private void butLoginAnmelden_Click(object sender, EventArgs e)
        {

            try
            {
                MySqlConnection con = new MySqlConnection("server=localhost;user=root;database=logindaten;port=3306;password=");
                MySqlCommand com = new MySqlCommand("SELECT Mit_Benutzer,Mit_Pw FROM mitarbeiter WHERE Mit_Benutzer = '" + tBoxLoginEmail + "' AND Mit_Pw = '" + tBoxLoginPas.Text + "'", con);
                con.Open();

                if (con.State == ConnectionState.Open)
                {
                    MySqlDataReader dtr = com.ExecuteReader();

                    while (dtr.Read())
                    {
                        cLogin l = new cLogin();
                        l.Login_Email = dtr["Mit_Benutzer"].ToString();
                        l.Login_Passwort = dtr["Mit_Pw"].ToString();
                        if (l.Login_Email == tBoxLoginEmail.Text && l.Login_Passwort == tBoxLoginPas.Text)
                        {
                            Hauptmenu hauptmenu= new Hauptmenu();
                            hauptmenu.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid credentials!\nPlease enter a valid username and password to continue.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
               Console.WriteLine("Erorr", "Error::::" + ex);
            }

        }
    }
}
