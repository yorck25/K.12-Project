using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class cLieferschein
    {
        public static List<cLieferschein> LsListe = new List<cLieferschein>();

        public long? LS_ID { get; set; } = null;
        public int LS_B_ID { get; set; }
        public string LS_Datum { get; set; }
        public bool LS_Bearbeitet { get; set; } 
        public int  LS_BearbeitetVon_ID { get; set; }
        public bool LS_Status { get; set; }

        public string LieferscheinListe => LS_ID + ": " + LS_Datum;
        
        public static void AlleLieferscheinLaden()
        {
            string sql = "SELECT * FROM Lieferschein";
            MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["localsql"].ConnectionString);

            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();

            cBestellMenge.BMListe = new List<cBestellMenge>();

            while (rdr.Read())
            {
                cLieferschein Ls = new cLieferschein();
                Ls.LS_ID = rdr.GetInt16("LS_ID");
                Ls.LS_B_ID = rdr.GetInt16("Ls_B_ID");
                Ls.LS_Datum = rdr.GetString("LS_Datum");
                Ls.LS_BearbeitetVon_ID = rdr.GetInt16("LS_BearbeitetVon_ID");
                Ls.LS_Bearbeitet = rdr.GetBoolean("LS_Bearbeitet");
                cLieferschein.LsListe.Add(Ls);
            }
            rdr.Close();
        }

        public static void NurBearbeiteteScheineLaden()
        {
            string sql = "SELECT * FROM lieferschein WHERE LS_Status = true";
            MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["localsql"].ConnectionString);

            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();

            cLieferschein.LsListe = new List<cLieferschein>();

            while (rdr.Read())
            {
                cLieferschein Ls = new cLieferschein();
                Ls.LS_ID = rdr.GetInt16("LS_ID");
                Ls.LS_B_ID = rdr.GetInt16("Ls_B_ID");
                Ls.LS_Datum = rdr.GetString("LS_Datum");
                Ls.LS_BearbeitetVon_ID = rdr.GetInt16("LS_BearbeitetVon_ID");
                Ls.LS_Bearbeitet = rdr.GetBoolean("LS_Bearbeitet");
                cLieferschein.LsListe.Add(Ls);
            }
            rdr.Close();
        }

        public static void NurUnbearbeiteteScheineLaden()
        {
            string sql = "SELECT * FROM lieferschein WHERE LS_Status = false";
            MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["localsql"].ConnectionString);

            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();

            cLieferschein.LsListe = new List<cLieferschein>();

            while (rdr.Read())
            {
                cLieferschein Ls = new cLieferschein();
                Ls.LS_ID = rdr.GetInt16("LS_ID");
                Ls.LS_B_ID = rdr.GetInt16("Ls_B_ID");
                Ls.LS_Datum = rdr.GetString("LS_Datum");
                Ls.LS_BearbeitetVon_ID = rdr.GetInt16("LS_BearbeitetVon_ID");
                Ls.LS_Bearbeitet = rdr.GetBoolean("LS_Bearbeitet");
                cLieferschein.LsListe.Add(Ls);
            }
            rdr.Close();
        }

        public void LieferscheinSpeichern()
        {
            MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["localsql"].ConnectionString);

            conn.Open();

            string sql = "INSERT INTO lieferschein (LS_ID,Ls_B_ID, LS_Datum, LS_Bearbeitet, LS_BearbeitetVon_ID, LS_Status) " +
                " VALUES (@Ls_ID, @Ls_B_ID, @Ls_Datum, @Ls_Bearbeitet, @Ls_BearbeitetVon_ID, false)";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            this.LieferscheinWerteSpeichern(cmd);
            cmd.ExecuteNonQuery();
            this.LS_ID = cmd.LastInsertedId;
            cLieferschein.LsListe.Add(this);

            conn.Close();
            return;
        }  

        public void LieferscheinWerteSpeichern(MySqlCommand cmd)
        {
            cmd.Parameters.AddWithValue("@Ls_ID", this.LS_ID);
            cmd.Parameters.AddWithValue("@Ls_B_ID", this.LS_B_ID);
            cmd.Parameters.AddWithValue("@Ls_Datum", this.LS_Datum);
            cmd.Parameters.AddWithValue("@Ls_Bearbeitet", this.LS_Bearbeitet);
            cmd.Parameters.AddWithValue("@Ls_BearbeitetVon_ID", this.LS_BearbeitetVon_ID);

        }
    }
}
