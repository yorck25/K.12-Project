using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class cLager
    {
        public static List<cLager> LVWListe = new List<cLager>();

        public long? LVW_ID { get; set; } = null;
        public string LVW_Bez { get; set; }
        public string LVW_Ort { get; set; }
        public string LVW_PLZ { get; set; } //In der Datenbank auf INT ändern
        public string LVW_Str { get; set; }

        public string LagerortListe => LVW_ID + ": " + LVW_Bez;

        public static void LagerLaden()
        {
            string sql = "SELECT * FROM lagerverwaltung";
            MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["localsql"].ConnectionString);

            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();

            cLager.LVWListe = new List<cLager>();

            while (rdr.Read())
            {
                cLager lvw = new cLager();
                lvw.LVW_ID = rdr.GetInt64("LVW_ID");
                lvw.LVW_Bez = rdr.GetString("LVW_Bez");
                lvw.LVW_Ort = rdr.GetString("LVW_Ort");
                lvw.LVW_PLZ = rdr.GetString("LVW_PLZ");
                lvw.LVW_Str = rdr.GetString("LVW_Str");
                LVWListe.Add(lvw);
            }
            rdr.Close();
        }

        public void LagerSpeichern()
        {
            MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["localsql"].ConnectionString);

            conn.Open();

            if (LVW_ID.HasValue)
            {
                string sql = "UPDATE lagerverwaltung SET LVW_Bez = @LVW_Bez, LVW_Ort = @LVW_Ort, LVW_PLZ = @LVW_PLZ, LVW_Str = @LVW_Str  WHERE LVW_ID = @LVW_ID";
                Console.WriteLine("ID:" + this.LVW_ID);
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                this.LagerWerteSpeichern(cmd);
                cmd.ExecuteNonQuery();
            }
            else
            {
                string sql = "INSERT INTO lagerverwaltung (LVW_Bez, LVW_Ort, LVW_PLZ, LVW_Str) VALUES (@LVW_Bez, @LVW_Ort, @LVW_PLZ, @LVW_Str)";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                this.LagerWerteSpeichern(cmd);
                cmd.ExecuteNonQuery();
                this.LVW_ID = cmd.LastInsertedId;
                cLager.LVWListe.Add(this);
            }
            conn.Close();
            return;
        }

        public void LagerLöschen()
        {
            MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["localsql"].ConnectionString);

            conn.Open();

            try
            {
                string sql = "DELETE FROM lagerverwaltung WHERE LVW_ID = @LVW_ID";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                this.LagerWerteSpeichern(cmd);
                cmd.ExecuteNonQuery();
                Console.WriteLine("Lager wird Gelöscht");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            conn.Close();
            return;
        }

        public void LagerWerteSpeichern(MySqlCommand cmd)
        {
            cmd.Parameters.AddWithValue("@LVW_Bez", this.LVW_Bez);
            cmd.Parameters.AddWithValue("@LVW_Ort", this.LVW_Ort);
            cmd.Parameters.AddWithValue("@LVW_PLZ", this.LVW_PLZ);
            cmd.Parameters.AddWithValue("@LVW_Str", this.LVW_Str);
            cmd.Parameters.AddWithValue("@LVW_ID", this.LVW_ID);
        }
    }
}
