using MySql.Data.MySqlClient;
using Org.BouncyCastle.Tls;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class cMitarbeiter
    {
        public static List<cMitarbeiter> MitListe = new List<cMitarbeiter>();
        public long? Mit_ID { get; set; } = null;
        public string Mit_Name { get; set; }
        public string Mit_VName { get; set; }
        public string Mit_Straße { get; set; }
        public int Mit_HausNr { get; set; }
        public int Mit_PLZ { get; set; }
        public string Mit_Ort { get; set; }
        public  DateTime Mit_GDat { get; set; }
        public string Mit_Mail { get; set; }
        public string Mit_Benutzer { get; set; }
        public string Mit_Pw { get; set; }
        public int Mit_Abt_ID { get; set; }
        public int Mit_R_ID { get; set; }
        public int Mit_F_ID { get; set; }
        public bool Mit_Geloescht { get; set; }

        public string MitarbeiterListe => Mit_ID + ":" + Mit_VName + "," + Mit_Name; 

        public void MitarbeiterSpeichern()
        {
            MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["localsql"].ConnectionString);

            conn.Open();

            if (Mit_ID.HasValue)
            {
                string sql = "UPDATE mitarbeiter SET Mit_Name = @Mit_Name," +
                    " Mit_VName = @Mit_VName," +
                    " Mit_Strasse = @Mit_Straße," +
                    " Mit_HausNr = @Mit_HausNr, " +
                    " Mit_PLZ = @Mit_PLZ," +
                    " Mit_Ort = @Mit_Ort," +
                    " Mit_GDat = @Mit_GDat," +
                    " Mit_Mail = @Mit_Mail," +
                    " Mit_Benutzer = @Mit_Benutzer," +
                    " Mit_Pw = @Mit_Pw," +
                    " Mit_Abt_ID = @Mit_Abt_ID," +
                    " Mit_F_ID = @Mit_F_ID," +
                    " Mit_R_ID =  @Mit_R_ID," +
                    " WHERE Mit_ID = @Mit_ID";
                Console.WriteLine("ID:" + this.Mit_ID);
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                this.MitarbeiterWerte(cmd);
                cmd.ExecuteNonQuery();
            }
            else
            {
                string sql = "INSERT INTO mitarbeiter (Mit_Name, Mit_VName, Mit_Strasse, Mit_HausNr, Mit_PLZ, Mit_Ort, Mit_GDat, Mit_Mail, Mit_Benutzer, Mit_Pw, Mit_Abt_ID, Mit_F_ID, Mit_R_ID, Mit_Geloescht)" +
                    " VALUES (@Mit_Name, @Mit_VName, @Mit_Strasse, @Mit_HausNr, @Mit_PLZ, @Mit_Ort, @Mit_GDat, @Mit_Mail, @Mit_Benutzer, @Mit_Pw, @Mit_Abt_ID, @Mit_F_ID, @Mit_R_ID, @Mit_Geloescht)";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                this.MitarbeiterWerte(cmd);
                cmd.ExecuteNonQuery();
                this.Mit_ID = cmd.LastInsertedId;
                cMitarbeiter.MitListe.Add(this);
            }
            conn.Close();
            return;
        }

        public void MitarbeiterWerte(MySqlCommand cmd)
        {
            cmd.Parameters.AddWithValue("@Mit_ID", this.Mit_ID);
            cmd.Parameters.AddWithValue("@Mit_Name", this.Mit_Name);
            cmd.Parameters.AddWithValue("@Mit_VName", this.Mit_VName);
            cmd.Parameters.AddWithValue("@Mit_Strasse", this.Mit_Straße);
            cmd.Parameters.AddWithValue("@Mit_HausNr", this.Mit_HausNr);
            cmd.Parameters.AddWithValue("@Mit_PLZ", this.Mit_PLZ);
            cmd.Parameters.AddWithValue("@Mit_Ort", this.Mit_Ort);
            cmd.Parameters.AddWithValue("@Mit_GDat", this.Mit_GDat);
            cmd.Parameters.AddWithValue("@Mit_Mail", this.Mit_Mail);
            cmd.Parameters.AddWithValue("@Mit_Benutzer", this.Mit_Benutzer);
            cmd.Parameters.AddWithValue("@Mit_Pw", this.Mit_Pw);
            cmd.Parameters.AddWithValue("@Mit_Abt_ID", this.Mit_Abt_ID);
            cmd.Parameters.AddWithValue("@Mit_R_ID", this.Mit_R_ID);
            cmd.Parameters.AddWithValue("@Mit_F_ID", this.Mit_F_ID);
            cmd.Parameters.AddWithValue("@Mit_Geloescht", this.Mit_Geloescht);
        }

        public static void MitarbeiterLaden()
        {
            string sql = "SELECT * FROM mitarbeiter";
            MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["localsql"].ConnectionString);

            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();

            cMitarbeiter.MitListe = new List<cMitarbeiter>();

            while (rdr.Read())
            {
                cMitarbeiter mit = new cMitarbeiter();
                mit.Mit_ID = rdr.GetInt64("Mit_ID");
                mit.Mit_VName = rdr.GetString("Mit_VName");
                mit.Mit_Name = rdr.GetString("Mit_Name");
                mit.Mit_Straße = rdr.GetString("Mit_Strasse");
                mit.Mit_HausNr = rdr.GetInt16("Mit_HausNr");
                mit.Mit_PLZ = rdr.GetInt16("Mit_PLZ");
                mit.Mit_Ort = rdr.GetString("Mit_Ort");
                //mit.Mit_VName = rdr.GetString("Mit_GDat");
                mit.Mit_Mail = rdr.GetString("Mit_Mail");
                mit.Mit_Benutzer = rdr.GetString("Mit_Benutzer");
                mit.Mit_Pw = rdr.GetString("Mit_Pw");
                mit.Mit_Abt_ID = rdr.GetInt16("Mit_Abt_ID");
                mit.Mit_R_ID = rdr.GetInt16("Mit_R_ID");
                mit.Mit_F_ID = rdr.GetInt16("Mit_F_ID");
                cMitarbeiter.MitListe.Add(mit);
            }
            rdr.Close();
        }
        public void MItarbeiterLöschen()
        {
            MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["localsql"].ConnectionString);

            conn.Open();

            try
            {
                string sql = "DELETE FROM mitarbeiter WHERE Mit_ID = @Mit_ID";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                this.MitarbeiterWerte(cmd);
                cmd.ExecuteNonQuery();
                Console.WriteLine("Mitarbeiter wird Gelöscht");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            conn.Close();
            return;
        }
    }
}
