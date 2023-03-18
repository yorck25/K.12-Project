using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class cAbteilung
    {

        public static List<cAbteilung> Abtliste= new List<cAbteilung>();

        public long? Abt_ID { get; set; } = null;
        public string Abt_Bez { get; set; }
        public int Abt_Kst_ID { get; set; }
        public bool Abt_Geloescht { get; set; }

        public string AbteilungsListe => Abt_ID + ": " + Abt_Bez;

        public static void AbteilungLaden()
        {
            string sql = "SELECT * FROM abteilung";
            MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["localsql"].ConnectionString);

            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();

            cAbteilung.Abtliste = new List<cAbteilung>();

            while (rdr.Read())
            {
                cAbteilung abt = new cAbteilung();
                abt.Abt_ID = rdr.GetInt64("Abt_ID");
                abt.Abt_Bez = rdr.GetString("Abt_Bez");
                abt.Abt_Kst_ID = rdr.GetInt16("Abt_Kst_ID");
                cAbteilung.Abtliste.Add(abt);
            }
            rdr.Close();
        }
        public void KostenstelleLaden()
        {
            string sql = "SELECT * FROM kostenstelle";
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
                cKostenstelle.liste.Add(kst);
            }
            rdr.Close();
        }

        public void Spiechern()
        {
            MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["localsql"].ConnectionString);

            conn.Open();

            if (Abt_ID.HasValue)
            {
                string sql = "UPDATE abteilung SET Abt_Bez = @Abt_Bez WHERE Abt_ID = @Abt_ID";
                Console.WriteLine("ID:" + this.Abt_ID);
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                this.AbteilungSpeichern(cmd);
                cmd.ExecuteNonQuery();
            }
            else
            {
                string sql = "INSERT INTO abteilung (Abt_Bez, Abt_KST_ID, Abt_Geloescht) VALUES (@Abt_Bez, @Abt_KST_ID, @Abt_Geloescht)";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                this.AbteilungSpeichern(cmd);
                cmd.ExecuteNonQuery();
                this.Abt_ID = cmd.LastInsertedId;
                cAbteilung.Abtliste.Add(this);
            }
            conn.Close();
            return;
        }

        public void AbteilungLöschen()
        {
            MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["localsql"].ConnectionString);

            conn.Open();

            try
            {
                string sql = "DELETE FROM abteilung WHERE Abt_ID = @Abt_ID";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                this.AbteilungSpeichern(cmd);
                cmd.ExecuteNonQuery();
                Console.WriteLine("Abteilung wird Gelöscht");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            conn.Close();
            return;
        }

        public void AbteilungSpeichern(MySqlCommand cmd)
        {
            cmd.Parameters.AddWithValue("@Abt_Geloescht", this.Abt_Geloescht);
            cmd.Parameters.AddWithValue("@Abt_Bez", this.Abt_Bez);
            cmd.Parameters.AddWithValue("@Abt_ID", this.Abt_ID);
            cmd.Parameters.AddWithValue("@Abt_Kst_ID", this.Abt_Kst_ID);
        }

    }
}