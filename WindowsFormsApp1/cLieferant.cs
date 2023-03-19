using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class cLieferant
    {
        public static List<cLieferant> LListe = new List<cLieferant>();

        public long? L_ID { get; set; } = null;
        public string L_Anrede { get; set; }
        public string L_Name { get; set; }
        public string L_Strasse { get; set; }
        public int L_HausNr { get; set; } 
        public int L_PLZ { get; set; } 
        public string L_Ort { get; set; }
        public string L_Postfach { get; set; }
        public int L_Tel { get; set; }
        public int L_Fax { get; set; }
        public int L_BLZ { get; set; }
        public string L_Anspr { get; set; }
        public string L_Mail { get; set; }
        public int L_Durchwahl { get; set; }
        public string L_Ntz { get; set; }
        public string LiferantenListe => L_ID + ": " + L_Name;

        public static void LieferantLaden()
        {
            string sql = "SELECT * FROM lieferanten";
            MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["localsql"].ConnectionString);

            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();

            cLieferant.LListe = new List<cLieferant>();

            while (rdr.Read())
            {
                cLieferant l = new cLieferant();
                l.L_ID = rdr.GetInt64("L_ID");
                l.L_Anrede = rdr.GetString("L_Anrede");
                l.L_Name = rdr.GetString("L_Name");
                l.L_Strasse = rdr.GetString("L_Strasse");
                l.L_HausNr = rdr.GetInt16("L_HausNr");
                l.L_PLZ = rdr.GetInt16("L_PLZ");
                l.L_Ort = rdr.GetString("L_Ort");
                l.L_Tel = rdr.GetInt32("L_Tel");
                l.L_Postfach = rdr.GetString("L_Postfach");
                l.L_Fax = rdr.GetInt16("L_Fax");
                l.L_BLZ = rdr.GetInt16("L_BLZ");
                l.L_Anspr = rdr.GetString("L_Anspr");
                l.L_Mail = rdr.GetString("L_Mail");
                l.L_Durchwahl = rdr.GetInt16("L_Durchwahl");
                l.L_Ntz = rdr.GetString("L_Ntz");
                LListe.Add(l);
            }
            rdr.Close();
        }

        public void LieferantSpeichern()
        {
            MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["localsql"].ConnectionString);

            conn.Open();

            if(L_ID.HasValue)
            {
                string sql = "UPDATE lieferanten SET L_Name = @L_Name, L_Strasse = @L_Strasse, L_HausNr = @L_HausNr," +
                    " L_PLZ = @L_PLZ, L_Ort = @L_Ort, L_Postfach = @L_Postfach, L_Tel = @L_Tel, L_Fax = @L_Fax, L_BLZ = @L_BLZ, L_Anspr = @L_Anspr, L_Mail = @L_Mail, L_Durchwahl = @L_Durchwahl," +
                    " L_Ntz = @L_Ntz WHERE L_ID = @L_ID";
                Console.WriteLine("ID:" + this.L_ID);
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                this.LieferantWerteSpeichern(cmd);
                cmd.ExecuteNonQuery();
            }
            else
            {
                string sql = "INSERT INTO lieferanten (L_Anrede, L_Name, L_Strasse, L_HausNr, L_PLZ, L_Ort, L_Postfach, L_Tel, L_Fax, L_BLZ, L_Anspr, L_Mail, L_Durchwahl, L_Ntz) " +
                    "VALUES (@L_Anrede, @L_Name, @L_Strasse,  @L_HausNr, @L_PLZ, @L_Ort, @L_Postfach, @L_Tel, @L_Fax, @L_BLZ, @L_Anspr, @L_Mail, @L_Durchwahl, @L_Ntz)";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                this.LieferantWerteSpeichern(cmd);
                cmd.ExecuteNonQuery();
                this.L_ID = cmd.LastInsertedId;
                cLieferant.LListe.Add(this);
                conn.Close();
                return;               
            }
        }

        public void LieferantLöschen()
        {
            MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["localsql"].ConnectionString);

            conn.Open();

            try
            {
                string sql = "DELETE FROM lieferanten WHERE L_ID = @L_ID";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                this.LieferantWerteSpeichern(cmd);
                cmd.ExecuteNonQuery();
                Console.WriteLine("Lieferant wird Gelöscht");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            conn.Close();
            return;
        }

        public void LieferantWerteSpeichern(MySqlCommand cmd)
        {
            cmd.Parameters.AddWithValue("@L_ID", this.L_ID);
            cmd.Parameters.AddWithValue("@L_Anrede", this.L_Anrede);
            cmd.Parameters.AddWithValue("@L_Name", this.L_Name);
            cmd.Parameters.AddWithValue("@L_Strasse", this.L_Strasse);
            cmd.Parameters.AddWithValue("@L_HausNr", this.L_HausNr);
            cmd.Parameters.AddWithValue("@L_PLZ", this.L_PLZ);
            cmd.Parameters.AddWithValue("@L_Ort", this.L_Ort);
            cmd.Parameters.AddWithValue("@L_Postfach", this.L_Postfach);
            cmd.Parameters.AddWithValue("@L_Tel", this.L_Tel);
            cmd.Parameters.AddWithValue("@L_Fax", this.L_Fax);
            cmd.Parameters.AddWithValue("@L_BLZ", this.L_BLZ);
            cmd.Parameters.AddWithValue("@L_Anspr", this.L_Anspr);
            cmd.Parameters.AddWithValue("@L_Mail", this.L_Mail);
            cmd.Parameters.AddWithValue("@L_Durchwahl", this.L_Durchwahl);
            cmd.Parameters.AddWithValue("@L_Ntz", this.L_Ntz);

        }
    }
}