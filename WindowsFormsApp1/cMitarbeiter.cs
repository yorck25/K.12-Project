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
        public string Mit_HausNr { get; set; }
        public int Mit_PLZ { get; set; }
        public string Mit_Ort { get; set; }
        public  DateTime Mit_GDat { get; set; }
        public string Mit_Mail { get; set; }
        public string Mit_Benutzer { get; set; }
        public string Mit_Pw { get; set; }
        public int Mit_Abt_ID { get; set; }
        public int Mit_R_ID { get; set; }
        public int Mit_F_ID { get; set; }
        public int Mit_Abr_ID { get; set; }

        public string MitarbeiterListe => Mit_ID + ":" + Mit_VName + "," + Mit_Name; 

        public void MitarbeiterSpeichern()
        {
            MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["localsql"].ConnectionString);

            conn.Open();

            if (Mit_ID.HasValue)
            {
                string sql = "UPDATE mitarbeiter SET" 
                    + "Mit_Name = @Mit_Name," +
                    " Mit_VName = @Mit_VName," +
                    " Mit_Straße = @Mit_Straße," +
                    " Mit_HausNr = @Mit_HausNr, " +
                    " Mit_PLZ = @Mit_PLZ," +
                    " Mit_Ort = @Mit_Ort," +
                    " Mit_GDat = @Mit_GDat," +
                    " Mit_Mail = @Mit_Mail," +
                    " Mit_Benutzer = @Mit_Benutzer," +
                    " Mit_Pw = @Mit_Pw," +
                    " Mit_Abt_ID = @Mit_ABAbt_ID," +
                    " Mit_F_ID = @Mit_F_ID," +
                    " Mit_R_ID =  @Mit_R_ID," +
                    " Mit_Abr_ID =  @Mit_Abr_ID  "
                    + "WHERE Mit_ID = @Mit_ID";
                Console.WriteLine("ID:" + this.Mit_ID);
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                this.MitarbeiterWerte(cmd);
                cmd.ExecuteNonQuery();
            }
            else
            {
                string sql = "INSERT INTO mitarbeiter (Mit_Name) VALUES (@Mit_Name)";
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
            cmd.Parameters.AddWithValue("@Mit_Straße", this.Mit_Straße);
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
            cmd.Parameters.AddWithValue("@Mit_Abr_ID", this.Mit_Abr_ID);
        }

        public void MitarbeiterLaden()
        {
            string sql = "SELECT * FROM rolle";
            MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["localsql"].ConnectionString);

            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();

            cRolle.RListe = new List<cRolle>();

            while (rdr.Read())
            {
                cRolle r = new cRolle();
                r.R_ID = rdr.GetInt64("R_ID");
                r.R_Bez = rdr.GetString("R_Bez");
                cRolle.RListe.Add(r);
            }
            rdr.Close();
        }
    }
}
