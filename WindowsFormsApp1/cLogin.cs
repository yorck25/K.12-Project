using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class cLogin
    {
        public static List<cLogin> loginList = new List<cLogin>();

        public string Login_Email { get; set; }
        public string Login_Passwort { get; set; }

        public void Anmelden()
        {
            MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["localsql"].ConnectionString);
            conn.Open();
            
        }

        public void LoginWerte(MySqlCommand cmd)
        { 
            cmd.Parameters.AddWithValue("@Login_Email", this.Login_Email);
            cmd.Parameters.AddWithValue("@Login_Pw", this.Login_Passwort);

            cmd.Parameters.AddWithValue("@Mit_Name", "test");
        }
    }
}
