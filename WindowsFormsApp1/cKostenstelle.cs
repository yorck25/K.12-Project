using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class cKostenstelle
    { 
        public static List<cKostenstelle> liste = new List<cKostenstelle>();

        public long? Kst_ID { get; set; } = null;
        public string Kst_Bez { get; set; }
        public bool Kst_Geloescht { get; set; }

        public string KostenstelleListe => Kst_ID + ": " + Kst_Bez;

        public static void AlleLaden()
        {
            string sql = "SELECT * FROM kostenstelle WHERE Kst_Geloescht = false";
            MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["localsql"].ConnectionString);

            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();

            cKostenstelle.liste = new List<cKostenstelle>();

            while (rdr.Read())
            {
                cKostenstelle kst = new cKostenstelle();
                kst.Kst_ID = rdr.GetInt64("Kst_ID");
                kst.Kst_Bez = rdr.GetString("Kst_Bez");
                kst.Kst_Geloescht = rdr.GetBoolean("Kst_Geloescht");
                cKostenstelle.liste.Add(kst);
            }
            rdr.Close();
        }

        public void Spiechern()
        {
            MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["localsql"].ConnectionString);
            
            conn.Open();

            if(this.Kst_ID.HasValue)
            {
                string sql = "UPDATE kostenstelle SET Kst_Bez = @Kst_Bez WHERE Kst_ID = @Kst_ID";
                Console.WriteLine("ID:" + this.Kst_ID);
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                this.WerteSpeichern(cmd);
                cmd.ExecuteNonQuery();
            }
            else
            {
                string sql = "INSERT INTO kostenstelle (Kst_Bez, Kst_Geloescht) VALUES (@Kst_Bez, @Kst_Geloescht)";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                this.WerteSpeichern(cmd);
                cmd.ExecuteNonQuery();
                this.Kst_ID = cmd.LastInsertedId;
                cKostenstelle.liste.Add(this);
            }
            conn.Close();
            return;
        }

        public void KostenstelleLöschen()
        {
            MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["localsql"].ConnectionString);

            conn.Open();

            try
            {
                string sql = "UPDATE kostenstelle SET Kst_Geloescht = true WHERE Kst_ID = @Kst_ID";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                this.WerteSpeichern(cmd);
                cmd.ExecuteNonQuery();
                Console.WriteLine("Kostenstelle wird Gelöscht");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            conn.Close();
            return;
        }

        public void WerteSpeichern(MySqlCommand cmd)
        {
            cmd.Parameters.AddWithValue("@Kst_Geloescht", this.Kst_Geloescht);
            cmd.Parameters.AddWithValue("@Kst_Bez", this.Kst_Bez);
            cmd.Parameters.AddWithValue("@Kst_ID", this.Kst_ID);
        }

    }
}
