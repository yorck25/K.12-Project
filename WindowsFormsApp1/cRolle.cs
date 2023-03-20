using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class cRolle
    {
        public static List<cRolle> RListe = new List<cRolle>();

        public long? R_ID { get; set; } = null;
        public string R_Bez { get; set; }
        public bool R_Geloescht { get; set; }

        public string RolleListe => R_ID + ": " + R_Bez;

        public static void RolleLaden()
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

        public void RolleSpeichern()
        {
            MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["localsql"].ConnectionString);

            conn.Open();

            if (R_ID.HasValue)
            {
                string sql = "UPDATE rolle SET R_Bez = @R_Bez WHERE R_ID = @R_ID";
                Console.WriteLine("ID:" + this.R_ID);
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                this.RolleWerteSpeichern(cmd);
                cmd.ExecuteNonQuery();
            }
            else
            {
                string sql = "INSERT INTO rolle (R_Bez, R_Geloescht) VALUES (@R_Bez, @R_Geloescht)";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                this.RolleWerteSpeichern(cmd);
                cmd.ExecuteNonQuery();
                this.R_ID = cmd.LastInsertedId;
                cRolle.RListe.Add(this);
            }
            conn.Close();
            return;
        }

        public void RolleLöschen()
        {
            MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["localsql"].ConnectionString);

            conn.Open();

            try
            {
                string sql = "UPDATE rolle SET R_Geloescht = true WHERE R_ID = @R_ID";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                this.RolleWerteSpeichern(cmd);
                cmd.ExecuteNonQuery();
                Console.WriteLine("Rolle wird Gelöscht");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            conn.Close();
            return;
        }


        public void RolleWerteSpeichern(MySqlCommand cmd)
        {
            cmd.Parameters.AddWithValue("@R_Bez", this.R_Bez);
            cmd.Parameters.AddWithValue("@R_Geloescht", this.R_Geloescht);
            cmd.Parameters.AddWithValue("@R_ID", this.R_ID);
        }
    }
}
