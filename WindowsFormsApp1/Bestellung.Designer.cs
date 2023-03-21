namespace WindowsFormsApp1
{
    partial class Bestellung
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
            this.lBoxBestellung = new System.Windows.Forms.ListBox();
            this.herfBNeu = new System.Windows.Forms.LinkLabel();
            this.BestellungDetail = new System.Windows.Forms.Panel();
            this.butBArtikel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cBoxBMit = new System.Windows.Forms.ComboBox();
            this.butBsMehrArt = new System.Windows.Forms.Button();
            this.BestellungDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // lBoxBestellung
            // 
            this.lBoxBestellung.DisplayMember = "BestellungListe";
            this.lBoxBestellung.FormattingEnabled = true;
            this.lBoxBestellung.Location = new System.Drawing.Point(12, 29);
            this.lBoxBestellung.Name = "lBoxBestellung";
            this.lBoxBestellung.Size = new System.Drawing.Size(120, 329);
            this.lBoxBestellung.TabIndex = 0;
            this.lBoxBestellung.SelectedIndexChanged += new System.EventHandler(this.lBoxBestellung_SelectedIndexChanged);
            // 
            // herfBNeu
            // 
            this.herfBNeu.AutoSize = true;
            this.herfBNeu.LinkColor = System.Drawing.SystemColors.Highlight;
            this.herfBNeu.Location = new System.Drawing.Point(38, 13);
            this.herfBNeu.Name = "herfBNeu";
            this.herfBNeu.Size = new System.Drawing.Size(94, 13);
            this.herfBNeu.TabIndex = 1;
            this.herfBNeu.TabStop = true;
            this.herfBNeu.Text = "Neue Bestellung...";
            this.herfBNeu.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.herfBNeu_LinkClicked);
            // 
            // BestellungDetail
            // 
            this.BestellungDetail.Controls.Add(this.butBArtikel);
            this.BestellungDetail.Controls.Add(this.label2);
            this.BestellungDetail.Controls.Add(this.cBoxBMit);
            this.BestellungDetail.Location = new System.Drawing.Point(154, 29);
            this.BestellungDetail.Name = "BestellungDetail";
            this.BestellungDetail.Size = new System.Drawing.Size(142, 93);
            this.BestellungDetail.TabIndex = 3;
            this.BestellungDetail.Visible = false;
            // 
            // butBArtikel
            // 
            this.butBArtikel.Location = new System.Drawing.Point(3, 49);
            this.butBArtikel.Name = "butBArtikel";
            this.butBArtikel.Size = new System.Drawing.Size(121, 35);
            this.butBArtikel.TabIndex = 7;
            this.butBArtikel.Text = "Artikel zu Bestellung hinzufügen...";
            this.butBArtikel.UseVisualStyleBackColor = true;
            this.butBArtikel.Click += new System.EventHandler(this.butBArtikel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mitarbeiter:";
            // 
            // cBoxBMit
            // 
            this.cBoxBMit.DisplayMember = "MitarbeiterListe";
            this.cBoxBMit.FormattingEnabled = true;
            this.cBoxBMit.Location = new System.Drawing.Point(3, 22);
            this.cBoxBMit.Name = "cBoxBMit";
            this.cBoxBMit.Size = new System.Drawing.Size(121, 21);
            this.cBoxBMit.TabIndex = 4;
            // 
            // butBsMehrArt
            // 
            this.butBsMehrArt.Location = new System.Drawing.Point(157, 128);
            this.butBsMehrArt.Name = "butBsMehrArt";
            this.butBsMehrArt.Size = new System.Drawing.Size(121, 35);
            this.butBsMehrArt.TabIndex = 8;
            this.butBsMehrArt.Text = "Weitern Artikel zu Bestellung hinzufügen...";
            this.butBsMehrArt.UseVisualStyleBackColor = true;
            this.butBsMehrArt.Visible = false;
            this.butBsMehrArt.Click += new System.EventHandler(this.butBsMehrArt_Click);
            // 
            // Bestellung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 369);
            this.Controls.Add(this.butBsMehrArt);
            this.Controls.Add(this.BestellungDetail);
            this.Controls.Add(this.herfBNeu);
            this.Controls.Add(this.lBoxBestellung);
            this.Name = "Bestellung";
            this.Text = "Bestellung";
            this.Load += new System.EventHandler(this.Bestellung_Load);
            this.BestellungDetail.ResumeLayout(false);
            this.BestellungDetail.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lBoxBestellung;
        private System.Windows.Forms.LinkLabel herfBNeu;
        private System.Windows.Forms.Panel BestellungDetail;
        private System.Windows.Forms.Button butBArtikel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cBoxBMit;
        private System.Windows.Forms.Button butBsMehrArt;
    }
}