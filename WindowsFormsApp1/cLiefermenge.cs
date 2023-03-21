using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class cLiefermenge
    {
        public static List<cLiefermenge> LmListe = new List<cLiefermenge>();

        public long? LM_ID { get; set; } = null;
        public int LM_LS_ID { get; set; }
        public int LM_ART_ID { get; set; }
        public int LM_Menge { get; set; }

        public string LmArtProBstListe => LM_ID +"-- "+ LM_ART_ID + ": " + LM_Menge;

        public void LiefermengeLaden()
        {
            string sql = "SELECT * FROM liefermenge WHERE LM_LS_ID = @LM_LS_ID";
            MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["localsql"].ConnectionString);

            conn.Open();
            
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            this.LiefermengeWerteSpeichern(cmd);
            cmd.ExecuteNonQuery();
            MySqlDataReader rdr = cmd.ExecuteReader();


            cArtikel.ArtListe = new List<cArtikel>();

            while (rdr.Read())
            {
                cLiefermenge lm = new cLiefermenge();
                lm.LM_ID = rdr.GetInt32("LM_ID");
                lm.LM_LS_ID = rdr.GetInt16("LM_LS_ID");
                lm.LM_ART_ID = rdr.GetInt16("LM_ART_ID");
                lm.LM_Menge = rdr.GetInt16("LM_Menge");
                cLiefermenge.LmListe.Add(lm);
            }
            rdr.Close();
        }

        public void ArtikelFürLmLAden()
        {
            string sql = "SELECT Art_ID, Art_Menge FROM artikel";
            MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["localsql"].ConnectionString);

            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();

            cArtikel.ArtListe = new List<cArtikel>();

            while (rdr.Read())
            {
                cLiefermenge lm = new cLiefermenge();
                lm.LM_ID = rdr.GetInt32("LM_ID");
                lm.LM_Menge = rdr.GetInt16("LM_Menge");
                cLiefermenge.LmListe.Add(lm);
            }
            rdr.Close();
        }

        public void LagerAtuell()
        {
            MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["localsql"].ConnectionString);

            conn.Open();
           
            string sql = "UPDATE artikel SET Art_Bst = Art_Bst + @LM_Menge WHERE Art_ID = @LM_ART_ID";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            this.LiefermengeWerteSpeichern(cmd);
            cmd.ExecuteNonQuery();
            this.LM_ID = cmd.LastInsertedId;
            cLiefermenge.LmListe.Add(this);
            conn.Close();
            return;
        }
        
        public void ArtikelEinFürLieferschein()
        {
            MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["localsql"].ConnectionString);

            conn.Open();

            string sql = "INSERT INTO liefermenge (LM_ID, LM_LS_ID, LM_ART_ID, LM_Menge) VALUES (@LM_ID, @LM_LS_ID, @LM_ART_ID, @LM_Menge)";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            this.LiefermengeWerteSpeichern(cmd);
            this.LM_ID = cmd.LastInsertedId;
            cmd.ExecuteNonQuery();
            cLiefermenge.LmListe.Add(this);
            LagerAtuell();
            conn.Close();
            return;
        }

        public void LieferscheinStatusnNeu()
        {
            MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["localsql"].ConnectionString);

            conn.Open();

            string sql = "UPDATE lieferschein SET LS_Status = true WHERE LS_ID = @LM_LS_ID";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            this.LiefermengeWerteSpeichern(cmd);
            cmd.ExecuteNonQuery();
            conn.Close();
            return;
        }

        public void LiefermengeWerteSpeichern(MySqlCommand cmd)
        {
            cmd.Parameters.AddWithValue("@LM_LS_ID", this.LM_LS_ID);
            cmd.Parameters.AddWithValue("@LM_ART_ID", this.LM_ART_ID);
            cmd.Parameters.AddWithValue("@LM_Menge", this.LM_Menge);
            cmd.Parameters.AddWithValue("@LM_ID", this.LM_ID);
        }
    }
}
