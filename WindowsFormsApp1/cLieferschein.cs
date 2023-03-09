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
        public static List<cBestellMenge> BMListe = new List<cBestellMenge>();

        public long? BM_ID { get; set; } = null;
        public int BM_BST_ID { get; set; }
        public int BM_Menge { get; set; }
        public int BM_ART_ID { get; set; }

        public string BestemMengeListe => BM_ID + ": " + BM_ART_ID + ":" + BM_Menge;
        
        public static void BestellmengeLaden()
        {
            string sql = "SELECT * FROM bestellmenge";
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
       /* public void BestellmengeSpeichern()
        {
            MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["localsql"].ConnectionString);

            conn.Open();

            string sql = "INSERT INTO bestellmenge (BM_ID, BM_BST_ID, BM_ART_ID, BM_Menge) VALUES (@BM_ID, @BM_BST_ID, @BM_ART_ID, @BM_Menge)";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            this.BestellmengeWerteSpeichern(cmd);
            cmd.ExecuteNonQuery();
            this.BM_ID = cmd.LastInsertedId;
            cBestellMenge.BMListe.Add(this);

            conn.Close();
            return;
        }

        public void BestellmengeWerteSpeichern(MySqlCommand cmd)
        {
            cmd.Parameters.AddWithValue("@BM_ID", this.BM_ID);
            cmd.Parameters.AddWithValue("@BM_BST_ID", this.BM_BST_ID);
            cmd.Parameters.AddWithValue("@BM_ART_ID", this.BM_ART_ID);
            cmd.Parameters.AddWithValue("@BM_Menge", this.BM_Menge);
        }*/
    }
}
