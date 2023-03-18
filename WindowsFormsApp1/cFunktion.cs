using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class cFunktion
    {
        public static List<cFunktion> FListe = new List<cFunktion>();

        public long? F_ID { get; set; } = null;
        public string F_Bez { get; set; }
        public bool F_Geloescht { get; set; }

        public string FunktionListe => F_ID + ": " + F_Bez;

        public static void FunktionLaden()
        {
            string sql = "SELECT * FROM funktion";
            MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["localsql"].ConnectionString);

            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();

            cFunktion.FListe = new List<cFunktion>();

            while (rdr.Read())
            {
                cFunktion f= new cFunktion();
                f.F_ID = rdr.GetInt64("F_ID");
                f.F_Bez = rdr.GetString("F_Bez");
                cFunktion.FListe.Add(f);
            }
            rdr.Close();
        }

        public void FunktionSpeichern()
        {
            MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["localsql"].ConnectionString);

            conn.Open();

            if (F_ID.HasValue)
            {
                string sql = "UPDATE funktion SET F_Bez = @F_Bez WHERE F_ID = @F_ID";
                Console.WriteLine("ID:" + this.F_ID);
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                this.FunktionWerteSpeichern(cmd);
                cmd.ExecuteNonQuery();
            }
            else
            {
                string sql = "INSERT INTO funktion (F_Bez, F_Geloescht) VALUES (@F_Bez, @F_Geloescht)";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                this.FunktionWerteSpeichern(cmd);
                cmd.ExecuteNonQuery();
                this.F_ID = cmd.LastInsertedId;
                cFunktion.FListe.Add(this);
            }
            conn.Close();
            return;
        }

        public void FunktionLöschen()
        {
            MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["localsql"].ConnectionString);

            conn.Open();

            try
            {
                string sql = "DELETE FROM funktion WHERE F_ID = @F_ID";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                this.FunktionWerteSpeichern(cmd);
                cmd.ExecuteNonQuery();
                Console.WriteLine("Funktion wird Gelöscht");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            conn.Close();
            return;
        }

        public void FunktionWerteSpeichern(MySqlCommand cmd)
        {       
            cmd.Parameters.AddWithValue("@F_Bez", this.F_Bez);
            cmd.Parameters.AddWithValue("@F_Geloescht", this.F_Geloescht);
            cmd.Parameters.AddWithValue("@F_ID", this.F_ID);
        }
    }
}
