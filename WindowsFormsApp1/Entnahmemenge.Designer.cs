﻿namespace WindowsFormsApp1
{
    partial class Entnahmemenge
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.bmrBestätigungEinfügen = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.butEmbestätigen = new System.Windows.Forms.Button();
            this.cBoxEmEschein = new System.Windows.Forms.ComboBox();
            this.butEmHinzu = new System.Windows.Forms.Button();
            this.cBoxEmArt = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tBoxEmMenge = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lBoxEmArt = new System.Windows.Forms.ListBox();
            this.butEmBestellt = new System.Windows.Forms.Button();
            this.EmFehler = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.butEmFehler = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.bmrBestätigungEinfügen.SuspendLayout();
            this.EmFehler.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.EmFehler);
            this.panel1.Controls.Add(this.bmrBestätigungEinfügen);
            this.panel1.Controls.Add(this.cBoxEmEschein);
            this.panel1.Controls.Add(this.butEmHinzu);
            this.panel1.Controls.Add(this.cBoxEmArt);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tBoxEmMenge);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lBoxEmArt);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(442, 242);
            this.panel1.TabIndex = 3;
            // 
            // bmrBestätigungEinfügen
            // 
            this.bmrBestätigungEinfügen.BackColor = System.Drawing.Color.Gray;
            this.bmrBestätigungEinfügen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bmrBestätigungEinfügen.Controls.Add(this.label3);
            this.bmrBestätigungEinfügen.Controls.Add(this.butEmbestätigen);
            this.bmrBestätigungEinfügen.Location = new System.Drawing.Point(174, 47);
            this.bmrBestätigungEinfügen.Name = "bmrBestätigungEinfügen";
            this.bmrBestätigungEinfügen.Size = new System.Drawing.Size(229, 100);
            this.bmrBestätigungEinfügen.TabIndex = 12;
            this.bmrBestätigungEinfügen.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(5, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 26);
            this.label3.TabIndex = 1;
            this.label3.Text = "Der Artikelund die Menge werdengespeichert \r\nund können nicht geändert werden";
            // 
            // butEmbestätigen
            // 
            this.butEmbestätigen.Location = new System.Drawing.Point(65, 43);
            this.butEmbestätigen.Name = "butEmbestätigen";
            this.butEmbestätigen.Size = new System.Drawing.Size(75, 23);
            this.butEmbestätigen.TabIndex = 0;
            this.butEmbestätigen.Text = "Bestätigen";
            this.butEmbestätigen.UseVisualStyleBackColor = true;
            this.butEmbestätigen.Click += new System.EventHandler(this.butEmbestätigen_Click);
            // 
            // cBoxEmEschein
            // 
            this.cBoxEmEschein.DisplayMember = "EntnahmeschinListe";
            this.cBoxEmEschein.FormattingEnabled = true;
            this.cBoxEmEschein.Location = new System.Drawing.Point(17, 21);
            this.cBoxEmEschein.Name = "cBoxEmEschein";
            this.cBoxEmEschein.Size = new System.Drawing.Size(121, 21);
            this.cBoxEmEschein.TabIndex = 13;
            this.cBoxEmEschein.SelectedIndexChanged += new System.EventHandler(this.cBoxEmEschein_SelectedIndexChanged);
            // 
            // butEmHinzu
            // 
            this.butEmHinzu.Location = new System.Drawing.Point(269, 165);
            this.butEmHinzu.Name = "butEmHinzu";
            this.butEmHinzu.Size = new System.Drawing.Size(75, 23);
            this.butEmHinzu.TabIndex = 12;
            this.butEmHinzu.Text = "Hinzufügen";
            this.butEmHinzu.UseVisualStyleBackColor = true;
            this.butEmHinzu.Click += new System.EventHandler(this.butEmHinzu_Click);
            // 
            // cBoxEmArt
            // 
            this.cBoxEmArt.DisplayMember = "ArtikelListe";
            this.cBoxEmArt.FormattingEnabled = true;
            this.cBoxEmArt.Location = new System.Drawing.Point(269, 87);
            this.cBoxEmArt.Name = "cBoxEmArt";
            this.cBoxEmArt.Size = new System.Drawing.Size(121, 21);
            this.cBoxEmArt.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Entnahmeschein:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(269, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Menge:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(269, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Artikel:";
            // 
            // tBoxEmMenge
            // 
            this.tBoxEmMenge.Location = new System.Drawing.Point(269, 127);
            this.tBoxEmMenge.Name = "tBoxEmMenge";
            this.tBoxEmMenge.Size = new System.Drawing.Size(121, 20);
            this.tBoxEmMenge.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Alle Artikel im Entnahmeschein:\r\n";
            // 
            // lBoxEmArt
            // 
            this.lBoxEmArt.DisplayMember = "EmArtProEmListe";
            this.lBoxEmArt.FormattingEnabled = true;
            this.lBoxEmArt.Location = new System.Drawing.Point(17, 60);
            this.lBoxEmArt.Name = "lBoxEmArt";
            this.lBoxEmArt.Size = new System.Drawing.Size(234, 147);
            this.lBoxEmArt.TabIndex = 2;
            // 
            // butEmBestellt
            // 
            this.butEmBestellt.Location = new System.Drawing.Point(15, 260);
            this.butEmBestellt.Name = "butEmBestellt";
            this.butEmBestellt.Size = new System.Drawing.Size(138, 23);
            this.butEmBestellt.TabIndex = 14;
            this.butEmBestellt.Text = "Bestellung Abschiken";
            this.butEmBestellt.UseVisualStyleBackColor = true;
            this.butEmBestellt.Click += new System.EventHandler(this.butEmBestellt_Click);
            // 
            // EmFehler
            // 
            this.EmFehler.BackColor = System.Drawing.Color.Gray;
            this.EmFehler.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EmFehler.Controls.Add(this.label6);
            this.EmFehler.Controls.Add(this.butEmFehler);
            this.EmFehler.Location = new System.Drawing.Point(44, 47);
            this.EmFehler.Name = "EmFehler";
            this.EmFehler.Size = new System.Drawing.Size(219, 100);
            this.EmFehler.TabIndex = 18;
            this.EmFehler.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(210, 52);
            this.label6.TabIndex = 1;
            this.label6.Text = "Es liegt ein Fehler vor.\r\nKontrolieren Sie ihre eingetragenen Werte. \r\nFalls der " +
    "Fehler weiterhin besteht\r\n starten Sie das Program neu.";
            // 
            // butEmFehler
            // 
            this.butEmFehler.Location = new System.Drawing.Point(59, 60);
            this.butEmFehler.Name = "butEmFehler";
            this.butEmFehler.Size = new System.Drawing.Size(75, 23);
            this.butEmFehler.TabIndex = 0;
            this.butEmFehler.Text = "Bestätigen";
            this.butEmFehler.UseVisualStyleBackColor = true;
            this.butEmFehler.Click += new System.EventHandler(this.butEmFehler_Click);
            // 
            // Entnahmemenge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 295);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.butEmBestellt);
            this.Name = "Entnahmemenge";
            this.Text = "Entnahmemenge";
            this.Load += new System.EventHandler(this.Entnahmemenge_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.bmrBestätigungEinfügen.ResumeLayout(false);
            this.bmrBestätigungEinfügen.PerformLayout();
            this.EmFehler.ResumeLayout(false);
            this.EmFehler.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button butEmHinzu;
        private System.Windows.Forms.ComboBox cBoxEmArt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tBoxEmMenge;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lBoxEmArt;
        private System.Windows.Forms.ComboBox cBoxEmEschein;
        private System.Windows.Forms.Panel bmrBestätigungEinfügen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button butEmbestätigen;
        private System.Windows.Forms.Button butEmBestellt;
        private System.Windows.Forms.Panel EmFehler;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button butEmFehler;
    }
}