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
            this.panel1 = new System.Windows.Forms.Panel();
            this.butBArtikel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cBoxBMit = new System.Windows.Forms.ComboBox();
            this.cBoxBLager = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lBoxBestellung
            // 
            this.lBoxBestellung.FormattingEnabled = true;
            this.lBoxBestellung.Location = new System.Drawing.Point(12, 29);
            this.lBoxBestellung.Name = "lBoxBestellung";
            this.lBoxBestellung.Size = new System.Drawing.Size(120, 329);
            this.lBoxBestellung.TabIndex = 0;
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
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.butBArtikel);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cBoxBMit);
            this.panel1.Controls.Add(this.cBoxBLager);
            this.panel1.Location = new System.Drawing.Point(154, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(142, 218);
            this.panel1.TabIndex = 3;
            // 
            // butBArtikel
            // 
            this.butBArtikel.Location = new System.Drawing.Point(6, 112);
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
            this.label2.Location = new System.Drawing.Point(3, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mitarbeiter:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Lagerort:";
            // 
            // cBoxBMit
            // 
            this.cBoxBMit.DisplayMember = "MitarbeiterListe";
            this.cBoxBMit.FormattingEnabled = true;
            this.cBoxBMit.Location = new System.Drawing.Point(6, 72);
            this.cBoxBMit.Name = "cBoxBMit";
            this.cBoxBMit.Size = new System.Drawing.Size(121, 21);
            this.cBoxBMit.TabIndex = 4;
            // 
            // cBoxBLager
            // 
            this.cBoxBLager.DisplayMember = "LagerortListe";
            this.cBoxBLager.FormattingEnabled = true;
            this.cBoxBLager.Location = new System.Drawing.Point(3, 20);
            this.cBoxBLager.Name = "cBoxBLager";
            this.cBoxBLager.Size = new System.Drawing.Size(121, 21);
            this.cBoxBLager.TabIndex = 3;
            // 
            // Bestellung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 394);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.herfBNeu);
            this.Controls.Add(this.lBoxBestellung);
            this.Name = "Bestellung";
            this.Text = "Bestellung";
            this.Load += new System.EventHandler(this.Bestellung_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lBoxBestellung;
        private System.Windows.Forms.LinkLabel herfBNeu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button butBArtikel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cBoxBMit;
        private System.Windows.Forms.ComboBox cBoxBLager;
    }
}