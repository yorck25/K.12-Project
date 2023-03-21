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
        public string B_Datum { get; set; }
        public int B_Lager { get; set; }
        public int B_Mitarbeiter { get; set; }
        public bool B_S_ID { get; set; }

        public string BestellungListe => B_ID + ": " + B_Datum;

        public static void BestellungLaden()
        {
            string sql = "SELECT * FROM bestellung";
            MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["localsql"].ConnectionString);

            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();

            cBestellung.BstListe = new List<cBestellung>();

            while (rdr.Read())
            {
                cBestellung bst = new cBestellung();
                bst.B_ID = rdr.GetInt16("B_ID");
                bst.B_Mitarbeiter = rdr.GetInt16("B_MIT_ID");
                bst.B_Datum = rdr.GetString("B_Datum");
                cBestellung.BstListe.Add(bst);
            }
            rdr.Close();
        }

        public void BestellungSpeichern()
        {
            MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["localsql"].ConnectionString);

            conn.Open();

            if ( 0 != 0)
            {
                string sql = "UPDATE bestellung SET" + "B_Bez = @Art_Bez" + "WHERE B_ID = @B_ID";
                Console.WriteLine("ID:" + this.B_ID);
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                this.BestellungWerteSpeichern(cmd);
                cmd.ExecuteNonQuery();
            }
            else
            {
                string sql = "INSERT INTO bestellung (B_ID, B_Datum, B_Mit_ID, B_S_ID) VALUES (@B_ID, @B_Datum, @B_Mitarbeiter, false)";
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
           // cmd.Parameters.AddWithValue("@B_Bestelldatum", this.B_Bestelldatum);
            cmd.Parameters.AddWithValue("@B_Mitarbeiter", this.B_Mitarbeiter);
            cmd.Parameters.AddWithValue("@B_Datum", this.B_Datum);
        }
    }
}
