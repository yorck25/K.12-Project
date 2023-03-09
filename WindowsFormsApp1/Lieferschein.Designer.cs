namespace WindowsFormsApp1
{
    partial class Lieferschein
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
            this.lBoxLsBgeliefert = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LsNeuLsanlegen = new System.Windows.Forms.Panel();
            this.tBoxLsBId = new System.Windows.Forms.TextBox();
            this.butLsNeu = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tBoxLsbDatum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cBoxLsBearbeitetVon = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.LsNeuLsanlegen.SuspendLayout();
            this.SuspendLayout();
            // 
            // lBoxLsBgeliefert
            // 
            this.lBoxLsBgeliefert.DisplayMember = "BestellungListe";
            this.lBoxLsBgeliefert.FormattingEnabled = true;
            this.lBoxLsBgeliefert.Location = new System.Drawing.Point(13, 35);
            this.lBoxLsBgeliefert.Name = "lBoxLsBgeliefert";
            this.lBoxLsBgeliefert.Size = new System.Drawing.Size(146, 342);
            this.lBoxLsBgeliefert.TabIndex = 0;
            this.lBoxLsBgeliefert.SelectedIndexChanged += new System.EventHandler(this.lBoxLsBgeliefert_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bestelllung ID:";
            // 
            // LsNeuLsanlegen
            // 
            this.LsNeuLsanlegen.Controls.Add(this.label4);
            this.LsNeuLsanlegen.Controls.Add(this.cBoxLsBearbeitetVon);
            this.LsNeuLsanlegen.Controls.Add(this.tBoxLsBId);
            this.LsNeuLsanlegen.Controls.Add(this.butLsNeu);
            this.LsNeuLsanlegen.Controls.Add(this.label3);
            this.LsNeuLsanlegen.Controls.Add(this.tBoxLsbDatum);
            this.LsNeuLsanlegen.Controls.Add(this.label1);
            this.LsNeuLsanlegen.Location = new System.Drawing.Point(169, 62);
            this.LsNeuLsanlegen.Name = "LsNeuLsanlegen";
            this.LsNeuLsanlegen.Size = new System.Drawing.Size(181, 218);
            this.LsNeuLsanlegen.TabIndex = 4;
            // 
            // tBoxLsBId
            // 
            this.tBoxLsBId.Location = new System.Drawing.Point(6, 34);
            this.tBoxLsBId.Name = "tBoxLsBId";
            this.tBoxLsBId.Size = new System.Drawing.Size(123, 20);
            this.tBoxLsBId.TabIndex = 8;
            // 
            // butLsNeu
            // 
            this.butLsNeu.Location = new System.Drawing.Point(6, 152);
            this.butLsNeu.Name = "butLsNeu";
            this.butLsNeu.Size = new System.Drawing.Size(131, 34);
            this.butLsNeu.TabIndex = 7;
            this.butLsNeu.Text = "Lieferschein ins System eintragen";
            this.butLsNeu.UseVisualStyleBackColor = true;
            this.butLsNeu.Click += new System.EventHandler(this.butLsNeu_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Datum:";
            // 
            // tBoxLsbDatum
            // 
            this.tBoxLsbDatum.Location = new System.Drawing.Point(6, 76);
            this.tBoxLsbDatum.Name = "tBoxLsbDatum";
            this.tBoxLsbDatum.Size = new System.Drawing.Size(123, 20);
            this.tBoxLsbDatum.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Bestellung die geliefert sind:";
            // 
            // cBoxLsBearbeitetVon
            // 
            this.cBoxLsBearbeitetVon.DisplayMember = "MitarbeiterListe";
            this.cBoxLsBearbeitetVon.FormattingEnabled = true;
            this.cBoxLsBearbeitetVon.Location = new System.Drawing.Point(6, 125);
            this.cBoxLsBearbeitetVon.Name = "cBoxLsBearbeitetVon";
            this.cBoxLsBearbeitetVon.Size = new System.Drawing.Size(121, 21);
            this.cBoxLsBearbeitetVon.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Bearbeitet Von:";
            // 
            // Lieferschein
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LsNeuLsanlegen);
            this.Controls.Add(this.lBoxLsBgeliefert);
            this.Name = "Lieferschein";
            this.Text = "Lieferschein";
            this.Load += new System.EventHandler(this.Lieferschein_Load);
            this.LsNeuLsanlegen.ResumeLayout(false);
            this.LsNeuLsanlegen.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lBoxLsBgeliefert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel LsNeuLsanlegen;
        private System.Windows.Forms.Button butLsNeu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tBoxLsbDatum;
        private System.Windows.Forms.TextBox tBoxLsBId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cBoxLsBearbeitetVon;
    }
}