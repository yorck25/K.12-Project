using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class cLogin
    {
        public static List<cLogin> loginList = new List<cLogin>();

        public bool Anmelden(string Login_Email,string Login_Passwort )
        {

            using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["localsql"].ConnectionString))
            {
                string query = "SELECT COUNT(*) FROM mitarbeiter WHERE Mit_Benutzer=@Benutzername AND Mit_Pw=@Passwort";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Benutzername", Login_Email);
                cmd.Parameters.AddWithValue("@Passwort", Login_Passwort);
                conn.Open();
                int result = Convert.ToInt32(cmd.ExecuteScalar());
                if (result > 0)
                {
                    Hauptmenu hauptmenu = new Hauptmenu(new cNachricht());
                    hauptmenu.Show();
                    return true;
                }
                else
                {
                    return false;
                }

            }
        }
    }
}
