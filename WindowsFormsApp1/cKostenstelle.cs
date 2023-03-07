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

        public string KostenstelleListe => Kst_ID + ": " + Kst_Bez;

        public static void AlleLaden()
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
                string sql = "INSERT INTO kostenstelle (Kst_Bez) VALUES (@Kst_Bez)";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                this.WerteSpeichern(cmd);
                cmd.ExecuteNonQuery();
                this.Kst_ID = cmd.LastInsertedId;
                cKostenstelle.liste.Add(this);
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

        public void WerteSpeichern(MySqlCommand cmd)
        {
            cmd.Parameters.AddWithValue("@Kst_Bez", this.Kst_Bez);
            cmd.Parameters.AddWithValue("@Kst_ID", this.Kst_ID);
        }

    }
}
