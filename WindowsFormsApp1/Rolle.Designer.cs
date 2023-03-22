namespace WindowsFormsApp1
{
    partial class Rolle
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
            this.herfRNeue = new System.Windows.Forms.LinkLabel();
            this.RDetail = new System.Windows.Forms.Panel();
            this.rBestätigungLöschen = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.butRbestätigen = new System.Windows.Forms.Button();
            this.butRSpeichern = new System.Windows.Forms.Button();
            this.RMitProAbt = new System.Windows.Forms.Panel();
            this.herfRMit = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.lBoxRMit = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tBoxRBez = new System.Windows.Forms.TextBox();
            this.herfRLöschen = new System.Windows.Forms.LinkLabel();
            this.lBoxR = new System.Windows.Forms.ListBox();
            this.rFehler = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.butRFehler = new System.Windows.Forms.Button();
            this.RDetail.SuspendLayout();
            this.rBestätigungLöschen.SuspendLayout();
            this.RMitProAbt.SuspendLayout();
            this.rFehler.SuspendLayout();
            this.SuspendLayout();
            // 
            // herfRNeue
            // 
            this.herfRNeue.AutoSize = true;
            this.herfRNeue.LinkColor = System.Drawing.SystemColors.Highlight;
            this.herfRNeue.Location = new System.Drawing.Point(69, 4);
            this.herfRNeue.Name = "herfRNeue";
            this.herfRNeue.Size = new System.Drawing.Size(63, 13);
            this.herfRNeue.TabIndex = 23;
            this.herfRNeue.TabStop = true;
            this.herfRNeue.Text = "Neu Rolle...";
            this.herfRNeue.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.herfRNeue_LinkClicked);
            // 
            // RDetail
            // 
            this.RDetail.Controls.Add(this.rBestätigungLöschen);
            this.RDetail.Controls.Add(this.butRSpeichern);
            this.RDetail.Controls.Add(this.RMitProAbt);
            this.RDetail.Controls.Add(this.label1);
            this.RDetail.Controls.Add(this.tBoxRBez);
            this.RDetail.Location = new System.Drawing.Point(149, 4);
            this.RDetail.Name = "RDetail";
            this.RDetail.Size = new System.Drawing.Size(413, 329);
            this.RDetail.TabIndex = 22;
            this.RDetail.Visible = false;
            // 
            // rBestätigungLöschen
            // 
            this.rBestätigungLöschen.BackColor = System.Drawing.Color.Gray;
            this.rBestätigungLöschen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rBestätigungLöschen.Controls.Add(this.label2);
            this.rBestätigungLöschen.Controls.Add(this.butRbestätigen);
            this.rBestätigungLöschen.Location = new System.Drawing.Point(17, 145);
            this.rBestätigungLöschen.Name = "rBestätigungLöschen";
            this.rBestätigungLöschen.Size = new System.Drawing.Size(200, 100);
            this.rBestätigungLöschen.TabIndex = 10;
            this.rBestätigungLöschen.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Die Ausgewählte Rolle wird gelösche";
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
            // butRSpeichern
            // 
            this.butRSpeichern.Location = new System.Drawing.Point(17, 64);
            this.butRSpeichern.Name = "butRSpeichern";
            this.butRSpeichern.Size = new System.Drawing.Size(81, 32);
            this.butRSpeichern.TabIndex = 9;
            this.butRSpeichern.Text = "Speichern";
            this.butRSpeichern.UseVisualStyleBackColor = true;
            this.butRSpeichern.Click += new System.EventHandler(this.butRSpeichern_Click);
            // 
            // RMitProAbt
            // 
            this.RMitProAbt.Controls.Add(this.herfRMit);
            this.RMitProAbt.Controls.Add(this.label3);
            this.RMitProAbt.Controls.Add(this.lBoxRMit);
            this.RMitProAbt.Location = new System.Drawing.Point(202, 9);
            this.RMitProAbt.Name = "RMitProAbt";
            this.RMitProAbt.Size = new System.Drawing.Size(200, 239);
            this.RMitProAbt.TabIndex = 7;
            // 
            // herfRMit
            // 
            this.herfRMit.AutoSize = true;
            this.herfRMit.LinkColor = System.Drawing.SystemColors.Highlight;
            this.herfRMit.Location = new System.Drawing.Point(5, 205);
            this.herfRMit.Name = "herfRMit";
            this.herfRMit.Size = new System.Drawing.Size(118, 13);
            this.herfRMit.TabIndex = 2;
            this.herfRMit.TabStop = true;
            this.herfRMit.Text = "Mitarbeiter bearbeiten...";
            this.herfRMit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.herfRMit_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mitarbeiter in der Rolle:";
            // 
            // lBoxRMit
            // 
            this.lBoxRMit.FormattingEnabled = true;
            this.lBoxRMit.Items.AddRange(new object[] {
            "TEst"});
            this.lBoxRMit.Location = new System.Drawing.Point(3, 29);
            this.lBoxRMit.Name = "lBoxRMit";
            this.lBoxRMit.Size = new System.Drawing.Size(120, 173);
            this.lBoxRMit.TabIndex = 0;
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
            // tBoxRBez
            // 
            this.tBoxRBez.Location = new System.Drawing.Point(17, 38);
            this.tBoxRBez.Name = "tBoxRBez";
            this.tBoxRBez.Size = new System.Drawing.Size(151, 20);
            this.tBoxRBez.TabIndex = 1;
            // 
            // herfRLöschen
            // 
            this.herfRLöschen.AutoSize = true;
            this.herfRLöschen.LinkColor = System.Drawing.SystemColors.Highlight;
            this.herfRLöschen.Location = new System.Drawing.Point(48, 328);
            this.herfRLöschen.Name = "herfRLöschen";
            this.herfRLöschen.Size = new System.Drawing.Size(84, 13);
            this.herfRLöschen.TabIndex = 21;
            this.herfRLöschen.TabStop = true;
            this.herfRLöschen.Text = "Rolle Löschen...";
            this.herfRLöschen.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.herfRLöschen_LinkClicked);
            // 
            // lBoxR
            // 
            this.lBoxR.DisplayMember = "RolleListe";
            this.lBoxR.FormattingEnabled = true;
            this.lBoxR.Items.AddRange(new object[] {
            "TEst"});
            this.lBoxR.Location = new System.Drawing.Point(12, 22);
            this.lBoxR.Name = "lBoxR";
            this.lBoxR.Size = new System.Drawing.Size(120, 303);
            this.lBoxR.TabIndex = 20;
            this.lBoxR.SelectedIndexChanged += new System.EventHandler(this.lBoxR_SelectedIndexChanged);
            // 
            // rFehler
            // 
            this.rFehler.BackColor = System.Drawing.Color.Gray;
            this.rFehler.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rFehler.Controls.Add(this.label11);
            this.rFehler.Controls.Add(this.butRFehler);
            this.rFehler.Location = new System.Drawing.Point(138, 91);
            this.rFehler.Name = "rFehler";
            this.rFehler.Size = new System.Drawing.Size(219, 100);
            this.rFehler.TabIndex = 52;
            this.rFehler.Visible = false;
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
            // butRFehler
            // 
            this.butRFehler.Location = new System.Drawing.Point(59, 60);
            this.butRFehler.Name = "butRFehler";
            this.butRFehler.Size = new System.Drawing.Size(75, 23);
            this.butRFehler.TabIndex = 0;
            this.butRFehler.Text = "Bestätigen";
            this.butRFehler.UseVisualStyleBackColor = true;
            this.butRFehler.Click += new System.EventHandler(this.butRFehler_Click);
            // 
            // Rolle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 346);
            this.Controls.Add(this.rFehler);
            this.Controls.Add(this.herfRNeue);
            this.Controls.Add(this.RDetail);
            this.Controls.Add(this.herfRLöschen);
            this.Controls.Add(this.lBoxR);
            this.Name = "Rolle";
            this.Text = "Rolle";
            this.Load += new System.EventHandler(this.Rolle_Load);
            this.RDetail.ResumeLayout(false);
            this.RDetail.PerformLayout();
            this.rBestätigungLöschen.ResumeLayout(false);
            this.rBestätigungLöschen.PerformLayout();
            this.RMitProAbt.ResumeLayout(false);
            this.RMitProAbt.PerformLayout();
            this.rFehler.ResumeLayout(false);
            this.rFehler.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel herfRNeue;
        private System.Windows.Forms.Panel RDetail;
        private System.Windows.Forms.Button butRSpeichern;
        private System.Windows.Forms.Panel RMitProAbt;
        private System.Windows.Forms.LinkLabel herfRMit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lBoxRMit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBoxRBez;
        private System.Windows.Forms.LinkLabel herfRLöschen;
        private System.Windows.Forms.ListBox lBoxR;
        private System.Windows.Forms.Panel rBestätigungLöschen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button butRbestätigen;
        private System.Windows.Forms.Panel rFehler;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button butRFehler;
    }
}