namespace WindowsFormsApp1
{
    partial class Funktion
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
            this.herfFNeue = new System.Windows.Forms.LinkLabel();
            this.FDetail = new System.Windows.Forms.Panel();
            this.butFSpeichern = new System.Windows.Forms.Button();
            this.FMitProAbt = new System.Windows.Forms.Panel();
            this.herfFMit = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.lBoxFMit = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tBoxFBez = new System.Windows.Forms.TextBox();
            this.herfFLöschen = new System.Windows.Forms.LinkLabel();
            this.lBoxF = new System.Windows.Forms.ListBox();
            this.fBestätigungLöschen = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.butRbestätigen = new System.Windows.Forms.Button();
            this.fFehler = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.butFFehler = new System.Windows.Forms.Button();
            this.FDetail.SuspendLayout();
            this.FMitProAbt.SuspendLayout();
            this.fBestätigungLöschen.SuspendLayout();
            this.fFehler.SuspendLayout();
            this.SuspendLayout();
            // 
            // herfFNeue
            // 
            this.herfFNeue.AutoSize = true;
            this.herfFNeue.LinkColor = System.Drawing.SystemColors.Highlight;
            this.herfFNeue.Location = new System.Drawing.Point(49, 9);
            this.herfFNeue.Name = "herfFNeue";
            this.herfFNeue.Size = new System.Drawing.Size(80, 13);
            this.herfFNeue.TabIndex = 19;
            this.herfFNeue.TabStop = true;
            this.herfFNeue.Text = "Neu Funktion...";
            this.herfFNeue.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.herfFNeue_LinkClicked);
            // 
            // FDetail
            // 
            this.FDetail.Controls.Add(this.butFSpeichern);
            this.FDetail.Controls.Add(this.FMitProAbt);
            this.FDetail.Controls.Add(this.label1);
            this.FDetail.Controls.Add(this.tBoxFBez);
            this.FDetail.Location = new System.Drawing.Point(162, 9);
            this.FDetail.Name = "FDetail";
            this.FDetail.Size = new System.Drawing.Size(365, 244);
            this.FDetail.TabIndex = 18;
            this.FDetail.Visible = false;
            // 
            // butFSpeichern
            // 
            this.butFSpeichern.Location = new System.Drawing.Point(17, 64);
            this.butFSpeichern.Name = "butFSpeichern";
            this.butFSpeichern.Size = new System.Drawing.Size(81, 32);
            this.butFSpeichern.TabIndex = 9;
            this.butFSpeichern.Text = "Speichern";
            this.butFSpeichern.UseVisualStyleBackColor = true;
            this.butFSpeichern.Click += new System.EventHandler(this.butFSpeichern_Click);
            // 
            // FMitProAbt
            // 
            this.FMitProAbt.Controls.Add(this.herfFMit);
            this.FMitProAbt.Controls.Add(this.label3);
            this.FMitProAbt.Controls.Add(this.lBoxFMit);
            this.FMitProAbt.Location = new System.Drawing.Point(202, 9);
            this.FMitProAbt.Name = "FMitProAbt";
            this.FMitProAbt.Size = new System.Drawing.Size(200, 239);
            this.FMitProAbt.TabIndex = 7;
            // 
            // herfFMit
            // 
            this.herfFMit.AutoSize = true;
            this.herfFMit.LinkColor = System.Drawing.SystemColors.Highlight;
            this.herfFMit.Location = new System.Drawing.Point(5, 205);
            this.herfFMit.Name = "herfFMit";
            this.herfFMit.Size = new System.Drawing.Size(118, 13);
            this.herfFMit.TabIndex = 2;
            this.herfFMit.TabStop = true;
            this.herfFMit.Text = "Mitarbeiter bearbeiten...";
            this.herfFMit.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mitarbeiter in der Funktion:";
            // 
            // lBoxFMit
            // 
            this.lBoxFMit.FormattingEnabled = true;
            this.lBoxFMit.Items.AddRange(new object[] {
            "TEst"});
            this.lBoxFMit.Location = new System.Drawing.Point(3, 29);
            this.lBoxFMit.Name = "lBoxFMit";
            this.lBoxFMit.Size = new System.Drawing.Size(120, 173);
            this.lBoxFMit.TabIndex = 0;
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
            // tBoxFBez
            // 
            this.tBoxFBez.Location = new System.Drawing.Point(17, 38);
            this.tBoxFBez.Name = "tBoxFBez";
            this.tBoxFBez.Size = new System.Drawing.Size(151, 20);
            this.tBoxFBez.TabIndex = 1;
            // 
            // herfFLöschen
            // 
            this.herfFLöschen.AutoSize = true;
            this.herfFLöschen.LinkColor = System.Drawing.SystemColors.Highlight;
            this.herfFLöschen.Location = new System.Drawing.Point(28, 331);
            this.herfFLöschen.Name = "herfFLöschen";
            this.herfFLöschen.Size = new System.Drawing.Size(101, 13);
            this.herfFLöschen.TabIndex = 17;
            this.herfFLöschen.TabStop = true;
            this.herfFLöschen.Text = "Funktion Löschen...";
            this.herfFLöschen.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.herfFLöschen_LinkClicked);
            // 
            // lBoxF
            // 
            this.lBoxF.DisplayMember = "FunktionListe";
            this.lBoxF.FormattingEnabled = true;
            this.lBoxF.Items.AddRange(new object[] {
            "TEst"});
            this.lBoxF.Location = new System.Drawing.Point(12, 25);
            this.lBoxF.Name = "lBoxF";
            this.lBoxF.Size = new System.Drawing.Size(120, 303);
            this.lBoxF.TabIndex = 16;
            this.lBoxF.SelectedIndexChanged += new System.EventHandler(this.lBoxF_SelectedIndexChanged);
            // 
            // fBestätigungLöschen
            // 
            this.fBestätigungLöschen.BackColor = System.Drawing.Color.Gray;
            this.fBestätigungLöschen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fBestätigungLöschen.Controls.Add(this.label2);
            this.fBestätigungLöschen.Controls.Add(this.butRbestätigen);
            this.fBestätigungLöschen.Location = new System.Drawing.Point(138, 136);
            this.fBestätigungLöschen.Name = "fBestätigungLöschen";
            this.fBestätigungLöschen.Size = new System.Drawing.Size(200, 100);
            this.fBestätigungLöschen.TabIndex = 20;
            this.fBestätigungLöschen.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-1, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Der ausgewählte Funktion wird gelöscht";
            // 
            // butRbestätigen
            // 
            this.butRbestätigen.Location = new System.Drawing.Point(59, 47);
            this.butRbestätigen.Name = "butRbestätigen";
            this.butRbestätigen.Size = new System.Drawing.Size(75, 23);
            this.butRbestätigen.TabIndex = 0;
            this.butRbestätigen.Text = "Bestätigen";
            this.butRbestätigen.UseVisualStyleBackColor = true;
            this.butRbestätigen.Click += new System.EventHandler(this.butRbestätigen_Click);
            // 
            // fFehler
            // 
            this.fFehler.BackColor = System.Drawing.Color.Gray;
            this.fFehler.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fFehler.Controls.Add(this.label6);
            this.fFehler.Controls.Add(this.butFFehler);
            this.fFehler.Location = new System.Drawing.Point(138, 89);
            this.fFehler.Name = "fFehler";
            this.fFehler.Size = new System.Drawing.Size(219, 100);
            this.fFehler.TabIndex = 21;
            this.fFehler.Visible = false;
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
            // butFFehler
            // 
            this.butFFehler.Location = new System.Drawing.Point(59, 60);
            this.butFFehler.Name = "butFFehler";
            this.butFFehler.Size = new System.Drawing.Size(75, 23);
            this.butFFehler.TabIndex = 0;
            this.butFFehler.Text = "Bestätigen";
            this.butFFehler.UseVisualStyleBackColor = true;
            this.butFFehler.Click += new System.EventHandler(this.butFFehler_Click);
            // 
            // Funktion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 380);
            this.Controls.Add(this.fFehler);
            this.Controls.Add(this.fBestätigungLöschen);
            this.Controls.Add(this.herfFNeue);
            this.Controls.Add(this.FDetail);
            this.Controls.Add(this.herfFLöschen);
            this.Controls.Add(this.lBoxF);
            this.Name = "Funktion";
            this.Text = "Funtion";
            this.Load += new System.EventHandler(this.Funktion_Load);
            this.FDetail.ResumeLayout(false);
            this.FDetail.PerformLayout();
            this.FMitProAbt.ResumeLayout(false);
            this.FMitProAbt.PerformLayout();
            this.fBestätigungLöschen.ResumeLayout(false);
            this.fBestätigungLöschen.PerformLayout();
            this.fFehler.ResumeLayout(false);
            this.fFehler.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel herfFNeue;
        private System.Windows.Forms.Panel FDetail;
        private System.Windows.Forms.Button butFSpeichern;
        private System.Windows.Forms.Panel FMitProAbt;
        private System.Windows.Forms.LinkLabel herfFMit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lBoxFMit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBoxFBez;
        private System.Windows.Forms.LinkLabel herfFLöschen;
        private System.Windows.Forms.ListBox lBoxF;
        private System.Windows.Forms.Panel fBestätigungLöschen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button butRbestätigen;
        private System.Windows.Forms.Panel fFehler;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button butFFehler;
    }
}