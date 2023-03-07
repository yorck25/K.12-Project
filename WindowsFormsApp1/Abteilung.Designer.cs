namespace WindowsFormsApp1
{
    partial class Abteilung
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
            this.lBoxAbt = new System.Windows.Forms.ListBox();
            this.tBoxAbtBez = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cBoxAbtKst = new System.Windows.Forms.ComboBox();
            this.herfAbtLöschen = new System.Windows.Forms.LinkLabel();
            this.AbtMitProAbt = new System.Windows.Forms.Panel();
            this.herfAbtMitarebiter = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.lBoxAbtMit = new System.Windows.Forms.ListBox();
            this.butAbtBearbeiten = new System.Windows.Forms.Button();
            this.AbtDetail = new System.Windows.Forms.Panel();
            this.herfAbtKst = new System.Windows.Forms.LinkLabel();
            this.herfAbtNeu = new System.Windows.Forms.LinkLabel();
            this.AbtMitProAbt.SuspendLayout();
            this.AbtDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // lBoxAbt
            // 
            this.lBoxAbt.DisplayMember = "AbteilungsListe";
            this.lBoxAbt.FormattingEnabled = true;
            this.lBoxAbt.Items.AddRange(new object[] {
            "TEst"});
            this.lBoxAbt.Location = new System.Drawing.Point(25, 30);
            this.lBoxAbt.Name = "lBoxAbt";
            this.lBoxAbt.Size = new System.Drawing.Size(120, 303);
            this.lBoxAbt.TabIndex = 0;
            this.lBoxAbt.SelectedIndexChanged += new System.EventHandler(this.lBoxAbt_SelectedIndexChanged);
            // 
            // tBoxAbtBez
            // 
            this.tBoxAbtBez.Location = new System.Drawing.Point(17, 38);
            this.tBoxAbtBez.Name = "tBoxAbtBez";
            this.tBoxAbtBez.Size = new System.Drawing.Size(151, 20);
            this.tBoxAbtBez.TabIndex = 1;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kostenstelle";
            // 
            // cBoxAbtKst
            // 
            this.cBoxAbtKst.DisplayMember = "KostenstelleListe";
            this.cBoxAbtKst.FormattingEnabled = true;
            this.cBoxAbtKst.Location = new System.Drawing.Point(17, 96);
            this.cBoxAbtKst.Name = "cBoxAbtKst";
            this.cBoxAbtKst.Size = new System.Drawing.Size(151, 21);
            this.cBoxAbtKst.TabIndex = 5;
            this.cBoxAbtKst.SelectedIndexChanged += new System.EventHandler(this.cBoxAbtKst_SelectedIndexChanged);
            // 
            // herfAbtLöschen
            // 
            this.herfAbtLöschen.AutoSize = true;
            this.herfAbtLöschen.LinkColor = System.Drawing.SystemColors.Highlight;
            this.herfAbtLöschen.Location = new System.Drawing.Point(41, 336);
            this.herfAbtLöschen.Name = "herfAbtLöschen";
            this.herfAbtLöschen.Size = new System.Drawing.Size(104, 13);
            this.herfAbtLöschen.TabIndex = 6;
            this.herfAbtLöschen.TabStop = true;
            this.herfAbtLöschen.Text = "Abteilung Löschen...";
            // 
            // AbtMitProAbt
            // 
            this.AbtMitProAbt.Controls.Add(this.herfAbtMitarebiter);
            this.AbtMitProAbt.Controls.Add(this.label3);
            this.AbtMitProAbt.Controls.Add(this.lBoxAbtMit);
            this.AbtMitProAbt.Location = new System.Drawing.Point(202, 9);
            this.AbtMitProAbt.Name = "AbtMitProAbt";
            this.AbtMitProAbt.Size = new System.Drawing.Size(200, 239);
            this.AbtMitProAbt.TabIndex = 7;
            // 
            // herfAbtMitarebiter
            // 
            this.herfAbtMitarebiter.AutoSize = true;
            this.herfAbtMitarebiter.LinkColor = System.Drawing.SystemColors.Highlight;
            this.herfAbtMitarebiter.Location = new System.Drawing.Point(5, 205);
            this.herfAbtMitarebiter.Name = "herfAbtMitarebiter";
            this.herfAbtMitarebiter.Size = new System.Drawing.Size(118, 13);
            this.herfAbtMitarebiter.TabIndex = 2;
            this.herfAbtMitarebiter.TabStop = true;
            this.herfAbtMitarebiter.Text = "Mitarbeiter bearbeiten...";
            this.herfAbtMitarebiter.Visible = false;
            this.herfAbtMitarebiter.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.herfAbtMitarebiter_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mitarbeiter in der Abteilung:";
            // 
            // lBoxAbtMit
            // 
            this.lBoxAbtMit.FormattingEnabled = true;
            this.lBoxAbtMit.Items.AddRange(new object[] {
            "TEst"});
            this.lBoxAbtMit.Location = new System.Drawing.Point(3, 29);
            this.lBoxAbtMit.Name = "lBoxAbtMit";
            this.lBoxAbtMit.Size = new System.Drawing.Size(120, 173);
            this.lBoxAbtMit.TabIndex = 0;
            this.lBoxAbtMit.SelectedIndexChanged += new System.EventHandler(this.lBoxAbtMit_SelectedIndexChanged);
            // 
            // butAbtBearbeiten
            // 
            this.butAbtBearbeiten.Location = new System.Drawing.Point(17, 140);
            this.butAbtBearbeiten.Name = "butAbtBearbeiten";
            this.butAbtBearbeiten.Size = new System.Drawing.Size(81, 32);
            this.butAbtBearbeiten.TabIndex = 9;
            this.butAbtBearbeiten.Text = "Speichern";
            this.butAbtBearbeiten.UseVisualStyleBackColor = true;
            this.butAbtBearbeiten.Click += new System.EventHandler(this.butAbtBearbeiten_Click);
            // 
            // AbtDetail
            // 
            this.AbtDetail.Controls.Add(this.herfAbtKst);
            this.AbtDetail.Controls.Add(this.butAbtBearbeiten);
            this.AbtDetail.Controls.Add(this.AbtMitProAbt);
            this.AbtDetail.Controls.Add(this.cBoxAbtKst);
            this.AbtDetail.Controls.Add(this.label2);
            this.AbtDetail.Controls.Add(this.label1);
            this.AbtDetail.Controls.Add(this.tBoxAbtBez);
            this.AbtDetail.Location = new System.Drawing.Point(151, 12);
            this.AbtDetail.Name = "AbtDetail";
            this.AbtDetail.Size = new System.Drawing.Size(413, 329);
            this.AbtDetail.TabIndex = 10;
            this.AbtDetail.Visible = false;
            // 
            // herfAbtKst
            // 
            this.herfAbtKst.AutoSize = true;
            this.herfAbtKst.LinkColor = System.Drawing.SystemColors.Highlight;
            this.herfAbtKst.Location = new System.Drawing.Point(17, 124);
            this.herfAbtKst.Name = "herfAbtKst";
            this.herfAbtKst.Size = new System.Drawing.Size(102, 13);
            this.herfAbtKst.TabIndex = 10;
            this.herfAbtKst.TabStop = true;
            this.herfAbtKst.Text = "Neue Kostenstelle...";
            this.herfAbtKst.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.herfAbtKst_LinkClicked);
            // 
            // herfAbtNeu
            // 
            this.herfAbtNeu.AutoSize = true;
            this.herfAbtNeu.LinkColor = System.Drawing.SystemColors.Highlight;
            this.herfAbtNeu.Location = new System.Drawing.Point(62, 14);
            this.herfAbtNeu.Name = "herfAbtNeu";
            this.herfAbtNeu.Size = new System.Drawing.Size(83, 13);
            this.herfAbtNeu.TabIndex = 15;
            this.herfAbtNeu.TabStop = true;
            this.herfAbtNeu.Text = "Neu Abteilung...";
            this.herfAbtNeu.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.herfAbtNeu_LinkClicked);
            // 
            // Abteilung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 363);
            this.Controls.Add(this.herfAbtNeu);
            this.Controls.Add(this.AbtDetail);
            this.Controls.Add(this.herfAbtLöschen);
            this.Controls.Add(this.lBoxAbt);
            this.Name = "Abteilung";
            this.Text = "Abteilung";
            this.Load += new System.EventHandler(this.Abteilung_Load);
            this.AbtMitProAbt.ResumeLayout(false);
            this.AbtMitProAbt.PerformLayout();
            this.AbtDetail.ResumeLayout(false);
            this.AbtDetail.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lBoxAbt;
        private System.Windows.Forms.TextBox tBoxAbtBez;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cBoxAbtKst;
        private System.Windows.Forms.LinkLabel herfAbtLöschen;
        private System.Windows.Forms.Panel AbtMitProAbt;
        private System.Windows.Forms.LinkLabel herfAbtMitarebiter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lBoxAbtMit;
        private System.Windows.Forms.Button butAbtBearbeiten;
        private System.Windows.Forms.Panel AbtDetail;
        private System.Windows.Forms.LinkLabel herfAbtKst;
        private System.Windows.Forms.LinkLabel herfAbtNeu;
    }
}