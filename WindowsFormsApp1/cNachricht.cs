using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class cNachricht
    {

        public static List<cNachricht> NachListe = new List<cNachricht>();

        public long? Nach_ID {  get; set; } = null;
        public string Nach_Betreff { get; set; }
        public string Nach_Text { get; set; }
        public int Nach_Mit_Id { get; set; }
        public int Nach_GesVon { get; set; }
        public bool Nach_Gelesen { get; set; }

        public string Nachricht => Nach_ID + ":"+ Nach_Betreff;

        public static void NachrichtenLaden()
        {
            string sql = "SELECT * FROM nachricht WHERE Nach_Gelesen = false";
            MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["localsql"].ConnectionString);

            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();

            cNachricht.NachListe = new List<cNachricht>();

            while (rdr.Read())
            {
                cNachricht nach = new cNachricht();
                nach.Nach_ID = rdr.GetInt32("Nach_ID");
                nach.Nach_Betreff = rdr.GetString("Nach_Betreff");
                nach.Nach_Text = rdr.GetString("Nach_Text");
                //nach.Nach_Mit_Id = rdr.GetInt16("Nach_Mit_Id");
                //nach.Nach_GesVon = rdr.GetInt16("Nach_GesVon");
                nach.Nach_Gelesen = rdr.GetBoolean("Nach_Gelesen");
                cNachricht.NachListe.Add(nach);
            }
            rdr.Close();
        }

        public void  NachrichtSystemSpeichern()
        {
            this.Nach_Text = "Bestand Unterschreitung";
            
            MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["localsql"].ConnectionString);

            conn.Open();

            string sql = "INSERT INTO nachricht (Nach_ID, Nach_Betreff, Nach_Text, Nach_Gelesen) " +
            " VALUES (@Nach_ID, @Nach_Betreff , @Nach_Text, @Nach_Gelesen)";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            this.NachrichtenAutomatischWerte(cmd);
            cmd.ExecuteNonQuery();
            this.Nach_ID = cmd.LastInsertedId;
            cNachricht.NachListe.Add(this);
            conn.Close();
            return;
        }

        public void NachrichtLöschen()
        {
            MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["localsql"].ConnectionString);

            conn.Open();

            try
            {
                string sql = "UPDATE nachricht SET Nach_Gelesen = true WHERE Nach_ID = @Nach_ID";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                this.NachrichtenAutomatischWerte(cmd);
                cmd.ExecuteNonQuery();
                Console.WriteLine("Nachricht wird Gelöscht");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            conn.Close();
            return;
        }

        public void AlleNachrichtLöschen()
        {
            MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["localsql"].ConnectionString);

            conn.Open();

            try
            {
                string sql = "UPDATE nachricht SET Nach_Gelesen = true";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                this.NachrichtenAutomatischWerte(cmd);
                cmd.ExecuteNonQuery();
                Console.WriteLine("Alle Nachricht wird Gelöscht");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            conn.Close();
            return;
        }

        public void NachrichtenAutomatischWerte(MySqlCommand cmd)
        {
            Nach_Betreff = "Bestand Unterschreitung";
            Nach_Text = "Der MIndestbestnad bei einem Artikel wurde unterschritten!!!";
            Nach_Gelesen = false;

            cmd.Parameters.AddWithValue("@Nach_ID",this.Nach_ID);
            cmd.Parameters.AddWithValue("@Nach_Betreff", this.Nach_Betreff);
            cmd.Parameters.AddWithValue("@Nach_Text", this.Nach_Text);
            cmd.Parameters.AddWithValue("@Nach_Mit_Id", this.Nach_Mit_Id);
            cmd.Parameters.AddWithValue("@Nach_GesVon", this.Nach_GesVon);
            cmd.Parameters.AddWithValue("@Nach_Gelesen", this.Nach_Gelesen);
        }
        public void NachrichtenWerte(MySqlCommand cmd)
        {
            cmd.Parameters.AddWithValue("@Nach_ID",this.Nach_ID);
            cmd.Parameters.AddWithValue("@Nach_Betreff", this.Nach_Betreff);
            cmd.Parameters.AddWithValue("@Nach_Text", this.Nach_Text);
            cmd.Parameters.AddWithValue("@Nach_Mit_Id", this.Nach_Mit_Id);
            cmd.Parameters.AddWithValue("@Nach_GesVon", this.Nach_GesVon);
            cmd.Parameters.AddWithValue("@Nach_Gelesen", this.Nach_Gelesen);

        }

    }
}
