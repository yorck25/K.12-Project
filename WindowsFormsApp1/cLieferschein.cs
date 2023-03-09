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
        public int Ls_B_ID { get; set; }
        public string LS_Datum { get; set; }
        public bool LS_Bearbeitet { get; set; } 
        public int  LS_BearbeitetVon_ID { get; set; }

        public string LieferscheinListe => LS_ID + ": " + Ls_B_ID + ":";
        
        public static void LieferscheinLaden()
        {
            string sql = "SELECT * FROM Lieferschein";
            MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["localsql"].ConnectionString);

            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();

            cBestellMenge.BMListe = new List<cBestellMenge>();

            while (rdr.Read())
            {
                cBestellMenge bm = new cBestellMenge();
                bm.BM_ID = rdr.GetInt16("BM_ID");
                bm.BM_BST_ID = rdr.GetInt16(" BM_BST_ID");
                bm.BM_ART_ID = rdr.GetInt16(" BM_ART_ID");
                bm.BM_Menge = rdr.GetInt16("BM_Menge");
                cBestellMenge.BMListe.Add(bm);
            }
            rdr.Close();
        }
        public void LieferscheinSpeichern()
        {
            MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["localsql"].ConnectionString);

            conn.Open();

            string sql = "INSERT INTO lieferschein (LS_ID,Ls_B_ID, LS_Datum, LS_Bearbeitet, LS_BearbeitetVon_ID) " +
                " VALUES (@Ls_ID, @Ls_B_ID, @Ls_Datum, @Ls_Bearbeitet, @Ls_BearbeitetVon_ID)";
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
            cmd.Parameters.AddWithValue("@Ls_B_ID", this.Ls_B_ID);
            cmd.Parameters.AddWithValue("@Ls_Datum", this.LS_Datum);
            cmd.Parameters.AddWithValue("@Ls_Bearbeitet", this.LS_Bearbeitet);
            cmd.Parameters.AddWithValue("@Ls_BearbeitetVon_ID", this.LS_BearbeitetVon_ID);

        }
    }
}
