using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class cEntnahmeschein
    {
        public static List<cEntnahmeschein> Emliste = new List<cEntnahmeschein>();

        public long? ES_ID { get; set; } = null;
        public string ES_Datum { get; set; }
        public string ES_Ntz { get; set; }
        public int ES_VonMit { get; set; }
        public int ES_FuerMit { get; set; }

        public string EntnahmeschinListe => ES_ID + ": " + ES_Datum;

        public static void AlleEntnahmescheinLaden()
        {
            string sql = "SELECT * FROM entnahmeschein";
            MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["localsql"].ConnectionString);

            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();

            cKostenstelle.liste = new List<cKostenstelle>();

            while (rdr.Read())
            {
                cEntnahmeschein em = new cEntnahmeschein();
                em.ES_ID = rdr.GetInt64("ES_ID");
                em.ES_Datum = rdr.GetString("ES_Datum");
                em.ES_Ntz = rdr.GetString("ES_Ntz");
                em.ES_VonMit = rdr.GetInt16("ES_VonMit_ID");
                em.ES_FuerMit = rdr.GetInt16("ES_FuerMit_ID");
                cEntnahmeschein.Emliste.Add(em);
            }
            rdr.Close();
        }

        public void EntnahmescheinSpiechern()
        {
            MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["localsql"].ConnectionString);

            conn.Open();

            string sql = "INSERT INTO entnahmeschein (ES_ID, ES_Datum, ES_Ntz, ES_VonMit_ID, ES_FuerMit_ID) VALUES (@ES_ID, @ES_Datum, @ES_Ntz, @ES_VonMit, @Es_FeurMit)";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            this.EntnahmescheinWerteSpeichern(cmd);
            cmd.ExecuteNonQuery();
            this.ES_ID = cmd.LastInsertedId;
            cEntnahmeschein.Emliste.Add(this);
           
            conn.Close();
            return;
        }

        public void EntnahmescheinWerteSpeichern(MySqlCommand cmd)
        {
            cmd.Parameters.AddWithValue("@ES_ID", this.ES_ID);
            cmd.Parameters.AddWithValue("@ES_Datum", this.ES_Datum);
            cmd.Parameters.AddWithValue("@ES_Ntz", this.ES_Ntz);
            cmd.Parameters.AddWithValue("@ES_VonMit", this.ES_VonMit);
            cmd.Parameters.AddWithValue("@ES_FeurMit", this.ES_FuerMit);
        }
    }
}
