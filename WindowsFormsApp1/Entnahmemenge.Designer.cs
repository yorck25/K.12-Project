namespace WindowsFormsApp1
{
    partial class Entnahmemenge
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
            this.cBoxEmEschein = new System.Windows.Forms.ComboBox();
            this.butEmHinzu = new System.Windows.Forms.Button();
            this.cBoxEmArt = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tBoxEmMenge = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lBoxEmArt = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cBoxEmEschein);
            this.panel1.Controls.Add(this.butEmHinzu);
            this.panel1.Controls.Add(this.cBoxEmArt);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tBoxEmMenge);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lBoxEmArt);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(296, 249);
            this.panel1.TabIndex = 3;
            // 
            // cBoxEmEschein
            // 
            this.cBoxEmEschein.DisplayMember = "EntnahmeschinListe";
            this.cBoxEmEschein.FormattingEnabled = true;
            this.cBoxEmEschein.Location = new System.Drawing.Point(17, 21);
            this.cBoxEmEschein.Name = "cBoxEmEschein";
            this.cBoxEmEschein.Size = new System.Drawing.Size(121, 21);
            this.cBoxEmEschein.TabIndex = 13;
            this.cBoxEmEschein.SelectedIndexChanged += new System.EventHandler(this.cBoxEmEschein_SelectedIndexChanged_1);
            // 
            // butEmHinzu
            // 
            this.butEmHinzu.Location = new System.Drawing.Point(154, 165);
            this.butEmHinzu.Name = "butEmHinzu";
            this.butEmHinzu.Size = new System.Drawing.Size(75, 23);
            this.butEmHinzu.TabIndex = 12;
            this.butEmHinzu.Text = "Hinzufügen";
            this.butEmHinzu.UseVisualStyleBackColor = true;
            this.butEmHinzu.Click += new System.EventHandler(this.butEmHinzu_Click);
            // 
            // cBoxEmArt
            // 
            this.cBoxEmArt.DisplayMember = "ArtikelListe";
            this.cBoxEmArt.FormattingEnabled = true;
            this.cBoxEmArt.Location = new System.Drawing.Point(154, 87);
            this.cBoxEmArt.Name = "cBoxEmArt";
            this.cBoxEmArt.Size = new System.Drawing.Size(121, 21);
            this.cBoxEmArt.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Entnahmeschein:";
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
            // tBoxEmMenge
            // 
            this.tBoxEmMenge.Location = new System.Drawing.Point(154, 127);
            this.tBoxEmMenge.Name = "tBoxEmMenge";
            this.tBoxEmMenge.Size = new System.Drawing.Size(121, 20);
            this.tBoxEmMenge.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Alle Artikel im Entnahmeschein:\r\n";
            // 
            // lBoxEmArt
            // 
            this.lBoxEmArt.DisplayMember = "LmArtProBstListe";
            this.lBoxEmArt.FormattingEnabled = true;
            this.lBoxEmArt.Location = new System.Drawing.Point(17, 58);
            this.lBoxEmArt.Name = "lBoxEmArt";
            this.lBoxEmArt.Size = new System.Drawing.Size(131, 147);
            this.lBoxEmArt.TabIndex = 2;
            // 
            // Entnahmemenge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 388);
            this.Controls.Add(this.panel1);
            this.Name = "Entnahmemenge";
            this.Text = "Entnahmemenge";
            this.Load += new System.EventHandler(this.Entnahmemenge_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button butEmHinzu;
        private System.Windows.Forms.ComboBox cBoxEmArt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tBoxEmMenge;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lBoxEmArt;
        private System.Windows.Forms.ComboBox cBoxEmEschein;
    }
}