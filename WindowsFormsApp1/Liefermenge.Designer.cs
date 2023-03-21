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
            this.SuspendLayout();
            // 
            // panel1
            // 
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
            this.panel1.Size = new System.Drawing.Size(287, 221);
            this.panel1.TabIndex = 2;
            // 
            // butLsmHinzu
            // 
            this.butLsmHinzu.Location = new System.Drawing.Point(154, 165);
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
            this.cBoxLsmArt.Location = new System.Drawing.Point(154, 87);
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
            this.label5.Location = new System.Drawing.Point(154, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Menge:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(154, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Artikel:";
            // 
            // tBoxLsmMenge
            // 
            this.tBoxLsmMenge.Location = new System.Drawing.Point(154, 127);
            this.tBoxLsmMenge.Name = "tBoxLsmMenge";
            this.tBoxLsmMenge.Size = new System.Drawing.Size(121, 20);
            this.tBoxLsmMenge.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Alle Artikel in der Bestellung";
            // 
            // lBoxLsmArt
            // 
            this.lBoxLsmArt.DisplayMember = "LmArtProBstListe";
            this.lBoxLsmArt.FormattingEnabled = true;
            this.lBoxLsmArt.Location = new System.Drawing.Point(17, 58);
            this.lBoxLsmArt.Name = "lBoxLsmArt";
            this.lBoxLsmArt.Size = new System.Drawing.Size(131, 147);
            this.lBoxLsmArt.TabIndex = 2;
            // 
            // butLmLsFertig
            // 
            this.butLmLsFertig.Location = new System.Drawing.Point(169, 240);
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
            this.ClientSize = new System.Drawing.Size(379, 311);
            this.Controls.Add(this.butLmLsFertig);
            this.Controls.Add(this.panel1);
            this.Name = "Liefermenge";
            this.Text = "Liefermenge";
            this.Load += new System.EventHandler(this.Liefermenge_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
    }
}