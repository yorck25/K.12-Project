﻿namespace WindowsFormsApp1
{
    partial class Kostenstelle
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
            this.KstDetail = new System.Windows.Forms.Panel();
            this.KstFehlereingabe = new System.Windows.Forms.Label();
            this.butKstSpeichern = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tBoxKstBez = new System.Windows.Forms.TextBox();
            this.AbtMitProAbt = new System.Windows.Forms.Panel();
            this.herfKstAbt = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.lBoxKstAbt = new System.Windows.Forms.ListBox();
            this.herfKstLöschen = new System.Windows.Forms.LinkLabel();
            this.lBoxKst = new System.Windows.Forms.ListBox();
            this.herfKstNew = new System.Windows.Forms.LinkLabel();
            this.KstBestätigungLöschen = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.butKstbestätigen = new System.Windows.Forms.Button();
            this.KstFehler = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.butKstFehler = new System.Windows.Forms.Button();
            this.KstDetail.SuspendLayout();
            this.AbtMitProAbt.SuspendLayout();
            this.KstBestätigungLöschen.SuspendLayout();
            this.KstFehler.SuspendLayout();
            this.SuspendLayout();
            // 
            // KstDetail
            // 
            this.KstDetail.Controls.Add(this.KstFehlereingabe);
            this.KstDetail.Controls.Add(this.butKstSpeichern);
            this.KstDetail.Controls.Add(this.label1);
            this.KstDetail.Controls.Add(this.tBoxKstBez);
            this.KstDetail.Location = new System.Drawing.Point(138, 8);
            this.KstDetail.Name = "KstDetail";
            this.KstDetail.Size = new System.Drawing.Size(194, 118);
            this.KstDetail.TabIndex = 13;
            this.KstDetail.Visible = false;
            this.KstDetail.Paint += new System.Windows.Forms.PaintEventHandler(this.KstDetail_Paint);
            // 
            // KstFehlereingabe
            // 
            this.KstFehlereingabe.AutoSize = true;
            this.KstFehlereingabe.ForeColor = System.Drawing.Color.Red;
            this.KstFehlereingabe.Location = new System.Drawing.Point(95, 19);
            this.KstFehlereingabe.Name = "KstFehlereingabe";
            this.KstFehlereingabe.Size = new System.Drawing.Size(76, 13);
            this.KstFehlereingabe.TabIndex = 11;
            this.KstFehlereingabe.Text = "Keine Eingabe";
            this.KstFehlereingabe.Visible = false;
            // 
            // butKstSpeichern
            // 
            this.butKstSpeichern.Location = new System.Drawing.Point(17, 64);
            this.butKstSpeichern.Name = "butKstSpeichern";
            this.butKstSpeichern.Size = new System.Drawing.Size(81, 32);
            this.butKstSpeichern.TabIndex = 10;
            this.butKstSpeichern.Text = "Speichern";
            this.butKstSpeichern.UseVisualStyleBackColor = true;
            this.butKstSpeichern.Click += new System.EventHandler(this.butKstSpeichern_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bezeichnung:";
            // 
            // tBoxKstBez
            // 
            this.tBoxKstBez.Location = new System.Drawing.Point(17, 38);
            this.tBoxKstBez.Name = "tBoxKstBez";
            this.tBoxKstBez.Size = new System.Drawing.Size(151, 20);
            this.tBoxKstBez.TabIndex = 1;
            this.tBoxKstBez.TextChanged += new System.EventHandler(this.tBoxKstBez_TextChanged);
            // 
            // AbtMitProAbt
            // 
            this.AbtMitProAbt.Controls.Add(this.herfKstAbt);
            this.AbtMitProAbt.Controls.Add(this.label3);
            this.AbtMitProAbt.Controls.Add(this.lBoxKstAbt);
            this.AbtMitProAbt.Location = new System.Drawing.Point(347, 8);
            this.AbtMitProAbt.Name = "AbtMitProAbt";
            this.AbtMitProAbt.Size = new System.Drawing.Size(200, 239);
            this.AbtMitProAbt.TabIndex = 7;
            this.AbtMitProAbt.Visible = false;
            this.AbtMitProAbt.Paint += new System.Windows.Forms.PaintEventHandler(this.AbtMitProAbt_Paint);
            // 
            // herfKstAbt
            // 
            this.herfKstAbt.AutoSize = true;
            this.herfKstAbt.LinkColor = System.Drawing.SystemColors.Highlight;
            this.herfKstAbt.Location = new System.Drawing.Point(5, 205);
            this.herfKstAbt.Name = "herfKstAbt";
            this.herfKstAbt.Size = new System.Drawing.Size(113, 13);
            this.herfKstAbt.TabIndex = 2;
            this.herfKstAbt.TabStop = true;
            this.herfKstAbt.Text = "Abteilung bearbeiten...";
            this.herfKstAbt.Visible = false;
            this.herfKstAbt.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.herfKstAbt_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Abteilung in der Kostenstelle";
            // 
            // lBoxKstAbt
            // 
            this.lBoxKstAbt.FormattingEnabled = true;
            this.lBoxKstAbt.Items.AddRange(new object[] {
            "TEst"});
            this.lBoxKstAbt.Location = new System.Drawing.Point(3, 29);
            this.lBoxKstAbt.Name = "lBoxKstAbt";
            this.lBoxKstAbt.Size = new System.Drawing.Size(120, 173);
            this.lBoxKstAbt.TabIndex = 0;
            this.lBoxKstAbt.SelectedIndexChanged += new System.EventHandler(this.lBoxKstAbt_SelectedIndexChanged);
            // 
            // herfKstLöschen
            // 
            this.herfKstLöschen.AutoSize = true;
            this.herfKstLöschen.LinkColor = System.Drawing.SystemColors.Highlight;
            this.herfKstLöschen.Location = new System.Drawing.Point(15, 332);
            this.herfKstLöschen.Name = "herfKstLöschen";
            this.herfKstLöschen.Size = new System.Drawing.Size(117, 13);
            this.herfKstLöschen.TabIndex = 12;
            this.herfKstLöschen.TabStop = true;
            this.herfKstLöschen.Text = "Kostenstelle Löschen...";
            this.herfKstLöschen.Visible = false;
            this.herfKstLöschen.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.herfKstLöschen_LinkClicked);
            // 
            // lBoxKst
            // 
            this.lBoxKst.DisplayMember = "KostenstelleListe";
            this.lBoxKst.FormattingEnabled = true;
            this.lBoxKst.Items.AddRange(new object[] {
            "TEst"});
            this.lBoxKst.Location = new System.Drawing.Point(12, 26);
            this.lBoxKst.Name = "lBoxKst";
            this.lBoxKst.Size = new System.Drawing.Size(120, 303);
            this.lBoxKst.TabIndex = 11;
            this.lBoxKst.SelectedIndexChanged += new System.EventHandler(this.lBoxKst_SelectedIndexChanged);
            // 
            // herfKstNew
            // 
            this.herfKstNew.AutoSize = true;
            this.herfKstNew.LinkColor = System.Drawing.SystemColors.Highlight;
            this.herfKstNew.Location = new System.Drawing.Point(36, 8);
            this.herfKstNew.Name = "herfKstNew";
            this.herfKstNew.Size = new System.Drawing.Size(96, 13);
            this.herfKstNew.TabIndex = 14;
            this.herfKstNew.TabStop = true;
            this.herfKstNew.Text = "Neu Kostenstelle...";
            this.herfKstNew.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.herfKstNew_LinkClicked);
            // 
            // KstBestätigungLöschen
            // 
            this.KstBestätigungLöschen.BackColor = System.Drawing.Color.Gray;
            this.KstBestätigungLöschen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.KstBestätigungLöschen.Controls.Add(this.label2);
            this.KstBestätigungLöschen.Controls.Add(this.butKstbestätigen);
            this.KstBestätigungLöschen.Location = new System.Drawing.Point(194, 132);
            this.KstBestätigungLöschen.Name = "KstBestätigungLöschen";
            this.KstBestätigungLöschen.Size = new System.Drawing.Size(219, 100);
            this.KstBestätigungLöschen.TabIndex = 15;
            this.KstBestätigungLöschen.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Der ausgewählte Kostenstelle wird gelöscht";
            // 
            // butKstbestätigen
            // 
            this.butKstbestätigen.Location = new System.Drawing.Point(71, 44);
            this.butKstbestätigen.Name = "butKstbestätigen";
            this.butKstbestätigen.Size = new System.Drawing.Size(75, 23);
            this.butKstbestätigen.TabIndex = 0;
            this.butKstbestätigen.Text = "Bestätigen";
            this.butKstbestätigen.UseVisualStyleBackColor = true;
            this.butKstbestätigen.Click += new System.EventHandler(this.butKstbestätigen_Click);
            // 
            // KstFehler
            // 
            this.KstFehler.BackColor = System.Drawing.Color.Gray;
            this.KstFehler.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.KstFehler.Controls.Add(this.label11);
            this.KstFehler.Controls.Add(this.butKstFehler);
            this.KstFehler.Location = new System.Drawing.Point(127, 213);
            this.KstFehler.Name = "KstFehler";
            this.KstFehler.Size = new System.Drawing.Size(219, 100);
            this.KstFehler.TabIndex = 18;
            this.KstFehler.Visible = false;
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
            // butKstFehler
            // 
            this.butKstFehler.Location = new System.Drawing.Point(59, 60);
            this.butKstFehler.Name = "butKstFehler";
            this.butKstFehler.Size = new System.Drawing.Size(75, 23);
            this.butKstFehler.TabIndex = 0;
            this.butKstFehler.Text = "Bestätigen";
            this.butKstFehler.UseVisualStyleBackColor = true;
            this.butKstFehler.Click += new System.EventHandler(this.butKstFehler_Click);
            // 
            // Kostenstelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 367);
            this.Controls.Add(this.KstFehler);
            this.Controls.Add(this.KstBestätigungLöschen);
            this.Controls.Add(this.herfKstNew);
            this.Controls.Add(this.KstDetail);
            this.Controls.Add(this.AbtMitProAbt);
            this.Controls.Add(this.herfKstLöschen);
            this.Controls.Add(this.lBoxKst);
            this.Name = "Kostenstelle";
            this.Text = "Kostenstelle";
            this.Load += new System.EventHandler(this.Kostenstelle_Load);
            this.KstDetail.ResumeLayout(false);
            this.KstDetail.PerformLayout();
            this.AbtMitProAbt.ResumeLayout(false);
            this.AbtMitProAbt.PerformLayout();
            this.KstBestätigungLöschen.ResumeLayout(false);
            this.KstBestätigungLöschen.PerformLayout();
            this.KstFehler.ResumeLayout(false);
            this.KstFehler.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel KstDetail;
        private System.Windows.Forms.Panel AbtMitProAbt;
        private System.Windows.Forms.LinkLabel herfKstAbt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lBoxKstAbt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBoxKstBez;
        private System.Windows.Forms.LinkLabel herfKstLöschen;
        private System.Windows.Forms.ListBox lBoxKst;
        private System.Windows.Forms.Button butKstSpeichern;
        private System.Windows.Forms.LinkLabel herfKstNew;
        private System.Windows.Forms.Label KstFehlereingabe;
        private System.Windows.Forms.Panel KstBestätigungLöschen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button butKstbestätigen;
        private System.Windows.Forms.Panel KstFehler;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button butKstFehler;
    }
}