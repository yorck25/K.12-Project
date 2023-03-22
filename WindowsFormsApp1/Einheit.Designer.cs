namespace WindowsFormsApp1
{
    partial class Einheit
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
            this.lBoxEinheit = new System.Windows.Forms.ListBox();
            this.herfEinNeu = new System.Windows.Forms.LinkLabel();
            this.herfEinLöschen = new System.Windows.Forms.LinkLabel();
            this.tBoxEinBez = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.butEinErstellen = new System.Windows.Forms.Button();
            this.EinDetail = new System.Windows.Forms.Panel();
            this.einBestätigungLöschen = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.butEinbestätigen = new System.Windows.Forms.Button();
            this.EinFehler = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.butEinFehler = new System.Windows.Forms.Button();
            this.EinDetail.SuspendLayout();
            this.einBestätigungLöschen.SuspendLayout();
            this.EinFehler.SuspendLayout();
            this.SuspendLayout();
            // 
            // lBoxEinheit
            // 
            this.lBoxEinheit.DisplayMember = "EinheitListe";
            this.lBoxEinheit.FormattingEnabled = true;
            this.lBoxEinheit.Items.AddRange(new object[] {
            "gdfg",
            "df",
            "g",
            "dfg",
            "df",
            "g",
            "dfg"});
            this.lBoxEinheit.Location = new System.Drawing.Point(13, 26);
            this.lBoxEinheit.Name = "lBoxEinheit";
            this.lBoxEinheit.Size = new System.Drawing.Size(120, 212);
            this.lBoxEinheit.TabIndex = 0;
            this.lBoxEinheit.SelectedIndexChanged += new System.EventHandler(this.lBoxEinheit_SelectedIndexChanged);
            // 
            // herfEinNeu
            // 
            this.herfEinNeu.AutoSize = true;
            this.herfEinNeu.LinkColor = System.Drawing.SystemColors.Highlight;
            this.herfEinNeu.Location = new System.Drawing.Point(56, 9);
            this.herfEinNeu.Name = "herfEinNeu";
            this.herfEinNeu.Size = new System.Drawing.Size(77, 13);
            this.herfEinNeu.TabIndex = 1;
            this.herfEinNeu.TabStop = true;
            this.herfEinNeu.Text = "Neue Einheit...";
            this.herfEinNeu.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.herfEinNeu_LinkClicked);
            // 
            // herfEinLöschen
            // 
            this.herfEinLöschen.AutoSize = true;
            this.herfEinLöschen.LinkColor = System.Drawing.SystemColors.Highlight;
            this.herfEinLöschen.Location = new System.Drawing.Point(45, 241);
            this.herfEinLöschen.Name = "herfEinLöschen";
            this.herfEinLöschen.Size = new System.Drawing.Size(88, 13);
            this.herfEinLöschen.TabIndex = 2;
            this.herfEinLöschen.TabStop = true;
            this.herfEinLöschen.Text = "Einheit löschen...";
            this.herfEinLöschen.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // tBoxEinBez
            // 
            this.tBoxEinBez.Location = new System.Drawing.Point(3, 18);
            this.tBoxEinBez.Name = "tBoxEinBez";
            this.tBoxEinBez.Size = new System.Drawing.Size(116, 20);
            this.tBoxEinBez.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Bezeichnung:";
            // 
            // butEinErstellen
            // 
            this.butEinErstellen.Location = new System.Drawing.Point(3, 45);
            this.butEinErstellen.Name = "butEinErstellen";
            this.butEinErstellen.Size = new System.Drawing.Size(75, 23);
            this.butEinErstellen.TabIndex = 5;
            this.butEinErstellen.Text = "Erstellen";
            this.butEinErstellen.UseVisualStyleBackColor = true;
            this.butEinErstellen.Click += new System.EventHandler(this.butEinErstellen_Click);
            // 
            // EinDetail
            // 
            this.EinDetail.Controls.Add(this.label1);
            this.EinDetail.Controls.Add(this.tBoxEinBez);
            this.EinDetail.Controls.Add(this.butEinErstellen);
            this.EinDetail.Location = new System.Drawing.Point(139, 26);
            this.EinDetail.Name = "EinDetail";
            this.EinDetail.Size = new System.Drawing.Size(146, 89);
            this.EinDetail.TabIndex = 7;
            this.EinDetail.Visible = false;
            // 
            // einBestätigungLöschen
            // 
            this.einBestätigungLöschen.BackColor = System.Drawing.Color.Gray;
            this.einBestätigungLöschen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.einBestätigungLöschen.Controls.Add(this.label2);
            this.einBestätigungLöschen.Controls.Add(this.butEinbestätigen);
            this.einBestätigungLöschen.Location = new System.Drawing.Point(142, 121);
            this.einBestätigungLöschen.Name = "einBestätigungLöschen";
            this.einBestätigungLöschen.Size = new System.Drawing.Size(200, 100);
            this.einBestätigungLöschen.TabIndex = 11;
            this.einBestätigungLöschen.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Die Ausgewählte Einheit wird gelöscht\r\n";
            // 
            // butEinbestätigen
            // 
            this.butEinbestätigen.Location = new System.Drawing.Point(59, 47);
            this.butEinbestätigen.Name = "butEinbestätigen";
            this.butEinbestätigen.Size = new System.Drawing.Size(75, 23);
            this.butEinbestätigen.TabIndex = 0;
            this.butEinbestätigen.Text = "Bestätigen";
            this.butEinbestätigen.UseVisualStyleBackColor = true;
            this.butEinbestätigen.Click += new System.EventHandler(this.butEinbestätigen_Click);
            // 
            // EinFehler
            // 
            this.EinFehler.BackColor = System.Drawing.Color.Gray;
            this.EinFehler.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EinFehler.Controls.Add(this.label5);
            this.EinFehler.Controls.Add(this.butEinFehler);
            this.EinFehler.Location = new System.Drawing.Point(139, 71);
            this.EinFehler.Name = "EinFehler";
            this.EinFehler.Size = new System.Drawing.Size(219, 100);
            this.EinFehler.TabIndex = 17;
            this.EinFehler.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(210, 52);
            this.label5.TabIndex = 1;
            this.label5.Text = "Es liegt ein Fehler vor.\r\nKontrolieren Sie ihre eingetragenen Werte. \r\nFalls der " +
    "Fehler weiterhin besteht\r\n starten Sie das Program neu.";
            // 
            // butEinFehler
            // 
            this.butEinFehler.Location = new System.Drawing.Point(59, 60);
            this.butEinFehler.Name = "butEinFehler";
            this.butEinFehler.Size = new System.Drawing.Size(75, 23);
            this.butEinFehler.TabIndex = 0;
            this.butEinFehler.Text = "Bestätigen";
            this.butEinFehler.UseVisualStyleBackColor = true;
            this.butEinFehler.Click += new System.EventHandler(this.butEinFehler_Click);
            // 
            // Einheit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 263);
            this.Controls.Add(this.EinFehler);
            this.Controls.Add(this.einBestätigungLöschen);
            this.Controls.Add(this.EinDetail);
            this.Controls.Add(this.herfEinLöschen);
            this.Controls.Add(this.herfEinNeu);
            this.Controls.Add(this.lBoxEinheit);
            this.Name = "Einheit";
            this.Text = "Einheit";
            this.Load += new System.EventHandler(this.Einheit_Load);
            this.EinDetail.ResumeLayout(false);
            this.EinDetail.PerformLayout();
            this.einBestätigungLöschen.ResumeLayout(false);
            this.einBestätigungLöschen.PerformLayout();
            this.EinFehler.ResumeLayout(false);
            this.EinFehler.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lBoxEinheit;
        private System.Windows.Forms.LinkLabel herfEinNeu;
        private System.Windows.Forms.LinkLabel herfEinLöschen;
        private System.Windows.Forms.TextBox tBoxEinBez;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butEinErstellen;
        internal System.Windows.Forms.Panel EinDetail;
        private System.Windows.Forms.Panel einBestätigungLöschen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button butEinbestätigen;
        private System.Windows.Forms.Panel EinFehler;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button butEinFehler;
    }
}