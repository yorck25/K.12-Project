namespace WindowsFormsApp1
{
    partial class Entnahmeschein
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
            this.lBoxEs = new System.Windows.Forms.ListBox();
            this.herfEsNeu = new System.Windows.Forms.LinkLabel();
            this.EsDetail = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.tBoxEsNtz = new System.Windows.Forms.RichTextBox();
            this.butEsErstellen = new System.Windows.Forms.Button();
            this.cBoxEsFürMit = new System.Windows.Forms.ComboBox();
            this.cBoxEsVonMit = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.butEsMehrArt = new System.Windows.Forms.Button();
            this.EsDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // lBoxEs
            // 
            this.lBoxEs.DisplayMember = "EntnahmeschinListe";
            this.lBoxEs.FormattingEnabled = true;
            this.lBoxEs.Location = new System.Drawing.Point(12, 37);
            this.lBoxEs.Name = "lBoxEs";
            this.lBoxEs.Size = new System.Drawing.Size(126, 251);
            this.lBoxEs.TabIndex = 0;
            this.lBoxEs.SelectedIndexChanged += new System.EventHandler(this.lBoxEs_SelectedIndexChanged);
            // 
            // herfEsNeu
            // 
            this.herfEsNeu.AutoSize = true;
            this.herfEsNeu.LinkColor = System.Drawing.SystemColors.Highlight;
            this.herfEsNeu.Location = new System.Drawing.Point(9, 9);
            this.herfEsNeu.Name = "herfEsNeu";
            this.herfEsNeu.Size = new System.Drawing.Size(130, 13);
            this.herfEsNeu.TabIndex = 1;
            this.herfEsNeu.TabStop = true;
            this.herfEsNeu.Text = "Neuen Entnahmeschein...";
            this.herfEsNeu.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.herfEsNeu_LinkClicked);
            // 
            // EsDetail
            // 
            this.EsDetail.Controls.Add(this.label3);
            this.EsDetail.Controls.Add(this.tBoxEsNtz);
            this.EsDetail.Controls.Add(this.butEsErstellen);
            this.EsDetail.Controls.Add(this.cBoxEsFürMit);
            this.EsDetail.Controls.Add(this.cBoxEsVonMit);
            this.EsDetail.Controls.Add(this.label2);
            this.EsDetail.Controls.Add(this.label1);
            this.EsDetail.Enabled = false;
            this.EsDetail.Location = new System.Drawing.Point(144, 37);
            this.EsDetail.Name = "EsDetail";
            this.EsDetail.Size = new System.Drawing.Size(158, 251);
            this.EsDetail.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Anhang:";
            // 
            // tBoxEsNtz
            // 
            this.tBoxEsNtz.Location = new System.Drawing.Point(17, 116);
            this.tBoxEsNtz.Name = "tBoxEsNtz";
            this.tBoxEsNtz.Size = new System.Drawing.Size(100, 96);
            this.tBoxEsNtz.TabIndex = 5;
            this.tBoxEsNtz.Text = "";
            // 
            // butEsErstellen
            // 
            this.butEsErstellen.Location = new System.Drawing.Point(17, 218);
            this.butEsErstellen.Name = "butEsErstellen";
            this.butEsErstellen.Size = new System.Drawing.Size(75, 23);
            this.butEsErstellen.TabIndex = 4;
            this.butEsErstellen.Text = "Erstellen";
            this.butEsErstellen.UseVisualStyleBackColor = true;
            this.butEsErstellen.Click += new System.EventHandler(this.butEsErstellen_Click);
            // 
            // cBoxEsFürMit
            // 
            this.cBoxEsFürMit.FormattingEnabled = true;
            this.cBoxEsFürMit.Location = new System.Drawing.Point(17, 71);
            this.cBoxEsFürMit.Name = "cBoxEsFürMit";
            this.cBoxEsFürMit.Size = new System.Drawing.Size(121, 21);
            this.cBoxEsFürMit.TabIndex = 3;
            // 
            // cBoxEsVonMit
            // 
            this.cBoxEsVonMit.FormattingEnabled = true;
            this.cBoxEsVonMit.Location = new System.Drawing.Point(17, 30);
            this.cBoxEsVonMit.Name = "cBoxEsVonMit";
            this.cBoxEsVonMit.Size = new System.Drawing.Size(121, 21);
            this.cBoxEsVonMit.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ausgabe an:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bearbeitet von:";
            // 
            // butEsMehrArt
            // 
            this.butEsMehrArt.Location = new System.Drawing.Point(12, 294);
            this.butEsMehrArt.Name = "butEsMehrArt";
            this.butEsMehrArt.Size = new System.Drawing.Size(121, 35);
            this.butEsMehrArt.TabIndex = 10;
            this.butEsMehrArt.Text = "Weitern Artikel zum Entnahmeschein hinzufühgen...\r\n";
            this.butEsMehrArt.UseVisualStyleBackColor = true;
            this.butEsMehrArt.Click += new System.EventHandler(this.butEsMehrArt_Click);
            // 
            // Entnahmeschein
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 397);
            this.Controls.Add(this.butEsMehrArt);
            this.Controls.Add(this.EsDetail);
            this.Controls.Add(this.herfEsNeu);
            this.Controls.Add(this.lBoxEs);
            this.Name = "Entnahmeschein";
            this.Text = "Entnahmeschein";
            this.Load += new System.EventHandler(this.Entnahmeschein_Load);
            this.EsDetail.ResumeLayout(false);
            this.EsDetail.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lBoxEs;
        private System.Windows.Forms.LinkLabel herfEsNeu;
        private System.Windows.Forms.Panel EsDetail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butEsErstellen;
        private System.Windows.Forms.ComboBox cBoxEsFürMit;
        private System.Windows.Forms.ComboBox cBoxEsVonMit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox tBoxEsNtz;
        private System.Windows.Forms.Button butEsMehrArt;
    }
}