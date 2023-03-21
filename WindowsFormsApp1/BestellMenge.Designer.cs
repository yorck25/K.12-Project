namespace WindowsFormsApp1
{
    partial class BestellMenge
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
            this.label1 = new System.Windows.Forms.Label();
            this.tBoxBMmenge = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BMDetail = new System.Windows.Forms.Panel();
            this.butBMHinzu = new System.Windows.Forms.Button();
            this.cBoxBMArt = new System.Windows.Forms.ComboBox();
            this.lBoxBMliste = new System.Windows.Forms.ListBox();
            this.lBoxBestellungen = new System.Windows.Forms.ListBox();
            this.butEmBestellt = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.BMDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(154, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bestellmange:";
            // 
            // tBoxBMmenge
            // 
            this.tBoxBMmenge.Location = new System.Drawing.Point(157, 84);
            this.tBoxBMmenge.Name = "tBoxBMmenge";
            this.tBoxBMmenge.Size = new System.Drawing.Size(121, 20);
            this.tBoxBMmenge.TabIndex = 1;
            this.tBoxBMmenge.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Bestellung:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(154, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Artikel:";
            // 
            // BMDetail
            // 
            this.BMDetail.Controls.Add(this.butBMHinzu);
            this.BMDetail.Controls.Add(this.cBoxBMArt);
            this.BMDetail.Controls.Add(this.label3);
            this.BMDetail.Controls.Add(this.lBoxBMliste);
            this.BMDetail.Controls.Add(this.tBoxBMmenge);
            this.BMDetail.Controls.Add(this.label1);
            this.BMDetail.Location = new System.Drawing.Point(137, 63);
            this.BMDetail.Name = "BMDetail";
            this.BMDetail.Size = new System.Drawing.Size(319, 197);
            this.BMDetail.TabIndex = 5;
            this.BMDetail.Visible = false;
            this.BMDetail.Paint += new System.Windows.Forms.PaintEventHandler(this.BMDetail_Paint);
            // 
            // butBMHinzu
            // 
            this.butBMHinzu.Location = new System.Drawing.Point(157, 127);
            this.butBMHinzu.Name = "butBMHinzu";
            this.butBMHinzu.Size = new System.Drawing.Size(75, 23);
            this.butBMHinzu.TabIndex = 5;
            this.butBMHinzu.Text = "Hinzufügen";
            this.butBMHinzu.UseVisualStyleBackColor = true;
            this.butBMHinzu.Click += new System.EventHandler(this.butBMHinzu_Click);
            // 
            // cBoxBMArt
            // 
            this.cBoxBMArt.DisplayMember = "ArtikelListe";
            this.cBoxBMArt.FormattingEnabled = true;
            this.cBoxBMArt.Location = new System.Drawing.Point(157, 24);
            this.cBoxBMArt.Name = "cBoxBMArt";
            this.cBoxBMArt.Size = new System.Drawing.Size(121, 21);
            this.cBoxBMArt.TabIndex = 2;
            this.cBoxBMArt.SelectedIndexChanged += new System.EventHandler(this.cBoxBMArt_SelectedIndexChanged);
            // 
            // lBoxBMliste
            // 
            this.lBoxBMliste.DisplayMember = "BestemMengeListe";
            this.lBoxBMliste.FormattingEnabled = true;
            this.lBoxBMliste.Location = new System.Drawing.Point(20, 8);
            this.lBoxBMliste.Name = "lBoxBMliste";
            this.lBoxBMliste.Size = new System.Drawing.Size(120, 147);
            this.lBoxBMliste.TabIndex = 0;
            this.lBoxBMliste.SelectedIndexChanged += new System.EventHandler(this.lBoxBMliste_SelectedIndexChanged);
            // 
            // lBoxBestellungen
            // 
            this.lBoxBestellungen.DisplayMember = "BestellungListe";
            this.lBoxBestellungen.FormattingEnabled = true;
            this.lBoxBestellungen.Location = new System.Drawing.Point(12, 45);
            this.lBoxBestellungen.Name = "lBoxBestellungen";
            this.lBoxBestellungen.Size = new System.Drawing.Size(120, 264);
            this.lBoxBestellungen.TabIndex = 6;
            this.lBoxBestellungen.SelectedIndexChanged += new System.EventHandler(this.lBoxBestellungen_SelectedIndexChanged);
            // 
            // butEmBestellt
            // 
            this.butEmBestellt.Location = new System.Drawing.Point(139, 281);
            this.butEmBestellt.Name = "butEmBestellt";
            this.butEmBestellt.Size = new System.Drawing.Size(138, 23);
            this.butEmBestellt.TabIndex = 8;
            this.butEmBestellt.Text = "Bestellung Abschiken";
            this.butEmBestellt.UseVisualStyleBackColor = true;
            this.butEmBestellt.Click += new System.EventHandler(this.butEmBestellt_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 316);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BestellMenge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.butEmBestellt);
            this.Controls.Add(this.lBoxBestellungen);
            this.Controls.Add(this.BMDetail);
            this.Controls.Add(this.label2);
            this.Name = "BestellMenge";
            this.Text = "BtestellMenge";
            this.Load += new System.EventHandler(this.BestellMenge_Load);
            this.BMDetail.ResumeLayout(false);
            this.BMDetail.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBoxBMmenge;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel BMDetail;
        private System.Windows.Forms.Button butBMHinzu;
        private System.Windows.Forms.ComboBox cBoxBMArt;
        private System.Windows.Forms.ListBox lBoxBMliste;
        private System.Windows.Forms.ListBox lBoxBestellungen;
        private System.Windows.Forms.Button butEmBestellt;
        private System.Windows.Forms.Button button1;
    }
}