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
            this.tBoxAbtPreis = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cBoxAbtEinheit = new System.Windows.Forms.ComboBox();
            this.AbtneueAbteilung = new System.Windows.Forms.Panel();
            this.herfArtneueEinheit = new System.Windows.Forms.LinkLabel();
            this.butArtSpeichern = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.butArtErstellen = new System.Windows.Forms.Button();
            this.herfArtLöschen = new System.Windows.Forms.LinkLabel();
            this.cBoxArtL = new System.Windows.Forms.ComboBox();
            this.cBoxArtLager = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.herfArtLgv = new System.Windows.Forms.LinkLabel();
            this.herfArtLief = new System.Windows.Forms.LinkLabel();
            this.AbtneueAbteilung.SuspendLayout();
            this.SuspendLayout();
            // 
            // lBoxArt
            // 
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
            // tBoxAbtPreis
            // 
            this.tBoxAbtPreis.Location = new System.Drawing.Point(6, 105);
            this.tBoxAbtPreis.Name = "tBoxAbtPreis";
            this.tBoxAbtPreis.Size = new System.Drawing.Size(97, 20);
            this.tBoxAbtPreis.TabIndex = 7;
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
            this.AbtneueAbteilung.Controls.Add(this.butArtSpeichern);
            this.AbtneueAbteilung.Controls.Add(this.textBox3);
            this.AbtneueAbteilung.Controls.Add(this.label6);
            this.AbtneueAbteilung.Controls.Add(this.textBox2);
            this.AbtneueAbteilung.Controls.Add(this.label5);
            this.AbtneueAbteilung.Controls.Add(this.textBox1);
            this.AbtneueAbteilung.Controls.Add(this.label4);
            this.AbtneueAbteilung.Controls.Add(this.butArtErstellen);
            this.AbtneueAbteilung.Controls.Add(this.tBoxAbtPreis);
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
            // butArtSpeichern
            // 
            this.butArtSpeichern.Location = new System.Drawing.Point(6, 170);
            this.butArtSpeichern.Name = "butArtSpeichern";
            this.butArtSpeichern.Size = new System.Drawing.Size(119, 30);
            this.butArtSpeichern.TabIndex = 16;
            this.butArtSpeichern.Text = "Änderung Speichern";
            this.butArtSpeichern.UseVisualStyleBackColor = true;
            this.butArtSpeichern.Visible = false;
            this.butArtSpeichern.Click += new System.EventHandler(this.butArtSpeichern_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(121, 144);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(97, 20);
            this.textBox3.TabIndex = 15;
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
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(6, 144);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(97, 20);
            this.textBox2.TabIndex = 13;
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(121, 105);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(97, 20);
            this.textBox1.TabIndex = 11;
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
            this.butArtErstellen.Visible = false;
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
            // cBoxArtLager
            // 
            this.cBoxArtLager.DisplayMember = "LagerortListe";
            this.cBoxArtLager.FormattingEnabled = true;
            this.cBoxArtLager.Location = new System.Drawing.Point(118, 25);
            this.cBoxArtLager.Name = "cBoxArtLager";
            this.cBoxArtLager.Size = new System.Drawing.Size(97, 21);
            this.cBoxArtLager.TabIndex = 19;
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(118, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Lieferant:";
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
            // Artikel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 354);
            this.Controls.Add(this.herfArtLöschen);
            this.Controls.Add(this.AbtneueAbteilung);
            this.Controls.Add(this.herfArtNeu);
            this.Controls.Add(this.lBoxArt);
            this.Name = "Artikel";
            this.Text = "Artikel";
            this.Load += new System.EventHandler(this.Artikel_Load);
            this.AbtneueAbteilung.ResumeLayout(false);
            this.AbtneueAbteilung.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lBoxArt;
        private System.Windows.Forms.LinkLabel herfArtNeu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBoxAbtBez;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tBoxAbtPreis;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cBoxAbtEinheit;
        private System.Windows.Forms.Panel AbtneueAbteilung;
        private System.Windows.Forms.Button butArtErstellen;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel herfArtLöschen;
        private System.Windows.Forms.Button butArtSpeichern;
        private System.Windows.Forms.LinkLabel herfArtneueEinheit;
        private System.Windows.Forms.LinkLabel herfArtLief;
        private System.Windows.Forms.LinkLabel herfArtLgv;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cBoxArtLager;
        private System.Windows.Forms.ComboBox cBoxArtL;
    }
}