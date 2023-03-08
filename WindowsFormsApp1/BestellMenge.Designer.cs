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
            this.cBoxBMBestellung = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BMDetail = new System.Windows.Forms.Panel();
            this.butBMHinzu = new System.Windows.Forms.Button();
            this.cBoxBMArt = new System.Windows.Forms.ComboBox();
            this.lBoxBMliste = new System.Windows.Forms.ListBox();
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
            // cBoxBMBestellung
            // 
            this.cBoxBMBestellung.DisplayMember = "BestellungListe";
            this.cBoxBMBestellung.FormattingEnabled = true;
            this.cBoxBMBestellung.Location = new System.Drawing.Point(12, 32);
            this.cBoxBMBestellung.Name = "cBoxBMBestellung";
            this.cBoxBMBestellung.Size = new System.Drawing.Size(121, 21);
            this.cBoxBMBestellung.TabIndex = 2;
            this.cBoxBMBestellung.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 16);
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
            this.BMDetail.Location = new System.Drawing.Point(15, 59);
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
            this.lBoxBMliste.FormattingEnabled = true;
            this.lBoxBMliste.Location = new System.Drawing.Point(20, 8);
            this.lBoxBMliste.Name = "lBoxBMliste";
            this.lBoxBMliste.Size = new System.Drawing.Size(120, 147);
            this.lBoxBMliste.TabIndex = 0;
            // 
            // BestellMenge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 450);
            this.Controls.Add(this.BMDetail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cBoxBMBestellung);
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
        private System.Windows.Forms.ComboBox cBoxBMBestellung;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel BMDetail;
        private System.Windows.Forms.Button butBMHinzu;
        private System.Windows.Forms.ComboBox cBoxBMArt;
        private System.Windows.Forms.ListBox lBoxBMliste;
    }
}