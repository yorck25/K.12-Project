using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class cEinheit
    {
        public static List<cEinheit> EinListe = new List<cEinheit>();

        public long? Ein_ID { get; set; } = null;
        public string Ein_Bez { get; set; }
        public bool Ein_Geloescht { get; set; }

        public string EinheitListe => Ein_ID + ": " + Ein_Bez;

        public static void EinheitLaden()
        {
            string sql = "SELECT * FROM einheit WHERE Ein_Geloescht = false";
            MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["localsql"].ConnectionString);

            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();

            cEinheit.EinListe = new List<cEinheit>();

            while (rdr.Read())
            {
                cEinheit e = new cEinheit();
                e.Ein_ID = rdr.GetInt64("Ein_ID");
                e.Ein_Bez = rdr.GetString("Ein_Bez");
                e.Ein_Geloescht = rdr.GetBoolean("Ein_Geloescht");
                cEinheit.EinListe.Add(e);
            }
            rdr.Close();
        }

        public void EinheitSpiechern()
        {
            MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["localsql"].ConnectionString);

            conn.Open();

            if (Ein_ID.HasValue)
            {
                string sql = "UPDATE einheit SET Ein_Bez = @Ein_Bez WHERE Ein_ID = @Ein_ID";
                Console.WriteLine("ID:" + this.Ein_ID);
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                this.EinheitWerteSpeichern(cmd);
                cmd.ExecuteNonQuery();
            }
            else
            {
                string sql = "INSERT INTO einheit (Ein_Bez, Ein_Geloescht) VALUES (@Ein_Bez, @Ein_Geloescht)";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                this.EinheitWerteSpeichern(cmd);
                cmd.ExecuteNonQuery();
                this.Ein_ID = cmd.LastInsertedId;
                cEinheit.EinListe.Add(this);        
            }
            conn.Close();
            return;
        }

        public void EinheitLöschen()
        {
            MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["localsql"].ConnectionString);

            conn.Open();

            try
            {
                string sql = "UPDATE einheit SET Ein_Geloescht = true WHERE Ein_ID = @Ein_ID";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                this.EinheitWerteSpeichern(cmd);
                cmd.ExecuteNonQuery();
                Console.WriteLine("Einheit wird Gelöscht");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            conn.Close();
            return;
        }

        public void EinheitWerteSpeichern(MySqlCommand cmd)
        {
            cmd.Parameters.AddWithValue("@Ein_Bez", this.Ein_Bez);
            cmd.Parameters.AddWithValue("@Ein_ID", this.Ein_ID);
            cmd.Parameters.AddWithValue("@Ein_Geloescht", this.Ein_Geloescht);
        }

    }
}
