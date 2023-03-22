namespace WindowsFormsApp1
{
    partial class Artikel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lBoxArt = new System.Windows.Forms.ListBox();
            this.herfArtNeu = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.tBoxAbtBez = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tBoxArtPreis = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cBoxAbtEinheit = new System.Windows.Forms.ComboBox();
            this.AbtneueAbteilung = new System.Windows.Forms.Panel();
            this.herfArtLief = new System.Windows.Forms.LinkLabel();
            this.herfArtLgv = new System.Windows.Forms.LinkLabel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cBoxArtLager = new System.Windows.Forms.ComboBox();
            this.cBoxArtL = new System.Windows.Forms.ComboBox();
            this.herfArtneueEinheit = new System.Windows.Forms.LinkLabel();
            this.tBoxArtMaxBst = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tBoxArtMinBst = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tBoxArtBst = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.butArtErstellen = new System.Windows.Forms.Button();
            this.herfArtLöschen = new System.Windows.Forms.LinkLabel();
            this.artBestätigungLöschen = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.butArtbestätigen = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.ArtFehler = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.butArtFehler = new System.Windows.Forms.Button();
            this.AbtneueAbteilung.SuspendLayout();
            this.artBestätigungLöschen.SuspendLayout();
            this.ArtFehler.SuspendLayout();
            this.SuspendLayout();
            // 
            // lBoxArt
            // 
            this.lBoxArt.DisplayMember = "ArtikelListe";
            this.lBoxArt.FormattingEnabled = true;
            this.lBoxArt.Items.AddRange(new object[] {
            "Test",
            "Test",
            "3242",
            "234234",
            "234"});
            this.lBoxArt.Location = new System.Drawing.Point(35, 37);
            this.lBoxArt.Name = "lBoxArt";
            this.lBoxArt.Size = new System.Drawing.Size(120, 277);
            this.lBoxArt.TabIndex = 0;
            this.lBoxArt.SelectedIndexChanged += new System.EventHandler(this.lBoxArt_SelectedIndexChanged);
            // 
            // herfArtNeu
            // 
            this.herfArtNeu.AutoSize = true;
            this.herfArtNeu.LinkColor = System.Drawing.SystemColors.Highlight;
            this.herfArtNeu.Location = new System.Drawing.Point(55, 21);
            this.herfArtNeu.Name = "herfArtNeu";
            this.herfArtNeu.Size = new System.Drawing.Size(100, 13);
            this.herfArtNeu.TabIndex = 1;
            this.herfArtNeu.TabStop = true;
            this.herfArtNeu.Text = "Artikel hinzufügen...";
            this.herfArtNeu.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.herfArtNeu_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bezeichnung:";
            // 
            // tBoxAbtBez
            // 
            this.tBoxAbtBez.Location = new System.Drawing.Point(3, 24);
            this.tBoxAbtBez.Name = "tBoxAbtBez";
            this.tBoxAbtBez.Size = new System.Drawing.Size(97, 20);
            this.tBoxAbtBez.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Einheit";
            // 
            // tBoxArtPreis
            // 
            this.tBoxArtPreis.Location = new System.Drawing.Point(6, 105);
            this.tBoxArtPreis.Name = "tBoxArtPreis";
            this.tBoxArtPreis.Size = new System.Drawing.Size(97, 20);
            this.tBoxArtPreis.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Preis:";
            // 
            // cBoxAbtEinheit
            // 
            this.cBoxAbtEinheit.DisplayMember = "EinheitListe";
            this.cBoxAbtEinheit.FormattingEnabled = true;
            this.cBoxAbtEinheit.Location = new System.Drawing.Point(3, 63);
            this.cBoxAbtEinheit.Name = "cBoxAbtEinheit";
            this.cBoxAbtEinheit.Size = new System.Drawing.Size(97, 21);
            this.cBoxAbtEinheit.TabIndex = 8;
            // 
            // AbtneueAbteilung
            // 
            this.AbtneueAbteilung.Controls.Add(this.herfArtLief);
            this.AbtneueAbteilung.Controls.Add(this.herfArtLgv);
            this.AbtneueAbteilung.Controls.Add(this.label8);
            this.AbtneueAbteilung.Controls.Add(this.label7);
            this.AbtneueAbteilung.Controls.Add(this.cBoxArtLager);
            this.AbtneueAbteilung.Controls.Add(this.cBoxArtL);
            this.AbtneueAbteilung.Controls.Add(this.herfArtneueEinheit);
            this.AbtneueAbteilung.Controls.Add(this.tBoxArtMaxBst);
            this.AbtneueAbteilung.Controls.Add(this.label6);
            this.AbtneueAbteilung.Controls.Add(this.tBoxArtMinBst);
            this.AbtneueAbteilung.Controls.Add(this.label5);
            this.AbtneueAbteilung.Controls.Add(this.tBoxArtBst);
            this.AbtneueAbteilung.Controls.Add(this.label4);
            this.AbtneueAbteilung.Controls.Add(this.butArtErstellen);
            this.AbtneueAbteilung.Controls.Add(this.tBoxArtPreis);
            this.AbtneueAbteilung.Controls.Add(this.cBoxAbtEinheit);
            this.AbtneueAbteilung.Controls.Add(this.label1);
            this.AbtneueAbteilung.Controls.Add(this.tBoxAbtBez);
            this.AbtneueAbteilung.Controls.Add(this.label3);
            this.AbtneueAbteilung.Controls.Add(this.label2);
            this.AbtneueAbteilung.Location = new System.Drawing.Point(171, 37);
            this.AbtneueAbteilung.Name = "AbtneueAbteilung";
            this.AbtneueAbteilung.Size = new System.Drawing.Size(258, 259);
            this.AbtneueAbteilung.TabIndex = 9;
            this.AbtneueAbteilung.Visible = false;
            // 
            // herfArtLief
            // 
            this.herfArtLief.AutoSize = true;
            this.herfArtLief.LinkColor = System.Drawing.SystemColors.Highlight;
            this.herfArtLief.Location = new System.Drawing.Point(168, 47);
            this.herfArtLief.Name = "herfArtLief";
            this.herfArtLief.Size = new System.Drawing.Size(89, 13);
            this.herfArtLief.TabIndex = 23;
            this.herfArtLief.TabStop = true;
            this.herfArtLief.Text = "Neuer Lieferant...";
            this.herfArtLief.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.herfArtLief_LinkClicked);
            // 
            // herfArtLgv
            // 
            this.herfArtLgv.AutoSize = true;
            this.herfArtLgv.LinkColor = System.Drawing.SystemColors.Highlight;
            this.herfArtLgv.Location = new System.Drawing.Point(168, 6);
            this.herfArtLgv.Name = "herfArtLgv";
            this.herfArtLgv.Size = new System.Drawing.Size(87, 13);
            this.herfArtLgv.TabIndex = 22;
            this.herfArtLgv.TabStop = true;
            this.herfArtLgv.Text = "Neuer Lagerort...";
            this.herfArtLgv.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.herfArtLgv_LinkClicked);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(118, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Lieferant:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(118, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Lagerort:";
            // 
            // cBoxArtLager
            // 
            this.cBoxArtLager.DisplayMember = "LagerortListe";
            this.cBoxArtLager.FormattingEnabled = true;
            this.cBoxArtLager.Location = new System.Drawing.Point(118, 25);
            this.cBoxArtLager.Name = "cBoxArtLager";
            this.cBoxArtLager.Size = new System.Drawing.Size(97, 21);
            this.cBoxArtLager.TabIndex = 19;
            this.cBoxArtLager.SelectedIndexChanged += new System.EventHandler(this.cBoxArtLager_SelectedIndexChanged);
            // 
            // cBoxArtL
            // 
            this.cBoxArtL.DisplayMember = "LiferantenListe";
            this.cBoxArtL.FormattingEnabled = true;
            this.cBoxArtL.Location = new System.Drawing.Point(118, 63);
            this.cBoxArtL.Name = "cBoxArtL";
            this.cBoxArtL.Size = new System.Drawing.Size(97, 21);
            this.cBoxArtL.TabIndex = 18;
            // 
            // herfArtneueEinheit
            // 
            this.herfArtneueEinheit.AutoSize = true;
            this.herfArtneueEinheit.LinkColor = System.Drawing.SystemColors.Highlight;
            this.herfArtneueEinheit.Location = new System.Drawing.Point(36, 47);
            this.herfArtneueEinheit.Name = "herfArtneueEinheit";
            this.herfArtneueEinheit.Size = new System.Drawing.Size(77, 13);
            this.herfArtneueEinheit.TabIndex = 17;
            this.herfArtneueEinheit.TabStop = true;
            this.herfArtneueEinheit.Text = "Neue Einheit...";
            this.herfArtneueEinheit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.herfArtneueEinheit_LinkClicked);
            // 
            // tBoxArtMaxBst
            // 
            this.tBoxArtMaxBst.Location = new System.Drawing.Point(121, 144);
            this.tBoxArtMaxBst.Name = "tBoxArtMaxBst";
            this.tBoxArtMaxBst.Size = new System.Drawing.Size(97, 20);
            this.tBoxArtMaxBst.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(121, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Maximal Bestand:";
            // 
            // tBoxArtMinBst
            // 
            this.tBoxArtMinBst.Location = new System.Drawing.Point(6, 144);
            this.tBoxArtMinBst.Name = "tBoxArtMinBst";
            this.tBoxArtMinBst.Size = new System.Drawing.Size(97, 20);
            this.tBoxArtMinBst.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Mindest Bestand:";
            // 
            // tBoxArtBst
            // 
            this.tBoxArtBst.Location = new System.Drawing.Point(121, 105);
            this.tBoxArtBst.Name = "tBoxArtBst";
            this.tBoxArtBst.Size = new System.Drawing.Size(97, 20);
            this.tBoxArtBst.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(121, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Bestand:";
            // 
            // butArtErstellen
            // 
            this.butArtErstellen.Location = new System.Drawing.Point(6, 170);
            this.butArtErstellen.Name = "butArtErstellen";
            this.butArtErstellen.Size = new System.Drawing.Size(75, 23);
            this.butArtErstellen.TabIndex = 9;
            this.butArtErstellen.Text = "Erstellen";
            this.butArtErstellen.UseVisualStyleBackColor = true;
            this.butArtErstellen.Click += new System.EventHandler(this.butArtErstellen_Click);
            // 
            // herfArtLöschen
            // 
            this.herfArtLöschen.AutoSize = true;
            this.herfArtLöschen.LinkColor = System.Drawing.SystemColors.Highlight;
            this.herfArtLöschen.Location = new System.Drawing.Point(70, 320);
            this.herfArtLöschen.Name = "herfArtLöschen";
            this.herfArtLöschen.Size = new System.Drawing.Size(85, 13);
            this.herfArtLöschen.TabIndex = 10;
            this.herfArtLöschen.TabStop = true;
            this.herfArtLöschen.Text = "Artiekl löschen...";
            this.herfArtLöschen.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.herfArtLöschen_LinkClicked);
            // 
            // artBestätigungLöschen
            // 
            this.artBestätigungLöschen.BackColor = System.Drawing.Color.Gray;
            this.artBestätigungLöschen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.artBestätigungLöschen.Controls.Add(this.label9);
            this.artBestätigungLöschen.Controls.Add(this.butArtbestätigen);
            this.artBestätigungLöschen.Location = new System.Drawing.Point(161, 59);
            this.artBestätigungLöschen.Name = "artBestätigungLöschen";
            this.artBestätigungLöschen.Size = new System.Drawing.Size(200, 100);
            this.artBestätigungLöschen.TabIndex = 11;
            this.artBestätigungLöschen.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(184, 39);
            this.label9.TabIndex = 1;
            this.label9.Text = "\r\n\r\nDer ausgewählte Artikel wird gelöscht";
            // 
            // butArtbestätigen
            // 
            this.butArtbestätigen.Location = new System.Drawing.Point(59, 47);
            this.butArtbestätigen.Name = "butArtbestätigen";
            this.butArtbestätigen.Size = new System.Drawing.Size(75, 23);
            this.butArtbestätigen.TabIndex = 0;
            this.butArtbestätigen.Text = "Bestätigen";
            this.butArtbestätigen.UseVisualStyleBackColor = true;
            this.butArtbestätigen.Click += new System.EventHandler(this.butArtbestätigen_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Image = global::WindowsFormsApp1.Properties.Resources.info;
            this.label10.Location = new System.Drawing.Point(433, 319);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 13);
            this.label10.TabIndex = 12;
            // 
            // ArtFehler
            // 
            this.ArtFehler.BackColor = System.Drawing.Color.Gray;
            this.ArtFehler.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ArtFehler.Controls.Add(this.label11);
            this.ArtFehler.Controls.Add(this.butArtFehler);
            this.ArtFehler.Location = new System.Drawing.Point(161, 22);
            this.ArtFehler.Name = "ArtFehler";
            this.ArtFehler.Size = new System.Drawing.Size(219, 100);
            this.ArtFehler.TabIndex = 17;
            this.ArtFehler.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(210, 52);
            this.label11.TabIndex = 1;
            this.label11.Text = "Es liegt ein Fehler vor.\r\nKontrolieren Sie ihre eingetragenen Werte. \r\nFalls der " +
    "Fehler weiterhin besteht\r\n starten Sie das Program neu.";
            // 
            // butArtFehler
            // 
            this.butArtFehler.Location = new System.Drawing.Point(59, 60);
            this.butArtFehler.Name = "butArtFehler";
            this.butArtFehler.Size = new System.Drawing.Size(75, 23);
            this.butArtFehler.TabIndex = 0;
            this.butArtFehler.Text = "Bestätigen";
            this.butArtFehler.UseVisualStyleBackColor = true;
            this.butArtFehler.Click += new System.EventHandler(this.butArtFehler_Click);
            // 
            // Artikel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 354);
            this.Controls.Add(this.ArtFehler);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.artBestätigungLöschen);
            this.Controls.Add(this.herfArtLöschen);
            this.Controls.Add(this.herfArtNeu);
            this.Controls.Add(this.lBoxArt);
            this.Controls.Add(this.AbtneueAbteilung);
            this.Name = "Artikel";
            this.Text = "Artikel";
            this.Load += new System.EventHandler(this.Artikel_Load);
            this.AbtneueAbteilung.ResumeLayout(false);
            this.AbtneueAbteilung.PerformLayout();
            this.artBestätigungLöschen.ResumeLayout(false);
            this.artBestätigungLöschen.PerformLayout();
            this.ArtFehler.ResumeLayout(false);
            this.ArtFehler.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lBoxArt;
        private System.Windows.Forms.LinkLabel herfArtNeu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBoxAbtBez;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tBoxArtPreis;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cBoxAbtEinheit;
        private System.Windows.Forms.Panel AbtneueAbteilung;
        private System.Windows.Forms.Button butArtErstellen;
        private System.Windows.Forms.TextBox tBoxArtMaxBst;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tBoxArtMinBst;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tBoxArtBst;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel herfArtLöschen;
        private System.Windows.Forms.LinkLabel herfArtneueEinheit;
        private System.Windows.Forms.LinkLabel herfArtLief;
        private System.Windows.Forms.LinkLabel herfArtLgv;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cBoxArtLager;
        private System.Windows.Forms.ComboBox cBoxArtL;
        private System.Windows.Forms.Panel artBestätigungLöschen;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button butArtbestätigen;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel ArtFehler;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button butArtFehler;
    }
}