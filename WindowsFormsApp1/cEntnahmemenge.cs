﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class cEntnahmemenge
    {
        public static List<cEntnahmemenge> EmListe = new List<cEntnahmemenge>();

        public long? EM_ID { get; set; } = null;
        public int Em_ART_ID { get; set; }
        public int LM_ES_ID { get; set; }
        public int EM_Menge { get; set; }

        //public void EntnahmeMengeLaden()
        //{
        //    string sql = "SELECT * FROM entnahmemenge WHERE EM_ES_ID = @EM_ES_ID";
        //    MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["localsql"].ConnectionString);

        //    conn.Open();

        //    MySqlCommand cmd = new MySqlCommand(sql, conn);
        //    this.LiefermengeWerteSpeichern(cmd);
        //    cmd.ExecuteNonQuery();
        //    MySqlDataReader rdr = cmd.ExecuteReader();


        //    cArtikel.ArtListe = new List<cArtikel>();

        //    while (rdr.Read())
        //    {
        //        cLiefermenge lm = new cLiefermenge();
        //        lm.LM_ID = rdr.GetInt32("LM_ID");
        //        lm.LM_LS_ID = rdr.GetInt16("LM_LS_ID");
        //        lm.LM_ART_ID = rdr.GetInt16("LM_ART_ID");
        //        lm.LM_Menge = rdr.GetInt16("LM_Menge");
        //        cLiefermenge.LmListe.Add(lm);
        //    }
        //    rdr.Close();
        //}

        

        //public void LagerAtuell()
        //{
        //    MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["localsql"].ConnectionString);

        //    conn.Open();

        //    string sql = "UPDATE artikel SET Art_Bst = Art_Bst - @LM_Menge WHERE Art_ID = @LM_ART_ID";
        //    MySqlCommand cmd = new MySqlCommand(sql, conn);
        //    this.LiefermengeWerteSpeichern(cmd);
        //    cmd.ExecuteNonQuery();
        //    this.EM_ID = cmd.LastInsertedId;
        //   // cLiefermenge.LmListe.Add(this);
        //    conn.Close();
        //    return;
        //}

        //public void ArtikelEinFürLieferschein()
        //{
        //    MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["localsql"].ConnectionString);

        //    conn.Open();

        //    string sql = "INSERT INTO liefermenge (LM_ID, LM_LS_ID, LM_ART_ID, LM_Menge) " + " VALUES (@LM_ID, @LM_LS_ID, @LM_ART_ID, @LM_Menge)";
        //    LagerAtuell();
        //    MySqlCommand cmd = new MySqlCommand(sql, conn);
        //    this.LiefermengeWerteSpeichern(cmd);
        //    cmd.ExecuteNonQuery();
        //    this.LM_ID = cmd.LastInsertedId;
        //    cLiefermenge.LmListe.Add(this);
        //    conn.Close();
        //    return;
        //}

        //public void LiefermengeWerteSpeichern(MySqlCommand cmd)
        //{
        //    cmd.Parameters.AddWithValue("@LM_ID", this.LM_ID);
        //    cmd.Parameters.AddWithValue("@LM_LS_ID", this.LM_LS_ID);
        //    cmd.Parameters.AddWithValue("@LM_ART_ID", this.LM_ART_ID);
        //    cmd.Parameters.AddWithValue("@LM_Menge", this.LM_Menge);
        //}
    }
}
