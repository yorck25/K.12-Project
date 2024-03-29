﻿using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class cArtikel
    {
        public static List<cArtikel> ArtListe = new List<cArtikel>();

        public long? Art_ID { get; set; } = null;
        public string Art_Bez { get; set; }
        public int Art_Einheit { get; set; }
        public double Art_Preis { get; set; } // In der Datenbank auf double ändern
        public int Art_Bst { get; set; }
        public int Art_MaxBst { get; set; }
        public int Art_MinBst { get; set; }
        public int Art_Lager { get; set; }
        public int Art_Lieferant { get; set; }
        public string Art_Unterschreitung { get; set; }
        public string Art_Überschreitung { get; set; }
        public bool Art_Geloescht { get; set; }

        public string ArtikelListe => Art_ID + ": " + Art_Bez;

        public string ArtHmenuBst => Art_Bez + " - " + Art_Bst;
        public string ArtBstMeldung => Art_Unterschreitung;
        public string ArtÜberMEldung => Art_Überschreitung;

        public static void ArtikelLaden()
        {
            string sql = "SELECT * FROM artikel WHERE Art_Geloescht = false";
            MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["localsql"].ConnectionString);

            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();

            cArtikel.ArtListe = new List<cArtikel>();

            while (rdr.Read())
            {
                cArtikel art = new cArtikel();
                art.Art_ID = rdr.GetInt32("Art_ID");
                art.Art_Bez = rdr.GetString("Art_Bez");
                art.Art_Einheit = rdr.GetInt32("Art_Einheit");
                art.Art_Preis = rdr.GetDouble("Art_Preis");
                art.Art_Bst = rdr.GetInt32("Art_Bst");
                art.Art_MaxBst = rdr.GetInt32("Art_MaxBst");
                art.Art_MinBst = rdr.GetInt32("Art_MinBst");
                art.Art_Lager = rdr.GetInt32("Art_LVW_ID");
                art.Art_Lieferant = rdr.GetInt32("Art_L_ID");
                art.Art_Geloescht = rdr.GetBoolean("Art_Geloescht");
                if(art.Art_Bst < art.Art_MinBst)
                {
                    Console.WriteLine("Bestand Unterschritten" + art.Art_Bez);
                    art.Art_Unterschreitung = "Bestand Unterschritten: " + art.Art_Bez + " || Aktueller Bestand: " + art.Art_Bst;
                    cNachricht cNachricht = new cNachricht();
                    cNachricht.NachrichtSystemSpeichern();
                }
                if(art.Art_Bst > art.Art_MaxBst)
                {
                    Console.WriteLine("Bestand Überschritten" + art.Art_Bez);
                    art.Art_Unterschreitung = "Bestand Überschritten: " + art.Art_Bez + " || Aktueller Bestand: " + art.Art_Bst;
                    cNachricht cNachricht = new cNachricht();
                    cNachricht.NachrichtÜberSystemSpeichern();
                }
                cArtikel.ArtListe.Add(art);
            }
            rdr.Close();
        }

        public void ArtikelSpeichern()
        {
            MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["localsql"].ConnectionString);

            conn.Open();

            if (Art_ID.HasValue)
            {
                string sql = "UPDATE artikel SET Art_Bez = @Art_Bez, Art_Einheit = @Art_Einheit, Art_Preis = @Art_Preis, Art_Bst = @Art_Bst, Art_MaxBst = @Art_MaxBst, Art_MinBst = @Art_MinBst, Art_LVW_ID = @Art_LVW_ID, Art_L_ID = @Art_L_ID WHERE Art_ID = @Art_ID";
                Console.WriteLine("ID:" + this.Art_ID);
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                this.ArtikelWerteSpeichern(cmd);
                cmd.ExecuteNonQuery();
            }
            else
            {
                string sql = "INSERT INTO artikel (Art_Bez, Art_Einheit, Art_Preis, Art_Bst, Art_MaxBst, Art_MinBst, Art_LVW_ID, Art_L_ID, Art_Geloescht) " +
                    "VALUES (@Art_Bez, @Art_Einheit, @Art_Preis, @Art_Bst, @Art_MaxBst, @Art_MinBst, @Art_LVW_ID, @Art_L_ID, @Art_Geloescht)";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                this.ArtikelWerteSpeichern(cmd);
                cmd.ExecuteNonQuery();
                this.Art_ID = cmd.LastInsertedId;
                cArtikel.ArtListe.Add(this);
            }
            conn.Close();
            return;
        }

        public void ArtikelLöschen()
        {
            MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["localsql"].ConnectionString);

            conn.Open();

            try
            {
                string sql = "UPDATE artikel SET Art_Geloescht = true WHERE Art_ID = @Art_ID";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                this.ArtikelWerteSpeichern(cmd);
                cmd.ExecuteNonQuery();
                Console.WriteLine("Artikel wird Gelöscht");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            conn.Close();
            return;
        }

        public void ArtikelWerteSpeichern(MySqlCommand cmd)
        {
            cmd.Parameters.AddWithValue("@Art_ID", this.Art_ID);
            cmd.Parameters.AddWithValue("@Art_Bez", this.Art_Bez);
            cmd.Parameters.AddWithValue("@Art_Einheit", this.Art_Einheit);
            cmd.Parameters.AddWithValue("@Art_Preis", this.Art_Preis);
            cmd.Parameters.AddWithValue("@Art_Bst", this.Art_Bst);
            cmd.Parameters.AddWithValue("@Art_MaxBst", this.Art_MaxBst);
            cmd.Parameters.AddWithValue("@Art_MinBst", this.Art_MinBst);
            cmd.Parameters.AddWithValue("@Art_LVW_ID", this.Art_Lager);
            cmd.Parameters.AddWithValue("@Art_L_ID", this.Art_Lieferant);
            cmd.Parameters.AddWithValue("@Art_Geloescht", this.Art_Geloescht);
        }
    }
}
