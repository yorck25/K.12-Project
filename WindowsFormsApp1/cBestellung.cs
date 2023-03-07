using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class cBestellung
    {
        public static List<cBestellung> BstListe = new List<cBestellung>();

        public long? B_ID { get; set; } = null;
        public Timestamp B_Bestelldatum { get; set; }
        public int B_Lieferant { get; set; }
        public int B_Mitarbeiter { get; set; }

        public string BestellungListe => B_ID + ": " + B_Bestelldatum;

        public static void ArtikelLaden()
        {
            string sql = "SELECT * FROM artikel";
            MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["localsql"].ConnectionString);

            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();

            cArtikel.ArtListe = new List<cArtikel>();

            while (rdr.Read())
            {
                cArtikel art = new cArtikel();
                art.Art_ID = rdr.GetInt32("Art_ID");
                 cBestellung bst = new cBestellung();
                bst.B_Mitarbeiter = rdr.GetInt16("B_Mitarbeiter");
                bst.B_ID = rdr.GetInt16("ID");
                bst.B_Lieferant = rdr.GetInt16("");
            }
            rdr.Close();
        }

        public void BestellungSpeichern()
        {
            MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["localsql"].ConnectionString);

            conn.Open();

            if (B_ID.HasValue)
            {
                string sql = "UPDATE bestellung SET" + "B_Bez = @Art_Bez" + "WHERE B_ID = @B_ID";
                Console.WriteLine("ID:" + this.B_ID);
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                this.BestellungWerteSpeichern(cmd);
                cmd.ExecuteNonQuery();
            }
            else
            {
                string sql = "INSERT INTO bestellung (B_ID, B_Datum, B_L_ID, B_Mit_ID) " +
                    "VALUES (@B_ID, @B_Bestelldatum, @B_Lieferant, @B_Mitarbeiter)";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                this.BestellungWerteSpeichern(cmd);
                cmd.ExecuteNonQuery();
                this.B_ID = cmd.LastInsertedId;
                cBestellung.BstListe.Add(this);
            }
            conn.Close();
            return;
        }

        public void BestellungWerteSpeichern(MySqlCommand cmd)
        {
            cmd.Parameters.AddWithValue("@B_ID", this.B_ID);
            cmd.Parameters.AddWithValue("@B_Bestelldatum", this.B_Bestelldatum);
            cmd.Parameters.AddWithValue("@B_Lieferant", this.B_Lieferant);
            cmd.Parameters.AddWithValue("@B_Mitarbeiter", this.B_Mitarbeiter);
        }
    }
}
