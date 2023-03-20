using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class cEntnahmemenge
    {
        public static List<cEntnahmemenge> EmListe = new List<cEntnahmemenge>();

        public long? EM_ID { get; set; } = null;
        public int EM_ART_ID { get; set; }
        public int EM_ES_ID { get; set; }
        public int EM_Menge { get; set; }

        public void EntnahmeMengeLaden()
        {
            string sql = "SELECT * FROM entnahmemenge";
            MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["localsql"].ConnectionString);

            conn.Open();

            MySqlCommand cmd = new MySqlCommand(sql, conn);
            this.EntnahmemengeWerteSpeichern(cmd);
            cmd.ExecuteNonQuery();
            MySqlDataReader rdr = cmd.ExecuteReader();

            cEntnahmemenge.EmListe = new List<cEntnahmemenge>();
            cArtikel.ArtListe = new List<cArtikel>();

            while (rdr.Read())
            {
                cEntnahmemenge em = new cEntnahmemenge();
                em.EM_ID = rdr.GetInt16("EM_ID");
                em.EM_ART_ID = rdr.GetInt16("EM_ART_ID");
                em.EM_Menge = rdr.GetInt16("EM_Menge");
                cEntnahmemenge.EmListe.Add(em);
            }
            rdr.Close();
        }

        public void EntnahmeMengeProScheinLaden()
        {
            string sql = "SELECT * FROM entnahmemenge WHERE ";
            MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["localsql"].ConnectionString);

            conn.Open();

            MySqlCommand cmd = new MySqlCommand(sql, conn);
            this.EntnahmemengeWerteSpeichern(cmd);
            cmd.ExecuteNonQuery();
            MySqlDataReader rdr = cmd.ExecuteReader();

            cEntnahmemenge.EmListe = new List<cEntnahmemenge>();
            cArtikel.ArtListe = new List<cArtikel>();

            while (rdr.Read())
            {
                cEntnahmemenge em = new cEntnahmemenge();
                em.EM_ID = rdr.GetInt16("EM_ID");
                em.EM_ART_ID = rdr.GetInt16("EM_ART_ID");
                em.EM_Menge = rdr.GetInt16("EM_Menge");
                cEntnahmemenge.EmListe.Add(em);
            }
            rdr.Close();
        }

        public void LagerAtuell()
        {
            MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["localsql"].ConnectionString);

            conn.Open();

            string sql = "UPDATE artikel SET Art_Bst = Art_Bst - @EM_Menge WHERE Art_ID = @EM_ART_ID";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            this.EntnahmemengeWerteSpeichern(cmd);
            cmd.ExecuteNonQuery();
            this.EM_ID = cmd.LastInsertedId;
            cEntnahmemenge.EmListe.Add(this);
            conn.Close();
            return;
        }

        public void ArtikelEinFürLieferschein()
        {
            MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["localsql"].ConnectionString);

            conn.Open();

            string sql = "INSERT INTO entnahmemenge (EM_ID, EM_ES_ID, EM_ART_ID, EM_Menge) VALUES (@EM_ID, @EM_ES_ID, @EM_ART_ID, @EM_Menge)";
            LagerAtuell();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            this.EntnahmemengeWerteSpeichern(cmd);
            cmd.ExecuteNonQuery();
            this.EM_ID = cmd.LastInsertedId;
            cEntnahmemenge.EmListe.Add(this);
            conn.Close();
            return;
        }

        public void EntnahmemengeWerteSpeichern(MySqlCommand cmd)
        {
            cmd.Parameters.AddWithValue("@EM_ID", this.EM_ID);
            cmd.Parameters.AddWithValue("@EM_ES_ID", this.EM_ES_ID);
            cmd.Parameters.AddWithValue("@EM_ART_ID", this.EM_ART_ID);
            cmd.Parameters.AddWithValue("@EM_Menge", this.EM_Menge);
        }
    }
}
