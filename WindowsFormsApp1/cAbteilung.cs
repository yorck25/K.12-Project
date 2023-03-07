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
                string sql = "INSERT INTO abteilung (Abt_Bez, Abt_KST_ID) VALUES (@Abt_Bez, @Abt_KST_ID)";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                this.AbteilungSpeichern(cmd);
                cmd.ExecuteNonQuery();
                this.Abt_ID = cmd.LastInsertedId;
                cAbteilung.Abtliste.Add(this);
            }
            conn.Close();
            return;


            /*
            //Connection String für SqlGuru
            string connectionString = "server=dedi1778.your-server.de;user=sqlguru_5;database=sqlguru_db5;port=3306;password=t5Z3s4Z7uqig2bwJ";
            MySqlConnection conn = new MySqlConnection(connectionString);

            try
            {
                conn.Open();
                Console.WriteLine("Conn Open");
            }
            catch (Exception ex)
            {
                Console.WriteLine("not open" + ex.Message);
            }
            */
        }

        public void AbteilungSpeichern(MySqlCommand cmd)
        {
            cmd.Parameters.AddWithValue("@Abt_Bez", this.Abt_Bez);
            cmd.Parameters.AddWithValue("@Abt_ID", this.Abt_ID);
            cmd.Parameters.AddWithValue("@Abt_Kst_ID", this.Abt_Kst_ID);
        }

    }
}