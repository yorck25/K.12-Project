﻿using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto.Engines;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class cBestellMenge
    {
        public static List<cBestellMenge> BMListe = new List<cBestellMenge>();

        public long? BM_ID { get; set; } = null;
        public int BM_BST_ID { get; set; }
        public int BM_Menge { get; set; }
        public int BM_ART_ID { get; set; }

        public string BestemMengeListe => "Artieklnummer: " + BM_ART_ID + " || Bestellmenge: " + BM_Menge;


        public void BestellmengeSpeichern()
        {
            MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["localsql"].ConnectionString);

            conn.Open();

            string sql = "INSERT INTO bestellmenge (BM_ID, BM_BST_ID, BM_ART_ID, BM_Menge) VALUES (@BM_ID, @BM_BST_ID, @BM_ART_ID, @BM_Menge)";
            MySqlCommand cmd = new MySqlCommand(sql, conn) ;
            this.BestellmengeWerteSpeichern(cmd);
            cmd.ExecuteNonQuery();
            this.BM_ID = cmd.LastInsertedId;
            cBestellMenge.BMListe.Add(this);
            
            conn.Close();
            return;
        }
        
        public void BestellungStatusNeu()
        {
            string sql = "UPDATE bestellung SET B_S_ID = true WHERE B_ID = @BM_BST_ID";
            MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["localsql"].ConnectionString);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            this.BestellmengeWerteSpeichern(cmd);
            cmd.ExecuteNonQuery();

        }

        public void AusgewählteBestellmengeLaden()
        {
            string sql = "SELECT * FROM bestellmenge WHERE BM_BST_ID = @BM_BST_ID";
            MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["localsql"].ConnectionString);

            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@BM_BST_ID", this.BM_BST_ID);
            MySqlDataReader rdr = cmd.ExecuteReader();

            cBestellMenge.BMListe = new List<cBestellMenge>();

            while (rdr.Read())
            {
                cBestellMenge bm = new cBestellMenge();
                bm.BM_ART_ID = rdr.GetInt16("BM_ART_ID");
                bm.BM_ID = rdr.GetInt16("BM_ID");
                bm.BM_BST_ID = rdr.GetInt16("BM_BST_ID");
                bm.BM_Menge = rdr.GetInt16("BM_Menge");
                cBestellMenge.BMListe.Add(bm);
            }
            rdr.Close();
            conn.Close();
            return;
        }

        public void AusgewählteLieferscheinBestellmengeLaden()
        {
            string sql = "SELECT * FROM bestellmenge WHERE BM_BST_ID = 8";
            MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["localsql"].ConnectionString);

            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@BM_BST_ID", this.BM_BST_ID);
            MySqlDataReader rdr = cmd.ExecuteReader();

            cBestellMenge.BMListe = new List<cBestellMenge>();

            while (rdr.Read())
            {
                cBestellMenge bm = new cBestellMenge();
                bm.BM_ART_ID = rdr.GetInt16("BM_ART_ID");
                bm.BM_ID = rdr.GetInt16("BM_ID");
                bm.BM_BST_ID = rdr.GetInt16("BM_BST_ID");
                bm.BM_Menge = rdr.GetInt16("BM_Menge");
                cBestellMenge.BMListe.Add(bm);
                Console.WriteLine("true");
            }
            rdr.Close();
            conn.Close();
            return;
        }

        public void BestellmengeWerteSpeichern(MySqlCommand cmd)
        {
            cmd.Parameters.AddWithValue("@BM_ID", this.BM_ID);
            cmd.Parameters.AddWithValue("@BM_BST_ID", this.BM_BST_ID);
            cmd.Parameters.AddWithValue("@BM_ART_ID", this.BM_ART_ID);
            cmd.Parameters.AddWithValue("@BM_Menge", this.BM_Menge);
        }
    }
}
