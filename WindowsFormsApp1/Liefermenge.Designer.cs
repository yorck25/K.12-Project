namespace WindowsFormsApp1
{
    partial class Liefermenge
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
            this.label6 = new System.Windows.Forms.Label();
            this.lBoxLmArtProBst = new System.Windows.Forms.ListBox();
            this.lmBestätigungEinfügen = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.butLmbestätigen = new System.Windows.Forms.Button();
            this.butLsmHinzu = new System.Windows.Forms.Button();
            this.cBoxLsmArt = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cBoxLsmScheine = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tBoxLsmMenge = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lBoxLsmArt = new System.Windows.Forms.ListBox();
            this.butLmLsFertig = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.lmBestätigungEinfügen.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lBoxLmArtProBst);
            this.panel1.Controls.Add(this.lmBestätigungEinfügen);
            this.panel1.Controls.Add(this.butLsmHinzu);
            this.panel1.Controls.Add(this.cBoxLsmArt);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cBoxLsmScheine);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tBoxLsmMenge);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lBoxLsmArt);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(655, 221);
            this.panel1.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(456, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(199, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Artikel in der Bestellung zum Lieferschein";
            // 
            // lBoxLmArtProBst
            // 
            this.lBoxLmArtProBst.DisplayMember = "BestemMengeListe";
            this.lBoxLmArtProBst.FormattingEnabled = true;
            this.lBoxLmArtProBst.Location = new System.Drawing.Point(459, 39);
            this.lBoxLmArtProBst.Name = "lBoxLmArtProBst";
            this.lBoxLmArtProBst.Size = new System.Drawing.Size(120, 95);
            this.lBoxLmArtProBst.TabIndex = 13;
            // 
            // lmBestätigungEinfügen
            // 
            this.lmBestätigungEinfügen.BackColor = System.Drawing.Color.Gray;
            this.lmBestätigungEinfügen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lmBestätigungEinfügen.Controls.Add(this.label3);
            this.lmBestätigungEinfügen.Controls.Add(this.butLmbestätigen);
            this.lmBestätigungEinfügen.Location = new System.Drawing.Point(157, 44);
            this.lmBestätigungEinfügen.Name = "lmBestätigungEinfügen";
            this.lmBestätigungEinfügen.Size = new System.Drawing.Size(229, 100);
            this.lmBestätigungEinfügen.TabIndex = 12;
            this.lmBestätigungEinfügen.Visible = false;
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
            // butLmbestätigen
            // 
            this.butLmbestätigen.Location = new System.Drawing.Point(65, 43);
            this.butLmbestätigen.Name = "butLmbestätigen";
            this.butLmbestätigen.Size = new System.Drawing.Size(75, 23);
            this.butLmbestätigen.TabIndex = 0;
            this.butLmbestätigen.Text = "Bestätigen";
            this.butLmbestätigen.UseVisualStyleBackColor = true;
            this.butLmbestätigen.Click += new System.EventHandler(this.butLmbestätigen_Click);
            // 
            // butLsmHinzu
            // 
            this.butLsmHinzu.Location = new System.Drawing.Point(299, 172);
            this.butLsmHinzu.Name = "butLsmHinzu";
            this.butLsmHinzu.Size = new System.Drawing.Size(75, 23);
            this.butLsmHinzu.TabIndex = 12;
            this.butLsmHinzu.Text = "Hinzufügen";
            this.butLsmHinzu.UseVisualStyleBackColor = true;
            this.butLsmHinzu.Click += new System.EventHandler(this.butLsmHinzu_Click);
            // 
            // cBoxLsmArt
            // 
            this.cBoxLsmArt.DisplayMember = "ArtikelListe";
            this.cBoxLsmArt.FormattingEnabled = true;
            this.cBoxLsmArt.Location = new System.Drawing.Point(299, 94);
            this.cBoxLsmArt.Name = "cBoxLsmArt";
            this.cBoxLsmArt.Size = new System.Drawing.Size(121, 21);
            this.cBoxLsmArt.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Lieferschein:";
            // 
            // cBoxLsmScheine
            // 
            this.cBoxLsmScheine.DisplayMember = "LieferscheinListe";
            this.cBoxLsmScheine.FormattingEnabled = true;
            this.cBoxLsmScheine.Location = new System.Drawing.Point(17, 20);
            this.cBoxLsmScheine.Name = "cBoxLsmScheine";
            this.cBoxLsmScheine.Size = new System.Drawing.Size(121, 21);
            this.cBoxLsmScheine.TabIndex = 9;
            this.cBoxLsmScheine.SelectedIndexChanged += new System.EventHandler(this.cBoxLsmScheine_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(299, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Menge:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(299, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Artikel:";
            // 
            // tBoxLsmMenge
            // 
            this.tBoxLsmMenge.Location = new System.Drawing.Point(299, 134);
            this.tBoxLsmMenge.Name = "tBoxLsmMenge";
            this.tBoxLsmMenge.Size = new System.Drawing.Size(121, 20);
            this.tBoxLsmMenge.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Alle Artikel in dem Lieferschein\r\n";
            // 
            // lBoxLsmArt
            // 
            this.lBoxLsmArt.DisplayMember = "LmArtProBstListe";
            this.lBoxLsmArt.FormattingEnabled = true;
            this.lBoxLsmArt.Location = new System.Drawing.Point(17, 58);
            this.lBoxLsmArt.Name = "lBoxLsmArt";
            this.lBoxLsmArt.Size = new System.Drawing.Size(258, 147);
            this.lBoxLsmArt.TabIndex = 2;
            // 
            // butLmLsFertig
            // 
            this.butLmLsFertig.Location = new System.Drawing.Point(12, 239);
            this.butLmLsFertig.Name = "butLmLsFertig";
            this.butLmLsFertig.Size = new System.Drawing.Size(130, 37);
            this.butLmLsFertig.TabIndex = 3;
            this.butLmLsFertig.Text = "Lieferschein Fertig eingetragen";
            this.butLmLsFertig.UseVisualStyleBackColor = true;
            this.butLmLsFertig.Click += new System.EventHandler(this.butLmLsFertig_Click);
            // 
            // Liefermenge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 296);
            this.Controls.Add(this.butLmLsFertig);
            this.Controls.Add(this.panel1);
            this.Name = "Liefermenge";
            this.Text = "Liefermenge";
            this.Load += new System.EventHandler(this.Liefermenge_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.lmBestätigungEinfügen.ResumeLayout(false);
            this.lmBestätigungEinfügen.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tBoxLsmMenge;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lBoxLsmArt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cBoxLsmScheine;
        private System.Windows.Forms.ComboBox cBoxLsmArt;
        private System.Windows.Forms.Button butLsmHinzu;
        private System.Windows.Forms.Button butLmLsFertig;
        private System.Windows.Forms.Panel lmBestätigungEinfügen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button butLmbestätigen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lBoxLmArtProBst;
    }
}